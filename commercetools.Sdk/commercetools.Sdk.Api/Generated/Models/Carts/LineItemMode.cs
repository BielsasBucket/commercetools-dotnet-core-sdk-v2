using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.Api.Models.Carts
{
    public enum LineItemMode
    {
        [Description("Standard")]
        Standard,

        [Description("GiftLineItem")]
        GiftLineItem
    }

    public class LineItemModeWrapper : ILineItemMode
    {
        public string JsonName { get; internal set; }
        public LineItemMode? Value { get; internal set; }
        public override string ToString()
        {
            return JsonName;
        }
    }

    [EnumInterfaceCreator(typeof(ILineItemMode), "FindEnum")]
    public interface ILineItemMode : IJsonName
    {
        public static ILineItemMode Standard = new LineItemModeWrapper
        { Value = LineItemMode.Standard, JsonName = "Standard" };

        public static ILineItemMode GiftLineItem = new LineItemModeWrapper
        { Value = LineItemMode.GiftLineItem, JsonName = "GiftLineItem" };

        LineItemMode? Value { get; }

        static ILineItemMode[] Values()
        {
            return new[]
            {
                 Standard ,
                 GiftLineItem
             };
        }
        static ILineItemMode FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new LineItemModeWrapper() { JsonName = value };
        }
    }
}
