using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BabylonJS;
using BabylonJS.GUI;
using EventHorizon.Blazor.Server.Interop.Callbacks;

namespace AutomaticKingdom.BabylonControls
{
    public partial class Avatar : IDisposable
    {
        private IDictionary<string, AnimationGroup> _animationMap = new Dictionary<string, AnimationGroup>();
        private AnimationGroup _runningAnimation = null;
        private Engine _engine;

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await CreateScene();
            }
        }

        public void Dispose()
        {
            _engine?.dispose();
        }

        public async ValueTask CreateScene()
        {
            var canvas = await Canvas.GetElementById(
                "game-window"
            );
            var engine = await Engine.NewEngine(
                canvas,
                true
            );
            var scene = await Scene.NewScene(
                engine
            );
            var light0 = await PointLight.NewPointLight(
                "Omni",
                await Vector3.NewVector3(
                    0,
                    100,
                    8
                ),
                scene
            );
            var light1 = await HemisphericLight.NewHemisphericLight(
                "HemisphericLight",
                await Vector3.NewVector3(
                    0,
                    100,
                    8
                ),
                scene
            );

            var Player = await SceneLoader.ImportMesh(
                null,
                "assets/",
                "Player.glb",
                scene,
                new ActionCallback<AbstractMesh[], IParticleSystem[], Skeleton[], AnimationGroup[]>(async (arg1, arg2, arg3, arg4) =>
                {
                    foreach (var animation in arg4)
                    {
                        await animation.stop();
                        _animationMap.Add(await animation.get_name(), animation);
                    }
                    if (_animationMap.Count > 0)
                    {
                        _runningAnimation = _animationMap.First().Value;
                        await _runningAnimation.start(true);
                    }
                })
            );
            var camera = await ArcRotateCamera.NewArcRotateCamera(
                "ArcRotateCamera",
                (decimal)(System.Math.PI / 2),
                (decimal)(System.Math.PI / 4),
                3,
                await Vector3.NewVector3(0, 1, 0),
                scene
            );

            await camera.set_lowerRadiusLimit(2);
            await camera.set_upperRadiusLimit(10);
            await camera.set_wheelDeltaPercentage(0.01m);

            await scene.set_activeCamera(camera);
            await camera.attachControl(
                canvas,
                false
            );
            await engine.runRenderLoop(() => Task.Run(() => scene.render(true, false)));

            _engine = engine;
        }

        public async ValueTask RunAnimation(string name)
        {
            if (_runningAnimation != null)
            {
                await _runningAnimation.stop();
                _runningAnimation = null;
            }

            if (_animationMap.ContainsKey(name))
            {
                await _animationMap[name].play(true);
                _runningAnimation = _animationMap[name];
            }
        }
    }
}
