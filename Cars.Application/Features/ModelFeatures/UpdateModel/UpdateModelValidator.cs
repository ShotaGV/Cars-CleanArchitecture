using Cars.Application.Dtos.BrandDtos;
using Cars.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.Features.ModelFeatures.UpdateModel
{
    public class UpdateModelValidator : AbstractValidator<UpdateModelQuery>
    {
        public UpdateModelValidator()
        {
            RuleFor(q => q.updateModelDto.Name)
                .NotNull().WithMessage("Cannot be null")
                .NotEmpty().WithMessage("{Name} Cannot be empty");

            RuleFor(dto => dto.updateModelDto.ManufactureStartDate)
                .NotEmpty().WithMessage("Manufacture start date is required.")
                .GreaterThanOrEqualTo(1700).WithMessage($"Manufacture start date must be greater than BrandCreatedYear.");

            RuleFor(dto => dto.updateModelDto.ManufactureEndDate)
                .NotEmpty().WithMessage("Manufacture end date is required.")
                .GreaterThanOrEqualTo(dto => dto.updateModelDto.ManufactureStartDate).WithMessage("End date must be greater than or equal to start date.");
        }
    }
}
