using ApiBase.Domain.Dtos;
using ApiBase.Domain.Interfaces.Repositories;
using FluentValidation;

namespace ApiBase.Service.Validators
{
    public class ProdutoValidator : AbstractValidator<ProdutoDto>
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public ProdutoValidator(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;

            RuleFor(x => x.Situacao).Must(ValidarSituacao).WithMessage("O campo situação deve esta preenchido com true ou false.");
            RuleFor(x => x.CategoriaId).Must(ValidarCategoria).WithMessage("Nao foi encontrada nenhuma categoria.");
        }

        private static bool ValidarSituacao(string situacao)
            => situacao.ToUpper() == "TRUE" || situacao.ToUpper() == "FALSE";

        private bool ValidarCategoria(long? categoriaId)
        {
            if (categoriaId.HasValue && categoriaId != 0)
                return _categoriaRepository.Find(categoriaId.Value) != null;

            return true;
        }
             
    }
}
