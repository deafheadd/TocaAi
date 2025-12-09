using FluentValidation;
using TocaAi.Domain.Base;

namespace TocaAi.Service.Interfaces
{
    public interface IBaseService<TEntity, TId> where TEntity : IBaseEntity<TId>
    {
        void AttachObject(object obj);

        TOutputModel Add<TInputModel, TOutputModel, TValidator>(TInputModel inputModel)
        where TValidator : AbstractValidator<TEntity>, new()
        where TInputModel : class
        where TOutputModel : class;

        void Delete(TId id);

        IEnumerable<TOutputModel> Get<TOutputModel>(bool tracking = true, IList<string>? includes = null)
        where TOutputModel : class;

        TOutputModel GetById<TOutputModel>(TId id, bool tracking = true, IList<string>? includes = null)
            where TOutputModel : class;

        TOutputModel Update<TInputModel, TOutputModel, TValidator>(TInputModel inputModel)
            where TValidator : AbstractValidator<TEntity>, new()
            where TInputModel : class
            where TOutputModel : class;
    }
}
