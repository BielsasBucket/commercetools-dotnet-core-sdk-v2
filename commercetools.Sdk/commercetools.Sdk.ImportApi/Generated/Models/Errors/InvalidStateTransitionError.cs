using commercetools.ImportApi.Models.Common;


namespace commercetools.ImportApi.Models.Errors
{
    public partial class InvalidStateTransitionError : IInvalidStateTransitionError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public IProcessingState CurrentState { get; set; }

        public IProcessingState NewState { get; set; }
        public InvalidStateTransitionError()
        {
            this.Code = "InvalidTransition";
        }
    }
}
