using DotnetCards.API.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetCards.API.Filters
{
    public class ValidationFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                var errorDto = new ErrorDto();
                errorDto.Status = 400;

                var modelErrors = context.ModelState.Values.SelectMany(v => v.Errors);
                modelErrors.ToList().ForEach(x => errorDto.Errors.Add(x.ErrorMessage));

                context.Result = new BadRequestObjectResult(errorDto);
            }
        }
    }
}
