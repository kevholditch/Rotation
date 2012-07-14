using System.Collections.Generic;
using System.Linq;

namespace Rotation.GameObjects.sTests.Extensions
{
    public static class EnumerationExtensions
    {
        public static T Second<T>(this IEnumerable<T> collection)
        {
            return collection.Skip(1).First();
        }

        public static T Third<T>(this IEnumerable<T> collection)
        {
            return collection.Skip(2).First();
        }

        public static T Fourth<T>(this IEnumerable<T> collection)
        {
            return collection.Skip(3).First();
        }
    }
}