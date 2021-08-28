using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace OrientExpress.Extensions {

    public static class PredicateExtensions {

        public static Expression<Func<A, bool>> Or<A>(this Expression<Func<A, bool>> @this, Expression<Func<A, bool>> other) {
            var a = Expression.Parameter(typeof(A), "a");

            return Expression.Lambda<Func<A, bool>>(
                Expression.Or(
                    Expression.Invoke(@this, a),
                    Expression.Invoke(other, a)),
                new List<ParameterExpression>() { a });
        }

        public static Expression<Func<A, bool>> And<A>(this Expression<Func<A, bool>> @this, Expression<Func<A, bool>> other) {
            var a = Expression.Parameter(typeof(A), "a");

            return Expression.Lambda<Func<A, bool>>(
                Expression.And(
                    Expression.Invoke(@this, a),
                    Expression.Invoke(other, a)),
                new List<ParameterExpression>() { a });
        }
    }
}
