using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Errors
{
    public partial class ReferenceExistsError : IReferenceExistsError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public IReferenceTypeId ReferencedBy { get; set; }
        public ReferenceExistsError()
        {
            this.Code = "ReferenceExists";
        }
    }
}
