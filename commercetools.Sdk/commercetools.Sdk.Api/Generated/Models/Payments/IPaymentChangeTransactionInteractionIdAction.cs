using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Api.Models.Payments.PaymentChangeTransactionInteractionIdAction))]
    public partial interface IPaymentChangeTransactionInteractionIdAction : IPaymentUpdateAction
    {
        string TransactionId { get; set; }

        string InteractionId { get; set; }
    }
}
