﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Otus.Delegates.Vasileva
{
    public static class Extensions
    {
        public static T GetMax<T>(this IEnumerable<T> collection, Func<T, float> convertToNumber) where T : class
        {
            if (collection == null || !collection.Any()) throw new ArgumentException("Collection cannot be null or empty.");

            T maxItem = null;
            float maxValue = float.MinValue;

            foreach (var item in collection)
            {
                float value = convertToNumber(item);
                if (value > maxValue)
                {
                    maxValue = value;
                    maxItem = item;
                }
            }

            return maxItem;
        }
    }
}
