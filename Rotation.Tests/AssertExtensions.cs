using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Xunit;

// ReSharper disable CheckNamespace
namespace Rotation.Tests
// ReSharper restore CheckNamespace
{
    [DebuggerNonUserCode]
    [DebuggerStepThrough]
    public static class AssertExtensions
    {
        public static Exception OfType<T>(this Exception item)
        {
            Assert.IsType<T>(item);
            return item;
        }

        public static IList<T> ShouldBeEmpty<T>(this IList<T> list)
        {
            list.ShouldNotBeNull();
            list.Count.ShouldEqual(0);
            return list;
        }

        public static IList<T> ShouldEqual<T>(this IList<T> list, IEnumerable<T> expected) where T : IEquatable<T>
        {
            list.ToList().ShouldContainAll(expected);
            expected.ToList().ShouldContainAll(list);
            return list;
        }

        public static T ShouldEqual<T>(this T item, T expected)
        {
            Assert.Equal(expected, item);
            return item;
        }

        public static T? ShouldEqual<T>(this T? item, T? expected) where T : struct
        {
            Assert.Equal(expected, item);
            return item;
        }

        public static T ShouldBeTheSameAs<T>(this T item, T expected)
        {
            Assert.Same(expected, item);
            return item;
        }

        public static T ShouldEqual<T>(this T item, T expected, string errorMessage)
        {
            Assert.True(item.Equals(expected), errorMessage);
            return item;
        }

        public static void ShouldBeFalse(this bool item)
        {
            Assert.False(item);
        }

        public static void ShouldBeFalse(this bool item, string errorMessage)
        {
            Assert.False(item,errorMessage);
        }

        public static T ShouldBeGreaterThan<T>(this T item, T lowEndOfRange) where T : IComparable
        {
            Assert.True(item.CompareTo(lowEndOfRange) > 0);
            return item;
        }

        public static T ShouldBeGreaterThan<T>(this T item, T lowEndOfRange, string errorMessage) where T : IComparable
        {
            Assert.True(item.CompareTo(lowEndOfRange) > 0, errorMessage);
            return item;
        }

        public static T ShouldBeGreaterThanOrEqualTo<T>(this T item, T lowEndOfRange) where T : IComparable
        {
            Assert.True(item.CompareTo(lowEndOfRange)>= 0);
            return item;
        }

        public static T ShouldBeInRangeInclusive<T>(this T item, T lowEndOfRange, T highEndOfRange)
            where T : IComparable
        {
            item.ShouldBeGreaterThanOrEqualTo(lowEndOfRange);
            item.ShouldBeLessThanOrEqualTo(highEndOfRange);
            return item;
        }

        public static T ShouldBeLessThan<T>(this T item, T highEndOfRange) where T : IComparable
        {
            Assert.True(item.CompareTo(highEndOfRange) < 0);

            return item;
        }

        public static T ShouldBeLessThan<T>(this T item, T highEndOfRange, string errorMessage) where T : IComparable
        {
            Assert.True(item.CompareTo(highEndOfRange) < 0, errorMessage);
            return item;
        }

        public static T ShouldBeLessThanOrEqualTo<T>(this T item, T highEndOfRange) where T : IComparable
        {
            Assert.True(item.CompareTo(highEndOfRange) <= 0);
            return item;
        }

        public static T ShouldBeNull<T>(this T item)
        {
            Assert.Null(item);
            return item;
        }

        public static T ShouldBeNull<T>(this T item, string errorMessage) where T : class
        {
            Assert.True(item == null,errorMessage);
            return item;
        }

        public static object ShouldBeOfType<TType>(this object item)
        {
            item.ShouldBeOfType<TType>("");
            return item;
        }

        public static object ShouldNotBeOfType<TType>(this object item)
        {
            item.ShouldNotBeOfType<TType>("");
            return item;
        }

        public static object ShouldBeOfType<TType>(this object item, string errorMessage)
        {
            typeof(TType).IsAssignableFrom(item.GetType()).ShouldBeTrue(errorMessage);
            return item;
        }

        public static object ShouldNotBeOfType<TType>(this object item,string errorMessage)
        {
            typeof(TType).IsAssignableFrom(item.GetType()).ShouldBeFalse(errorMessage);
            return item;
        }

        public static void ShouldBeTrue(this bool item)
        {
            Assert.True(item);
        }

        public static void ShouldBeTrue(this bool item, string errorMessage)
        {
            Assert.True(item, errorMessage);
        }

        public static string ShouldContain(this string item, string expectedSubstring)
        {
            item.Contains(expectedSubstring).ShouldBeTrue();
            return item;
        }

        public static IList<T> ShouldContainAll<T>(this IList<T> list, IEnumerable<T> expected) where T : IEquatable<T>
        {
            foreach (T item in expected)
            {
                T other = item;
                list.Any(x => x.Equals(other)).ShouldBeTrue("Collection does not contain '" + item + "'");
            }
            return list;
        }

        public static IEnumerable<T> ShouldContainAllInOrder<T>(this IEnumerable<T> list, IEnumerable<T> expected)
            where T : IEquatable<T>
        {
            var indexedSource = list.Select((x, i) => new
            {
                Item = x,
                Index = i
            }).ToList();
            var indexedExpected = expected.Select((x, i) => new
            {
                Item = x,
                Index = i
            }).ToList();
            indexedSource.Count.ShouldEqual(indexedExpected.Count);
            foreach (int index in Enumerable.Range(0, indexedSource.Count))
            {
                indexedSource[index].Item.ShouldEqual(indexedExpected[index].Item, "at offset " + index);
            }
            return list;
        }

        public static T ShouldNotEqual<T>(this T item, T expected)
        {
            Assert.NotEqual(expected, item);
            return item;
        }

        public static T ShouldNotEqual<T>(this T item, T expected, string errorMessage)
        {
            Assert.True(!expected.Equals(item), errorMessage);
            return item;
        }

        public static T ShouldNotBeNull<T>(this T item) where T : class
        {
            Assert.NotNull(item);
            return item;
        }

        public static T? ShouldNotBeNull<T>(this T? item) where T : struct
        {
            Assert.True(item.HasValue);
            return item;
        }

        public static T ShouldNotBeNull<T>(this T item, string errorMessage) where T : class
        {
            Assert.True(item!=null,errorMessage);
            return item;
        }

        public static string ShouldNotBeNullOrEmpty(this string item)
        {
            Assert.NotNull(item);
            Assert.NotEmpty(item);
            return item;
        }

        public static string ShouldNotBeNullOrEmpty(this string item, string message)
        {
            item.ShouldNotBeNull(message);
            Assert.True(item!="",message);
            return item;
        }

        public static string ShouldNotContain(this string item, string expectedSubstring)
        {
            item.Contains(expectedSubstring).ShouldBeFalse();
            return item;
        }

        public static string ShouldStartWith(this string item, string expected)
        {
            item.StartsWith(expected).ShouldBeTrue();
            return item;
        }

        public static string ShouldStartWith(this string item, string expected, string errorMessage)
        {
            item.StartsWith(expected).ShouldBeTrue(errorMessage);
            return item;
        }
    }
}
