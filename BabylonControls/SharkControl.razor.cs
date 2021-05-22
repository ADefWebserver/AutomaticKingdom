using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BABYLON;
using EventHorizon.Blazor.BabylonJS.Model;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Server.BabylonJS.Model;
using EventHorizon.Blazor.Server.Interop.Callbacks;

namespace AutomaticKingdom.BabylonControls
{
    public partial class SharkControl : IDisposable
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
                "Shark.glb",
                scene,
                new ActionCallback<AbstractMesh[], IParticleSystem[], Skeleton[], AnimationGroup[], TransformNode[], Geometry[], Light[]>(async (arg1, arg2, arg3, arg4, arg5, arg6, arg7) =>
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
                0,
                await Vector3.NewVector3(0, 1, 0),
                scene
            );

            // This positions the camera
            await camera.setPosition(await Vector3.NewVector3(30, 10, -30));

            await camera.set_lowerRadiusLimit(2);
            await camera.set_upperRadiusLimit(100);
            await camera.set_wheelDeltaPercentage(0.01m);

            await scene.set_activeCamera(camera);

            await camera.attachControl(                
                false
            );

            await engine.runRenderLoop(new ActionCallback(
                            () => Task.Run(() => scene.render(true, false))
                        ));

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
