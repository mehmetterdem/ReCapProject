using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(x => x.DailyPrice).NotEmpty();
            RuleFor(x => x.Description).NotEmpty();
            RuleFor(x => x.Description).MaximumLength(50);

        }
    }
}
