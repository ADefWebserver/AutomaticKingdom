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

    public interface IShadowGenerator : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<IShadowGeneratorCachedEntity>))]
    public class IShadowGeneratorCachedEntity : CachedEntityObject, IShadowGenerator
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

        #endregion
        
        #region Constructor
        public IShadowGeneratorCachedEntity() : base() { }

        public IShadowGeneratorCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public async ValueTask<RenderTargetTexture> getShadowMap()
        {
            return await EventHorizonBlazorInterop.FuncClass<RenderTargetTexture>(
                entity => new RenderTargetTexture() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getShadowMap" }
                }
            );
        }

        public async ValueTask<bool> isReady(SubMesh subMesh, bool useInstances)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isReady" }, subMesh, useInstances
                }
            );
        }

        public async ValueTask prepareDefines(MaterialDefines defines, decimal lightIndex)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "prepareDefines" }, defines, lightIndex
                }
            );
        }

        public async ValueTask bindShadowLight(string lightIndex, Effect effect)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "bindShadowLight" }, lightIndex, effect
                }
            );
        }

        public async ValueTask<Matrix> getTransformMatrix()
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getTransformMatrix" }
                }
            );
        }

        public async ValueTask recreateShadowMap()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "recreateShadowMap" }
                }
            );
        }

        #region forceCompilation TODO: Get Comments as metadata identification
        private bool _isForceCompilationEnabled = false;
        private readonly IDictionary<string, Func<IShadowGenerator, Task>> _forceCompilationActionMap = new Dictionary<string, Func<IShadowGenerator, Task>>();

        public async ValueTask<string> forceCompilation(
            Func<IShadowGenerator, Task> callback
        )
        {
            await SetupForceCompilationLoop();

            var handle = Guid.NewGuid().ToString();
            _forceCompilationActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private async ValueTask SetupForceCompilationLoop()
        {
            if (_isForceCompilationEnabled)
            {
                return;
            }
            await EventHorizonBlazorInterop.FuncCallback(
                this,
                "forceCompilation",
                "CallForceCompilationActions",
                _invokableReference
            );
            _isForceCompilationEnabled = true;
        }

        [JSInvokable]
        public async Task CallForceCompilationActions(IShadowGeneratorCachedEntity generator)
        {
            foreach (var action in _forceCompilationActionMap.Values)
            {
                await action(generator);
            }
        }
        #endregion

        public async ValueTask forceCompilationAsync(object options = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "forceCompilationAsync" }, options
                }
            );
        }

        public async ValueTask<CachedEntity> serialize()
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "serialize" }
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
        #endregion
    }
}