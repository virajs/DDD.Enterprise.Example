﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo.Library.Extensions
{
    public static class ForEachExtensions
    {
        public static void ForEachWithLast<T>(this IEnumerable<T> list, Action<T, bool> action)
        {
            var i = 0;
            var count = list.Count();
            foreach (var x in list)
            {
                if (++i == count)
                    action(x, true);
                else
                    action(x, false);
            }
        }
    }
}