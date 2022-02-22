using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Kategori adını boş geçemezsiniz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklamayı boi geçemezsiniz");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapın");
            RuleFor(x => x.Name).MaximumLength(20).WithMessage("Lütfen en fazla 20 karakter girişi yapın");
        }
    }
}
