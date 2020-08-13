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

    
    
    [JsonConverter(typeof(CachedEntityConverter<SceneLoaderProgressEvent>))]
    public class SceneLoaderProgressEvent : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static async ValueTask<SceneLoaderProgressEvent> FromProgressEvent(ProgressEvent @event)
        {
            return await EventHorizonBlazorInterop.FuncClass<SceneLoaderProgressEvent>(
                entity => new SceneLoaderProgressEvent() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "SceneLoaderProgressEvent", "FromProgressEvent" }, @event
                }
            );
        }
        #endregion

        #region Accessors

        #endregion

        #region Properties
        
        public async ValueTask<bool> get_lengthComputable()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "lengthComputable"
                );
        }

        
        public async ValueTask<decimal> get_loaded()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "loaded"
                );
        }

        
        public async ValueTask<decimal> get_total()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "total"
                );
        }
        #endregion
        
        #region Constructor
        public SceneLoaderProgressEvent() : base() { } 

        public SceneLoaderProgressEvent(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public static async ValueTask<SceneLoaderProgressEvent> NewSceneLoaderProgressEvent(
            bool lengthComputable, decimal loaded, decimal total
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "SceneLoaderProgressEvent" },
                lengthComputable, loaded, total
            );

            return new SceneLoaderProgressEvent(entity);
        }
        #endregion

        #region Methods

        #endregion
    }
}