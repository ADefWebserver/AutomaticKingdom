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

    
    
    [JsonConverter(typeof(CachedEntityConverter<FollowCamera>))]
    public class FollowCamera : TargetCamera
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
        
        public async ValueTask<decimal> get_radius()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "radius"
                );
        }
        public ValueTask set_radius(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "radius",
                    value
                );
        }

        
        public async ValueTask<decimal> get_lowerRadiusLimit()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "lowerRadiusLimit"
                );
        }
        public ValueTask set_lowerRadiusLimit(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lowerRadiusLimit",
                    value
                );
        }

        
        public async ValueTask<decimal> get_upperRadiusLimit()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "upperRadiusLimit"
                );
        }
        public ValueTask set_upperRadiusLimit(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "upperRadiusLimit",
                    value
                );
        }

        
        public async ValueTask<decimal> get_rotationOffset()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "rotationOffset"
                );
        }
        public ValueTask set_rotationOffset(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "rotationOffset",
                    value
                );
        }

        
        public async ValueTask<decimal> get_lowerRotationOffsetLimit()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "lowerRotationOffsetLimit"
                );
        }
        public ValueTask set_lowerRotationOffsetLimit(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lowerRotationOffsetLimit",
                    value
                );
        }

        
        public async ValueTask<decimal> get_upperRotationOffsetLimit()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "upperRotationOffsetLimit"
                );
        }
        public ValueTask set_upperRotationOffsetLimit(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "upperRotationOffsetLimit",
                    value
                );
        }

        
        public async ValueTask<decimal> get_heightOffset()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "heightOffset"
                );
        }
        public ValueTask set_heightOffset(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "heightOffset",
                    value
                );
        }

        
        public async ValueTask<decimal> get_lowerHeightOffsetLimit()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "lowerHeightOffsetLimit"
                );
        }
        public ValueTask set_lowerHeightOffsetLimit(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lowerHeightOffsetLimit",
                    value
                );
        }

        
        public async ValueTask<decimal> get_upperHeightOffsetLimit()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "upperHeightOffsetLimit"
                );
        }
        public ValueTask set_upperHeightOffsetLimit(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "upperHeightOffsetLimit",
                    value
                );
        }

        
        public async ValueTask<decimal> get_cameraAcceleration()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "cameraAcceleration"
                );
        }
        public ValueTask set_cameraAcceleration(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cameraAcceleration",
                    value
                );
        }

        
        public async ValueTask<decimal> get_maxCameraSpeed()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxCameraSpeed"
                );
        }
        public ValueTask set_maxCameraSpeed(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maxCameraSpeed",
                    value
                );
        }

        private AbstractMesh __lockedTarget;
        public async ValueTask<AbstractMesh> get_lockedTarget()
        {
            if(__lockedTarget == null)
            {
                __lockedTarget = await EventHorizonBlazorInterop.GetClass<AbstractMesh>(
                    this.___guid,
                    "lockedTarget",
                    (entity) =>
                    {
                        return new AbstractMesh() { ___guid = entity.___guid };
                    }
                );
            }
            return __lockedTarget;
        }
        public ValueTask set_lockedTarget(AbstractMesh value)
        {
__lockedTarget = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lockedTarget",
                    value
                );
        }

        private FollowCameraInputsManager __inputs;
        public async ValueTask<FollowCameraInputsManager> get_inputs()
        {
            if(__inputs == null)
            {
                __inputs = await EventHorizonBlazorInterop.GetClass<FollowCameraInputsManager>(
                    this.___guid,
                    "inputs",
                    (entity) =>
                    {
                        return new FollowCameraInputsManager() { ___guid = entity.___guid };
                    }
                );
            }
            return __inputs;
        }
        public ValueTask set_inputs(FollowCameraInputsManager value)
        {
__inputs = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "inputs",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public FollowCamera() : base() { }

        public FollowCamera(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<FollowCamera> NewFollowCamera(
            string name, Vector3 position, Scene scene, AbstractMesh lockedTarget = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "FollowCamera" },
                name, position, scene, lockedTarget
            );

            return new FollowCamera(entity);
        }
        #endregion

        #region Methods
        public async ValueTask attachControl(object element, System.Nullable<bool> noPreventDefault = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "attachControl" }, element, noPreventDefault
                }
            );
        }

        public async ValueTask detachControl(object element)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "detachControl" }, element
                }
            );
        }

        public async ValueTask<string> getClassName()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }
        #endregion
    }
}