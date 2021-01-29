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

    
    
    [JsonConverter(typeof(CachedEntityConverter<FollowCameraInputsManager>))]
    public class FollowCameraInputsManager : CameraInputsManager<FollowCamera>
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
        public FollowCameraInputsManager() : base() { }

        public FollowCameraInputsManager(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<FollowCameraInputsManager> NewFollowCameraInputsManager(
            FollowCamera camera
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "FollowCameraInputsManager" },
                camera
            );

            return new FollowCameraInputsManager(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<FollowCameraInputsManager> addKeyboard()
        {
            return await EventHorizonBlazorInterop.FuncClass<FollowCameraInputsManager>(
                entity => new FollowCameraInputsManager() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addKeyboard" }
                }
            );
        }

        public async ValueTask<FollowCameraInputsManager> addMouseWheel()
        {
            return await EventHorizonBlazorInterop.FuncClass<FollowCameraInputsManager>(
                entity => new FollowCameraInputsManager() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addMouseWheel" }
                }
            );
        }

        public async ValueTask<FollowCameraInputsManager> addPointers()
        {
            return await EventHorizonBlazorInterop.FuncClass<FollowCameraInputsManager>(
                entity => new FollowCameraInputsManager() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addPointers" }
                }
            );
        }

        public async ValueTask<FollowCameraInputsManager> addVRDeviceOrientation()
        {
            return await EventHorizonBlazorInterop.FuncClass<FollowCameraInputsManager>(
                entity => new FollowCameraInputsManager() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addVRDeviceOrientation" }
                }
            );
        }
        #endregion
    }
}