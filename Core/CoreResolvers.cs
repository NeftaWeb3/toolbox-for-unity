#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168

namespace Nefta.Core.Resolvers
{
    using System;
    using Utf8Json;

    public class CoreResolvers : global::Utf8Json.IJsonFormatterResolver
    {
        public static readonly global::Utf8Json.IJsonFormatterResolver Instance = new CoreResolvers();

        CoreResolvers()
        {

        }

        public global::Utf8Json.IJsonFormatter<T> GetFormatter<T>()
        {
            return FormatterCache<T>.formatter;
        }

        static class FormatterCache<T>
        {
            public static readonly global::Utf8Json.IJsonFormatter<T> formatter;

            static FormatterCache()
            {
                var f = CoreResolversGetFormatterHelper.GetFormatter(typeof(T));
                if (f != null)
                {
                    formatter = (global::Utf8Json.IJsonFormatter<T>)f;
                }
            }
        }
    }

    internal static class CoreResolversGetFormatterHelper
    {
        static readonly global::System.Collections.Generic.Dictionary<Type, int> lookup;

        static CoreResolversGetFormatterHelper()
        {
            lookup = new global::System.Collections.Generic.Dictionary<Type, int>(1)
            {
                {typeof(global::Nefta.Core.NeftaUser), 0 },
            };
        }

        internal static object GetFormatter(Type t)
        {
            int key;
            if (!lookup.TryGetValue(t, out key)) return null;

            switch (key)
            {
                case 0: return new Nefta.Core.Formatters.Nefta.Core.NeftaUserFormatter();
                default: return null;
            }
        }
    }
}

#pragma warning disable 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612

#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 219
#pragma warning disable 168

namespace Nefta.Core.Formatters.Nefta.Core
{
    using System;
    using Utf8Json;


    public sealed class NeftaUserFormatter : global::Utf8Json.IJsonFormatter<global::Nefta.Core.NeftaUser>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public NeftaUserFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("user_token"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("user_id"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("username"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("email"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("address"), 4},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("user_token"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("user_id"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("username"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("email"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("address"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::Nefta.Core.NeftaUser value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value._token);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value._userId);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value._username);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value._email);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteString(value._address);
            
            writer.WriteEndObject();
        }

        public global::Nefta.Core.NeftaUser Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var ___token__ = default(string);
            var ___token__b__ = false;
            var ___userId__ = default(string);
            var ___userId__b__ = false;
            var ___username__ = default(string);
            var ___username__b__ = false;
            var ___email__ = default(string);
            var ___email__b__ = false;
            var ___address__ = default(string);
            var ___address__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        ___token__ = reader.ReadString();
                        ___token__b__ = true;
                        break;
                    case 1:
                        ___userId__ = reader.ReadString();
                        ___userId__b__ = true;
                        break;
                    case 2:
                        ___username__ = reader.ReadString();
                        ___username__b__ = true;
                        break;
                    case 3:
                        ___email__ = reader.ReadString();
                        ___email__b__ = true;
                        break;
                    case 4:
                        ___address__ = reader.ReadString();
                        ___address__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Nefta.Core.NeftaUser();
            if(___token__b__) ____result._token = ___token__;
            if(___userId__b__) ____result._userId = ___userId__;
            if(___username__b__) ____result._username = ___username__;
            if(___email__b__) ____result._email = ___email__;
            if(___address__b__) ____result._address = ___address__;

            return ____result;
        }
    }

}

#pragma warning disable 168
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612
