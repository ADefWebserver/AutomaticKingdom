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

    
    
    [JsonConverter(typeof(CachedEntityConverter<BaseSubMesh>))]
    public class BaseSubMesh : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        private MaterialDefines __materialDefines;
        public async ValueTask<MaterialDefines> get_materialDefines()
        {
            if(__materialDefines == null)
            {
                __materialDefines = await EventHorizonBlazorInterop.GetClass<MaterialDefines>(
                    this.___guid,
                    "materialDefines",
                    (entity) =>
                    {
                        return new MaterialDefines() { ___guid = entity.___guid };
                    }
                );
            }
            return __materialDefines;
        }
        public ValueTask set_materialDefines(MaterialDefines value)
        {
__materialDefines = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "materialDefines",
                    value
                );
        }

        private Effect __effect;
        public async ValueTask<Effect> get_effect()
        {
            if(__effect == null)
            {
                __effect = await EventHorizonBlazorInterop.GetClass<Effect>(
                    this.___guid,
                    "effect",
                    (entity) =>
                    {
                        return new Effect() { ___guid = entity.___guid };
                    }
                );
            }
            return __effect;
        }
        #endregion

        #region Properties

        #endregion
        
        #region Constructor
        public BaseSubMesh() : base() { } 

        public BaseSubMesh(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods
        public async ValueTask setEffect(Effect effect, MaterialDefines defines = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setEffect" }, effect, defines
                }
            );
        }
        #endregion
    }
}