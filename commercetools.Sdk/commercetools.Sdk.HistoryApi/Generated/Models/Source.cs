using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.HistoryApi.Models
{
    public enum Source
    {
        [Description("MerchantCenter")]
        MerchantCenter,

        [Description("ImpEx")]
        ImpEx,

        [Description("ApiClient")]
        ApiClient
    }

    public class SourceWrapper : ISource
    {
        public string JsonName { get; internal set; }
        public Source? Value { get; internal set; }
        public override string ToString()
        {
            return JsonName;
        }
    }

    [EnumInterfaceCreator(typeof(ISource), "FindEnum")]
    public interface ISource : IJsonName
    {
        public static ISource MerchantCenter = new SourceWrapper
        { Value = Source.MerchantCenter, JsonName = "MerchantCenter" };

        public static ISource ImpEx = new SourceWrapper
        { Value = Source.ImpEx, JsonName = "ImpEx" };

        public static ISource ApiClient = new SourceWrapper
        { Value = Source.ApiClient, JsonName = "ApiClient" };

        Source? Value { get; }

        static ISource[] Values()
        {
            return new[]
            {
                 MerchantCenter ,
                 ImpEx ,
                 ApiClient
             };
        }
        static ISource FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new SourceWrapper() { JsonName = value };
        }
    }
}
