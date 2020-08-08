/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
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
        public Animation animation
        {
            get
            {
            if(__animation == null)
            {
                __animation = EventHorizonBlazorInterop.GetClass<Animation>(
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
            set
            {
__animation = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "animation",
                    value
                );
            }
        }

        
        public CachedEntity target
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "target"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "target",
                    value
                );
            }
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
        public CachedEntity serialize()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "serialize" }
                }
            );
        }
        #endregion
    }
}