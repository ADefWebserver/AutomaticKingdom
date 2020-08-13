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

    
    
    [JsonConverter(typeof(CachedEntityConverter<AudioEngine>))]
    public class AudioEngine : CachedEntityObject, IAudioEngine
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        private AudioContext __audioContext;
        public async ValueTask<AudioContext> get_audioContext()
        {
            if(__audioContext == null)
            {
                __audioContext = await EventHorizonBlazorInterop.GetClass<AudioContext>(
                    this.___guid,
                    "audioContext",
                    (entity) =>
                    {
                        return new AudioContext() { ___guid = entity.___guid };
                    }
                );
            }
            return __audioContext;
        }
        #endregion

        #region Properties
        
        public async ValueTask<bool> get_canUseWebAudio()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "canUseWebAudio"
                );
        }
        public ValueTask set_canUseWebAudio(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "canUseWebAudio",
                    value
                );
        }

        private GainNode __masterGain;
        public async ValueTask<GainNode> get_masterGain()
        {
            if(__masterGain == null)
            {
                __masterGain = await EventHorizonBlazorInterop.GetClass<GainNode>(
                    this.___guid,
                    "masterGain",
                    (entity) =>
                    {
                        return new GainNode() { ___guid = entity.___guid };
                    }
                );
            }
            return __masterGain;
        }
        public ValueTask set_masterGain(GainNode value)
        {
__masterGain = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "masterGain",
                    value
                );
        }

        
        public async ValueTask<bool> get_WarnedWebAudioUnsupported()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "WarnedWebAudioUnsupported"
                );
        }
        public ValueTask set_WarnedWebAudioUnsupported(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "WarnedWebAudioUnsupported",
                    value
                );
        }

        
        public async ValueTask<bool> get_isMP3supported()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isMP3supported"
                );
        }
        public ValueTask set_isMP3supported(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isMP3supported",
                    value
                );
        }

        
        public async ValueTask<bool> get_isOGGsupported()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isOGGsupported"
                );
        }
        public ValueTask set_isOGGsupported(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isOGGsupported",
                    value
                );
        }

        
        public async ValueTask<bool> get_unlocked()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "unlocked"
                );
        }
        public ValueTask set_unlocked(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "unlocked",
                    value
                );
        }

        
        public async ValueTask<bool> get_useCustomUnlockedButton()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useCustomUnlockedButton"
                );
        }
        public ValueTask set_useCustomUnlockedButton(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useCustomUnlockedButton",
                    value
                );
        }

        private Observable<AudioEngine> __onAudioUnlockedObservable;
        public async ValueTask<Observable<AudioEngine>> get_onAudioUnlockedObservable()
        {
            if(__onAudioUnlockedObservable == null)
            {
                __onAudioUnlockedObservable = await EventHorizonBlazorInterop.GetClass<Observable<AudioEngine>>(
                    this.___guid,
                    "onAudioUnlockedObservable",
                    (entity) =>
                    {
                        return new Observable<AudioEngine>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onAudioUnlockedObservable;
        }
        public ValueTask set_onAudioUnlockedObservable(Observable<AudioEngine> value)
        {
__onAudioUnlockedObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onAudioUnlockedObservable",
                    value
                );
        }

        private Observable<AudioEngine> __onAudioLockedObservable;
        public async ValueTask<Observable<AudioEngine>> get_onAudioLockedObservable()
        {
            if(__onAudioLockedObservable == null)
            {
                __onAudioLockedObservable = await EventHorizonBlazorInterop.GetClass<Observable<AudioEngine>>(
                    this.___guid,
                    "onAudioLockedObservable",
                    (entity) =>
                    {
                        return new Observable<AudioEngine>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onAudioLockedObservable;
        }
        public ValueTask set_onAudioLockedObservable(Observable<AudioEngine> value)
        {
__onAudioLockedObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onAudioLockedObservable",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public AudioEngine() : base() { }

        public AudioEngine(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<AudioEngine> NewAudioEngine(
            CachedEntity hostElement = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "AudioEngine" },
                hostElement
            );

            return new AudioEngine(entity);
        }
        #endregion

        #region Methods
        public async ValueTask @lock()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "@lock" }
                }
            );
        }

        public async ValueTask @unlock()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "@unlock" }
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

        public async ValueTask<decimal> getGlobalVolume()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getGlobalVolume" }
                }
            );
        }

        public async ValueTask setGlobalVolume(decimal newVolume)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setGlobalVolume" }, newVolume
                }
            );
        }

        public async ValueTask connectToAnalyser(Analyser analyser)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "connectToAnalyser" }, analyser
                }
            );
        }
        #endregion
    }
}