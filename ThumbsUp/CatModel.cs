using System;
using System.Collections.Generic;
using System.Text;

namespace ThumbsUp
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class CatModel
    {
        [JsonProperty("data")]
        public Data Data { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("status")]
        public long Status { get; set; }
    }

    public partial class Item
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public object Description { get; set; }

        [JsonProperty("datetime")]
        public long Datetime { get; set; }

        [JsonProperty("cover", NullValueHandling = NullValueHandling.Ignore)]
        public string Cover { get; set; }

        [JsonProperty("cover_width", NullValueHandling = NullValueHandling.Ignore)]
        public long? CoverWidth { get; set; }

        [JsonProperty("cover_height", NullValueHandling = NullValueHandling.Ignore)]
        public long? CoverHeight { get; set; }

        [JsonProperty("account_url")]
        public string AccountUrl { get; set; }

        [JsonProperty("account_id")]
        public long AccountId { get; set; }

        [JsonProperty("privacy", NullValueHandling = NullValueHandling.Ignore)]
        public Privacy? Privacy { get; set; }

        [JsonProperty("layout", NullValueHandling = NullValueHandling.Ignore)]
        public Layout? Layout { get; set; }

        [JsonProperty("views")]
        public long Views { get; set; }

        [JsonProperty("link")]
        public Uri Link { get; set; }

        [JsonProperty("ups")]
        public long Ups { get; set; }

        [JsonProperty("downs")]
        public long Downs { get; set; }

        [JsonProperty("points")]
        public long Points { get; set; }

        [JsonProperty("score")]
        public long Score { get; set; }

        [JsonProperty("is_album")]
        public bool IsAlbum { get; set; }

        [JsonProperty("vote")]
        public object Vote { get; set; }

        [JsonProperty("favorite")]
        public bool Favorite { get; set; }

        [JsonProperty("nsfw")]
        public bool Nsfw { get; set; }

        [JsonProperty("section")]
        public Section Section { get; set; }

        [JsonProperty("comment_count")]
        public long CommentCount { get; set; }

        [JsonProperty("favorite_count")]
        public long FavoriteCount { get; set; }

        [JsonProperty("topic")]
        public Topic Topic { get; set; }

        [JsonProperty("topic_id")]
        public long TopicId { get; set; }

        [JsonProperty("images_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? ImagesCount { get; set; }

        [JsonProperty("in_gallery")]
        public bool InGallery { get; set; }

        [JsonProperty("is_ad")]
        public bool IsAd { get; set; }

        [JsonProperty("tags")]
        public Data[] Tags { get; set; }

        [JsonProperty("ad_type")]
        public long AdType { get; set; }

        [JsonProperty("ad_url")]
        public string AdUrl { get; set; }

        [JsonProperty("in_most_viral")]
        public bool InMostViral { get; set; }

        [JsonProperty("include_album_ads", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeAlbumAds { get; set; }

        [JsonProperty("images", NullValueHandling = NullValueHandling.Ignore)]
        public Image[] Images { get; set; }

        [JsonProperty("ad_config")]
        public AdConfig AdConfig { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum? Type { get; set; }

        [JsonProperty("animated", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Animated { get; set; }

        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public long? Width { get; set; }

        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public long? Height { get; set; }

        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public long? Size { get; set; }

        [JsonProperty("bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public long? Bandwidth { get; set; }

        [JsonProperty("has_sound", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasSound { get; set; }

        [JsonProperty("edited", NullValueHandling = NullValueHandling.Ignore)]
        public long? Edited { get; set; }

        [JsonProperty("mp4_size", NullValueHandling = NullValueHandling.Ignore)]
        public long? Mp4Size { get; set; }

        [JsonProperty("mp4", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Mp4 { get; set; }

        [JsonProperty("gifv", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Gifv { get; set; }

        [JsonProperty("hls", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Hls { get; set; }

        [JsonProperty("processing", NullValueHandling = NullValueHandling.Ignore)]
        public Processing Processing { get; set; }
    }

    public partial class Data
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("followers")]
        public long Followers { get; set; }

        [JsonProperty("total_items")]
        public long TotalItems { get; set; }

        [JsonProperty("following")]
        public bool Following { get; set; }

        [JsonProperty("is_whitelisted")]
        public bool IsWhitelisted { get; set; }

        [JsonProperty("background_hash")]
        public string BackgroundHash { get; set; }

        [JsonProperty("thumbnail_hash")]
        public string ThumbnailHash { get; set; }

        [JsonProperty("accent")]
        public string Accent { get; set; }

        [JsonProperty("background_is_animated")]
        public bool BackgroundIsAnimated { get; set; }

        [JsonProperty("thumbnail_is_animated")]
        public bool ThumbnailIsAnimated { get; set; }

        [JsonProperty("is_promoted")]
        public bool IsPromoted { get; set; }

        [JsonProperty("description")]
        public Description Description { get; set; }

        [JsonProperty("logo_hash")]
        public object LogoHash { get; set; }

        [JsonProperty("logo_destination_url")]
        public object LogoDestinationUrl { get; set; }

        [JsonProperty("description_annotations")]
        public DescriptionAnnotations DescriptionAnnotations { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public Item[] Items { get; set; }
    }

    public partial class AdConfig
    {
        [JsonProperty("safeFlags")]
        public SafeFlag[] SafeFlags { get; set; }

        [JsonProperty("highRiskFlags")]
        public object[] HighRiskFlags { get; set; }

        [JsonProperty("unsafeFlags")]
        public UnsafeFlag[] UnsafeFlags { get; set; }

        [JsonProperty("wallUnsafeFlags")]
        public object[] WallUnsafeFlags { get; set; }

        [JsonProperty("showsAds")]
        public bool ShowsAds { get; set; }
    }

    public partial class Image
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public object Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("datetime")]
        public long Datetime { get; set; }

        [JsonProperty("type")]
        public TypeEnum Type { get; set; }

        [JsonProperty("animated")]
        public bool Animated { get; set; }

        [JsonProperty("width")]
        public long Width { get; set; }

        [JsonProperty("height")]
        public long Height { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("views")]
        public long Views { get; set; }

        [JsonProperty("bandwidth")]
        public long Bandwidth { get; set; }

        [JsonProperty("vote")]
        public object Vote { get; set; }

        [JsonProperty("favorite")]
        public bool Favorite { get; set; }

        [JsonProperty("nsfw")]
        public object Nsfw { get; set; }

        [JsonProperty("section")]
        public object Section { get; set; }

        [JsonProperty("account_url")]
        public object AccountUrl { get; set; }

        [JsonProperty("account_id")]
        public object AccountId { get; set; }

        [JsonProperty("is_ad")]
        public bool IsAd { get; set; }

        [JsonProperty("in_most_viral")]
        public bool InMostViral { get; set; }

        [JsonProperty("has_sound")]
        public bool HasSound { get; set; }

        [JsonProperty("tags")]
        public object[] Tags { get; set; }

        [JsonProperty("ad_type")]
        public long AdType { get; set; }

        [JsonProperty("ad_url")]
        public string AdUrl { get; set; }

        [JsonProperty("edited")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Edited { get; set; }

        [JsonProperty("in_gallery")]
        public bool InGallery { get; set; }

        [JsonProperty("link")]
        public Uri Link { get; set; }

        [JsonProperty("comment_count")]
        public object CommentCount { get; set; }

        [JsonProperty("favorite_count")]
        public object FavoriteCount { get; set; }

        [JsonProperty("ups")]
        public object Ups { get; set; }

        [JsonProperty("downs")]
        public object Downs { get; set; }

        [JsonProperty("points")]
        public object Points { get; set; }

        [JsonProperty("score")]
        public object Score { get; set; }

        [JsonProperty("mp4_size", NullValueHandling = NullValueHandling.Ignore)]
        public long? Mp4Size { get; set; }

        [JsonProperty("mp4", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Mp4 { get; set; }

        [JsonProperty("gifv", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Gifv { get; set; }

        [JsonProperty("hls", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Hls { get; set; }

        [JsonProperty("processing", NullValueHandling = NullValueHandling.Ignore)]
        public Processing Processing { get; set; }

        [JsonProperty("looping", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Looping { get; set; }
    }

    public partial class Processing
    {
        [JsonProperty("status")]
        public Status Status { get; set; }
    }

    public partial class DescriptionAnnotations
    {
    }

    public enum SafeFlag { Album, Gallery, InGallery, OnsfwModSafe, PageLoad, SixthModSafe };

    public enum UnsafeFlag { SixthModUnsafe, Under10, UpdatedDate };

    public enum Status { Completed };

    public enum TypeEnum { ImageGif, ImageJpeg, ImagePng, VideoMp4 };

    public enum Layout { Blog };

    public enum Privacy { Hidden };

    public enum Section { Aww, Awww, Empty, IllegallySmolCats };

    public enum Topic { NoTopic };

    public enum Description { AllThingsAnimal, BodyArt, CuteAndAdorable, Empty, FelineFriends, HappyLoveYourPetsDay, HumanSBestFriend, LoLsRofLsLmaOs, OurFelineFriends, PowBamZap, VideosWithSound };

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                DescriptionConverter.Singleton,
                SafeFlagConverter.Singleton,
                UnsafeFlagConverter.Singleton,
                StatusConverter.Singleton,
                TypeEnumConverter.Singleton,
                LayoutConverter.Singleton,
                PrivacyConverter.Singleton,
                SectionConverter.Singleton,
                TopicConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class DescriptionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Description) || t == typeof(Description?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "":
                    return Description.Empty;
                case "Happy Love Your Pets Day!":
                    return Description.HappyLoveYourPetsDay;
                case "LOLs, ROFLs, LMAOs":
                    return Description.LoLsRofLsLmaOs;
                case "Our feline friends":
                    return Description.OurFelineFriends;
                case "POW! BAM! ZAP!":
                    return Description.PowBamZap;
                case "all things animal":
                    return Description.AllThingsAnimal;
                case "body art":
                    return Description.BodyArt;
                case "cute and adorable":
                    return Description.CuteAndAdorable;
                case "feline friends":
                    return Description.FelineFriends;
                case "human's best friend":
                    return Description.HumanSBestFriend;
                case "videos with sound":
                    return Description.VideosWithSound;
            }
            throw new Exception("Cannot unmarshal type Description");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Description)untypedValue;
            switch (value)
            {
                case Description.Empty:
                    serializer.Serialize(writer, "");
                    return;
                case Description.HappyLoveYourPetsDay:
                    serializer.Serialize(writer, "Happy Love Your Pets Day!");
                    return;
                case Description.LoLsRofLsLmaOs:
                    serializer.Serialize(writer, "LOLs, ROFLs, LMAOs");
                    return;
                case Description.OurFelineFriends:
                    serializer.Serialize(writer, "Our feline friends");
                    return;
                case Description.PowBamZap:
                    serializer.Serialize(writer, "POW! BAM! ZAP!");
                    return;
                case Description.AllThingsAnimal:
                    serializer.Serialize(writer, "all things animal");
                    return;
                case Description.BodyArt:
                    serializer.Serialize(writer, "body art");
                    return;
                case Description.CuteAndAdorable:
                    serializer.Serialize(writer, "cute and adorable");
                    return;
                case Description.FelineFriends:
                    serializer.Serialize(writer, "feline friends");
                    return;
                case Description.HumanSBestFriend:
                    serializer.Serialize(writer, "human's best friend");
                    return;
                case Description.VideosWithSound:
                    serializer.Serialize(writer, "videos with sound");
                    return;
            }
            throw new Exception("Cannot marshal type Description");
        }

        public static readonly DescriptionConverter Singleton = new DescriptionConverter();
    }

    internal class SafeFlagConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(SafeFlag) || t == typeof(SafeFlag?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "album":
                    return SafeFlag.Album;
                case "gallery":
                    return SafeFlag.Gallery;
                case "in_gallery":
                    return SafeFlag.InGallery;
                case "onsfw_mod_safe":
                    return SafeFlag.OnsfwModSafe;
                case "page_load":
                    return SafeFlag.PageLoad;
                case "sixth_mod_safe":
                    return SafeFlag.SixthModSafe;
            }
            throw new Exception("Cannot unmarshal type SafeFlag");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (SafeFlag)untypedValue;
            switch (value)
            {
                case SafeFlag.Album:
                    serializer.Serialize(writer, "album");
                    return;
                case SafeFlag.Gallery:
                    serializer.Serialize(writer, "gallery");
                    return;
                case SafeFlag.InGallery:
                    serializer.Serialize(writer, "in_gallery");
                    return;
                case SafeFlag.OnsfwModSafe:
                    serializer.Serialize(writer, "onsfw_mod_safe");
                    return;
                case SafeFlag.PageLoad:
                    serializer.Serialize(writer, "page_load");
                    return;
                case SafeFlag.SixthModSafe:
                    serializer.Serialize(writer, "sixth_mod_safe");
                    return;
            }
            throw new Exception("Cannot marshal type SafeFlag");
        }

        public static readonly SafeFlagConverter Singleton = new SafeFlagConverter();
    }

    internal class UnsafeFlagConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(UnsafeFlag) || t == typeof(UnsafeFlag?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "sixth_mod_unsafe":
                    return UnsafeFlag.SixthModUnsafe;
                case "under_10":
                    return UnsafeFlag.Under10;
                case "updated_date":
                    return UnsafeFlag.UpdatedDate;
            }
            throw new Exception("Cannot unmarshal type UnsafeFlag");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (UnsafeFlag)untypedValue;
            switch (value)
            {
                case UnsafeFlag.SixthModUnsafe:
                    serializer.Serialize(writer, "sixth_mod_unsafe");
                    return;
                case UnsafeFlag.Under10:
                    serializer.Serialize(writer, "under_10");
                    return;
                case UnsafeFlag.UpdatedDate:
                    serializer.Serialize(writer, "updated_date");
                    return;
            }
            throw new Exception("Cannot marshal type UnsafeFlag");
        }

        public static readonly UnsafeFlagConverter Singleton = new UnsafeFlagConverter();
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }

    internal class StatusConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Status) || t == typeof(Status?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "completed")
            {
                return Status.Completed;
            }
            throw new Exception("Cannot unmarshal type Status");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Status)untypedValue;
            if (value == Status.Completed)
            {
                serializer.Serialize(writer, "completed");
                return;
            }
            throw new Exception("Cannot marshal type Status");
        }

        public static readonly StatusConverter Singleton = new StatusConverter();
    }

    internal class TypeEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TypeEnum) || t == typeof(TypeEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "image/gif":
                    return TypeEnum.ImageGif;
                case "image/jpeg":
                    return TypeEnum.ImageJpeg;
                case "image/png":
                    return TypeEnum.ImagePng;
                case "video/mp4":
                    return TypeEnum.VideoMp4;
            }
            throw new Exception("Cannot unmarshal type TypeEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TypeEnum)untypedValue;
            switch (value)
            {
                case TypeEnum.ImageGif:
                    serializer.Serialize(writer, "image/gif");
                    return;
                case TypeEnum.ImageJpeg:
                    serializer.Serialize(writer, "image/jpeg");
                    return;
                case TypeEnum.ImagePng:
                    serializer.Serialize(writer, "image/png");
                    return;
                case TypeEnum.VideoMp4:
                    serializer.Serialize(writer, "video/mp4");
                    return;
            }
            throw new Exception("Cannot marshal type TypeEnum");
        }

        public static readonly TypeEnumConverter Singleton = new TypeEnumConverter();
    }

    internal class LayoutConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Layout) || t == typeof(Layout?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "blog")
            {
                return Layout.Blog;
            }
            throw new Exception("Cannot unmarshal type Layout");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Layout)untypedValue;
            if (value == Layout.Blog)
            {
                serializer.Serialize(writer, "blog");
                return;
            }
            throw new Exception("Cannot marshal type Layout");
        }

        public static readonly LayoutConverter Singleton = new LayoutConverter();
    }

    internal class PrivacyConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Privacy) || t == typeof(Privacy?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "hidden")
            {
                return Privacy.Hidden;
            }
            throw new Exception("Cannot unmarshal type Privacy");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Privacy)untypedValue;
            if (value == Privacy.Hidden)
            {
                serializer.Serialize(writer, "hidden");
                return;
            }
            throw new Exception("Cannot marshal type Privacy");
        }

        public static readonly PrivacyConverter Singleton = new PrivacyConverter();
    }

    internal class SectionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Section) || t == typeof(Section?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "":
                    return Section.Empty;
                case "Awww":
                    return Section.Awww;
                case "IllegallySmolCats":
                    return Section.IllegallySmolCats;
                case "aww":
                    return Section.Aww;
            }
            throw new Exception("Cannot unmarshal type Section");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Section)untypedValue;
            switch (value)
            {
                case Section.Empty:
                    serializer.Serialize(writer, "");
                    return;
                case Section.Awww:
                    serializer.Serialize(writer, "Awww");
                    return;
                case Section.IllegallySmolCats:
                    serializer.Serialize(writer, "IllegallySmolCats");
                    return;
                case Section.Aww:
                    serializer.Serialize(writer, "aww");
                    return;
            }
            throw new Exception("Cannot marshal type Section");
        }

        public static readonly SectionConverter Singleton = new SectionConverter();
    }

    internal class TopicConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Topic) || t == typeof(Topic?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "No Topic")
            {
                return Topic.NoTopic;
            }
            throw new Exception("Cannot unmarshal type Topic");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Topic)untypedValue;
            if (value == Topic.NoTopic)
            {
                serializer.Serialize(writer, "No Topic");
                return;
            }
            throw new Exception("Cannot marshal type Topic");
        }

        public static readonly TopicConverter Singleton = new TopicConverter();
    }
}
