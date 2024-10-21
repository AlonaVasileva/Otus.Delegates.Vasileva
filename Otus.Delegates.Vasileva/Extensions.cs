using System;
using System.Collections.Generic;
using System.Linq;

namespace Otus.Delegates.Vasileva
{
    internal static class Extensions
    {
        public static T GetMax<T>(this IEnumerable<T> collection, Func<T, float> convertToNumber) where T : class
        {
            if (collection == null || !collection.Any())
                throw new ArgumentException("Collection cannot be null or empty.");

            return collection.Aggregate((maxItem, currentItem) =>
                convertToNumber(currentItem) > convertToNumber(maxItem) ? currentItem : maxItem);
        }
    }
}
