using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HiddenVilla_Server.Helper
{
    public static class IJSRuntimeExtensions
    {
        public static async ValueTask ToastrSuccess(this IJSRuntime JSRuntime, string message)
        {
            await JSRuntime.InvokeVoidAsync("ShowToastr", "success", "Success message");
        }

        public static async ValueTask ToastrError(this IJSRuntime JSRuntime, string message)
        {
            await JSRuntime.InvokeVoidAsync("ShowToastr", "error", "Error message");
        }
    }
}
