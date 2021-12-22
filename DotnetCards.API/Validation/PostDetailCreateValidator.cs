using DotnetCards.API.DTOs;
using DotnetCards.Core.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetCards.API.Validation
{
    public class PostDetailCreateValidator : AbstractValidator<PostDetailCreateDto>
    {
        public PostDetailCreateValidator()
        {
            RuleFor(pd => pd.PostText).NotEmpty().WithMessage("This field is required!");
        }
    }
}
