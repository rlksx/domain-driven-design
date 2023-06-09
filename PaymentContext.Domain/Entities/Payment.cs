namespace PaymentContext.Domain.Entities;

public abstract class Payment
{
   public decimal Number { get; set; }
   public DateTime PaidDate { get; set; }
   public DateTime ExpireDate { get; set; }
   public decimal Total { get; set; }
   public decimal TotalPaid { get; set; }
   public string Document { get; set; }
   public string Payer { get; set; }
   public string Adress { get; set; }
   public string Email { get; set; }
}

public class BoletoPayment : Payment
{
   public string BarCode { get; set; }
   public string BoletoNumber { get; set; }
}


public class CreditCardPayment : Payment
{
   public string CardNumber { get; set; }
   public string CardHolderName { get; set; }
   public string LastTransactionNumber { get; set; }
}

public class PaypalPayment : Payment
{
   public string TransactionCode { get; set; }
}