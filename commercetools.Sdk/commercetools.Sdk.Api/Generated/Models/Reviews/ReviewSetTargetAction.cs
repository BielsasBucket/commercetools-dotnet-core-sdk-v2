using System;


namespace commercetools.Api.Models.Reviews
{
    public partial class ReviewSetTargetAction : IReviewSetTargetAction
    {
        public string Action { get; set; }

        public Object Target { get; set; }
        public ReviewSetTargetAction()
        {
            this.Action = "setTarget";
        }
    }
}
