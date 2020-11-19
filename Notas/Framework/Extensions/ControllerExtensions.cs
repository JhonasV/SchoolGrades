using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolGrades.Framework.Extensions
{
    static public class ControllerExtensions
    {
        static public string GetValidationErrors(this ControllerBase controllerBase)
        {
            var message = string.Join(" | ", controllerBase.ModelState.Values
                            .SelectMany(v => v.Errors)
                            .Select(e => e.Exception.Message));

            return message;
        }
    }
}
