using DotNetForHtml5;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.JSInterop;
using Microsoft.JSInterop.WebAssembly;
using OpenSilverExample1.Browser.Interop;

namespace OpenSilverExample1.Browser.Pages
{
    [Route("/")]
    public class Index : ComponentBase
    {
        protected override void BuildRenderTree(RenderTreeBuilder __builder)
        {
        }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            JSInterop.Runtime = JSRuntime as WebAssemblyJSRuntime;
            Cshtml5Initializer.Initialize(new UnmarshalledJavaScriptExecutionHandler(JSRuntime));
            Program.RunApplication();
        }

        [Inject]
        private IJSRuntime JSRuntime { get; set; }
    }
}