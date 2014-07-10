﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Simple.OData.Client.Extensions
{
    static class EnumerableExtensions
    {
        public static IEnumerable<Tuple<T, int>> WithIndex<T>(this IEnumerable<T> source)
        {
            int index = 0;
            return source.Select(item => Tuple.Create(item, index++));
        }

        public static IEnumerable<T> OrIfEmpty<T>(this IEnumerable<T> source, IEnumerable<T> alternate)
        {
            return source.Any() ? source : alternate;
        }
    }
}
