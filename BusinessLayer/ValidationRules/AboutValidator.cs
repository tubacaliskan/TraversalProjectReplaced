using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator : AbstractValidator<About>
    {
        // her bir entity için ayrı validasyon classları oluşturulacak.
        // neden böyle bir şeye ihtiyaç duyuyoruz anlamadım. 
        public AboutValidator()
        {
            //rulefor validator'a a özel bir metot
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama kısmını boş bırakamazsınız!");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("Ltfen Görsel seçiniz!");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("Lütfen en az 50 karakterlik açıklama bilgisi giriniz");
            RuleFor(x => x.Description).MaximumLength(1500).WithMessage("Lütfen açıklamayı 1500 karakterden fazla tutmayınız.");

        }
    }
}
