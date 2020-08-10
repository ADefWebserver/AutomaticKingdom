using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace AutomaticKingdom
{
    public static class AutomaticKingdomInterop
    {
        // Blockly
        internal static ValueTask<object> DemoWorkspace(
            IJSRuntime jsRuntime,
            ElementReference blocklyDiv,
            ElementReference toolbox,
            ElementReference startBlocks)
        {
            return jsRuntime.InvokeAsync<object>(
                "BlocklyFunctions.createDemoWorkspace",
                blocklyDiv,
                toolbox,
                startBlocks);
        }

        internal static ValueTask<string> GetXML(
            IJSRuntime jsRuntime)
        {
            return jsRuntime.InvokeAsync<string>(
                "BlocklyFunctions.getXML");
        }

        // BabylonJs

        internal static ValueTask<string> LoadMesh(
            IJSRuntime jsRuntime,
            string ElementID,
            string FileName,
            string MeshName)
        {
            return jsRuntime.InvokeAsync<string>(
                "loadMesh",
                ElementID,
                FileName,
                MeshName);
        }

        internal static ValueTask<string> SetAnimation(
            IJSRuntime jsRuntime,
            string ElementID,
            string Animation,
            string Weight)
        {
            return jsRuntime.InvokeAsync<string>(
                "setAnimation",
                ElementID,
                Animation,
                Weight);
        }
    }
}