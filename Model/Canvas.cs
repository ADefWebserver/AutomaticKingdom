using System.Text.Json.Serialization;
using System.Threading.Tasks;
using BabylonJS;
using EventHorizon.Blazor.Server.Interop;

namespace AutomaticKingdom
{
    [JsonConverter(typeof(CachedEntityConverter<Canvas>))]
    public class Canvas : HTMLCanvasElementCachedEntity
    {
        public static ValueTask<Canvas> GetElementById(
            string elementId
        ) => EventHorizonBlazorInterop.FuncClass(
            entity => new Canvas(entity),
            new string[] { "document", "getElementById" },
            elementId
        );

        private Canvas(
            ICachedEntity entity
        )
        {
            ___guid = entity.___guid;
        }
    }
}
