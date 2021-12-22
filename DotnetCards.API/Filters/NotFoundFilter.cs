using DotnetCards.API.DTOs;
using DotnetCards.Core.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetCards.API.Filters
{
    public class NotFoundFilter : ActionFilterAttribute
    {
        private readonly IPostService _postService;

        public NotFoundFilter(IPostService postService)
        {
            _postService = postService;
        }

        public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            int id = (int)context.ActionArguments.Values.FirstOrDefault();

            var post = await _postService.GetByIdAsync(id);

            if(post != null)
            {
                await next();
            }
            else
            {
                var errorDto = new ErrorDto();
                errorDto.Status = 404;
                errorDto.Errors.Add($"id'si {id} olan kayıt veritabanında bulunamadı");

                context.Result = new NotFoundObjectResult(errorDto);
            }

        }
    }
}
