using ApiBase.Domain.Dtos;
using FluentValidation;

namespace ApiBase.Service.Validators
{
    public class CategoriaValidator : AbstractValidator<CategoriaDto>
    {
        public CategoriaValidator()
        {
            RuleFor(x => x.Situacao).Must(ValidarSituacao).WithMessage("O campo situação deve esta preenchido com true ou false.");
        }

        private static bool ValidarSituacao(string situacao)
            => situacao.ToUpper() == "TRUE" || situacao.ToUpper() == "FALSE";
    }
}
