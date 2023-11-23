using System.Xml;

namespace Wema.BIT.User
{
    public class User
    {
        // Remove the unnecessary JsonConvert property

        public static void Main(string[] args)
        {
            List<Payment> payment = new List<Payment>()
            {
                new Payment() {Id =1,UserId=1, Amount=1233},
                new Payment() {Id =2,UserId=2, Amount=1233},
                new Payment() {Id =3,UserId=3, Amount=1233},
                new Payment() {Id =4,UserId=4, Amount=1233},
                new Payment() {Id =5,UserId=5, Amount=1233}
            };

            List<Users> users = new List<Users>()
            {
                new Users() {Id =1, FirstName="Aluh", LastName="Johnson", Email="johnson@email.com", Payments=null},
                new Users() {Id =2, FirstName="Jim", LastName="Johnson", Email="johnson@email.com", Payments=payment.Where(x => x.UserId == 2).ToList()},
                new Users() {Id =3, FirstName="Mike", LastName="Johnson", Email="johnson@email.com", Payments=payment.Where(x => x.UserId == 3).ToList()},
                new Users() {Id =4, FirstName="Jide", LastName="Johnson", Email="johnson@email.com", Payments=payment.Where(x => x.UserId == 4).ToList()},
                new Users() {Id =5, FirstName="Tomi", LastName="Johnson", Email="johnson@email.com", Payments=payment.Where(x => x.UserId == 5).ToList()},
            };

            var userPayments = users.Where(x => x.Id == 1);
            var u = new List<User>();

            var json = JsonConvert.SerializeObject(userPayments, Formatting.Indented);

            foreach (var user in userPayments)
            {
                if (user.FirstName == "Tomi" || user.LastName == "Johnson") Console.WriteLine("First Name : " + user.FirstName + " Last Name : " + user.LastName);
            }
        }
    }

    internal class JsonConvert
    {
        internal static object SerializeObject(IEnumerable<Users> userPayments, Formatting indented)
        {
            throw new NotImplementedException();
        }
    }

    public class Users
    {
        public int Id { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Email { set; get; }
        public List<Payment> Payments { set; get; }
    }

    public class Payment
    {
        public int Id { set; get; }
        public int UserId { set; get; }
        public decimal Amount { set; get; }
        public User User { set; get; }
    }
}
