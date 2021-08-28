using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace OrientExpress.Extensions {

    public static class GeneralExtensions {

        public static Expression<Func<A, C>> AndThen<A, B, C>(this Expression<Func<A, B>> first, Expression<Func<B, C>> second) {
            var a = Expression.Parameter(typeof(A), "a");

            return Expression.Lambda<Func<A, C>>(
                Expression.Invoke(
                    second, 
                    Expression.Invoke(first, a)),
                a);
        }
    }
}
