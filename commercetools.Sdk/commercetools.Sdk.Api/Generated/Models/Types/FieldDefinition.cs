using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Types
{
    public partial class FieldDefinition : IFieldDefinition
    {
        public IFieldType Type { get; set; }

        public string Name { get; set; }

        public ILocalizedString Label { get; set; }

        public bool Required { get; set; }

        public ITypeTextInputHint InputHint { get; set; }
    }
}
