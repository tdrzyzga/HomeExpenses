using System;
using System.Linq.Expressions;
using LinqKit;

namespace Core.Domain.Specifications
{
    public abstract class Specification<T>
    {
        private Expression<Func<T, bool>> Predicate { get; set; }

        public static implicit operator Expression<Func<T, bool>>(Specification<T> specification)
        {
            return specification.ToExpression();
        }

        public AndSpecification<T> And(Specification<T> specification)
        {
            return new AndSpecification<T>(this, specification);
        }
        public OrSpecification<T> Or(Specification<T> specification)
        {
            return new OrSpecification<T>(this, specification);
        }
        
        public virtual Expression<Func<T, bool>> ToExpression()
        {
            return Predicate;
        }
    }

    public class AndSpecification<T> : Specification<T>
    {
        private readonly Specification<T> _firstSpecification;
        private readonly Specification<T> _secondSpecification;

        internal AndSpecification(Specification<T> firstSpecification, Specification<T> secondSpecification)
        {
            _firstSpecification = firstSpecification;
            _secondSpecification = secondSpecification;
        }

        public override Expression<Func<T, bool>> ToExpression()
        {
            return _firstSpecification.ToExpression().And(_secondSpecification.ToExpression());
        }
    }
    
    public class OrSpecification<T> : Specification<T>
    {
        private readonly Specification<T> _firstSpecification;
        private readonly Specification<T> _secondSpecification;

        internal OrSpecification(Specification<T> firstSpecification, Specification<T> secondSpecification)
        {
            _firstSpecification = firstSpecification;
            _secondSpecification = secondSpecification;
        }

        public override Expression<Func<T, bool>> ToExpression()
        {
            return _firstSpecification.ToExpression().Or(_secondSpecification.ToExpression());
        }
    }
}