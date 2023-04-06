namespace PaymentContext.Domain.Entities;

public class Subscription
{
   private List<Payment> _payments;
   public Subscription(DateTime? expiredDate)
   {
      Active = true;
      CreateDate = DateTime.Now;
      LastUpdateDate = DateTime.Now;
      ExpiredDate = expiredDate;
      _payments = new List<Payment>();
   }

   public bool Active { get; private set; }
   public DateTime CreateDate { get; private set; }
   public DateTime LastUpdateDate { get; private set; }
   public DateTime? ExpiredDate { get; private set; }
   public IReadOnlyCollection<Payment> Payments { get; private set; }

   public void AddPayment(Payment payment)
   {
      _payments.Add(payment);
   }

   public void Activete()
   {
      Active = true;
      LastUpdateDate = DateTime.Now;
   }

   public void Inactivate()
   {
      Active = false;
      LastUpdateDate = DateTime.Now;
   }
}