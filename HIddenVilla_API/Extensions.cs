using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HIddenVilla_API
{
    public static class Extensions
    {
        public static List<string> ToErrorsList(this ModelStateDictionary modelState)
        {
            return (from item in modelState
                    where item.Value.Errors.Any()
                    select item.Value.Errors[0].ErrorMessage).ToList();
        }
    }
}
