using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BabylonJS;
using BabylonJS.GUI;

namespace AutomaticKingdom.Pages
{
    public partial class AnimationExample : IDisposable
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
            var advancedTexture = await AdvancedDynamicTexture.CreateFullscreenUI("UI");
            var UiPanel = await StackPanel.NewStackPanel("name");
            await UiPanel.set_width("220px");
            await UiPanel.set_fontSize("14px");
            await UiPanel.set_horizontalAlignment(await Control.get_HORIZONTAL_ALIGNMENT_RIGHT());
            await UiPanel.set_verticalAlignment(await Control.get_VERTICAL_ALIGNMENT_CENTER());

            await advancedTexture.addControl(UiPanel);

            var house = await SceneLoader.ImportMesh(
                null,
                "assets/",
                "Player.glb",
                scene,
                new EventHorizon.Blazor.Server.Interop.Callbacks.ActionCallback<AbstractMesh[], IParticleSystem[], Skeleton[], AnimationGroup[]>(async (arg1, arg2, arg3, arg4) =>
                {
                    foreach (var animation in arg4)
                    {
                        await animation.stop();
                        _animationMap.Add(await animation.get_name(), animation);
                        await AddRunAnimationButton(
                            UiPanel,
                            await animation.get_name()
                        );
                    }
                    if(_animationMap.Count > 0)
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

        private async ValueTask AddRunAnimationButton(StackPanel uiPanel, string name)
        {
            var button = await Button.CreateSimpleButton($"but_{name}", name);
            await button.set_paddingTop("10px");
            await button.set_width("100px");
            await button.set_height("50px");
            await button.set_color("white");
            await button.set_background("green");
            await (await button.get_onPointerDownObservable()).add(async (_, __) => {
                if (_runningAnimation != null)
                {
                    await _runningAnimation.stop();
                    _runningAnimation = null;
                }
                if(_animationMap.ContainsKey(name))
                {
                    await _animationMap[name].play(true);
                    _runningAnimation = _animationMap[name];
                }
            });
            await uiPanel.addControl(button);
        }
    }
}
