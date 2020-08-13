/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Server.Interop;
    using EventHorizon.Blazor.Server.Interop.Callbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<AssetContainer>))]
    public class AssetContainer : AbstractScene
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        #endregion

        #region Properties
        private Scene __scene;
        public async ValueTask<Scene> get_scene()
        {
            if(__scene == null)
            {
                __scene = await EventHorizonBlazorInterop.GetClass<Scene>(
                    this.___guid,
                    "scene",
                    (entity) =>
                    {
                        return new Scene() { ___guid = entity.___guid };
                    }
                );
            }
            return __scene;
        }
        public ValueTask set_scene(Scene value)
        {
__scene = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scene",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public AssetContainer() : base() { }

        public AssetContainer(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<AssetContainer> NewAssetContainer(
            Scene scene
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "AssetContainer" },
                scene
            );

            return new AssetContainer(entity);
        }
        #endregion

        #region Methods
        #region instantiateModelsToScene TODO: Get Comments as metadata identification
        private bool _isInstantiateModelsToSceneEnabled = false;
        private readonly IDictionary<string, Func<string, Task>> _instantiateModelsToSceneActionMap = new Dictionary<string, Func<string, Task>>();

        public async ValueTask<string> instantiateModelsToScene(
            Func<string, Task> callback
        )
        {
            await SetupInstantiateModelsToSceneLoop();

            var handle = Guid.NewGuid().ToString();
            _instantiateModelsToSceneActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private async ValueTask SetupInstantiateModelsToSceneLoop()
        {
            if (_isInstantiateModelsToSceneEnabled)
            {
                return;
            }
            await EventHorizonBlazorInterop.FuncCallback(
                this,
                "instantiateModelsToScene",
                "CallInstantiateModelsToSceneActions",
                _invokableReference
            );
            _isInstantiateModelsToSceneEnabled = true;
        }

        [JSInvokable]
        public async Task CallInstantiateModelsToSceneActions(string sourceName)
        {
            foreach (var action in _instantiateModelsToSceneActionMap.Values)
            {
                await action(sourceName);
            }
        }
        #endregion

        public async ValueTask addAllToScene()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "addAllToScene" }
                }
            );
        }

        public async ValueTask removeAllFromScene()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "removeAllFromScene" }
                }
            );
        }

        public async ValueTask dispose()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }

        public async ValueTask moveAllFromScene(KeepAssets keepAssets = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "moveAllFromScene" }, keepAssets
                }
            );
        }

        public async ValueTask<Mesh> createRootMesh()
        {
            return await EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "createRootMesh" }
                }
            );
        }

        public async ValueTask mergeAnimationsTo(Animatable[] animatables, Scene scene = null, ActionCallback<CachedEntity> targetConverter = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "mergeAnimationsTo" }, scene, animatables, targetConverter
                }
            );
        }
        #endregion
    }
}