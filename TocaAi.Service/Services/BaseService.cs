using AutoMapper;
using FluentValidation;
using TocaAi.Domain.Base;
using TocaAi.Service.Interfaces;

namespace TocaAi.Service.Services
{
    public class BaseService<TEntity, TId> : IBaseService<TEntity, TId>
        where TEntity : class, IBaseEntity<TId>
    {
        private readonly IBaseRepository<TEntity, TId> _baseRepository;
        private readonly IMapper _mapper;

        public BaseService(IBaseRepository<TEntity, TId> baseRepository, IMapper mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }

        public TOutputModel Add<TInputModel, TOutputModel, TValidator>(TInputModel inputModel)
            where TInputModel : class
            where TOutputModel : class
            where TValidator : AbstractValidator<TEntity>, new()
        {
            var entity = _mapper.Map<TEntity>(inputModel);

            Validate(entity, new TValidator());

            _baseRepository.Insert(entity);

            return _mapper.Map<TOutputModel>(entity);
        }

        public void AttachObject(object obj)
        {
            _baseRepository.AttachObject(obj);
        }

        public void Delete(TId id)
        {
            _baseRepository.Delete(id);
        }

        public IEnumerable<TOutputModel> Get<TOutputModel>(bool tracking = true, IList<string>? includes = null) where TOutputModel : class
        {
            var entities = _baseRepository.Select(tracking, includes);
            return entities.Select(e => _mapper.Map<TOutputModel>(e));
        }

        public TOutputModel GetById<TOutputModel>(TId id, bool tracking = true, IList<string>? includes = null) where TOutputModel : class
        {
            var entity = _baseRepository.SelectById(id, tracking, includes);
            return _mapper.Map<TOutputModel>(entity);
        }

        public TOutputModel Update<TInputModel, TOutputModel, TValidator>(TInputModel inputModel)
            where TInputModel : class
            where TOutputModel : class
            where TValidator : AbstractValidator<TEntity>, new()
        {
            var entity = _mapper.Map<TEntity>(inputModel);

            Validate(entity, new TValidator());

            _baseRepository.Update(entity);

            return _mapper.Map<TOutputModel>(entity);
        }

        private void Validate(TEntity entity, AbstractValidator<TEntity> validator)
        {
            if (entity == null)
                throw new Exception("Invalid entity.");

            validator.ValidateAndThrow(entity);
        }
    }
}
