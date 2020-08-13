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

    
    
    [JsonConverter(typeof(CachedEntityConverter<TargetedAnimation>))]
    public class TargetedAnimation : CachedEntityObject
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
        private Animation __animation;
        public async ValueTask<Animation> get_animation()
        {
            if(__animation == null)
            {
                __animation = await EventHorizonBlazorInterop.GetClass<Animation>(
                    this.___guid,
                    "animation",
                    (entity) =>
                    {
                        return new Animation() { ___guid = entity.___guid };
                    }
                );
            }
            return __animation;
        }
        public ValueTask set_animation(Animation value)
        {
__animation = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "animation",
                    value
                );
        }

        
        public async ValueTask<CachedEntity> get_target()
        {
            return await EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "target"
                );
        }
        public ValueTask set_target(CachedEntity value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "target",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public TargetedAnimation() : base() { } 

        public TargetedAnimation(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods
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