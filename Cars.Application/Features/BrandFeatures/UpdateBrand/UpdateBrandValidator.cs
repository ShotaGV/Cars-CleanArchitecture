using Cars.Application.Features.BrandFeatures.CreateBrand;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.Features.BrandFeatures.UpdateBrand
{
    public class UpdateBrandValidator : AbstractValidator<UpdateBrandQuery>
    {
        public UpdateBrandValidator()
        {
            RuleFor(q => q.updateBrandDto.Name)
                .NotNull().WithMessage("Cannot be null")
                .NotEmpty().WithMessage("{Name} Cannot be empty");
            RuleFor(q => q.updateBrandDto.BrandCreatedYear)
                .GreaterThanOrEqualTo(1700).WithMessage("Error");
        }
    }
}
