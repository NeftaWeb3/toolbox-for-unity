#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168

namespace Nefta.AdSdk.Resolvers
{
    using System;
    using Utf8Json;

    public class AdResolvers : global::Utf8Json.IJsonFormatterResolver
    {
        public static readonly global::Utf8Json.IJsonFormatterResolver Instance = new AdResolvers();

        AdResolvers()
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
                var f = AdResolversGetFormatterHelper.GetFormatter(typeof(T));
                if (f != null)
                {
                    formatter = (global::Utf8Json.IJsonFormatter<T>)f;
                }
            }
        }
    }

    internal static class AdResolversGetFormatterHelper
    {
        static readonly global::System.Collections.Generic.Dictionary<Type, int> lookup;

        static AdResolversGetFormatterHelper()
        {
            lookup = new global::System.Collections.Generic.Dictionary<Type, int>(35)
            {
                {typeof(global::Nefta.AdSdk.Data.AdditionalData[]), 0 },
                {typeof(global::Nefta.AdSdk.Data.Format[]), 1 },
                {typeof(global::System.Collections.Generic.List<string>), 2 },
                {typeof(global::Nefta.AdSdk.Data.Metric[]), 3 },
                {typeof(global::Nefta.AdSdk.Data.Banner[]), 4 },
                {typeof(global::Nefta.AdSdk.Data.Impression[]), 5 },
                {typeof(global::System.Collections.Generic.List<global::Nefta.AdSdk.Data.Bid>), 6 },
                {typeof(global::System.Collections.Generic.List<global::Nefta.AdSdk.Data.SeatBid>), 7 },
                {typeof(global::System.Collections.Generic.List<global::Nefta.AdSdk.Data.AdUnit>), 8 },
                {typeof(global::Nefta.AdSdk.Data.AdUnit), 9 },
                {typeof(global::Nefta.AdSdk.Data.Publisher), 10 },
                {typeof(global::Nefta.AdSdk.Data.Content), 11 },
                {typeof(global::Nefta.AdSdk.Data.Application), 12 },
                {typeof(global::Nefta.AdSdk.Data.Format), 13 },
                {typeof(global::Nefta.AdSdk.Data.Banner), 14 },
                {typeof(global::Nefta.AdSdk.Data.BidExtNefta), 15 },
                {typeof(global::Nefta.AdSdk.Data.BidExt), 16 },
                {typeof(global::Nefta.AdSdk.Data.Bid), 17 },
                {typeof(global::Nefta.AdSdk.Data.Metric), 18 },
                {typeof(global::Nefta.AdSdk.Data.Video), 19 },
                {typeof(global::Nefta.AdSdk.Data.Impression), 20 },
                {typeof(global::Nefta.AdSdk.Data.Consent), 21 },
                {typeof(global::Nefta.AdSdk.Data.Site), 22 },
                {typeof(global::Nefta.AdSdk.Data.Geo), 23 },
                {typeof(global::Nefta.AdSdk.Data.Device), 24 },
                {typeof(global::Nefta.AdSdk.Data.User), 25 },
                {typeof(global::Nefta.AdSdk.Data.BidRequestExtNefta), 26 },
                {typeof(global::Nefta.AdSdk.Data.BidRequestExt), 27 },
                {typeof(global::Nefta.AdSdk.Data.BidRequest), 28 },
                {typeof(global::Nefta.AdSdk.Data.SeatBid), 29 },
                {typeof(global::Nefta.AdSdk.Data.BidResponse), 30 },
                {typeof(global::Nefta.AdSdk.Data.InitRequest), 31 },
                {typeof(global::Nefta.AdSdk.Data.InitResponse), 32 },
                {typeof(global::Nefta.AdSdk.Data.Native), 33 },
                {typeof(global::Nefta.AdSdk.Data.Producer), 34 },
            };
        }

        internal static object GetFormatter(Type t)
        {
            int key;
            if (!lookup.TryGetValue(t, out key)) return null;

            switch (key)
            {
                case 0: return new global::Utf8Json.Formatters.ArrayFormatter<global::Nefta.AdSdk.Data.AdditionalData>();
                case 1: return new global::Utf8Json.Formatters.ArrayFormatter<global::Nefta.AdSdk.Data.Format>();
                case 2: return new global::Utf8Json.Formatters.ListFormatter<string>();
                case 3: return new global::Utf8Json.Formatters.ArrayFormatter<global::Nefta.AdSdk.Data.Metric>();
                case 4: return new global::Utf8Json.Formatters.ArrayFormatter<global::Nefta.AdSdk.Data.Banner>();
                case 5: return new global::Utf8Json.Formatters.ArrayFormatter<global::Nefta.AdSdk.Data.Impression>();
                case 6: return new global::Utf8Json.Formatters.ListFormatter<global::Nefta.AdSdk.Data.Bid>();
                case 7: return new global::Utf8Json.Formatters.ListFormatter<global::Nefta.AdSdk.Data.SeatBid>();
                case 8: return new global::Utf8Json.Formatters.ListFormatter<global::Nefta.AdSdk.Data.AdUnit>();
                case 9: return new Nefta.AdSdk.Formatters.Nefta.AdSdk.Data.AdUnitFormatter();
                case 10: return new Nefta.AdSdk.Formatters.Nefta.AdSdk.Data.PublisherFormatter();
                case 11: return new Nefta.AdSdk.Formatters.Nefta.AdSdk.Data.ContentFormatter();
                case 12: return new Nefta.AdSdk.Formatters.Nefta.AdSdk.Data.ApplicationFormatter();
                case 13: return new Nefta.AdSdk.Formatters.Nefta.AdSdk.Data.FormatFormatter();
                case 14: return new Nefta.AdSdk.Formatters.Nefta.AdSdk.Data.BannerFormatter();
                case 15: return new Nefta.AdSdk.Formatters.Nefta.AdSdk.Data.BidExtNeftaFormatter();
                case 16: return new Nefta.AdSdk.Formatters.Nefta.AdSdk.Data.BidExtFormatter();
                case 17: return new Nefta.AdSdk.Formatters.Nefta.AdSdk.Data.BidFormatter();
                case 18: return new Nefta.AdSdk.Formatters.Nefta.AdSdk.Data.MetricFormatter();
                case 19: return new Nefta.AdSdk.Formatters.Nefta.AdSdk.Data.VideoFormatter();
                case 20: return new Nefta.AdSdk.Formatters.Nefta.AdSdk.Data.ImpressionFormatter();
                case 21: return new Nefta.AdSdk.Formatters.Nefta.AdSdk.Data.ConsentFormatter();
                case 22: return new Nefta.AdSdk.Formatters.Nefta.AdSdk.Data.SiteFormatter();
                case 23: return new Nefta.AdSdk.Formatters.Nefta.AdSdk.Data.GeoFormatter();
                case 24: return new Nefta.AdSdk.Formatters.Nefta.AdSdk.Data.DeviceFormatter();
                case 25: return new Nefta.AdSdk.Formatters.Nefta.AdSdk.Data.UserFormatter();
                case 26: return new Nefta.AdSdk.Formatters.Nefta.AdSdk.Data.BidRequestExtNeftaFormatter();
                case 27: return new Nefta.AdSdk.Formatters.Nefta.AdSdk.Data.BidRequestExtFormatter();
                case 28: return new Nefta.AdSdk.Formatters.Nefta.AdSdk.Data.BidRequestFormatter();
                case 29: return new Nefta.AdSdk.Formatters.Nefta.AdSdk.Data.SeatBidFormatter();
                case 30: return new Nefta.AdSdk.Formatters.Nefta.AdSdk.Data.BidResponseFormatter();
                case 31: return new Nefta.AdSdk.Formatters.Nefta.AdSdk.Data.InitRequestFormatter();
                case 32: return new Nefta.AdSdk.Formatters.Nefta.AdSdk.Data.InitResponseFormatter();
                case 33: return new Nefta.AdSdk.Formatters.Nefta.AdSdk.Data.NativeFormatter();
                case 34: return new Nefta.AdSdk.Formatters.Nefta.AdSdk.Data.ProducerFormatter();
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

namespace Nefta.AdSdk.Formatters.Nefta.AdSdk.Data
{
    using System;
    using Utf8Json;


    public sealed class AdUnitFormatter : global::Utf8Json.IJsonFormatter<global::Nefta.AdSdk.Data.AdUnit>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public AdUnitFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("id"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("app_id"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("type"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("width"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("height"), 4},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("id"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("app_id"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("type"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("width"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("height"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::Nefta.AdSdk.Data.AdUnit value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value._id);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value._appId);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value._type);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteInt32(value._width);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteInt32(value._height);
            
            writer.WriteEndObject();
        }

        public global::Nefta.AdSdk.Data.AdUnit Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var ___id__ = default(string);
            var ___id__b__ = false;
            var ___appId__ = default(string);
            var ___appId__b__ = false;
            var ___type__ = default(string);
            var ___type__b__ = false;
            var ___width__ = default(int);
            var ___width__b__ = false;
            var ___height__ = default(int);
            var ___height__b__ = false;

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
                        ___id__ = reader.ReadString();
                        ___id__b__ = true;
                        break;
                    case 1:
                        ___appId__ = reader.ReadString();
                        ___appId__b__ = true;
                        break;
                    case 2:
                        ___type__ = reader.ReadString();
                        ___type__b__ = true;
                        break;
                    case 3:
                        ___width__ = reader.ReadInt32();
                        ___width__b__ = true;
                        break;
                    case 4:
                        ___height__ = reader.ReadInt32();
                        ___height__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Nefta.AdSdk.Data.AdUnit();
            if(___id__b__) ____result._id = ___id__;
            if(___appId__b__) ____result._appId = ___appId__;
            if(___type__b__) ____result._type = ___type__;
            if(___width__b__) ____result._width = ___width__;
            if(___height__b__) ____result._height = ___height__;

            return ____result;
        }
    }


    public sealed class PublisherFormatter : global::Utf8Json.IJsonFormatter<global::Nefta.AdSdk.Data.Publisher>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public PublisherFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("id"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("name"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("cat"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("domain"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("ext"), 4},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("id"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("name"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("cat"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("domain"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("ext"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::Nefta.AdSdk.Data.Publisher value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value._id);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value._name);
            writer.WriteRaw(this.____stringByteKeys[2]);
            formatterResolver.GetFormatterWithVerify<string[]>().Serialize(ref writer, value._categories, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value._domain);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteString(value._ext);
            
            writer.WriteEndObject();
        }

        public global::Nefta.AdSdk.Data.Publisher Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var ___id__ = default(string);
            var ___id__b__ = false;
            var ___name__ = default(string);
            var ___name__b__ = false;
            var ___categories__ = default(string[]);
            var ___categories__b__ = false;
            var ___domain__ = default(string);
            var ___domain__b__ = false;
            var ___ext__ = default(string);
            var ___ext__b__ = false;

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
                        ___id__ = reader.ReadString();
                        ___id__b__ = true;
                        break;
                    case 1:
                        ___name__ = reader.ReadString();
                        ___name__b__ = true;
                        break;
                    case 2:
                        ___categories__ = formatterResolver.GetFormatterWithVerify<string[]>().Deserialize(ref reader, formatterResolver);
                        ___categories__b__ = true;
                        break;
                    case 3:
                        ___domain__ = reader.ReadString();
                        ___domain__b__ = true;
                        break;
                    case 4:
                        ___ext__ = reader.ReadString();
                        ___ext__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Nefta.AdSdk.Data.Publisher();
            if(___id__b__) ____result._id = ___id__;
            if(___name__b__) ____result._name = ___name__;
            if(___categories__b__) ____result._categories = ___categories__;
            if(___domain__b__) ____result._domain = ___domain__;
            if(___ext__b__) ____result._ext = ___ext__;

            return ____result;
        }
    }


    public sealed class ContentFormatter : global::Utf8Json.IJsonFormatter<global::Nefta.AdSdk.Data.Content>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public ContentFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("id"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("episode"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("title"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("series"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("season"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("artist"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("genre"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("album"), 7},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("isrc"), 8},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("producer"), 9},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("url"), 10},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("cat"), 11},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("prodq"), 12},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("context"), 13},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("contentrating"), 14},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("userrating"), 15},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("qagmediarating"), 16},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("keywords"), 17},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("livestream"), 18},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("sourcerelationship"), 19},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("len"), 20},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("language"), 21},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("embeddable"), 22},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("data"), 23},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("ext"), 24},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("id"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("episode"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("title"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("series"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("season"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("artist"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("genre"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("album"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("isrc"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("producer"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("url"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("cat"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("prodq"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("context"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("contentrating"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("userrating"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("qagmediarating"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("keywords"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("livestream"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("sourcerelationship"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("len"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("language"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("embeddable"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("data"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("ext"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::Nefta.AdSdk.Data.Content value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value._id);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteInt32(value._episode);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value._title);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value._name);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteString(value._season);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteString(value._creditedArtist);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteString(value._genre);
            writer.WriteRaw(this.____stringByteKeys[7]);
            writer.WriteString(value._album);
            writer.WriteRaw(this.____stringByteKeys[8]);
            writer.WriteString(value._recordingCode);
            writer.WriteRaw(this.____stringByteKeys[9]);
            writer.WriteString(value._producer);
            writer.WriteRaw(this.____stringByteKeys[10]);
            writer.WriteString(value._url);
            writer.WriteRaw(this.____stringByteKeys[11]);
            formatterResolver.GetFormatterWithVerify<string[]>().Serialize(ref writer, value._producerCategories, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[12]);
            writer.WriteInt32(value._productionQuality);
            writer.WriteRaw(this.____stringByteKeys[13]);
            writer.WriteInt32(value._type);
            writer.WriteRaw(this.____stringByteKeys[14]);
            writer.WriteString(value._contentRating);
            writer.WriteRaw(this.____stringByteKeys[15]);
            writer.WriteString(value._userRating);
            writer.WriteRaw(this.____stringByteKeys[16]);
            writer.WriteString(value._mediaRating);
            writer.WriteRaw(this.____stringByteKeys[17]);
            writer.WriteString(value._keywords);
            writer.WriteRaw(this.____stringByteKeys[18]);
            writer.WriteInt32(value._isLive);
            writer.WriteRaw(this.____stringByteKeys[19]);
            writer.WriteInt32(value._isDirect);
            writer.WriteRaw(this.____stringByteKeys[20]);
            writer.WriteInt32(value._lengthInSeconds);
            writer.WriteRaw(this.____stringByteKeys[21]);
            writer.WriteString(value._language);
            writer.WriteRaw(this.____stringByteKeys[22]);
            writer.WriteInt32(value._isEmbedded);
            writer.WriteRaw(this.____stringByteKeys[23]);
            formatterResolver.GetFormatterWithVerify<global::Nefta.AdSdk.Data.AdditionalData[]>().Serialize(ref writer, value._additionalData, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[24]);
            writer.WriteString(value._ext);
            
            writer.WriteEndObject();
        }

        public global::Nefta.AdSdk.Data.Content Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var ___id__ = default(string);
            var ___id__b__ = false;
            var ___episode__ = default(int);
            var ___episode__b__ = false;
            var ___title__ = default(string);
            var ___title__b__ = false;
            var ___name__ = default(string);
            var ___name__b__ = false;
            var ___season__ = default(string);
            var ___season__b__ = false;
            var ___creditedArtist__ = default(string);
            var ___creditedArtist__b__ = false;
            var ___genre__ = default(string);
            var ___genre__b__ = false;
            var ___album__ = default(string);
            var ___album__b__ = false;
            var ___recordingCode__ = default(string);
            var ___recordingCode__b__ = false;
            var ___producer__ = default(string);
            var ___producer__b__ = false;
            var ___url__ = default(string);
            var ___url__b__ = false;
            var ___producerCategories__ = default(string[]);
            var ___producerCategories__b__ = false;
            var ___productionQuality__ = default(int);
            var ___productionQuality__b__ = false;
            var ___type__ = default(int);
            var ___type__b__ = false;
            var ___contentRating__ = default(string);
            var ___contentRating__b__ = false;
            var ___userRating__ = default(string);
            var ___userRating__b__ = false;
            var ___mediaRating__ = default(string);
            var ___mediaRating__b__ = false;
            var ___keywords__ = default(string);
            var ___keywords__b__ = false;
            var ___isLive__ = default(int);
            var ___isLive__b__ = false;
            var ___isDirect__ = default(int);
            var ___isDirect__b__ = false;
            var ___lengthInSeconds__ = default(int);
            var ___lengthInSeconds__b__ = false;
            var ___language__ = default(string);
            var ___language__b__ = false;
            var ___isEmbedded__ = default(int);
            var ___isEmbedded__b__ = false;
            var ___additionalData__ = default(global::Nefta.AdSdk.Data.AdditionalData[]);
            var ___additionalData__b__ = false;
            var ___ext__ = default(string);
            var ___ext__b__ = false;

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
                        ___id__ = reader.ReadString();
                        ___id__b__ = true;
                        break;
                    case 1:
                        ___episode__ = reader.ReadInt32();
                        ___episode__b__ = true;
                        break;
                    case 2:
                        ___title__ = reader.ReadString();
                        ___title__b__ = true;
                        break;
                    case 3:
                        ___name__ = reader.ReadString();
                        ___name__b__ = true;
                        break;
                    case 4:
                        ___season__ = reader.ReadString();
                        ___season__b__ = true;
                        break;
                    case 5:
                        ___creditedArtist__ = reader.ReadString();
                        ___creditedArtist__b__ = true;
                        break;
                    case 6:
                        ___genre__ = reader.ReadString();
                        ___genre__b__ = true;
                        break;
                    case 7:
                        ___album__ = reader.ReadString();
                        ___album__b__ = true;
                        break;
                    case 8:
                        ___recordingCode__ = reader.ReadString();
                        ___recordingCode__b__ = true;
                        break;
                    case 9:
                        ___producer__ = reader.ReadString();
                        ___producer__b__ = true;
                        break;
                    case 10:
                        ___url__ = reader.ReadString();
                        ___url__b__ = true;
                        break;
                    case 11:
                        ___producerCategories__ = formatterResolver.GetFormatterWithVerify<string[]>().Deserialize(ref reader, formatterResolver);
                        ___producerCategories__b__ = true;
                        break;
                    case 12:
                        ___productionQuality__ = reader.ReadInt32();
                        ___productionQuality__b__ = true;
                        break;
                    case 13:
                        ___type__ = reader.ReadInt32();
                        ___type__b__ = true;
                        break;
                    case 14:
                        ___contentRating__ = reader.ReadString();
                        ___contentRating__b__ = true;
                        break;
                    case 15:
                        ___userRating__ = reader.ReadString();
                        ___userRating__b__ = true;
                        break;
                    case 16:
                        ___mediaRating__ = reader.ReadString();
                        ___mediaRating__b__ = true;
                        break;
                    case 17:
                        ___keywords__ = reader.ReadString();
                        ___keywords__b__ = true;
                        break;
                    case 18:
                        ___isLive__ = reader.ReadInt32();
                        ___isLive__b__ = true;
                        break;
                    case 19:
                        ___isDirect__ = reader.ReadInt32();
                        ___isDirect__b__ = true;
                        break;
                    case 20:
                        ___lengthInSeconds__ = reader.ReadInt32();
                        ___lengthInSeconds__b__ = true;
                        break;
                    case 21:
                        ___language__ = reader.ReadString();
                        ___language__b__ = true;
                        break;
                    case 22:
                        ___isEmbedded__ = reader.ReadInt32();
                        ___isEmbedded__b__ = true;
                        break;
                    case 23:
                        ___additionalData__ = formatterResolver.GetFormatterWithVerify<global::Nefta.AdSdk.Data.AdditionalData[]>().Deserialize(ref reader, formatterResolver);
                        ___additionalData__b__ = true;
                        break;
                    case 24:
                        ___ext__ = reader.ReadString();
                        ___ext__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Nefta.AdSdk.Data.Content();
            if(___id__b__) ____result._id = ___id__;
            if(___episode__b__) ____result._episode = ___episode__;
            if(___title__b__) ____result._title = ___title__;
            if(___name__b__) ____result._name = ___name__;
            if(___season__b__) ____result._season = ___season__;
            if(___creditedArtist__b__) ____result._creditedArtist = ___creditedArtist__;
            if(___genre__b__) ____result._genre = ___genre__;
            if(___album__b__) ____result._album = ___album__;
            if(___recordingCode__b__) ____result._recordingCode = ___recordingCode__;
            if(___producer__b__) ____result._producer = ___producer__;
            if(___url__b__) ____result._url = ___url__;
            if(___producerCategories__b__) ____result._producerCategories = ___producerCategories__;
            if(___productionQuality__b__) ____result._productionQuality = ___productionQuality__;
            if(___type__b__) ____result._type = ___type__;
            if(___contentRating__b__) ____result._contentRating = ___contentRating__;
            if(___userRating__b__) ____result._userRating = ___userRating__;
            if(___mediaRating__b__) ____result._mediaRating = ___mediaRating__;
            if(___keywords__b__) ____result._keywords = ___keywords__;
            if(___isLive__b__) ____result._isLive = ___isLive__;
            if(___isDirect__b__) ____result._isDirect = ___isDirect__;
            if(___lengthInSeconds__b__) ____result._lengthInSeconds = ___lengthInSeconds__;
            if(___language__b__) ____result._language = ___language__;
            if(___isEmbedded__b__) ____result._isEmbedded = ___isEmbedded__;
            if(___additionalData__b__) ____result._additionalData = ___additionalData__;
            if(___ext__b__) ____result._ext = ___ext__;

            return ____result;
        }
    }


    public sealed class ApplicationFormatter : global::Utf8Json.IJsonFormatter<global::Nefta.AdSdk.Data.Application>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public ApplicationFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("id"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("name"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("bundle"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("domain"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("storeurl"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("cat"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("sectioncat"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("pagecat"), 7},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("ver"), 8},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("privacypolicy"), 9},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("paid"), 10},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("publisher"), 11},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("content"), 12},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("keywords"), 13},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("ext"), 14},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("id"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("name"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("bundle"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("domain"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("storeurl"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("cat"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("sectioncat"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("pagecat"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("ver"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("privacypolicy"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("paid"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("publisher"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("content"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("keywords"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("ext"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::Nefta.AdSdk.Data.Application value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value._id);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value._name);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value._bundle);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value._domain);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteString(value._storeUrl);
            writer.WriteRaw(this.____stringByteKeys[5]);
            formatterResolver.GetFormatterWithVerify<string[]>().Serialize(ref writer, value._contentCategories, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[6]);
            formatterResolver.GetFormatterWithVerify<string[]>().Serialize(ref writer, value._sectionCategories, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[7]);
            formatterResolver.GetFormatterWithVerify<string[]>().Serialize(ref writer, value._pageCategories, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[8]);
            writer.WriteString(value._version);
            writer.WriteRaw(this.____stringByteKeys[9]);
            writer.WriteInt32(value._hasPrivacyPolicy);
            writer.WriteRaw(this.____stringByteKeys[10]);
            writer.WriteInt32(value._isPaid);
            writer.WriteRaw(this.____stringByteKeys[11]);
            formatterResolver.GetFormatterWithVerify<global::Nefta.AdSdk.Data.Publisher>().Serialize(ref writer, value._publisher, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[12]);
            formatterResolver.GetFormatterWithVerify<global::Nefta.AdSdk.Data.Content>().Serialize(ref writer, value._content, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[13]);
            writer.WriteString(value._keywords);
            writer.WriteRaw(this.____stringByteKeys[14]);
            writer.WriteString(value._ext);
            
            writer.WriteEndObject();
        }

        public global::Nefta.AdSdk.Data.Application Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var ___id__ = default(string);
            var ___id__b__ = false;
            var ___name__ = default(string);
            var ___name__b__ = false;
            var ___bundle__ = default(string);
            var ___bundle__b__ = false;
            var ___domain__ = default(string);
            var ___domain__b__ = false;
            var ___storeUrl__ = default(string);
            var ___storeUrl__b__ = false;
            var ___contentCategories__ = default(string[]);
            var ___contentCategories__b__ = false;
            var ___sectionCategories__ = default(string[]);
            var ___sectionCategories__b__ = false;
            var ___pageCategories__ = default(string[]);
            var ___pageCategories__b__ = false;
            var ___version__ = default(string);
            var ___version__b__ = false;
            var ___hasPrivacyPolicy__ = default(int);
            var ___hasPrivacyPolicy__b__ = false;
            var ___isPaid__ = default(int);
            var ___isPaid__b__ = false;
            var ___publisher__ = default(global::Nefta.AdSdk.Data.Publisher);
            var ___publisher__b__ = false;
            var ___content__ = default(global::Nefta.AdSdk.Data.Content);
            var ___content__b__ = false;
            var ___keywords__ = default(string);
            var ___keywords__b__ = false;
            var ___ext__ = default(string);
            var ___ext__b__ = false;

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
                        ___id__ = reader.ReadString();
                        ___id__b__ = true;
                        break;
                    case 1:
                        ___name__ = reader.ReadString();
                        ___name__b__ = true;
                        break;
                    case 2:
                        ___bundle__ = reader.ReadString();
                        ___bundle__b__ = true;
                        break;
                    case 3:
                        ___domain__ = reader.ReadString();
                        ___domain__b__ = true;
                        break;
                    case 4:
                        ___storeUrl__ = reader.ReadString();
                        ___storeUrl__b__ = true;
                        break;
                    case 5:
                        ___contentCategories__ = formatterResolver.GetFormatterWithVerify<string[]>().Deserialize(ref reader, formatterResolver);
                        ___contentCategories__b__ = true;
                        break;
                    case 6:
                        ___sectionCategories__ = formatterResolver.GetFormatterWithVerify<string[]>().Deserialize(ref reader, formatterResolver);
                        ___sectionCategories__b__ = true;
                        break;
                    case 7:
                        ___pageCategories__ = formatterResolver.GetFormatterWithVerify<string[]>().Deserialize(ref reader, formatterResolver);
                        ___pageCategories__b__ = true;
                        break;
                    case 8:
                        ___version__ = reader.ReadString();
                        ___version__b__ = true;
                        break;
                    case 9:
                        ___hasPrivacyPolicy__ = reader.ReadInt32();
                        ___hasPrivacyPolicy__b__ = true;
                        break;
                    case 10:
                        ___isPaid__ = reader.ReadInt32();
                        ___isPaid__b__ = true;
                        break;
                    case 11:
                        ___publisher__ = formatterResolver.GetFormatterWithVerify<global::Nefta.AdSdk.Data.Publisher>().Deserialize(ref reader, formatterResolver);
                        ___publisher__b__ = true;
                        break;
                    case 12:
                        ___content__ = formatterResolver.GetFormatterWithVerify<global::Nefta.AdSdk.Data.Content>().Deserialize(ref reader, formatterResolver);
                        ___content__b__ = true;
                        break;
                    case 13:
                        ___keywords__ = reader.ReadString();
                        ___keywords__b__ = true;
                        break;
                    case 14:
                        ___ext__ = reader.ReadString();
                        ___ext__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Nefta.AdSdk.Data.Application();
            if(___id__b__) ____result._id = ___id__;
            if(___name__b__) ____result._name = ___name__;
            if(___bundle__b__) ____result._bundle = ___bundle__;
            if(___domain__b__) ____result._domain = ___domain__;
            if(___storeUrl__b__) ____result._storeUrl = ___storeUrl__;
            if(___contentCategories__b__) ____result._contentCategories = ___contentCategories__;
            if(___sectionCategories__b__) ____result._sectionCategories = ___sectionCategories__;
            if(___pageCategories__b__) ____result._pageCategories = ___pageCategories__;
            if(___version__b__) ____result._version = ___version__;
            if(___hasPrivacyPolicy__b__) ____result._hasPrivacyPolicy = ___hasPrivacyPolicy__;
            if(___isPaid__b__) ____result._isPaid = ___isPaid__;
            if(___publisher__b__) ____result._publisher = ___publisher__;
            if(___content__b__) ____result._content = ___content__;
            if(___keywords__b__) ____result._keywords = ___keywords__;
            if(___ext__b__) ____result._ext = ___ext__;

            return ____result;
        }
    }


    public sealed class FormatFormatter : global::Utf8Json.IJsonFormatter<global::Nefta.AdSdk.Data.Format>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public FormatFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("w"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("h"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("wratio"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("hratio"), 3},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("w"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("h"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("wratio"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("hratio"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::Nefta.AdSdk.Data.Format value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteInt32(value._width);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteInt32(value._height);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteInt32(value._relativeWidth);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteInt32(value._relativeHeight);
            
            writer.WriteEndObject();
        }

        public global::Nefta.AdSdk.Data.Format Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var ___width__ = default(int);
            var ___width__b__ = false;
            var ___height__ = default(int);
            var ___height__b__ = false;
            var ___relativeWidth__ = default(int);
            var ___relativeWidth__b__ = false;
            var ___relativeHeight__ = default(int);
            var ___relativeHeight__b__ = false;

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
                        ___width__ = reader.ReadInt32();
                        ___width__b__ = true;
                        break;
                    case 1:
                        ___height__ = reader.ReadInt32();
                        ___height__b__ = true;
                        break;
                    case 2:
                        ___relativeWidth__ = reader.ReadInt32();
                        ___relativeWidth__b__ = true;
                        break;
                    case 3:
                        ___relativeHeight__ = reader.ReadInt32();
                        ___relativeHeight__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Nefta.AdSdk.Data.Format();
            if(___width__b__) ____result._width = ___width__;
            if(___height__b__) ____result._height = ___height__;
            if(___relativeWidth__b__) ____result._relativeWidth = ___relativeWidth__;
            if(___relativeHeight__b__) ____result._relativeHeight = ___relativeHeight__;

            return ____result;
        }
    }


    public sealed class BannerFormatter : global::Utf8Json.IJsonFormatter<global::Nefta.AdSdk.Data.Banner>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public BannerFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("format"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("w"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("h"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("btype"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("battr"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("pos"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("mimes"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("topframe"), 7},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("expdir"), 8},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("api"), 9},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("id"), 10},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("vcm"), 11},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("ext"), 12},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("format"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("w"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("h"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("btype"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("battr"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("pos"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("mimes"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("topframe"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("expdir"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("api"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("id"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("vcm"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("ext"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::Nefta.AdSdk.Data.Banner value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::Nefta.AdSdk.Data.Format[]>().Serialize(ref writer, value._format, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteInt32(value._width);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteInt32(value._height);
            writer.WriteRaw(this.____stringByteKeys[3]);
            formatterResolver.GetFormatterWithVerify<int[]>().Serialize(ref writer, value._blockedBannerTypes, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[4]);
            formatterResolver.GetFormatterWithVerify<int[]>().Serialize(ref writer, value._blockedCreativeAttributes, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteInt32(value._positionOnScreen);
            writer.WriteRaw(this.____stringByteKeys[6]);
            formatterResolver.GetFormatterWithVerify<string[]>().Serialize(ref writer, value._supportedMimeTypes, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[7]);
            writer.WriteInt32(value._isInTopFrame);
            writer.WriteRaw(this.____stringByteKeys[8]);
            formatterResolver.GetFormatterWithVerify<int[]>().Serialize(ref writer, value._expandDirections, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[9]);
            formatterResolver.GetFormatterWithVerify<int[]>().Serialize(ref writer, value._supportedApiFrameworks, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[10]);
            writer.WriteString(value._id);
            writer.WriteRaw(this.____stringByteKeys[11]);
            writer.WriteInt32(value._isEndCard);
            writer.WriteRaw(this.____stringByteKeys[12]);
            writer.WriteString(value._ext);
            
            writer.WriteEndObject();
        }

        public global::Nefta.AdSdk.Data.Banner Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var ___format__ = default(global::Nefta.AdSdk.Data.Format[]);
            var ___format__b__ = false;
            var ___width__ = default(int);
            var ___width__b__ = false;
            var ___height__ = default(int);
            var ___height__b__ = false;
            var ___blockedBannerTypes__ = default(int[]);
            var ___blockedBannerTypes__b__ = false;
            var ___blockedCreativeAttributes__ = default(int[]);
            var ___blockedCreativeAttributes__b__ = false;
            var ___positionOnScreen__ = default(int);
            var ___positionOnScreen__b__ = false;
            var ___supportedMimeTypes__ = default(string[]);
            var ___supportedMimeTypes__b__ = false;
            var ___isInTopFrame__ = default(int);
            var ___isInTopFrame__b__ = false;
            var ___expandDirections__ = default(int[]);
            var ___expandDirections__b__ = false;
            var ___supportedApiFrameworks__ = default(int[]);
            var ___supportedApiFrameworks__b__ = false;
            var ___id__ = default(string);
            var ___id__b__ = false;
            var ___isEndCard__ = default(int);
            var ___isEndCard__b__ = false;
            var ___ext__ = default(string);
            var ___ext__b__ = false;

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
                        ___format__ = formatterResolver.GetFormatterWithVerify<global::Nefta.AdSdk.Data.Format[]>().Deserialize(ref reader, formatterResolver);
                        ___format__b__ = true;
                        break;
                    case 1:
                        ___width__ = reader.ReadInt32();
                        ___width__b__ = true;
                        break;
                    case 2:
                        ___height__ = reader.ReadInt32();
                        ___height__b__ = true;
                        break;
                    case 3:
                        ___blockedBannerTypes__ = formatterResolver.GetFormatterWithVerify<int[]>().Deserialize(ref reader, formatterResolver);
                        ___blockedBannerTypes__b__ = true;
                        break;
                    case 4:
                        ___blockedCreativeAttributes__ = formatterResolver.GetFormatterWithVerify<int[]>().Deserialize(ref reader, formatterResolver);
                        ___blockedCreativeAttributes__b__ = true;
                        break;
                    case 5:
                        ___positionOnScreen__ = reader.ReadInt32();
                        ___positionOnScreen__b__ = true;
                        break;
                    case 6:
                        ___supportedMimeTypes__ = formatterResolver.GetFormatterWithVerify<string[]>().Deserialize(ref reader, formatterResolver);
                        ___supportedMimeTypes__b__ = true;
                        break;
                    case 7:
                        ___isInTopFrame__ = reader.ReadInt32();
                        ___isInTopFrame__b__ = true;
                        break;
                    case 8:
                        ___expandDirections__ = formatterResolver.GetFormatterWithVerify<int[]>().Deserialize(ref reader, formatterResolver);
                        ___expandDirections__b__ = true;
                        break;
                    case 9:
                        ___supportedApiFrameworks__ = formatterResolver.GetFormatterWithVerify<int[]>().Deserialize(ref reader, formatterResolver);
                        ___supportedApiFrameworks__b__ = true;
                        break;
                    case 10:
                        ___id__ = reader.ReadString();
                        ___id__b__ = true;
                        break;
                    case 11:
                        ___isEndCard__ = reader.ReadInt32();
                        ___isEndCard__b__ = true;
                        break;
                    case 12:
                        ___ext__ = reader.ReadString();
                        ___ext__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Nefta.AdSdk.Data.Banner();
            if(___format__b__) ____result._format = ___format__;
            if(___width__b__) ____result._width = ___width__;
            if(___height__b__) ____result._height = ___height__;
            if(___blockedBannerTypes__b__) ____result._blockedBannerTypes = ___blockedBannerTypes__;
            if(___blockedCreativeAttributes__b__) ____result._blockedCreativeAttributes = ___blockedCreativeAttributes__;
            if(___positionOnScreen__b__) ____result._positionOnScreen = ___positionOnScreen__;
            if(___supportedMimeTypes__b__) ____result._supportedMimeTypes = ___supportedMimeTypes__;
            if(___isInTopFrame__b__) ____result._isInTopFrame = ___isInTopFrame__;
            if(___expandDirections__b__) ____result._expandDirections = ___expandDirections__;
            if(___supportedApiFrameworks__b__) ____result._supportedApiFrameworks = ___supportedApiFrameworks__;
            if(___id__b__) ____result._id = ___id__;
            if(___isEndCard__b__) ____result._isEndCard = ___isEndCard__;
            if(___ext__b__) ____result._ext = ___ext__;

            return ____result;
        }
    }


    public sealed class BidExtNeftaFormatter : global::Utf8Json.IJsonFormatter<global::Nefta.AdSdk.Data.BidExtNefta>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public BidExtNeftaFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("tracking_click_url"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("redirect_click_url"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("tracking_click_url"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("redirect_click_url"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::Nefta.AdSdk.Data.BidExtNefta value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value._tracking_click_url);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value._redirect_click_url);
            
            writer.WriteEndObject();
        }

        public global::Nefta.AdSdk.Data.BidExtNefta Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var ___tracking_click_url__ = default(string);
            var ___tracking_click_url__b__ = false;
            var ___redirect_click_url__ = default(string);
            var ___redirect_click_url__b__ = false;

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
                        ___tracking_click_url__ = reader.ReadString();
                        ___tracking_click_url__b__ = true;
                        break;
                    case 1:
                        ___redirect_click_url__ = reader.ReadString();
                        ___redirect_click_url__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Nefta.AdSdk.Data.BidExtNefta();
            if(___tracking_click_url__b__) ____result._tracking_click_url = ___tracking_click_url__;
            if(___redirect_click_url__b__) ____result._redirect_click_url = ___redirect_click_url__;

            return ____result;
        }
    }


    public sealed class BidExtFormatter : global::Utf8Json.IJsonFormatter<global::Nefta.AdSdk.Data.BidExt>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public BidExtFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("nefta"), 0},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("nefta"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::Nefta.AdSdk.Data.BidExt value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::Nefta.AdSdk.Data.BidExtNefta>().Serialize(ref writer, value._nefta, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::Nefta.AdSdk.Data.BidExt Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var ___nefta__ = default(global::Nefta.AdSdk.Data.BidExtNefta);
            var ___nefta__b__ = false;

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
                        ___nefta__ = formatterResolver.GetFormatterWithVerify<global::Nefta.AdSdk.Data.BidExtNefta>().Deserialize(ref reader, formatterResolver);
                        ___nefta__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Nefta.AdSdk.Data.BidExt();
            if(___nefta__b__) ____result._nefta = ___nefta__;

            return ____result;
        }
    }


    public sealed class BidFormatter : global::Utf8Json.IJsonFormatter<global::Nefta.AdSdk.Data.Bid>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public BidFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("id"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("impid"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("price"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("nurl"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("burl"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("lurl"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("adm"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("adid"), 7},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("adomain"), 8},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("bundle"), 9},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("iurl"), 10},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("cid"), 11},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("crid"), 12},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("tactic"), 13},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("cat"), 14},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("attr"), 15},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("api"), 16},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("protocol"), 17},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("qagmediarating"), 18},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("language"), 19},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("dealid"), 20},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("w"), 21},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("h"), 22},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("wratio"), 23},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("hratio"), 24},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("exp"), 25},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("ext"), 26},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("id"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("impid"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("price"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("nurl"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("burl"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("lurl"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("adm"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("adid"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("adomain"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("bundle"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("iurl"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("cid"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("crid"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("tactic"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("cat"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("attr"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("api"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("protocol"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("qagmediarating"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("language"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("dealid"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("w"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("h"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("wratio"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("hratio"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("exp"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("ext"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::Nefta.AdSdk.Data.Bid value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value._id);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value._impressionId);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteSingle(value._price);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value._winNoticeUrl);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteString(value._billingNoticeUrl);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteString(value._lostNoticeUrl);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteString(value._adMarkup);
            writer.WriteRaw(this.____stringByteKeys[7]);
            writer.WriteString(value._preloadedAdIdToServe);
            writer.WriteRaw(this.____stringByteKeys[8]);
            formatterResolver.GetFormatterWithVerify<global::System.Collections.Generic.List<string>>().Serialize(ref writer, value._advertiserDomain, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[9]);
            writer.WriteString(value._bundle);
            writer.WriteRaw(this.____stringByteKeys[10]);
            writer.WriteString(value._url);
            writer.WriteRaw(this.____stringByteKeys[11]);
            writer.WriteString(value._campaignId);
            writer.WriteRaw(this.____stringByteKeys[12]);
            writer.WriteString(value._creativeQualityCheckId);
            writer.WriteRaw(this.____stringByteKeys[13]);
            writer.WriteString(value._tactic);
            writer.WriteRaw(this.____stringByteKeys[14]);
            formatterResolver.GetFormatterWithVerify<string[]>().Serialize(ref writer, value._categories, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[15]);
            formatterResolver.GetFormatterWithVerify<int[]>().Serialize(ref writer, value._attributes, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[16]);
            writer.WriteInt32(value._requiredApi);
            writer.WriteRaw(this.____stringByteKeys[17]);
            writer.WriteInt32(value._videoProtocol);
            writer.WriteRaw(this.____stringByteKeys[18]);
            writer.WriteInt32(value._mediaRating);
            writer.WriteRaw(this.____stringByteKeys[19]);
            writer.WriteString(value._language);
            writer.WriteRaw(this.____stringByteKeys[20]);
            writer.WriteString(value._dealId);
            writer.WriteRaw(this.____stringByteKeys[21]);
            writer.WriteInt32(value._width);
            writer.WriteRaw(this.____stringByteKeys[22]);
            writer.WriteInt32(value._height);
            writer.WriteRaw(this.____stringByteKeys[23]);
            writer.WriteInt32(value._relativeWidth);
            writer.WriteRaw(this.____stringByteKeys[24]);
            writer.WriteInt32(value._relativeHeight);
            writer.WriteRaw(this.____stringByteKeys[25]);
            writer.WriteInt32(value._suggestedDelayInSecondsFromAuctionToImpression);
            writer.WriteRaw(this.____stringByteKeys[26]);
            formatterResolver.GetFormatterWithVerify<global::Nefta.AdSdk.Data.BidExt>().Serialize(ref writer, value._ext, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::Nefta.AdSdk.Data.Bid Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var ___id__ = default(string);
            var ___id__b__ = false;
            var ___impressionId__ = default(string);
            var ___impressionId__b__ = false;
            var ___price__ = default(float);
            var ___price__b__ = false;
            var ___winNoticeUrl__ = default(string);
            var ___winNoticeUrl__b__ = false;
            var ___billingNoticeUrl__ = default(string);
            var ___billingNoticeUrl__b__ = false;
            var ___lostNoticeUrl__ = default(string);
            var ___lostNoticeUrl__b__ = false;
            var ___adMarkup__ = default(string);
            var ___adMarkup__b__ = false;
            var ___preloadedAdIdToServe__ = default(string);
            var ___preloadedAdIdToServe__b__ = false;
            var ___advertiserDomain__ = default(global::System.Collections.Generic.List<string>);
            var ___advertiserDomain__b__ = false;
            var ___bundle__ = default(string);
            var ___bundle__b__ = false;
            var ___url__ = default(string);
            var ___url__b__ = false;
            var ___campaignId__ = default(string);
            var ___campaignId__b__ = false;
            var ___creativeQualityCheckId__ = default(string);
            var ___creativeQualityCheckId__b__ = false;
            var ___tactic__ = default(string);
            var ___tactic__b__ = false;
            var ___categories__ = default(string[]);
            var ___categories__b__ = false;
            var ___attributes__ = default(int[]);
            var ___attributes__b__ = false;
            var ___requiredApi__ = default(int);
            var ___requiredApi__b__ = false;
            var ___videoProtocol__ = default(int);
            var ___videoProtocol__b__ = false;
            var ___mediaRating__ = default(int);
            var ___mediaRating__b__ = false;
            var ___language__ = default(string);
            var ___language__b__ = false;
            var ___dealId__ = default(string);
            var ___dealId__b__ = false;
            var ___width__ = default(int);
            var ___width__b__ = false;
            var ___height__ = default(int);
            var ___height__b__ = false;
            var ___relativeWidth__ = default(int);
            var ___relativeWidth__b__ = false;
            var ___relativeHeight__ = default(int);
            var ___relativeHeight__b__ = false;
            var ___suggestedDelayInSecondsFromAuctionToImpression__ = default(int);
            var ___suggestedDelayInSecondsFromAuctionToImpression__b__ = false;
            var ___ext__ = default(global::Nefta.AdSdk.Data.BidExt);
            var ___ext__b__ = false;

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
                        ___id__ = reader.ReadString();
                        ___id__b__ = true;
                        break;
                    case 1:
                        ___impressionId__ = reader.ReadString();
                        ___impressionId__b__ = true;
                        break;
                    case 2:
                        ___price__ = reader.ReadSingle();
                        ___price__b__ = true;
                        break;
                    case 3:
                        ___winNoticeUrl__ = reader.ReadString();
                        ___winNoticeUrl__b__ = true;
                        break;
                    case 4:
                        ___billingNoticeUrl__ = reader.ReadString();
                        ___billingNoticeUrl__b__ = true;
                        break;
                    case 5:
                        ___lostNoticeUrl__ = reader.ReadString();
                        ___lostNoticeUrl__b__ = true;
                        break;
                    case 6:
                        ___adMarkup__ = reader.ReadString();
                        ___adMarkup__b__ = true;
                        break;
                    case 7:
                        ___preloadedAdIdToServe__ = reader.ReadString();
                        ___preloadedAdIdToServe__b__ = true;
                        break;
                    case 8:
                        ___advertiserDomain__ = formatterResolver.GetFormatterWithVerify<global::System.Collections.Generic.List<string>>().Deserialize(ref reader, formatterResolver);
                        ___advertiserDomain__b__ = true;
                        break;
                    case 9:
                        ___bundle__ = reader.ReadString();
                        ___bundle__b__ = true;
                        break;
                    case 10:
                        ___url__ = reader.ReadString();
                        ___url__b__ = true;
                        break;
                    case 11:
                        ___campaignId__ = reader.ReadString();
                        ___campaignId__b__ = true;
                        break;
                    case 12:
                        ___creativeQualityCheckId__ = reader.ReadString();
                        ___creativeQualityCheckId__b__ = true;
                        break;
                    case 13:
                        ___tactic__ = reader.ReadString();
                        ___tactic__b__ = true;
                        break;
                    case 14:
                        ___categories__ = formatterResolver.GetFormatterWithVerify<string[]>().Deserialize(ref reader, formatterResolver);
                        ___categories__b__ = true;
                        break;
                    case 15:
                        ___attributes__ = formatterResolver.GetFormatterWithVerify<int[]>().Deserialize(ref reader, formatterResolver);
                        ___attributes__b__ = true;
                        break;
                    case 16:
                        ___requiredApi__ = reader.ReadInt32();
                        ___requiredApi__b__ = true;
                        break;
                    case 17:
                        ___videoProtocol__ = reader.ReadInt32();
                        ___videoProtocol__b__ = true;
                        break;
                    case 18:
                        ___mediaRating__ = reader.ReadInt32();
                        ___mediaRating__b__ = true;
                        break;
                    case 19:
                        ___language__ = reader.ReadString();
                        ___language__b__ = true;
                        break;
                    case 20:
                        ___dealId__ = reader.ReadString();
                        ___dealId__b__ = true;
                        break;
                    case 21:
                        ___width__ = reader.ReadInt32();
                        ___width__b__ = true;
                        break;
                    case 22:
                        ___height__ = reader.ReadInt32();
                        ___height__b__ = true;
                        break;
                    case 23:
                        ___relativeWidth__ = reader.ReadInt32();
                        ___relativeWidth__b__ = true;
                        break;
                    case 24:
                        ___relativeHeight__ = reader.ReadInt32();
                        ___relativeHeight__b__ = true;
                        break;
                    case 25:
                        ___suggestedDelayInSecondsFromAuctionToImpression__ = reader.ReadInt32();
                        ___suggestedDelayInSecondsFromAuctionToImpression__b__ = true;
                        break;
                    case 26:
                        ___ext__ = formatterResolver.GetFormatterWithVerify<global::Nefta.AdSdk.Data.BidExt>().Deserialize(ref reader, formatterResolver);
                        ___ext__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Nefta.AdSdk.Data.Bid();
            if(___id__b__) ____result._id = ___id__;
            if(___impressionId__b__) ____result._impressionId = ___impressionId__;
            if(___price__b__) ____result._price = ___price__;
            if(___winNoticeUrl__b__) ____result._winNoticeUrl = ___winNoticeUrl__;
            if(___billingNoticeUrl__b__) ____result._billingNoticeUrl = ___billingNoticeUrl__;
            if(___lostNoticeUrl__b__) ____result._lostNoticeUrl = ___lostNoticeUrl__;
            if(___adMarkup__b__) ____result._adMarkup = ___adMarkup__;
            if(___preloadedAdIdToServe__b__) ____result._preloadedAdIdToServe = ___preloadedAdIdToServe__;
            if(___advertiserDomain__b__) ____result._advertiserDomain = ___advertiserDomain__;
            if(___bundle__b__) ____result._bundle = ___bundle__;
            if(___url__b__) ____result._url = ___url__;
            if(___campaignId__b__) ____result._campaignId = ___campaignId__;
            if(___creativeQualityCheckId__b__) ____result._creativeQualityCheckId = ___creativeQualityCheckId__;
            if(___tactic__b__) ____result._tactic = ___tactic__;
            if(___categories__b__) ____result._categories = ___categories__;
            if(___attributes__b__) ____result._attributes = ___attributes__;
            if(___requiredApi__b__) ____result._requiredApi = ___requiredApi__;
            if(___videoProtocol__b__) ____result._videoProtocol = ___videoProtocol__;
            if(___mediaRating__b__) ____result._mediaRating = ___mediaRating__;
            if(___language__b__) ____result._language = ___language__;
            if(___dealId__b__) ____result._dealId = ___dealId__;
            if(___width__b__) ____result._width = ___width__;
            if(___height__b__) ____result._height = ___height__;
            if(___relativeWidth__b__) ____result._relativeWidth = ___relativeWidth__;
            if(___relativeHeight__b__) ____result._relativeHeight = ___relativeHeight__;
            if(___suggestedDelayInSecondsFromAuctionToImpression__b__) ____result._suggestedDelayInSecondsFromAuctionToImpression = ___suggestedDelayInSecondsFromAuctionToImpression__;
            if(___ext__b__) ____result._ext = ___ext__;

            return ____result;
        }
    }


    public sealed class MetricFormatter : global::Utf8Json.IJsonFormatter<global::Nefta.AdSdk.Data.Metric>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public MetricFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("type"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("value"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("vendor"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("ext"), 3},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("type"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("value"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("vendor"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("ext"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::Nefta.AdSdk.Data.Metric value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value._type);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteSingle(value._value);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteSingle(value._vendor);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value._ext);
            
            writer.WriteEndObject();
        }

        public global::Nefta.AdSdk.Data.Metric Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var ___type__ = default(string);
            var ___type__b__ = false;
            var ___value__ = default(float);
            var ___value__b__ = false;
            var ___vendor__ = default(float);
            var ___vendor__b__ = false;
            var ___ext__ = default(string);
            var ___ext__b__ = false;

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
                        ___type__ = reader.ReadString();
                        ___type__b__ = true;
                        break;
                    case 1:
                        ___value__ = reader.ReadSingle();
                        ___value__b__ = true;
                        break;
                    case 2:
                        ___vendor__ = reader.ReadSingle();
                        ___vendor__b__ = true;
                        break;
                    case 3:
                        ___ext__ = reader.ReadString();
                        ___ext__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Nefta.AdSdk.Data.Metric();
            if(___type__b__) ____result._type = ___type__;
            if(___value__b__) ____result._value = ___value__;
            if(___vendor__b__) ____result._vendor = ___vendor__;
            if(___ext__b__) ____result._ext = ___ext__;

            return ____result;
        }
    }


    public sealed class VideoFormatter : global::Utf8Json.IJsonFormatter<global::Nefta.AdSdk.Data.Video>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public VideoFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("mimes"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("minduration"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("maxduration"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("protocols"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("w"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("h"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("startdelay"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("placement"), 7},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("linearity"), 8},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("skip"), 9},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("skipmin"), 10},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("sequence"), 11},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("battr"), 12},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("maxextend"), 13},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("minbitrate"), 14},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("maxbitrate"), 15},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("boxingallowed"), 16},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("playbackmethod"), 17},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("playbackend"), 18},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("delivery"), 19},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("pos"), 20},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("companionad"), 21},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("api"), 22},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("companiontype"), 23},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("ext"), 24},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("mimes"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("minduration"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("maxduration"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("protocols"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("w"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("h"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("startdelay"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("placement"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("linearity"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("skip"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("skipmin"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("sequence"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("battr"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("maxextend"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("minbitrate"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("maxbitrate"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("boxingallowed"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("playbackmethod"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("playbackend"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("delivery"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("pos"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("companionad"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("api"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("companiontype"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("ext"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::Nefta.AdSdk.Data.Video value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<string[]>().Serialize(ref writer, value._supportedMimeTypes, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteInt32(value._minimumDurationInSeconds);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteInt32(value._maximumDurationInSeconds);
            writer.WriteRaw(this.____stringByteKeys[3]);
            formatterResolver.GetFormatterWithVerify<int[]>().Serialize(ref writer, value._supportedProtocols, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteInt32(value._width);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteInt32(value._height);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteInt32(value._preRollStartDelay);
            writer.WriteRaw(this.____stringByteKeys[7]);
            writer.WriteInt32(value._placementType);
            writer.WriteRaw(this.____stringByteKeys[8]);
            writer.WriteInt32(value._mustBeLinear);
            writer.WriteRaw(this.____stringByteKeys[9]);
            writer.WriteInt32(value._isSkippable);
            writer.WriteRaw(this.____stringByteKeys[10]);
            writer.WriteInt32(value._canSkipAfter);
            writer.WriteRaw(this.____stringByteKeys[11]);
            writer.WriteInt32(value._orderInSequence);
            writer.WriteRaw(this.____stringByteKeys[12]);
            formatterResolver.GetFormatterWithVerify<int[]>().Serialize(ref writer, value._blockedCreativeAttributes, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[13]);
            writer.WriteInt32(value._maxEimumExtendDuration);
            writer.WriteRaw(this.____stringByteKeys[14]);
            writer.WriteInt32(value._minimumBitRateInKbps);
            writer.WriteRaw(this.____stringByteKeys[15]);
            writer.WriteInt32(value._maximumBitRateInKbps);
            writer.WriteRaw(this.____stringByteKeys[16]);
            writer.WriteInt32(value._isLetterBoxingAllowed);
            writer.WriteRaw(this.____stringByteKeys[17]);
            formatterResolver.GetFormatterWithVerify<int[]>().Serialize(ref writer, value._playBackMethods, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[18]);
            writer.WriteInt32(value._playbeckEndEvent);
            writer.WriteRaw(this.____stringByteKeys[19]);
            formatterResolver.GetFormatterWithVerify<int[]>().Serialize(ref writer, value._supportedDeliveryMethods, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[20]);
            writer.WriteInt32(value._adPositionOnScreen);
            writer.WriteRaw(this.____stringByteKeys[21]);
            formatterResolver.GetFormatterWithVerify<global::Nefta.AdSdk.Data.Banner[]>().Serialize(ref writer, value._companionBanners, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[22]);
            formatterResolver.GetFormatterWithVerify<int[]>().Serialize(ref writer, value._supportedApiFrameworks, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[23]);
            formatterResolver.GetFormatterWithVerify<int[]>().Serialize(ref writer, value._supportedVastCompanionAdTypes, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[24]);
            writer.WriteString(value._ext);
            
            writer.WriteEndObject();
        }

        public global::Nefta.AdSdk.Data.Video Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var ___supportedMimeTypes__ = default(string[]);
            var ___supportedMimeTypes__b__ = false;
            var ___minimumDurationInSeconds__ = default(int);
            var ___minimumDurationInSeconds__b__ = false;
            var ___maximumDurationInSeconds__ = default(int);
            var ___maximumDurationInSeconds__b__ = false;
            var ___supportedProtocols__ = default(int[]);
            var ___supportedProtocols__b__ = false;
            var ___width__ = default(int);
            var ___width__b__ = false;
            var ___height__ = default(int);
            var ___height__b__ = false;
            var ___preRollStartDelay__ = default(int);
            var ___preRollStartDelay__b__ = false;
            var ___placementType__ = default(int);
            var ___placementType__b__ = false;
            var ___mustBeLinear__ = default(int);
            var ___mustBeLinear__b__ = false;
            var ___isSkippable__ = default(int);
            var ___isSkippable__b__ = false;
            var ___canSkipAfter__ = default(int);
            var ___canSkipAfter__b__ = false;
            var ___orderInSequence__ = default(int);
            var ___orderInSequence__b__ = false;
            var ___blockedCreativeAttributes__ = default(int[]);
            var ___blockedCreativeAttributes__b__ = false;
            var ___maxEimumExtendDuration__ = default(int);
            var ___maxEimumExtendDuration__b__ = false;
            var ___minimumBitRateInKbps__ = default(int);
            var ___minimumBitRateInKbps__b__ = false;
            var ___maximumBitRateInKbps__ = default(int);
            var ___maximumBitRateInKbps__b__ = false;
            var ___isLetterBoxingAllowed__ = default(int);
            var ___isLetterBoxingAllowed__b__ = false;
            var ___playBackMethods__ = default(int[]);
            var ___playBackMethods__b__ = false;
            var ___playbeckEndEvent__ = default(int);
            var ___playbeckEndEvent__b__ = false;
            var ___supportedDeliveryMethods__ = default(int[]);
            var ___supportedDeliveryMethods__b__ = false;
            var ___adPositionOnScreen__ = default(int);
            var ___adPositionOnScreen__b__ = false;
            var ___companionBanners__ = default(global::Nefta.AdSdk.Data.Banner[]);
            var ___companionBanners__b__ = false;
            var ___supportedApiFrameworks__ = default(int[]);
            var ___supportedApiFrameworks__b__ = false;
            var ___supportedVastCompanionAdTypes__ = default(int[]);
            var ___supportedVastCompanionAdTypes__b__ = false;
            var ___ext__ = default(string);
            var ___ext__b__ = false;

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
                        ___supportedMimeTypes__ = formatterResolver.GetFormatterWithVerify<string[]>().Deserialize(ref reader, formatterResolver);
                        ___supportedMimeTypes__b__ = true;
                        break;
                    case 1:
                        ___minimumDurationInSeconds__ = reader.ReadInt32();
                        ___minimumDurationInSeconds__b__ = true;
                        break;
                    case 2:
                        ___maximumDurationInSeconds__ = reader.ReadInt32();
                        ___maximumDurationInSeconds__b__ = true;
                        break;
                    case 3:
                        ___supportedProtocols__ = formatterResolver.GetFormatterWithVerify<int[]>().Deserialize(ref reader, formatterResolver);
                        ___supportedProtocols__b__ = true;
                        break;
                    case 4:
                        ___width__ = reader.ReadInt32();
                        ___width__b__ = true;
                        break;
                    case 5:
                        ___height__ = reader.ReadInt32();
                        ___height__b__ = true;
                        break;
                    case 6:
                        ___preRollStartDelay__ = reader.ReadInt32();
                        ___preRollStartDelay__b__ = true;
                        break;
                    case 7:
                        ___placementType__ = reader.ReadInt32();
                        ___placementType__b__ = true;
                        break;
                    case 8:
                        ___mustBeLinear__ = reader.ReadInt32();
                        ___mustBeLinear__b__ = true;
                        break;
                    case 9:
                        ___isSkippable__ = reader.ReadInt32();
                        ___isSkippable__b__ = true;
                        break;
                    case 10:
                        ___canSkipAfter__ = reader.ReadInt32();
                        ___canSkipAfter__b__ = true;
                        break;
                    case 11:
                        ___orderInSequence__ = reader.ReadInt32();
                        ___orderInSequence__b__ = true;
                        break;
                    case 12:
                        ___blockedCreativeAttributes__ = formatterResolver.GetFormatterWithVerify<int[]>().Deserialize(ref reader, formatterResolver);
                        ___blockedCreativeAttributes__b__ = true;
                        break;
                    case 13:
                        ___maxEimumExtendDuration__ = reader.ReadInt32();
                        ___maxEimumExtendDuration__b__ = true;
                        break;
                    case 14:
                        ___minimumBitRateInKbps__ = reader.ReadInt32();
                        ___minimumBitRateInKbps__b__ = true;
                        break;
                    case 15:
                        ___maximumBitRateInKbps__ = reader.ReadInt32();
                        ___maximumBitRateInKbps__b__ = true;
                        break;
                    case 16:
                        ___isLetterBoxingAllowed__ = reader.ReadInt32();
                        ___isLetterBoxingAllowed__b__ = true;
                        break;
                    case 17:
                        ___playBackMethods__ = formatterResolver.GetFormatterWithVerify<int[]>().Deserialize(ref reader, formatterResolver);
                        ___playBackMethods__b__ = true;
                        break;
                    case 18:
                        ___playbeckEndEvent__ = reader.ReadInt32();
                        ___playbeckEndEvent__b__ = true;
                        break;
                    case 19:
                        ___supportedDeliveryMethods__ = formatterResolver.GetFormatterWithVerify<int[]>().Deserialize(ref reader, formatterResolver);
                        ___supportedDeliveryMethods__b__ = true;
                        break;
                    case 20:
                        ___adPositionOnScreen__ = reader.ReadInt32();
                        ___adPositionOnScreen__b__ = true;
                        break;
                    case 21:
                        ___companionBanners__ = formatterResolver.GetFormatterWithVerify<global::Nefta.AdSdk.Data.Banner[]>().Deserialize(ref reader, formatterResolver);
                        ___companionBanners__b__ = true;
                        break;
                    case 22:
                        ___supportedApiFrameworks__ = formatterResolver.GetFormatterWithVerify<int[]>().Deserialize(ref reader, formatterResolver);
                        ___supportedApiFrameworks__b__ = true;
                        break;
                    case 23:
                        ___supportedVastCompanionAdTypes__ = formatterResolver.GetFormatterWithVerify<int[]>().Deserialize(ref reader, formatterResolver);
                        ___supportedVastCompanionAdTypes__b__ = true;
                        break;
                    case 24:
                        ___ext__ = reader.ReadString();
                        ___ext__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Nefta.AdSdk.Data.Video();
            if(___supportedMimeTypes__b__) ____result._supportedMimeTypes = ___supportedMimeTypes__;
            if(___minimumDurationInSeconds__b__) ____result._minimumDurationInSeconds = ___minimumDurationInSeconds__;
            if(___maximumDurationInSeconds__b__) ____result._maximumDurationInSeconds = ___maximumDurationInSeconds__;
            if(___supportedProtocols__b__) ____result._supportedProtocols = ___supportedProtocols__;
            if(___width__b__) ____result._width = ___width__;
            if(___height__b__) ____result._height = ___height__;
            if(___preRollStartDelay__b__) ____result._preRollStartDelay = ___preRollStartDelay__;
            if(___placementType__b__) ____result._placementType = ___placementType__;
            if(___mustBeLinear__b__) ____result._mustBeLinear = ___mustBeLinear__;
            if(___isSkippable__b__) ____result._isSkippable = ___isSkippable__;
            if(___canSkipAfter__b__) ____result._canSkipAfter = ___canSkipAfter__;
            if(___orderInSequence__b__) ____result._orderInSequence = ___orderInSequence__;
            if(___blockedCreativeAttributes__b__) ____result._blockedCreativeAttributes = ___blockedCreativeAttributes__;
            if(___maxEimumExtendDuration__b__) ____result._maxEimumExtendDuration = ___maxEimumExtendDuration__;
            if(___minimumBitRateInKbps__b__) ____result._minimumBitRateInKbps = ___minimumBitRateInKbps__;
            if(___maximumBitRateInKbps__b__) ____result._maximumBitRateInKbps = ___maximumBitRateInKbps__;
            if(___isLetterBoxingAllowed__b__) ____result._isLetterBoxingAllowed = ___isLetterBoxingAllowed__;
            if(___playBackMethods__b__) ____result._playBackMethods = ___playBackMethods__;
            if(___playbeckEndEvent__b__) ____result._playbeckEndEvent = ___playbeckEndEvent__;
            if(___supportedDeliveryMethods__b__) ____result._supportedDeliveryMethods = ___supportedDeliveryMethods__;
            if(___adPositionOnScreen__b__) ____result._adPositionOnScreen = ___adPositionOnScreen__;
            if(___companionBanners__b__) ____result._companionBanners = ___companionBanners__;
            if(___supportedApiFrameworks__b__) ____result._supportedApiFrameworks = ___supportedApiFrameworks__;
            if(___supportedVastCompanionAdTypes__b__) ____result._supportedVastCompanionAdTypes = ___supportedVastCompanionAdTypes__;
            if(___ext__b__) ____result._ext = ___ext__;

            return ____result;
        }
    }


    public sealed class ImpressionFormatter : global::Utf8Json.IJsonFormatter<global::Nefta.AdSdk.Data.Impression>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public ImpressionFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("id"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("metric"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("banner"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("video"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("displaymanager"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("displaymanagerver"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("instl"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("tagid"), 7},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("bidfloor"), 8},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("bidfloorcur"), 9},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("clickbrowser"), 10},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("secure"), 11},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("iframebuster"), 12},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("exp"), 13},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("ext"), 14},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("id"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("metric"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("banner"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("video"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("displaymanager"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("displaymanagerver"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("instl"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("tagid"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("bidfloor"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("bidfloorcur"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("clickbrowser"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("secure"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("iframebuster"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("exp"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("ext"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::Nefta.AdSdk.Data.Impression value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value._id);
            writer.WriteRaw(this.____stringByteKeys[1]);
            formatterResolver.GetFormatterWithVerify<global::Nefta.AdSdk.Data.Metric[]>().Serialize(ref writer, value._metrics, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[2]);
            formatterResolver.GetFormatterWithVerify<global::Nefta.AdSdk.Data.Banner>().Serialize(ref writer, value._banner, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[3]);
            formatterResolver.GetFormatterWithVerify<global::Nefta.AdSdk.Data.Video>().Serialize(ref writer, value._video, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteString(value._renderingManager);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteString(value._renderingManagerVersion);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteInt32(value._isInterstitialOrFullScreen);
            writer.WriteRaw(this.____stringByteKeys[7]);
            writer.WriteString(value._tagId);
            writer.WriteRaw(this.____stringByteKeys[8]);
            writer.WriteSingle(value._bidFloor);
            writer.WriteRaw(this.____stringByteKeys[9]);
            writer.WriteString(value._bidFloorCurrency);
            writer.WriteRaw(this.____stringByteKeys[10]);
            writer.WriteInt32(value._isNativeBrowser);
            writer.WriteRaw(this.____stringByteKeys[11]);
            writer.WriteInt32(value._isSecureImpressionUrlRequired);
            writer.WriteRaw(this.____stringByteKeys[12]);
            formatterResolver.GetFormatterWithVerify<string[]>().Serialize(ref writer, value._supportedFrameBusters, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[13]);
            writer.WriteInt32(value._suggestedDelayFromAuctionToImpression);
            writer.WriteRaw(this.____stringByteKeys[14]);
            writer.WriteString(value._ext);
            
            writer.WriteEndObject();
        }

        public global::Nefta.AdSdk.Data.Impression Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var ___id__ = default(string);
            var ___id__b__ = false;
            var ___metrics__ = default(global::Nefta.AdSdk.Data.Metric[]);
            var ___metrics__b__ = false;
            var ___banner__ = default(global::Nefta.AdSdk.Data.Banner);
            var ___banner__b__ = false;
            var ___video__ = default(global::Nefta.AdSdk.Data.Video);
            var ___video__b__ = false;
            var ___renderingManager__ = default(string);
            var ___renderingManager__b__ = false;
            var ___renderingManagerVersion__ = default(string);
            var ___renderingManagerVersion__b__ = false;
            var ___isInterstitialOrFullScreen__ = default(int);
            var ___isInterstitialOrFullScreen__b__ = false;
            var ___tagId__ = default(string);
            var ___tagId__b__ = false;
            var ___bidFloor__ = default(float);
            var ___bidFloor__b__ = false;
            var ___bidFloorCurrency__ = default(string);
            var ___bidFloorCurrency__b__ = false;
            var ___isNativeBrowser__ = default(int);
            var ___isNativeBrowser__b__ = false;
            var ___isSecureImpressionUrlRequired__ = default(int);
            var ___isSecureImpressionUrlRequired__b__ = false;
            var ___supportedFrameBusters__ = default(string[]);
            var ___supportedFrameBusters__b__ = false;
            var ___suggestedDelayFromAuctionToImpression__ = default(int);
            var ___suggestedDelayFromAuctionToImpression__b__ = false;
            var ___ext__ = default(string);
            var ___ext__b__ = false;

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
                        ___id__ = reader.ReadString();
                        ___id__b__ = true;
                        break;
                    case 1:
                        ___metrics__ = formatterResolver.GetFormatterWithVerify<global::Nefta.AdSdk.Data.Metric[]>().Deserialize(ref reader, formatterResolver);
                        ___metrics__b__ = true;
                        break;
                    case 2:
                        ___banner__ = formatterResolver.GetFormatterWithVerify<global::Nefta.AdSdk.Data.Banner>().Deserialize(ref reader, formatterResolver);
                        ___banner__b__ = true;
                        break;
                    case 3:
                        ___video__ = formatterResolver.GetFormatterWithVerify<global::Nefta.AdSdk.Data.Video>().Deserialize(ref reader, formatterResolver);
                        ___video__b__ = true;
                        break;
                    case 4:
                        ___renderingManager__ = reader.ReadString();
                        ___renderingManager__b__ = true;
                        break;
                    case 5:
                        ___renderingManagerVersion__ = reader.ReadString();
                        ___renderingManagerVersion__b__ = true;
                        break;
                    case 6:
                        ___isInterstitialOrFullScreen__ = reader.ReadInt32();
                        ___isInterstitialOrFullScreen__b__ = true;
                        break;
                    case 7:
                        ___tagId__ = reader.ReadString();
                        ___tagId__b__ = true;
                        break;
                    case 8:
                        ___bidFloor__ = reader.ReadSingle();
                        ___bidFloor__b__ = true;
                        break;
                    case 9:
                        ___bidFloorCurrency__ = reader.ReadString();
                        ___bidFloorCurrency__b__ = true;
                        break;
                    case 10:
                        ___isNativeBrowser__ = reader.ReadInt32();
                        ___isNativeBrowser__b__ = true;
                        break;
                    case 11:
                        ___isSecureImpressionUrlRequired__ = reader.ReadInt32();
                        ___isSecureImpressionUrlRequired__b__ = true;
                        break;
                    case 12:
                        ___supportedFrameBusters__ = formatterResolver.GetFormatterWithVerify<string[]>().Deserialize(ref reader, formatterResolver);
                        ___supportedFrameBusters__b__ = true;
                        break;
                    case 13:
                        ___suggestedDelayFromAuctionToImpression__ = reader.ReadInt32();
                        ___suggestedDelayFromAuctionToImpression__b__ = true;
                        break;
                    case 14:
                        ___ext__ = reader.ReadString();
                        ___ext__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Nefta.AdSdk.Data.Impression();
            if(___id__b__) ____result._id = ___id__;
            if(___metrics__b__) ____result._metrics = ___metrics__;
            if(___banner__b__) ____result._banner = ___banner__;
            if(___video__b__) ____result._video = ___video__;
            if(___renderingManager__b__) ____result._renderingManager = ___renderingManager__;
            if(___renderingManagerVersion__b__) ____result._renderingManagerVersion = ___renderingManagerVersion__;
            if(___isInterstitialOrFullScreen__b__) ____result._isInterstitialOrFullScreen = ___isInterstitialOrFullScreen__;
            if(___tagId__b__) ____result._tagId = ___tagId__;
            if(___bidFloor__b__) ____result._bidFloor = ___bidFloor__;
            if(___bidFloorCurrency__b__) ____result._bidFloorCurrency = ___bidFloorCurrency__;
            if(___isNativeBrowser__b__) ____result._isNativeBrowser = ___isNativeBrowser__;
            if(___isSecureImpressionUrlRequired__b__) ____result._isSecureImpressionUrlRequired = ___isSecureImpressionUrlRequired__;
            if(___supportedFrameBusters__b__) ____result._supportedFrameBusters = ___supportedFrameBusters__;
            if(___suggestedDelayFromAuctionToImpression__b__) ____result._suggestedDelayFromAuctionToImpression = ___suggestedDelayFromAuctionToImpression__;
            if(___ext__b__) ____result._ext = ___ext__;

            return ____result;
        }
    }


    public sealed class ConsentFormatter : global::Utf8Json.IJsonFormatter<global::Nefta.AdSdk.Data.Consent>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public ConsentFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("id"), 0},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("id"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::Nefta.AdSdk.Data.Consent value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value._id);
            
            writer.WriteEndObject();
        }

        public global::Nefta.AdSdk.Data.Consent Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var ___id__ = default(string);
            var ___id__b__ = false;

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
                        ___id__ = reader.ReadString();
                        ___id__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Nefta.AdSdk.Data.Consent();
            if(___id__b__) ____result._id = ___id__;

            return ____result;
        }
    }


    public sealed class SiteFormatter : global::Utf8Json.IJsonFormatter<global::Nefta.AdSdk.Data.Site>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public SiteFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("id"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("name"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("domain"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("cat"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("sectioncat"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("pagecat"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("page"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("ref"), 7},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("search"), 8},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("mobile"), 9},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("privacypolicy"), 10},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("publisher"), 11},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("consent"), 12},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("keywords"), 13},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("ext"), 14},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("id"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("name"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("domain"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("cat"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("sectioncat"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("pagecat"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("page"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("ref"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("search"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("mobile"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("privacypolicy"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("publisher"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("consent"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("keywords"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("ext"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::Nefta.AdSdk.Data.Site value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value._id);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value._name);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value._domain);
            writer.WriteRaw(this.____stringByteKeys[3]);
            formatterResolver.GetFormatterWithVerify<string[]>().Serialize(ref writer, value._contentCategories, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[4]);
            formatterResolver.GetFormatterWithVerify<string[]>().Serialize(ref writer, value._sectionCategories, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[5]);
            formatterResolver.GetFormatterWithVerify<string[]>().Serialize(ref writer, value._pageCategories, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteString(value._pageUrl);
            writer.WriteRaw(this.____stringByteKeys[7]);
            writer.WriteString(value._referrerUrl);
            writer.WriteRaw(this.____stringByteKeys[8]);
            writer.WriteString(value._referrerSearch);
            writer.WriteRaw(this.____stringByteKeys[9]);
            writer.WriteInt32(value._isOptimizedForMobile);
            writer.WriteRaw(this.____stringByteKeys[10]);
            writer.WriteInt32(value._hasPrivacyPolicy);
            writer.WriteRaw(this.____stringByteKeys[11]);
            formatterResolver.GetFormatterWithVerify<global::Nefta.AdSdk.Data.Publisher>().Serialize(ref writer, value._publisher, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[12]);
            formatterResolver.GetFormatterWithVerify<global::Nefta.AdSdk.Data.Consent>().Serialize(ref writer, value._consent, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[13]);
            formatterResolver.GetFormatterWithVerify<global::Nefta.AdSdk.Data.Publisher>().Serialize(ref writer, value._keywords, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[14]);
            writer.WriteString(value._ext);
            
            writer.WriteEndObject();
        }

        public global::Nefta.AdSdk.Data.Site Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var ___id__ = default(string);
            var ___id__b__ = false;
            var ___name__ = default(string);
            var ___name__b__ = false;
            var ___domain__ = default(string);
            var ___domain__b__ = false;
            var ___contentCategories__ = default(string[]);
            var ___contentCategories__b__ = false;
            var ___sectionCategories__ = default(string[]);
            var ___sectionCategories__b__ = false;
            var ___pageCategories__ = default(string[]);
            var ___pageCategories__b__ = false;
            var ___pageUrl__ = default(string);
            var ___pageUrl__b__ = false;
            var ___referrerUrl__ = default(string);
            var ___referrerUrl__b__ = false;
            var ___referrerSearch__ = default(string);
            var ___referrerSearch__b__ = false;
            var ___isOptimizedForMobile__ = default(int);
            var ___isOptimizedForMobile__b__ = false;
            var ___hasPrivacyPolicy__ = default(int);
            var ___hasPrivacyPolicy__b__ = false;
            var ___publisher__ = default(global::Nefta.AdSdk.Data.Publisher);
            var ___publisher__b__ = false;
            var ___consent__ = default(global::Nefta.AdSdk.Data.Consent);
            var ___consent__b__ = false;
            var ___keywords__ = default(global::Nefta.AdSdk.Data.Publisher);
            var ___keywords__b__ = false;
            var ___ext__ = default(string);
            var ___ext__b__ = false;

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
                        ___id__ = reader.ReadString();
                        ___id__b__ = true;
                        break;
                    case 1:
                        ___name__ = reader.ReadString();
                        ___name__b__ = true;
                        break;
                    case 2:
                        ___domain__ = reader.ReadString();
                        ___domain__b__ = true;
                        break;
                    case 3:
                        ___contentCategories__ = formatterResolver.GetFormatterWithVerify<string[]>().Deserialize(ref reader, formatterResolver);
                        ___contentCategories__b__ = true;
                        break;
                    case 4:
                        ___sectionCategories__ = formatterResolver.GetFormatterWithVerify<string[]>().Deserialize(ref reader, formatterResolver);
                        ___sectionCategories__b__ = true;
                        break;
                    case 5:
                        ___pageCategories__ = formatterResolver.GetFormatterWithVerify<string[]>().Deserialize(ref reader, formatterResolver);
                        ___pageCategories__b__ = true;
                        break;
                    case 6:
                        ___pageUrl__ = reader.ReadString();
                        ___pageUrl__b__ = true;
                        break;
                    case 7:
                        ___referrerUrl__ = reader.ReadString();
                        ___referrerUrl__b__ = true;
                        break;
                    case 8:
                        ___referrerSearch__ = reader.ReadString();
                        ___referrerSearch__b__ = true;
                        break;
                    case 9:
                        ___isOptimizedForMobile__ = reader.ReadInt32();
                        ___isOptimizedForMobile__b__ = true;
                        break;
                    case 10:
                        ___hasPrivacyPolicy__ = reader.ReadInt32();
                        ___hasPrivacyPolicy__b__ = true;
                        break;
                    case 11:
                        ___publisher__ = formatterResolver.GetFormatterWithVerify<global::Nefta.AdSdk.Data.Publisher>().Deserialize(ref reader, formatterResolver);
                        ___publisher__b__ = true;
                        break;
                    case 12:
                        ___consent__ = formatterResolver.GetFormatterWithVerify<global::Nefta.AdSdk.Data.Consent>().Deserialize(ref reader, formatterResolver);
                        ___consent__b__ = true;
                        break;
                    case 13:
                        ___keywords__ = formatterResolver.GetFormatterWithVerify<global::Nefta.AdSdk.Data.Publisher>().Deserialize(ref reader, formatterResolver);
                        ___keywords__b__ = true;
                        break;
                    case 14:
                        ___ext__ = reader.ReadString();
                        ___ext__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Nefta.AdSdk.Data.Site();
            if(___id__b__) ____result._id = ___id__;
            if(___name__b__) ____result._name = ___name__;
            if(___domain__b__) ____result._domain = ___domain__;
            if(___contentCategories__b__) ____result._contentCategories = ___contentCategories__;
            if(___sectionCategories__b__) ____result._sectionCategories = ___sectionCategories__;
            if(___pageCategories__b__) ____result._pageCategories = ___pageCategories__;
            if(___pageUrl__b__) ____result._pageUrl = ___pageUrl__;
            if(___referrerUrl__b__) ____result._referrerUrl = ___referrerUrl__;
            if(___referrerSearch__b__) ____result._referrerSearch = ___referrerSearch__;
            if(___isOptimizedForMobile__b__) ____result._isOptimizedForMobile = ___isOptimizedForMobile__;
            if(___hasPrivacyPolicy__b__) ____result._hasPrivacyPolicy = ___hasPrivacyPolicy__;
            if(___publisher__b__) ____result._publisher = ___publisher__;
            if(___consent__b__) ____result._consent = ___consent__;
            if(___keywords__b__) ____result._keywords = ___keywords__;
            if(___ext__b__) ____result._ext = ___ext__;

            return ____result;
        }
    }


    public sealed class GeoFormatter : global::Utf8Json.IJsonFormatter<global::Nefta.AdSdk.Data.Geo>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public GeoFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("lat"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("lon"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("type"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("accuracy"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("lastfix"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("ipservice"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("country"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("region"), 7},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("regionfips104"), 8},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("metro"), 9},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("city"), 10},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("zip"), 11},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("utcoffset"), 12},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("ext"), 13},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("lat"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("lon"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("type"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("accuracy"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("lastfix"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("ipservice"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("country"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("region"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("regionfips104"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("metro"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("city"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("zip"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("utcoffset"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("ext"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::Nefta.AdSdk.Data.Geo value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteSingle(value._latitude);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteSingle(value._longtitude);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteInt32(value._type);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteInt32(value._estimatedLocationAccuracyInMeters);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteInt32(value._numberOfSecondsSinceSync);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteInt32(value._provider);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteString(value._country);
            writer.WriteRaw(this.____stringByteKeys[7]);
            writer.WriteString(value._region);
            writer.WriteRaw(this.____stringByteKeys[8]);
            writer.WriteString(value._regionFips);
            writer.WriteRaw(this.____stringByteKeys[9]);
            writer.WriteString(value._metroCode);
            writer.WriteRaw(this.____stringByteKeys[10]);
            writer.WriteString(value._city);
            writer.WriteRaw(this.____stringByteKeys[11]);
            writer.WriteString(value._zip);
            writer.WriteRaw(this.____stringByteKeys[12]);
            writer.WriteString(value._utcOffset);
            writer.WriteRaw(this.____stringByteKeys[13]);
            writer.WriteString(value._ext);
            
            writer.WriteEndObject();
        }

        public global::Nefta.AdSdk.Data.Geo Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var ___latitude__ = default(float);
            var ___latitude__b__ = false;
            var ___longtitude__ = default(float);
            var ___longtitude__b__ = false;
            var ___type__ = default(int);
            var ___type__b__ = false;
            var ___estimatedLocationAccuracyInMeters__ = default(int);
            var ___estimatedLocationAccuracyInMeters__b__ = false;
            var ___numberOfSecondsSinceSync__ = default(int);
            var ___numberOfSecondsSinceSync__b__ = false;
            var ___provider__ = default(int);
            var ___provider__b__ = false;
            var ___country__ = default(string);
            var ___country__b__ = false;
            var ___region__ = default(string);
            var ___region__b__ = false;
            var ___regionFips__ = default(string);
            var ___regionFips__b__ = false;
            var ___metroCode__ = default(string);
            var ___metroCode__b__ = false;
            var ___city__ = default(string);
            var ___city__b__ = false;
            var ___zip__ = default(string);
            var ___zip__b__ = false;
            var ___utcOffset__ = default(string);
            var ___utcOffset__b__ = false;
            var ___ext__ = default(string);
            var ___ext__b__ = false;

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
                        ___latitude__ = reader.ReadSingle();
                        ___latitude__b__ = true;
                        break;
                    case 1:
                        ___longtitude__ = reader.ReadSingle();
                        ___longtitude__b__ = true;
                        break;
                    case 2:
                        ___type__ = reader.ReadInt32();
                        ___type__b__ = true;
                        break;
                    case 3:
                        ___estimatedLocationAccuracyInMeters__ = reader.ReadInt32();
                        ___estimatedLocationAccuracyInMeters__b__ = true;
                        break;
                    case 4:
                        ___numberOfSecondsSinceSync__ = reader.ReadInt32();
                        ___numberOfSecondsSinceSync__b__ = true;
                        break;
                    case 5:
                        ___provider__ = reader.ReadInt32();
                        ___provider__b__ = true;
                        break;
                    case 6:
                        ___country__ = reader.ReadString();
                        ___country__b__ = true;
                        break;
                    case 7:
                        ___region__ = reader.ReadString();
                        ___region__b__ = true;
                        break;
                    case 8:
                        ___regionFips__ = reader.ReadString();
                        ___regionFips__b__ = true;
                        break;
                    case 9:
                        ___metroCode__ = reader.ReadString();
                        ___metroCode__b__ = true;
                        break;
                    case 10:
                        ___city__ = reader.ReadString();
                        ___city__b__ = true;
                        break;
                    case 11:
                        ___zip__ = reader.ReadString();
                        ___zip__b__ = true;
                        break;
                    case 12:
                        ___utcOffset__ = reader.ReadString();
                        ___utcOffset__b__ = true;
                        break;
                    case 13:
                        ___ext__ = reader.ReadString();
                        ___ext__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Nefta.AdSdk.Data.Geo();
            if(___latitude__b__) ____result._latitude = ___latitude__;
            if(___longtitude__b__) ____result._longtitude = ___longtitude__;
            if(___type__b__) ____result._type = ___type__;
            if(___estimatedLocationAccuracyInMeters__b__) ____result._estimatedLocationAccuracyInMeters = ___estimatedLocationAccuracyInMeters__;
            if(___numberOfSecondsSinceSync__b__) ____result._numberOfSecondsSinceSync = ___numberOfSecondsSinceSync__;
            if(___provider__b__) ____result._provider = ___provider__;
            if(___country__b__) ____result._country = ___country__;
            if(___region__b__) ____result._region = ___region__;
            if(___regionFips__b__) ____result._regionFips = ___regionFips__;
            if(___metroCode__b__) ____result._metroCode = ___metroCode__;
            if(___city__b__) ____result._city = ___city__;
            if(___zip__b__) ____result._zip = ___zip__;
            if(___utcOffset__b__) ____result._utcOffset = ___utcOffset__;
            if(___ext__b__) ____result._ext = ___ext__;

            return ____result;
        }
    }


    public sealed class DeviceFormatter : global::Utf8Json.IJsonFormatter<global::Nefta.AdSdk.Data.Device>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public DeviceFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("ua"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("geo"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("dnt"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("lmt"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("ip"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("ipv6"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("devicetype"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("make"), 7},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("model"), 8},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("os"), 9},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("osv"), 10},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("hwv"), 11},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("h"), 12},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("w"), 13},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("ppi"), 14},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("pxration"), 15},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("js"), 16},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("geofetch"), 17},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("flashver"), 18},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("language"), 19},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("carrier"), 20},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("mccmnc"), 21},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("connectiontype"), 22},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("ifa"), 23},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("didsha1"), 24},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("didmd5"), 25},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("dpidsha1"), 26},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("dpidmd5"), 27},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("macsha1"), 28},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("macsmd5"), 29},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("ext"), 30},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("ua"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("geo"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("dnt"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("lmt"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("ip"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("ipv6"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("devicetype"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("make"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("model"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("os"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("osv"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("hwv"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("h"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("w"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("ppi"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("pxration"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("js"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("geofetch"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("flashver"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("language"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("carrier"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("mccmnc"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("connectiontype"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("ifa"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("didsha1"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("didmd5"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("dpidsha1"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("dpidmd5"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("macsha1"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("macsmd5"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("ext"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::Nefta.AdSdk.Data.Device value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value._userAgent);
            writer.WriteRaw(this.____stringByteKeys[1]);
            formatterResolver.GetFormatterWithVerify<global::Nefta.AdSdk.Data.Geo>().Serialize(ref writer, value._location, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteInt32(value._doNotTrack);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteInt32(value._isTrackingLimited);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteString(value._ip);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteString(value._ipv6);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteInt32(value._type);
            writer.WriteRaw(this.____stringByteKeys[7]);
            writer.WriteString(value._manufacturer);
            writer.WriteRaw(this.____stringByteKeys[8]);
            writer.WriteString(value._model);
            writer.WriteRaw(this.____stringByteKeys[9]);
            writer.WriteString(value._operatingSystem);
            writer.WriteRaw(this.____stringByteKeys[10]);
            writer.WriteString(value._operatingSystemVersion);
            writer.WriteRaw(this.____stringByteKeys[11]);
            writer.WriteString(value._hardwareVersion);
            writer.WriteRaw(this.____stringByteKeys[12]);
            writer.WriteInt32(value._screenHeight);
            writer.WriteRaw(this.____stringByteKeys[13]);
            writer.WriteInt32(value._screenWidth);
            writer.WriteRaw(this.____stringByteKeys[14]);
            writer.WriteInt32(value._dotsPerInch);
            writer.WriteRaw(this.____stringByteKeys[15]);
            writer.WriteSingle(value._screenToRendererPixelRatio);
            writer.WriteRaw(this.____stringByteKeys[16]);
            writer.WriteInt32(value._isJavaScriptSupported);
            writer.WriteRaw(this.____stringByteKeys[17]);
            writer.WriteInt32(value._isGeoLocationAvailableInJavaScript);
            writer.WriteRaw(this.____stringByteKeys[18]);
            writer.WriteString(value._flashVersion);
            writer.WriteRaw(this.____stringByteKeys[19]);
            writer.WriteString(value._language);
            writer.WriteRaw(this.____stringByteKeys[20]);
            writer.WriteString(value._carrier);
            writer.WriteRaw(this.____stringByteKeys[21]);
            writer.WriteString(value._mncCarrier);
            writer.WriteRaw(this.____stringByteKeys[22]);
            writer.WriteInt32(value._networkConnectionType);
            writer.WriteRaw(this.____stringByteKeys[23]);
            writer.WriteString(value._advertiserId);
            writer.WriteRaw(this.____stringByteKeys[24]);
            writer.WriteString(value._deviceIdSha1);
            writer.WriteRaw(this.____stringByteKeys[25]);
            writer.WriteString(value._deviceIdMd5);
            writer.WriteRaw(this.____stringByteKeys[26]);
            writer.WriteString(value._platformDeviceIdSha1);
            writer.WriteRaw(this.____stringByteKeys[27]);
            writer.WriteString(value._platformDeviceIdMd5);
            writer.WriteRaw(this.____stringByteKeys[28]);
            writer.WriteString(value._macAddressSha1);
            writer.WriteRaw(this.____stringByteKeys[29]);
            writer.WriteString(value._macAddressMd5);
            writer.WriteRaw(this.____stringByteKeys[30]);
            writer.WriteString(value._ext);
            
            writer.WriteEndObject();
        }

        public global::Nefta.AdSdk.Data.Device Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var ___userAgent__ = default(string);
            var ___userAgent__b__ = false;
            var ___location__ = default(global::Nefta.AdSdk.Data.Geo);
            var ___location__b__ = false;
            var ___doNotTrack__ = default(int);
            var ___doNotTrack__b__ = false;
            var ___isTrackingLimited__ = default(int);
            var ___isTrackingLimited__b__ = false;
            var ___ip__ = default(string);
            var ___ip__b__ = false;
            var ___ipv6__ = default(string);
            var ___ipv6__b__ = false;
            var ___type__ = default(int);
            var ___type__b__ = false;
            var ___manufacturer__ = default(string);
            var ___manufacturer__b__ = false;
            var ___model__ = default(string);
            var ___model__b__ = false;
            var ___operatingSystem__ = default(string);
            var ___operatingSystem__b__ = false;
            var ___operatingSystemVersion__ = default(string);
            var ___operatingSystemVersion__b__ = false;
            var ___hardwareVersion__ = default(string);
            var ___hardwareVersion__b__ = false;
            var ___screenHeight__ = default(int);
            var ___screenHeight__b__ = false;
            var ___screenWidth__ = default(int);
            var ___screenWidth__b__ = false;
            var ___dotsPerInch__ = default(int);
            var ___dotsPerInch__b__ = false;
            var ___screenToRendererPixelRatio__ = default(float);
            var ___screenToRendererPixelRatio__b__ = false;
            var ___isJavaScriptSupported__ = default(int);
            var ___isJavaScriptSupported__b__ = false;
            var ___isGeoLocationAvailableInJavaScript__ = default(int);
            var ___isGeoLocationAvailableInJavaScript__b__ = false;
            var ___flashVersion__ = default(string);
            var ___flashVersion__b__ = false;
            var ___language__ = default(string);
            var ___language__b__ = false;
            var ___carrier__ = default(string);
            var ___carrier__b__ = false;
            var ___mncCarrier__ = default(string);
            var ___mncCarrier__b__ = false;
            var ___networkConnectionType__ = default(int);
            var ___networkConnectionType__b__ = false;
            var ___advertiserId__ = default(string);
            var ___advertiserId__b__ = false;
            var ___deviceIdSha1__ = default(string);
            var ___deviceIdSha1__b__ = false;
            var ___deviceIdMd5__ = default(string);
            var ___deviceIdMd5__b__ = false;
            var ___platformDeviceIdSha1__ = default(string);
            var ___platformDeviceIdSha1__b__ = false;
            var ___platformDeviceIdMd5__ = default(string);
            var ___platformDeviceIdMd5__b__ = false;
            var ___macAddressSha1__ = default(string);
            var ___macAddressSha1__b__ = false;
            var ___macAddressMd5__ = default(string);
            var ___macAddressMd5__b__ = false;
            var ___ext__ = default(string);
            var ___ext__b__ = false;

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
                        ___userAgent__ = reader.ReadString();
                        ___userAgent__b__ = true;
                        break;
                    case 1:
                        ___location__ = formatterResolver.GetFormatterWithVerify<global::Nefta.AdSdk.Data.Geo>().Deserialize(ref reader, formatterResolver);
                        ___location__b__ = true;
                        break;
                    case 2:
                        ___doNotTrack__ = reader.ReadInt32();
                        ___doNotTrack__b__ = true;
                        break;
                    case 3:
                        ___isTrackingLimited__ = reader.ReadInt32();
                        ___isTrackingLimited__b__ = true;
                        break;
                    case 4:
                        ___ip__ = reader.ReadString();
                        ___ip__b__ = true;
                        break;
                    case 5:
                        ___ipv6__ = reader.ReadString();
                        ___ipv6__b__ = true;
                        break;
                    case 6:
                        ___type__ = reader.ReadInt32();
                        ___type__b__ = true;
                        break;
                    case 7:
                        ___manufacturer__ = reader.ReadString();
                        ___manufacturer__b__ = true;
                        break;
                    case 8:
                        ___model__ = reader.ReadString();
                        ___model__b__ = true;
                        break;
                    case 9:
                        ___operatingSystem__ = reader.ReadString();
                        ___operatingSystem__b__ = true;
                        break;
                    case 10:
                        ___operatingSystemVersion__ = reader.ReadString();
                        ___operatingSystemVersion__b__ = true;
                        break;
                    case 11:
                        ___hardwareVersion__ = reader.ReadString();
                        ___hardwareVersion__b__ = true;
                        break;
                    case 12:
                        ___screenHeight__ = reader.ReadInt32();
                        ___screenHeight__b__ = true;
                        break;
                    case 13:
                        ___screenWidth__ = reader.ReadInt32();
                        ___screenWidth__b__ = true;
                        break;
                    case 14:
                        ___dotsPerInch__ = reader.ReadInt32();
                        ___dotsPerInch__b__ = true;
                        break;
                    case 15:
                        ___screenToRendererPixelRatio__ = reader.ReadSingle();
                        ___screenToRendererPixelRatio__b__ = true;
                        break;
                    case 16:
                        ___isJavaScriptSupported__ = reader.ReadInt32();
                        ___isJavaScriptSupported__b__ = true;
                        break;
                    case 17:
                        ___isGeoLocationAvailableInJavaScript__ = reader.ReadInt32();
                        ___isGeoLocationAvailableInJavaScript__b__ = true;
                        break;
                    case 18:
                        ___flashVersion__ = reader.ReadString();
                        ___flashVersion__b__ = true;
                        break;
                    case 19:
                        ___language__ = reader.ReadString();
                        ___language__b__ = true;
                        break;
                    case 20:
                        ___carrier__ = reader.ReadString();
                        ___carrier__b__ = true;
                        break;
                    case 21:
                        ___mncCarrier__ = reader.ReadString();
                        ___mncCarrier__b__ = true;
                        break;
                    case 22:
                        ___networkConnectionType__ = reader.ReadInt32();
                        ___networkConnectionType__b__ = true;
                        break;
                    case 23:
                        ___advertiserId__ = reader.ReadString();
                        ___advertiserId__b__ = true;
                        break;
                    case 24:
                        ___deviceIdSha1__ = reader.ReadString();
                        ___deviceIdSha1__b__ = true;
                        break;
                    case 25:
                        ___deviceIdMd5__ = reader.ReadString();
                        ___deviceIdMd5__b__ = true;
                        break;
                    case 26:
                        ___platformDeviceIdSha1__ = reader.ReadString();
                        ___platformDeviceIdSha1__b__ = true;
                        break;
                    case 27:
                        ___platformDeviceIdMd5__ = reader.ReadString();
                        ___platformDeviceIdMd5__b__ = true;
                        break;
                    case 28:
                        ___macAddressSha1__ = reader.ReadString();
                        ___macAddressSha1__b__ = true;
                        break;
                    case 29:
                        ___macAddressMd5__ = reader.ReadString();
                        ___macAddressMd5__b__ = true;
                        break;
                    case 30:
                        ___ext__ = reader.ReadString();
                        ___ext__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Nefta.AdSdk.Data.Device();
            if(___userAgent__b__) ____result._userAgent = ___userAgent__;
            if(___location__b__) ____result._location = ___location__;
            if(___doNotTrack__b__) ____result._doNotTrack = ___doNotTrack__;
            if(___isTrackingLimited__b__) ____result._isTrackingLimited = ___isTrackingLimited__;
            if(___ip__b__) ____result._ip = ___ip__;
            if(___ipv6__b__) ____result._ipv6 = ___ipv6__;
            if(___type__b__) ____result._type = ___type__;
            if(___manufacturer__b__) ____result._manufacturer = ___manufacturer__;
            if(___model__b__) ____result._model = ___model__;
            if(___operatingSystem__b__) ____result._operatingSystem = ___operatingSystem__;
            if(___operatingSystemVersion__b__) ____result._operatingSystemVersion = ___operatingSystemVersion__;
            if(___hardwareVersion__b__) ____result._hardwareVersion = ___hardwareVersion__;
            if(___screenHeight__b__) ____result._screenHeight = ___screenHeight__;
            if(___screenWidth__b__) ____result._screenWidth = ___screenWidth__;
            if(___dotsPerInch__b__) ____result._dotsPerInch = ___dotsPerInch__;
            if(___screenToRendererPixelRatio__b__) ____result._screenToRendererPixelRatio = ___screenToRendererPixelRatio__;
            if(___isJavaScriptSupported__b__) ____result._isJavaScriptSupported = ___isJavaScriptSupported__;
            if(___isGeoLocationAvailableInJavaScript__b__) ____result._isGeoLocationAvailableInJavaScript = ___isGeoLocationAvailableInJavaScript__;
            if(___flashVersion__b__) ____result._flashVersion = ___flashVersion__;
            if(___language__b__) ____result._language = ___language__;
            if(___carrier__b__) ____result._carrier = ___carrier__;
            if(___mncCarrier__b__) ____result._mncCarrier = ___mncCarrier__;
            if(___networkConnectionType__b__) ____result._networkConnectionType = ___networkConnectionType__;
            if(___advertiserId__b__) ____result._advertiserId = ___advertiserId__;
            if(___deviceIdSha1__b__) ____result._deviceIdSha1 = ___deviceIdSha1__;
            if(___deviceIdMd5__b__) ____result._deviceIdMd5 = ___deviceIdMd5__;
            if(___platformDeviceIdSha1__b__) ____result._platformDeviceIdSha1 = ___platformDeviceIdSha1__;
            if(___platformDeviceIdMd5__b__) ____result._platformDeviceIdMd5 = ___platformDeviceIdMd5__;
            if(___macAddressSha1__b__) ____result._macAddressSha1 = ___macAddressSha1__;
            if(___macAddressMd5__b__) ____result._macAddressMd5 = ___macAddressMd5__;
            if(___ext__b__) ____result._ext = ___ext__;

            return ____result;
        }
    }


    public sealed class UserFormatter : global::Utf8Json.IJsonFormatter<global::Nefta.AdSdk.Data.User>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public UserFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("id"), 0},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("id"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::Nefta.AdSdk.Data.User value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.id);
            
            writer.WriteEndObject();
        }

        public global::Nefta.AdSdk.Data.User Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __id__ = default(string);
            var __id__b__ = false;

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
                        __id__ = reader.ReadString();
                        __id__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Nefta.AdSdk.Data.User();
            if(__id__b__) ____result.id = __id__;

            return ____result;
        }
    }


    public sealed class BidRequestExtNeftaFormatter : global::Utf8Json.IJsonFormatter<global::Nefta.AdSdk.Data.BidRequestExtNefta>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public BidRequestExtNeftaFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("nuid"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("puid"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("app_id"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("test"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("sdk_version"), 4},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("nuid"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("puid"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("app_id"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("test"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("sdk_version"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::Nefta.AdSdk.Data.BidRequestExtNefta value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value._neftaUserId);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value._publisherId);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value._appId);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteBoolean(value._test);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteString(value._sdkVersion);
            
            writer.WriteEndObject();
        }

        public global::Nefta.AdSdk.Data.BidRequestExtNefta Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var ___neftaUserId__ = default(string);
            var ___neftaUserId__b__ = false;
            var ___publisherId__ = default(string);
            var ___publisherId__b__ = false;
            var ___appId__ = default(string);
            var ___appId__b__ = false;
            var ___test__ = default(bool);
            var ___test__b__ = false;
            var ___sdkVersion__ = default(string);
            var ___sdkVersion__b__ = false;

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
                        ___neftaUserId__ = reader.ReadString();
                        ___neftaUserId__b__ = true;
                        break;
                    case 1:
                        ___publisherId__ = reader.ReadString();
                        ___publisherId__b__ = true;
                        break;
                    case 2:
                        ___appId__ = reader.ReadString();
                        ___appId__b__ = true;
                        break;
                    case 3:
                        ___test__ = reader.ReadBoolean();
                        ___test__b__ = true;
                        break;
                    case 4:
                        ___sdkVersion__ = reader.ReadString();
                        ___sdkVersion__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Nefta.AdSdk.Data.BidRequestExtNefta();
            if(___neftaUserId__b__) ____result._neftaUserId = ___neftaUserId__;
            if(___publisherId__b__) ____result._publisherId = ___publisherId__;
            if(___appId__b__) ____result._appId = ___appId__;
            if(___test__b__) ____result._test = ___test__;
            if(___sdkVersion__b__) ____result._sdkVersion = ___sdkVersion__;

            return ____result;
        }
    }


    public sealed class BidRequestExtFormatter : global::Utf8Json.IJsonFormatter<global::Nefta.AdSdk.Data.BidRequestExt>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public BidRequestExtFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("nefta"), 0},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("nefta"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::Nefta.AdSdk.Data.BidRequestExt value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::Nefta.AdSdk.Data.BidRequestExtNefta>().Serialize(ref writer, value._nefta, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::Nefta.AdSdk.Data.BidRequestExt Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var ___nefta__ = default(global::Nefta.AdSdk.Data.BidRequestExtNefta);
            var ___nefta__b__ = false;

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
                        ___nefta__ = formatterResolver.GetFormatterWithVerify<global::Nefta.AdSdk.Data.BidRequestExtNefta>().Deserialize(ref reader, formatterResolver);
                        ___nefta__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Nefta.AdSdk.Data.BidRequestExt();
            if(___nefta__b__) ____result._nefta = ___nefta__;

            return ____result;
        }
    }


    public sealed class BidRequestFormatter : global::Utf8Json.IJsonFormatter<global::Nefta.AdSdk.Data.BidRequest>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public BidRequestFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("id"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("at"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("cur"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("imp"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("site"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("app"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("device"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("user"), 7},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("ext"), 8},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("id"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("at"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("cur"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("imp"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("site"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("app"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("device"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("user"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("ext"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::Nefta.AdSdk.Data.BidRequest value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value._id);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteInt32(value._auctionType);
            writer.WriteRaw(this.____stringByteKeys[2]);
            formatterResolver.GetFormatterWithVerify<string[]>().Serialize(ref writer, value._allowedCurrencies, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[3]);
            formatterResolver.GetFormatterWithVerify<global::Nefta.AdSdk.Data.Impression[]>().Serialize(ref writer, value._impressions, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[4]);
            formatterResolver.GetFormatterWithVerify<global::Nefta.AdSdk.Data.Site>().Serialize(ref writer, value._site, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[5]);
            formatterResolver.GetFormatterWithVerify<global::Nefta.AdSdk.Data.Application>().Serialize(ref writer, value._application, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[6]);
            formatterResolver.GetFormatterWithVerify<global::Nefta.AdSdk.Data.Device>().Serialize(ref writer, value._device, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[7]);
            formatterResolver.GetFormatterWithVerify<global::Nefta.AdSdk.Data.User>().Serialize(ref writer, value._user, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[8]);
            formatterResolver.GetFormatterWithVerify<global::Nefta.AdSdk.Data.BidRequestExt>().Serialize(ref writer, value._ext, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::Nefta.AdSdk.Data.BidRequest Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var ___id__ = default(string);
            var ___id__b__ = false;
            var ___auctionType__ = default(int);
            var ___auctionType__b__ = false;
            var ___allowedCurrencies__ = default(string[]);
            var ___allowedCurrencies__b__ = false;
            var ___impressions__ = default(global::Nefta.AdSdk.Data.Impression[]);
            var ___impressions__b__ = false;
            var ___site__ = default(global::Nefta.AdSdk.Data.Site);
            var ___site__b__ = false;
            var ___application__ = default(global::Nefta.AdSdk.Data.Application);
            var ___application__b__ = false;
            var ___device__ = default(global::Nefta.AdSdk.Data.Device);
            var ___device__b__ = false;
            var ___user__ = default(global::Nefta.AdSdk.Data.User);
            var ___user__b__ = false;
            var ___ext__ = default(global::Nefta.AdSdk.Data.BidRequestExt);
            var ___ext__b__ = false;

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
                        ___id__ = reader.ReadString();
                        ___id__b__ = true;
                        break;
                    case 1:
                        ___auctionType__ = reader.ReadInt32();
                        ___auctionType__b__ = true;
                        break;
                    case 2:
                        ___allowedCurrencies__ = formatterResolver.GetFormatterWithVerify<string[]>().Deserialize(ref reader, formatterResolver);
                        ___allowedCurrencies__b__ = true;
                        break;
                    case 3:
                        ___impressions__ = formatterResolver.GetFormatterWithVerify<global::Nefta.AdSdk.Data.Impression[]>().Deserialize(ref reader, formatterResolver);
                        ___impressions__b__ = true;
                        break;
                    case 4:
                        ___site__ = formatterResolver.GetFormatterWithVerify<global::Nefta.AdSdk.Data.Site>().Deserialize(ref reader, formatterResolver);
                        ___site__b__ = true;
                        break;
                    case 5:
                        ___application__ = formatterResolver.GetFormatterWithVerify<global::Nefta.AdSdk.Data.Application>().Deserialize(ref reader, formatterResolver);
                        ___application__b__ = true;
                        break;
                    case 6:
                        ___device__ = formatterResolver.GetFormatterWithVerify<global::Nefta.AdSdk.Data.Device>().Deserialize(ref reader, formatterResolver);
                        ___device__b__ = true;
                        break;
                    case 7:
                        ___user__ = formatterResolver.GetFormatterWithVerify<global::Nefta.AdSdk.Data.User>().Deserialize(ref reader, formatterResolver);
                        ___user__b__ = true;
                        break;
                    case 8:
                        ___ext__ = formatterResolver.GetFormatterWithVerify<global::Nefta.AdSdk.Data.BidRequestExt>().Deserialize(ref reader, formatterResolver);
                        ___ext__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Nefta.AdSdk.Data.BidRequest();
            if(___id__b__) ____result._id = ___id__;
            if(___auctionType__b__) ____result._auctionType = ___auctionType__;
            if(___allowedCurrencies__b__) ____result._allowedCurrencies = ___allowedCurrencies__;
            if(___impressions__b__) ____result._impressions = ___impressions__;
            if(___site__b__) ____result._site = ___site__;
            if(___application__b__) ____result._application = ___application__;
            if(___device__b__) ____result._device = ___device__;
            if(___user__b__) ____result._user = ___user__;
            if(___ext__b__) ____result._ext = ___ext__;

            return ____result;
        }
    }


    public sealed class SeatBidFormatter : global::Utf8Json.IJsonFormatter<global::Nefta.AdSdk.Data.SeatBid>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public SeatBidFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("bid"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("seat"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("group"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("ext"), 3},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("bid"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("seat"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("group"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("ext"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::Nefta.AdSdk.Data.SeatBid value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::System.Collections.Generic.List<global::Nefta.AdSdk.Data.Bid>>().Serialize(ref writer, value._bids, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value._seatId);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteInt32(value._isGroupedImpression);
            writer.WriteRaw(this.____stringByteKeys[3]);
            formatterResolver.GetFormatterWithVerify<global::Nefta.AdSdk.Data.Ext>().Serialize(ref writer, value._ext, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::Nefta.AdSdk.Data.SeatBid Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var ___bids__ = default(global::System.Collections.Generic.List<global::Nefta.AdSdk.Data.Bid>);
            var ___bids__b__ = false;
            var ___seatId__ = default(string);
            var ___seatId__b__ = false;
            var ___isGroupedImpression__ = default(int);
            var ___isGroupedImpression__b__ = false;
            var ___ext__ = default(global::Nefta.AdSdk.Data.Ext);
            var ___ext__b__ = false;

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
                        ___bids__ = formatterResolver.GetFormatterWithVerify<global::System.Collections.Generic.List<global::Nefta.AdSdk.Data.Bid>>().Deserialize(ref reader, formatterResolver);
                        ___bids__b__ = true;
                        break;
                    case 1:
                        ___seatId__ = reader.ReadString();
                        ___seatId__b__ = true;
                        break;
                    case 2:
                        ___isGroupedImpression__ = reader.ReadInt32();
                        ___isGroupedImpression__b__ = true;
                        break;
                    case 3:
                        ___ext__ = formatterResolver.GetFormatterWithVerify<global::Nefta.AdSdk.Data.Ext>().Deserialize(ref reader, formatterResolver);
                        ___ext__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Nefta.AdSdk.Data.SeatBid();
            if(___bids__b__) ____result._bids = ___bids__;
            if(___seatId__b__) ____result._seatId = ___seatId__;
            if(___isGroupedImpression__b__) ____result._isGroupedImpression = ___isGroupedImpression__;
            if(___ext__b__) ____result._ext = ___ext__;

            return ____result;
        }
    }


    public sealed class BidResponseFormatter : global::Utf8Json.IJsonFormatter<global::Nefta.AdSdk.Data.BidResponse>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public BidResponseFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("id"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("seatbid"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("bidid"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("cutomdata"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("nbr"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("ext"), 5},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("id"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("seatbid"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("bidid"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("cutomdata"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("nbr"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("ext"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::Nefta.AdSdk.Data.BidResponse value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value._id);
            writer.WriteRaw(this.____stringByteKeys[1]);
            formatterResolver.GetFormatterWithVerify<global::System.Collections.Generic.List<global::Nefta.AdSdk.Data.SeatBid>>().Serialize(ref writer, value._seatBids, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value._bidId);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value._customData);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteInt32(value._reasonForNotBidding);
            writer.WriteRaw(this.____stringByteKeys[5]);
            formatterResolver.GetFormatterWithVerify<global::Nefta.AdSdk.Data.BidResponseExt>().Serialize(ref writer, value._ext, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::Nefta.AdSdk.Data.BidResponse Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var ___id__ = default(string);
            var ___id__b__ = false;
            var ___seatBids__ = default(global::System.Collections.Generic.List<global::Nefta.AdSdk.Data.SeatBid>);
            var ___seatBids__b__ = false;
            var ___bidId__ = default(string);
            var ___bidId__b__ = false;
            var ___customData__ = default(string);
            var ___customData__b__ = false;
            var ___reasonForNotBidding__ = default(int);
            var ___reasonForNotBidding__b__ = false;
            var ___ext__ = default(global::Nefta.AdSdk.Data.BidResponseExt);
            var ___ext__b__ = false;

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
                        ___id__ = reader.ReadString();
                        ___id__b__ = true;
                        break;
                    case 1:
                        ___seatBids__ = formatterResolver.GetFormatterWithVerify<global::System.Collections.Generic.List<global::Nefta.AdSdk.Data.SeatBid>>().Deserialize(ref reader, formatterResolver);
                        ___seatBids__b__ = true;
                        break;
                    case 2:
                        ___bidId__ = reader.ReadString();
                        ___bidId__b__ = true;
                        break;
                    case 3:
                        ___customData__ = reader.ReadString();
                        ___customData__b__ = true;
                        break;
                    case 4:
                        ___reasonForNotBidding__ = reader.ReadInt32();
                        ___reasonForNotBidding__b__ = true;
                        break;
                    case 5:
                        ___ext__ = formatterResolver.GetFormatterWithVerify<global::Nefta.AdSdk.Data.BidResponseExt>().Deserialize(ref reader, formatterResolver);
                        ___ext__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Nefta.AdSdk.Data.BidResponse();
            if(___id__b__) ____result._id = ___id__;
            if(___seatBids__b__) ____result._seatBids = ___seatBids__;
            if(___bidId__b__) ____result._bidId = ___bidId__;
            if(___customData__b__) ____result._customData = ___customData__;
            if(___reasonForNotBidding__b__) ____result._reasonForNotBidding = ___reasonForNotBidding__;
            if(___ext__b__) ____result._ext = ___ext__;

            return ____result;
        }
    }


    public sealed class InitRequestFormatter : global::Utf8Json.IJsonFormatter<global::Nefta.AdSdk.Data.InitRequest>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public InitRequestFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("app_id"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("nuid"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("app_id"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("nuid"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::Nefta.AdSdk.Data.InitRequest value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value._appId);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value._nuid);
            
            writer.WriteEndObject();
        }

        public global::Nefta.AdSdk.Data.InitRequest Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var ___appId__ = default(string);
            var ___appId__b__ = false;
            var ___nuid__ = default(string);
            var ___nuid__b__ = false;

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
                        ___appId__ = reader.ReadString();
                        ___appId__b__ = true;
                        break;
                    case 1:
                        ___nuid__ = reader.ReadString();
                        ___nuid__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Nefta.AdSdk.Data.InitRequest();
            if(___appId__b__) ____result._appId = ___appId__;
            if(___nuid__b__) ____result._nuid = ___nuid__;

            return ____result;
        }
    }


    public sealed class InitResponseFormatter : global::Utf8Json.IJsonFormatter<global::Nefta.AdSdk.Data.InitResponse>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public InitResponseFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("nuid"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("ad_units"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("nuid"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("ad_units"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::Nefta.AdSdk.Data.InitResponse value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value._nuid);
            writer.WriteRaw(this.____stringByteKeys[1]);
            formatterResolver.GetFormatterWithVerify<global::System.Collections.Generic.List<global::Nefta.AdSdk.Data.AdUnit>>().Serialize(ref writer, value._adUnits, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::Nefta.AdSdk.Data.InitResponse Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var ___nuid__ = default(string);
            var ___nuid__b__ = false;
            var ___adUnits__ = default(global::System.Collections.Generic.List<global::Nefta.AdSdk.Data.AdUnit>);
            var ___adUnits__b__ = false;

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
                        ___nuid__ = reader.ReadString();
                        ___nuid__b__ = true;
                        break;
                    case 1:
                        ___adUnits__ = formatterResolver.GetFormatterWithVerify<global::System.Collections.Generic.List<global::Nefta.AdSdk.Data.AdUnit>>().Deserialize(ref reader, formatterResolver);
                        ___adUnits__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Nefta.AdSdk.Data.InitResponse();
            if(___nuid__b__) ____result._nuid = ___nuid__;
            if(___adUnits__b__) ____result._adUnits = ___adUnits__;

            return ____result;
        }
    }


    public sealed class NativeFormatter : global::Utf8Json.IJsonFormatter<global::Nefta.AdSdk.Data.Native>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public NativeFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("request"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("ver"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("api"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("battr"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("ext"), 4},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("request"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("ver"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("api"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("battr"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("ext"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::Nefta.AdSdk.Data.Native value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value._requestPayload);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value._adApiVersion);
            writer.WriteRaw(this.____stringByteKeys[2]);
            formatterResolver.GetFormatterWithVerify<int[]>().Serialize(ref writer, value._supportedApis, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[3]);
            formatterResolver.GetFormatterWithVerify<int[]>().Serialize(ref writer, value._blockedCreativeAttributes, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteString(value._ext);
            
            writer.WriteEndObject();
        }

        public global::Nefta.AdSdk.Data.Native Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var ___requestPayload__ = default(string);
            var ___requestPayload__b__ = false;
            var ___adApiVersion__ = default(string);
            var ___adApiVersion__b__ = false;
            var ___supportedApis__ = default(int[]);
            var ___supportedApis__b__ = false;
            var ___blockedCreativeAttributes__ = default(int[]);
            var ___blockedCreativeAttributes__b__ = false;
            var ___ext__ = default(string);
            var ___ext__b__ = false;

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
                        ___requestPayload__ = reader.ReadString();
                        ___requestPayload__b__ = true;
                        break;
                    case 1:
                        ___adApiVersion__ = reader.ReadString();
                        ___adApiVersion__b__ = true;
                        break;
                    case 2:
                        ___supportedApis__ = formatterResolver.GetFormatterWithVerify<int[]>().Deserialize(ref reader, formatterResolver);
                        ___supportedApis__b__ = true;
                        break;
                    case 3:
                        ___blockedCreativeAttributes__ = formatterResolver.GetFormatterWithVerify<int[]>().Deserialize(ref reader, formatterResolver);
                        ___blockedCreativeAttributes__b__ = true;
                        break;
                    case 4:
                        ___ext__ = reader.ReadString();
                        ___ext__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Nefta.AdSdk.Data.Native();
            if(___requestPayload__b__) ____result._requestPayload = ___requestPayload__;
            if(___adApiVersion__b__) ____result._adApiVersion = ___adApiVersion__;
            if(___supportedApis__b__) ____result._supportedApis = ___supportedApis__;
            if(___blockedCreativeAttributes__b__) ____result._blockedCreativeAttributes = ___blockedCreativeAttributes__;
            if(___ext__b__) ____result._ext = ___ext__;

            return ____result;
        }
    }


    public sealed class ProducerFormatter : global::Utf8Json.IJsonFormatter<global::Nefta.AdSdk.Data.Producer>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public ProducerFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("id"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("name"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("cat"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("domain"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("ext"), 4},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("id"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("name"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("cat"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("domain"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("ext"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::Nefta.AdSdk.Data.Producer value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value._id);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value._name);
            writer.WriteRaw(this.____stringByteKeys[2]);
            formatterResolver.GetFormatterWithVerify<string[]>().Serialize(ref writer, value._categories, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value._domain);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteString(value._ext);
            
            writer.WriteEndObject();
        }

        public global::Nefta.AdSdk.Data.Producer Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var ___id__ = default(string);
            var ___id__b__ = false;
            var ___name__ = default(string);
            var ___name__b__ = false;
            var ___categories__ = default(string[]);
            var ___categories__b__ = false;
            var ___domain__ = default(string);
            var ___domain__b__ = false;
            var ___ext__ = default(string);
            var ___ext__b__ = false;

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
                        ___id__ = reader.ReadString();
                        ___id__b__ = true;
                        break;
                    case 1:
                        ___name__ = reader.ReadString();
                        ___name__b__ = true;
                        break;
                    case 2:
                        ___categories__ = formatterResolver.GetFormatterWithVerify<string[]>().Deserialize(ref reader, formatterResolver);
                        ___categories__b__ = true;
                        break;
                    case 3:
                        ___domain__ = reader.ReadString();
                        ___domain__b__ = true;
                        break;
                    case 4:
                        ___ext__ = reader.ReadString();
                        ___ext__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::Nefta.AdSdk.Data.Producer();
            if(___id__b__) ____result._id = ___id__;
            if(___name__b__) ____result._name = ___name__;
            if(___categories__b__) ____result._categories = ___categories__;
            if(___domain__b__) ____result._domain = ___domain__;
            if(___ext__b__) ____result._ext = ___ext__;

            return ____result;
        }
    }

}

#pragma warning disable 168
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612
