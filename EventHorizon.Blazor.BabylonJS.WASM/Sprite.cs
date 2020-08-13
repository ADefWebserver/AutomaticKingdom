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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Sprite>))]
    public class Sprite : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        
        public async ValueTask<decimal> get_size()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "size"
                );
        }
        public ValueTask set_size(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "size",
                    value
                );
        }
        #endregion

        #region Properties
        
        public async ValueTask<string> get_name()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "name"
                );
        }
        public ValueTask set_name(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "name",
                    value
                );
        }

        private Vector3 __position;
        public async ValueTask<Vector3> get_position()
        {
            if(__position == null)
            {
                __position = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "position",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __position;
        }
        public ValueTask set_position(Vector3 value)
        {
__position = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "position",
                    value
                );
        }

        private Color4 __color;
        public async ValueTask<Color4> get_color()
        {
            if(__color == null)
            {
                __color = await EventHorizonBlazorInterop.GetClass<Color4>(
                    this.___guid,
                    "color",
                    (entity) =>
                    {
                        return new Color4() { ___guid = entity.___guid };
                    }
                );
            }
            return __color;
        }
        public ValueTask set_color(Color4 value)
        {
__color = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "color",
                    value
                );
        }

        
        public async ValueTask<decimal> get_width()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "width"
                );
        }
        public ValueTask set_width(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "width",
                    value
                );
        }

        
        public async ValueTask<decimal> get_height()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "height"
                );
        }
        public ValueTask set_height(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "height",
                    value
                );
        }

        
        public async ValueTask<decimal> get_angle()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "angle"
                );
        }
        public ValueTask set_angle(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "angle",
                    value
                );
        }

        
        public async ValueTask<decimal> get_cellIndex()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "cellIndex"
                );
        }
        public ValueTask set_cellIndex(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cellIndex",
                    value
                );
        }

        
        public async ValueTask<string> get_cellRef()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "cellRef"
                );
        }
        public ValueTask set_cellRef(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cellRef",
                    value
                );
        }

        
        public async ValueTask<decimal> get_invertU()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "invertU"
                );
        }
        public ValueTask set_invertU(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "invertU",
                    value
                );
        }

        
        public async ValueTask<decimal> get_invertV()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "invertV"
                );
        }
        public ValueTask set_invertV(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "invertV",
                    value
                );
        }

        
        public async ValueTask<bool> get_disposeWhenFinishedAnimating()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "disposeWhenFinishedAnimating"
                );
        }
        public ValueTask set_disposeWhenFinishedAnimating(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "disposeWhenFinishedAnimating",
                    value
                );
        }

        
        public async ValueTask<Animation[]> get_animations()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<Animation>(
                    this.___guid,
                    "animations",
                    (entity) =>
                    {
                        return new Animation() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_animations(Animation[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "animations",
                    value
                );
        }

        
        public async ValueTask<bool> get_isPickable()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isPickable"
                );
        }
        public ValueTask set_isPickable(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isPickable",
                    value
                );
        }

        private ActionManager __actionManager;
        public async ValueTask<ActionManager> get_actionManager()
        {
            if(__actionManager == null)
            {
                __actionManager = await EventHorizonBlazorInterop.GetClass<ActionManager>(
                    this.___guid,
                    "actionManager",
                    (entity) =>
                    {
                        return new ActionManager() { ___guid = entity.___guid };
                    }
                );
            }
            return __actionManager;
        }
        public ValueTask set_actionManager(ActionManager value)
        {
__actionManager = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "actionManager",
                    value
                );
        }

        
        public async ValueTask<bool> get_isVisible()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isVisible"
                );
        }
        public ValueTask set_isVisible(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isVisible",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public Sprite() : base() { } 

        public Sprite(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public static async ValueTask<Sprite> NewSprite(
            string name, ISpriteManager manager
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Sprite" },
                name, manager
            );

            return new Sprite(entity);
        }
        #endregion

        #region Methods
        public async ValueTask playAnimation(decimal from, decimal to, bool loop, decimal delay, ActionCallback onAnimationEnd)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "playAnimation" }, from, to, loop, delay, onAnimationEnd
                }
            );
        }

        public async ValueTask stopAnimation()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "stopAnimation" }
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