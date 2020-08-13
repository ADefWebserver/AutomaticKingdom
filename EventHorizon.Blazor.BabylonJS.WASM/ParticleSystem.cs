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

    
    
    [JsonConverter(typeof(CachedEntityConverter<ParticleSystem>))]
    public class ParticleSystem : BaseParticleSystem, _IDisposable, IAnimatable, IParticleSystem
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static async ValueTask<decimal> get_BILLBOARDMODE_Y()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ParticleSystem.BILLBOARDMODE_Y"
                );
        }

        
        public static async ValueTask<decimal> get_BILLBOARDMODE_ALL()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ParticleSystem.BILLBOARDMODE_ALL"
                );
        }

        
        public static async ValueTask<decimal> get_BILLBOARDMODE_STRETCHED()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ParticleSystem.BILLBOARDMODE_STRETCHED"
                );
        }
        #endregion

        #region Static Methods
        public static async ValueTask<ParticleSystem> Parse(object parsedParticleSystem, Scene scene, string rootUrl, System.Nullable<bool> doNotStart = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<ParticleSystem>(
                entity => new ParticleSystem() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "ParticleSystem", "Parse" }, parsedParticleSystem, scene, rootUrl, doNotStart
                }
            );
        }
        #endregion

        #region Accessors
        
        public async ValueTask<bool> get_useRampGradients()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useRampGradients"
                );
        }
        public ValueTask set_useRampGradients(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useRampGradients",
                    value
                );
        }

        
        public async ValueTask<Particle[]> get_particles()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<Particle>(
                    this.___guid,
                    "particles",
                    (entity) =>
                    {
                        return new Particle() { ___guid = entity.___guid };
                    }
                );
        }
        #endregion

        #region Properties
        private Observable<ParticleSystem> __onDisposeObservable;
        public async ValueTask<Observable<ParticleSystem>> get_onDisposeObservable()
        {
            if(__onDisposeObservable == null)
            {
                __onDisposeObservable = await EventHorizonBlazorInterop.GetClass<Observable<ParticleSystem>>(
                    this.___guid,
                    "onDisposeObservable",
                    (entity) =>
                    {
                        return new Observable<ParticleSystem>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onDisposeObservable;
        }
        public ValueTask set_onDisposeObservable(Observable<ParticleSystem> value)
        {
__onDisposeObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onDisposeObservable",
                    value
                );
        }

        
        public async ValueTask<ParticleSystem[]> get_subEmitters()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<ParticleSystem>(
                    this.___guid,
                    "subEmitters",
                    (entity) =>
                    {
                        return new ParticleSystem() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_subEmitters(ParticleSystem[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "subEmitters",
                    value
                );
        }

        
        public async ValueTask<ParticleSystem[]> get_activeSubSystems()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<ParticleSystem>(
                    this.___guid,
                    "activeSubSystems",
                    (entity) =>
                    {
                        return new ParticleSystem() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_activeSubSystems(ParticleSystem[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "activeSubSystems",
                    value
                );
        }

        
        public async ValueTask<bool> get_isLocal()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isLocal"
                );
        }
        public ValueTask set_isLocal(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isLocal",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public ParticleSystem() : base() { }

        public ParticleSystem(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<ParticleSystem> NewParticleSystem(
            string name, decimal capacity, Scene scene, Effect customEffect = null, System.Nullable<bool> isAnimationSheetEnabled = null, System.Nullable<decimal> epsilon = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "ParticleSystem" },
                name, capacity, scene, customEffect, isAnimationSheetEnabled, epsilon
            );

            return new ParticleSystem(entity);
        }
        #endregion

        #region Methods
        #region updateFunction TODO: Get Comments as metadata identification
        private bool _isUpdateFunctionEnabled = false;
        private readonly IDictionary<string, Func<Task>> _updateFunctionActionMap = new Dictionary<string, Func<Task>>();

        public async ValueTask<string> updateFunction(
            Func<Task> callback
        )
        {
            await SetupUpdateFunctionLoop();

            var handle = Guid.NewGuid().ToString();
            _updateFunctionActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private async ValueTask SetupUpdateFunctionLoop()
        {
            if (_isUpdateFunctionEnabled)
            {
                return;
            }
            await EventHorizonBlazorInterop.FuncCallback(
                this,
                "updateFunction",
                "CallUpdateFunctionActions",
                _invokableReference
            );
            _isUpdateFunctionEnabled = true;
        }

        [JSInvokable]
        public async Task CallUpdateFunctionActions()
        {
            foreach (var action in _updateFunctionActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region startDirectionFunction TODO: Get Comments as metadata identification
        private bool _isStartDirectionFunctionEnabled = false;
        private readonly IDictionary<string, Func<Task>> _startDirectionFunctionActionMap = new Dictionary<string, Func<Task>>();

        public async ValueTask<string> startDirectionFunction(
            Func<Task> callback
        )
        {
            await SetupStartDirectionFunctionLoop();

            var handle = Guid.NewGuid().ToString();
            _startDirectionFunctionActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private async ValueTask SetupStartDirectionFunctionLoop()
        {
            if (_isStartDirectionFunctionEnabled)
            {
                return;
            }
            await EventHorizonBlazorInterop.FuncCallback(
                this,
                "startDirectionFunction",
                "CallStartDirectionFunctionActions",
                _invokableReference
            );
            _isStartDirectionFunctionEnabled = true;
        }

        [JSInvokable]
        public async Task CallStartDirectionFunctionActions()
        {
            foreach (var action in _startDirectionFunctionActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region startPositionFunction TODO: Get Comments as metadata identification
        private bool _isStartPositionFunctionEnabled = false;
        private readonly IDictionary<string, Func<Task>> _startPositionFunctionActionMap = new Dictionary<string, Func<Task>>();

        public async ValueTask<string> startPositionFunction(
            Func<Task> callback
        )
        {
            await SetupStartPositionFunctionLoop();

            var handle = Guid.NewGuid().ToString();
            _startPositionFunctionActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private async ValueTask SetupStartPositionFunctionLoop()
        {
            if (_isStartPositionFunctionEnabled)
            {
                return;
            }
            await EventHorizonBlazorInterop.FuncCallback(
                this,
                "startPositionFunction",
                "CallStartPositionFunctionActions",
                _invokableReference
            );
            _isStartPositionFunctionEnabled = true;
        }

        [JSInvokable]
        public async Task CallStartPositionFunctionActions()
        {
            foreach (var action in _startPositionFunctionActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public async ValueTask<string> getClassName()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public async ValueTask<IParticleSystemCachedEntity> addLifeTimeGradient(decimal gradient, decimal factor, System.Nullable<decimal> factor2 = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addLifeTimeGradient" }, gradient, factor, factor2
                }
            );
        }

        public async ValueTask<IParticleSystemCachedEntity> removeLifeTimeGradient(decimal gradient)
        {
            return await EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "removeLifeTimeGradient" }, gradient
                }
            );
        }

        public async ValueTask<IParticleSystemCachedEntity> addSizeGradient(decimal gradient, decimal factor, System.Nullable<decimal> factor2 = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addSizeGradient" }, gradient, factor, factor2
                }
            );
        }

        public async ValueTask<IParticleSystemCachedEntity> removeSizeGradient(decimal gradient)
        {
            return await EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "removeSizeGradient" }, gradient
                }
            );
        }

        public async ValueTask<IParticleSystemCachedEntity> addColorRemapGradient(decimal gradient, decimal min, decimal max)
        {
            return await EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addColorRemapGradient" }, gradient, min, max
                }
            );
        }

        public async ValueTask<IParticleSystemCachedEntity> removeColorRemapGradient(decimal gradient)
        {
            return await EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "removeColorRemapGradient" }, gradient
                }
            );
        }

        public async ValueTask<IParticleSystemCachedEntity> addAlphaRemapGradient(decimal gradient, decimal min, decimal max)
        {
            return await EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addAlphaRemapGradient" }, gradient, min, max
                }
            );
        }

        public async ValueTask<IParticleSystemCachedEntity> removeAlphaRemapGradient(decimal gradient)
        {
            return await EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "removeAlphaRemapGradient" }, gradient
                }
            );
        }

        public async ValueTask<IParticleSystemCachedEntity> addAngularSpeedGradient(decimal gradient, decimal factor, System.Nullable<decimal> factor2 = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addAngularSpeedGradient" }, gradient, factor, factor2
                }
            );
        }

        public async ValueTask<IParticleSystemCachedEntity> removeAngularSpeedGradient(decimal gradient)
        {
            return await EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "removeAngularSpeedGradient" }, gradient
                }
            );
        }

        public async ValueTask<IParticleSystemCachedEntity> addVelocityGradient(decimal gradient, decimal factor, System.Nullable<decimal> factor2 = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addVelocityGradient" }, gradient, factor, factor2
                }
            );
        }

        public async ValueTask<IParticleSystemCachedEntity> removeVelocityGradient(decimal gradient)
        {
            return await EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "removeVelocityGradient" }, gradient
                }
            );
        }

        public async ValueTask<IParticleSystemCachedEntity> addLimitVelocityGradient(decimal gradient, decimal factor, System.Nullable<decimal> factor2 = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addLimitVelocityGradient" }, gradient, factor, factor2
                }
            );
        }

        public async ValueTask<IParticleSystemCachedEntity> removeLimitVelocityGradient(decimal gradient)
        {
            return await EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "removeLimitVelocityGradient" }, gradient
                }
            );
        }

        public async ValueTask<IParticleSystemCachedEntity> addDragGradient(decimal gradient, decimal factor, System.Nullable<decimal> factor2 = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addDragGradient" }, gradient, factor, factor2
                }
            );
        }

        public async ValueTask<IParticleSystemCachedEntity> removeDragGradient(decimal gradient)
        {
            return await EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "removeDragGradient" }, gradient
                }
            );
        }

        public async ValueTask<IParticleSystemCachedEntity> addEmitRateGradient(decimal gradient, decimal factor, System.Nullable<decimal> factor2 = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addEmitRateGradient" }, gradient, factor, factor2
                }
            );
        }

        public async ValueTask<IParticleSystemCachedEntity> removeEmitRateGradient(decimal gradient)
        {
            return await EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "removeEmitRateGradient" }, gradient
                }
            );
        }

        public async ValueTask<IParticleSystemCachedEntity> addStartSizeGradient(decimal gradient, decimal factor, System.Nullable<decimal> factor2 = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addStartSizeGradient" }, gradient, factor, factor2
                }
            );
        }

        public async ValueTask<IParticleSystemCachedEntity> removeStartSizeGradient(decimal gradient)
        {
            return await EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "removeStartSizeGradient" }, gradient
                }
            );
        }

        public async ValueTask<Color3Gradient[]> getRampGradients()
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<Color3Gradient>(
                entity => new Color3Gradient() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getRampGradients" }
                }
            );
        }

        public async ValueTask<ParticleSystem> addRampGradient(decimal gradient, Color3 color)
        {
            return await EventHorizonBlazorInterop.FuncClass<ParticleSystem>(
                entity => new ParticleSystem() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addRampGradient" }, gradient, color
                }
            );
        }

        public async ValueTask<ParticleSystem> removeRampGradient(decimal gradient)
        {
            return await EventHorizonBlazorInterop.FuncClass<ParticleSystem>(
                entity => new ParticleSystem() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "removeRampGradient" }, gradient
                }
            );
        }

        public async ValueTask<IParticleSystemCachedEntity> addColorGradient(decimal gradient, Color4 color1, Color4 color2 = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addColorGradient" }, gradient, color1, color2
                }
            );
        }

        public async ValueTask<IParticleSystemCachedEntity> removeColorGradient(decimal gradient)
        {
            return await EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "removeColorGradient" }, gradient
                }
            );
        }

        public async ValueTask<decimal> getCapacity()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getCapacity" }
                }
            );
        }

        public async ValueTask<bool> isAlive()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isAlive" }
                }
            );
        }

        public async ValueTask<bool> isStarted()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isStarted" }
                }
            );
        }

        public async ValueTask start(System.Nullable<decimal> delay = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "start" }, delay
                }
            );
        }

        public async ValueTask stop(System.Nullable<bool> stopSubEmitters = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "stop" }, stopSubEmitters
                }
            );
        }

        public async ValueTask reset()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "reset" }
                }
            );
        }

        #region recycleParticle TODO: Get Comments as metadata identification
        private bool _isRecycleParticleEnabled = false;
        private readonly IDictionary<string, Func<Task>> _recycleParticleActionMap = new Dictionary<string, Func<Task>>();

        public async ValueTask<string> recycleParticle(
            Func<Task> callback
        )
        {
            await SetupRecycleParticleLoop();

            var handle = Guid.NewGuid().ToString();
            _recycleParticleActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private async ValueTask SetupRecycleParticleLoop()
        {
            if (_isRecycleParticleEnabled)
            {
                return;
            }
            await EventHorizonBlazorInterop.FuncCallback(
                this,
                "recycleParticle",
                "CallRecycleParticleActions",
                _invokableReference
            );
            _isRecycleParticleEnabled = true;
        }

        [JSInvokable]
        public async Task CallRecycleParticleActions()
        {
            foreach (var action in _recycleParticleActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public async ValueTask animate(System.Nullable<bool> preWarmOnly = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "animate" }, preWarmOnly
                }
            );
        }

        public async ValueTask rebuild()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "rebuild" }
                }
            );
        }

        public async ValueTask<bool> isReady()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isReady" }
                }
            );
        }

        public async ValueTask<decimal> render()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "render" }
                }
            );
        }

        public async ValueTask dispose(System.Nullable<bool> disposeTexture = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }, disposeTexture
                }
            );
        }

        public async ValueTask<ParticleSystem> clone(string name, object newEmitter)
        {
            return await EventHorizonBlazorInterop.FuncClass<ParticleSystem>(
                entity => new ParticleSystem() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "clone" }, name, newEmitter
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
        #endregion
    }
}