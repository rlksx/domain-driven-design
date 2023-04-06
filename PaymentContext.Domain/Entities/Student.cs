namespace PaymentContext.Domain.Entities;
/* single responsability principle */

public class Student
{
   public string FirstName { get; private set; }
   public string LastName { get; private set; }
   public string Document { get; private set; }
   public string Email { get; private set; }
   public string Adresss { get; private set; }
   public List<Subscription> Subscriptions { get; set; }

   public Student(string firstName, string lastName, string document, string email)
   {
      FirstName = firstName;
      LastName = lastName;
      Document = document;
      Email = email;
   }

   public void AddSubscription(Subscription subscription)
   {
      foreach (var sub in Subscriptions)
         sub.Inactivate();

      Subscriptions.Add(subscription);
   }
}