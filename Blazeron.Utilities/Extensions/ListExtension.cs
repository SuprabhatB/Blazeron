namespace Blazeron.Utilities.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;

    /// <summary>
    /// Defines the <see cref="ListExtension" />.
    /// </summary>
    public static class ListExtension
    {
        /// <summary>
        /// Distincts the by.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TKey">The type of the key.</typeparam>
        /// <param name="all">All.</param>
        /// <param name="KeySelector">The key selector.</param>
        /// <returns></returns>
        public static IEnumerable<T> DistinctBy<T, TKey>(this IEnumerable<T> all, Func<T, TKey> KeySelector)
        {
            var known = new HashSet<TKey>();
            return all.Where(element => known.Add(KeySelector(element)));
        }

        /// <summary>
        /// Withes the index.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">The source.</param>
        /// <returns></returns>
        public static IEnumerable<(T item, int index)> WithIndex<T>(this IEnumerable<T> source)
        {
            return source.Select((item, index) => (item, index));
        }

        /// <summary>
        /// Conditionals the where.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">The source.</param>
        /// <param name="condition">The condition.</param>
        /// <param name="predicate">The predicate.</param>
        /// <returns></returns>
        public static IEnumerable<T> ConditionalWhere<T>(this IQueryable<T> source, Func<bool> condition, Expression<Func<T, bool>> predicate)
        {
            if (condition())
            {
                return source.Where(predicate).ToList();
            }

            return source.ToList();
        }

        /// <summary>
        /// Lefts the outer join.
        /// </summary>
        /// <typeparam name="TOuter">The type of the outer.</typeparam>
        /// <typeparam name="TInner">The type of the inner.</typeparam>
        /// <typeparam name="TKey">The type of the key.</typeparam>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="outer">The outer.</param>
        /// <param name="inner">The inner.</param>
        /// <param name="outerKeySelector">The outer key selector.</param>
        /// <param name="innerKeySelector">The inner key selector.</param>
        /// <param name="resultSelector">The result selector.</param>
        /// <returns></returns>
        public static IEnumerable<TResult> LeftOuterJoin<TOuter, TInner, TKey, TResult>(
            this IEnumerable<TOuter> outer,
            IEnumerable<TInner> inner,
            Func<TOuter, TKey> outerKeySelector,
            Func<TInner, TKey> innerKeySelector,
            Func<TOuter, TInner, TResult> resultSelector)
        {
            return outer.GroupJoin(inner, outerKeySelector, innerKeySelector, (a, b) => new { a, b })
                .SelectMany(x => x.b.DefaultIfEmpty(), (x, b) => resultSelector(x.a, b));
        }

        /// <summary>
        /// Conditionals the intersect.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="first">The first.</param>
        /// <param name="condition">The condition.</param>
        /// <param name="second">The second.</param>
        /// <returns></returns>
        public static IEnumerable<T> ConditionalIntersect<T>(this IEnumerable<T> first, Func<bool> condition, IEnumerable<T> second)
        {
            if (condition())
            {
                return first.Intersect(second);
            }

            return first;
        }

        /// <summary>
        /// Conditionals the except.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="first">The first.</param>
        /// <param name="condition">The condition.</param>
        /// <param name="second">The second.</param>
        /// <returns></returns>
        public static IEnumerable<T> ConditionalExcept<T>(this IEnumerable<T> first, Func<bool> condition, IEnumerable<T> second)
        {
            if (condition())
            {
                return first.Except(second);
            }

            return first;
        }

        /// <summary>
        /// Conditionals the concat.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="first">The first.</param>
        /// <param name="condition">The condition.</param>
        /// <param name="second">The second.</param>
        /// <returns></returns>
        public static IEnumerable<T> ConditionalConcat<T>(this IEnumerable<T> first, Func<bool> condition, IEnumerable<T> second)
        {
            if (condition())
            {
                return first.Concat(second);
            }

            return first;
        }

        /// <summary>
        /// Empties if default.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">The source.</param>
        /// <returns></returns>
        public static IEnumerable<T> EmptyIfDefault<T>(this IEnumerable<T> source) =>
            source == default ? Enumerable.Empty<T>() : source;

        /// <summary>
        /// Empties if default.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">The source.</param>
        /// <returns></returns>
        public static T EmptyIfDefault<T>(this T source) where T : new() =>
            source == null ? new T() : source;

        /// <summary>
        /// Determines whether the specified items is first.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item">The item.</param>
        /// <param name="items">The items.</param>
        /// <returns>
        ///   <c>true</c> if the specified items is first; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsFirst<T>(this T item, IEnumerable<T> items)
        {
            var first = items.FirstOrDefault();
            if (first == null) return false;

            return ReferenceEquals(first, item);
        }

        /// <summary>
        /// Determines whether the specified items is last.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item">The item.</param>
        /// <param name="items">The items.</param>
        /// <returns>
        ///   <c>true</c> if the specified items is last; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsLast<T>(this T item, IEnumerable<T> items)
        {
            var last = items.LastOrDefault();
            if (last == null) return false;

            return ReferenceEquals(last, item);
        }
    }
}
