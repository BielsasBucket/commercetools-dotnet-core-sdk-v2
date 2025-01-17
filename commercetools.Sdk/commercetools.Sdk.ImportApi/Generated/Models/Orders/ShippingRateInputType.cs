using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.ImportApi.Models.Orders
{
    public enum ShippingRateInputType
    {
        [Description("Classification")]
        Classification,

        [Description("Score")]
        Score
    }

    public class ShippingRateInputTypeWrapper : IShippingRateInputType
    {
        public string JsonName { get; internal set; }
        public ShippingRateInputType? Value { get; internal set; }
        public override string ToString()
        {
            return JsonName;
        }
    }

    [EnumInterfaceCreator(typeof(IShippingRateInputType), "FindEnum")]
    public interface IShippingRateInputType : IJsonName
    {
        public static IShippingRateInputType Classification = new ShippingRateInputTypeWrapper
        { Value = ShippingRateInputType.Classification, JsonName = "Classification" };

        public static IShippingRateInputType Score = new ShippingRateInputTypeWrapper
        { Value = ShippingRateInputType.Score, JsonName = "Score" };

        ShippingRateInputType? Value { get; }

        static IShippingRateInputType[] Values()
        {
            return new[]
            {
                 Classification ,
                 Score
             };
        }
        static IShippingRateInputType FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new ShippingRateInputTypeWrapper() { JsonName = value };
        }
    }
}
