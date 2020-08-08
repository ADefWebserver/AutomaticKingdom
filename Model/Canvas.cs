using System.Text.Json.Serialization;
using BabylonJS;
using EventHorizon.Blazor.Interop;

namespace AutomaticKingdom.Model
{
    [JsonConverter(typeof(CachedEntityConverter<Canvas>))]
    public class Canvas : HTMLCanvasElementCachedEntity
    {
        public static Canvas GetElementById(string elementId)
        {
            var result = EventHorizonBlazorInterop.FuncClass(
            entity => new Canvas(entity),
            new string[] { "document", "getElementById" },
            elementId);

            return result;
        }

        private Canvas(
            ICachedEntity entity
        )
        {
            ___guid = entity.___guid;
        }
    }
}
