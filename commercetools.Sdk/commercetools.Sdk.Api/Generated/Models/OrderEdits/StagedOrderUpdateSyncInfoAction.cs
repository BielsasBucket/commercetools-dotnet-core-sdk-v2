using commercetools.Api.Models.Channels;
using System;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderUpdateSyncInfoAction : IStagedOrderUpdateSyncInfoAction
    {
        public string Action { get; set; }

        public IChannelResourceIdentifier Channel { get; set; }

        public string ExternalId { get; set; }

        public DateTime? SyncedAt { get; set; }
        public StagedOrderUpdateSyncInfoAction()
        {
            this.Action = "updateSyncInfo";
        }
    }
}
