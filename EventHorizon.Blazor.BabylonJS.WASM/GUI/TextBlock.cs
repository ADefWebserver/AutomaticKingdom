/// Generated - Do Not Edit
namespace BabylonJS.GUI
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<TextBlock>))]
    public class TextBlock : Control
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        
        public CachedEntity[] lines
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<CachedEntity>(
                    this.___guid,
                    "lines"
                );
            }
        }

        
        public bool resizeToFit
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "resizeToFit"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "resizeToFit",
                    value
                );
            }
        }

        private TextWrapping __textWrapping;
        public TextWrapping textWrapping
        {
            get
            {
            if(__textWrapping == null)
            {
                __textWrapping = EventHorizonBlazorInterop.GetClass<TextWrapping>(
                    this.___guid,
                    "textWrapping",
                    (entity) =>
                    {
                        return new TextWrapping() { ___guid = entity.___guid };
                    }
                );
            }
            return __textWrapping;
            }
            set
            {
__textWrapping = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "textWrapping",
                    value
                );
            }
        }

        
        public string text
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "text"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "text",
                    value
                );
            }
        }

        
        public decimal textHorizontalAlignment
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "textHorizontalAlignment"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "textHorizontalAlignment",
                    value
                );
            }
        }

        
        public decimal textVerticalAlignment
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "textVerticalAlignment"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "textVerticalAlignment",
                    value
                );
            }
        }

        
        public string lineSpacing
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "lineSpacing"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lineSpacing",
                    value
                );
            }
        }

        
        public decimal outlineWidth
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "outlineWidth"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "outlineWidth",
                    value
                );
            }
        }

        
        public string outlineColor
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "outlineColor"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "outlineColor",
                    value
                );
            }
        }
        #endregion

        #region Properties
        
        public string name
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "name"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "name",
                    value
                );
            }
        }

        private Observable<TextBlock> __onTextChangedObservable;
        public Observable<TextBlock> onTextChangedObservable
        {
            get
            {
            if(__onTextChangedObservable == null)
            {
                __onTextChangedObservable = EventHorizonBlazorInterop.GetClass<Observable<TextBlock>>(
                    this.___guid,
                    "onTextChangedObservable",
                    (entity) =>
                    {
                        return new Observable<TextBlock>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onTextChangedObservable;
            }
            set
            {
__onTextChangedObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onTextChangedObservable",
                    value
                );
            }
        }

        private Observable<TextBlock> __onLinesReadyObservable;
        public Observable<TextBlock> onLinesReadyObservable
        {
            get
            {
            if(__onLinesReadyObservable == null)
            {
                __onLinesReadyObservable = EventHorizonBlazorInterop.GetClass<Observable<TextBlock>>(
                    this.___guid,
                    "onLinesReadyObservable",
                    (entity) =>
                    {
                        return new Observable<TextBlock>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onLinesReadyObservable;
            }
            set
            {
__onLinesReadyObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onLinesReadyObservable",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public TextBlock() : base() { }

        public TextBlock(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public TextBlock(
            string name = null, string text = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "GUI", "TextBlock" },
                name, text
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public decimal computeExpectedHeight()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "computeExpectedHeight" }
                }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }
        #endregion
    }
}