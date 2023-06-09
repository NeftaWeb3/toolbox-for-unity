﻿using System.Reflection;
using Utf8Json.Formatters;
using Utf8Json.Resolvers.Internal;

namespace Utf8Json.Resolvers
{
    public static class EnumResolver
    {
        /// <summary>Serialize as Name.</summary>
        public static readonly IJsonFormatterResolver Default = EnumDefaultResolver.Instance;
        /// <summary>Serialize as Value.</summary>
        public static readonly IJsonFormatterResolver UnderlyingValue = EnumUnderlyingValueResolver.Instance;
    }
}

namespace Utf8Json.Resolvers.Internal
{
    internal sealed class EnumDefaultResolver : IJsonFormatterResolver
    {
        public static readonly IJsonFormatterResolver Instance = new EnumDefaultResolver();

        EnumDefaultResolver()
        {
        }

        public IJsonFormatter<T> GetFormatter<T>()
        {
            return FormatterCache<T>.formatter;
        }

        static class FormatterCache<T>
        {
            public static readonly IJsonFormatter<T> formatter;

            static FormatterCache()
            {
                var ti = typeof(T).GetTypeInfo();

                if (typeof(T).IsEnum)
                {
                    formatter = (IJsonFormatter<T>)(object)new EnumFormatter<T>(true);
                }
            }
        }
    }

    internal sealed class EnumUnderlyingValueResolver : IJsonFormatterResolver
    {
        public static readonly IJsonFormatterResolver Instance = new EnumUnderlyingValueResolver();

        EnumUnderlyingValueResolver()
        {
        }

        public IJsonFormatter<T> GetFormatter<T>()
        {
            return FormatterCache<T>.formatter;
        }

        static class FormatterCache<T>
        {
            public static readonly IJsonFormatter<T> formatter;

            static FormatterCache()
            {
                var ti = typeof(T).GetTypeInfo();

                if (typeof(T).IsEnum)
                {
                    formatter = (IJsonFormatter<T>)(object)new EnumFormatter<T>(false);
                }
            }
        }
    }
}