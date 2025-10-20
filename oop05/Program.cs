namespace oop05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region EX01
            Circle circle = new Circle(5);
            Rectangle rectangle = new Rectangle(4, 6);
            circle.DisplayShapeInfo();
            rectangle.DisplayShapeInfo();
            #endregion
            #region EX02
            //BasicAuthenticationService basicAuthenticationService = new BasicAuthenticationService()
            //{ Password = "password", Username = "admin", Role = "Administrator" };

            //Console.WriteLine(basicAuthenticationService.AuthenticateUser());

            //Console.WriteLine(basicAuthenticationService.AuthorizeUser());
            #endregion
            #region EX03
            //SmsNotificationService smsNotificationService = new SmsNotificationService();
            //PushNotificationService pushNotificationService = new PushNotificationService();
            //EmailNotificationService emailNotificationService = new EmailNotificationService();
            //smsNotificationService.SendNotification("+1234567890", "Your order has been shipped.");
            //pushNotificationService.SendNotification("user_device_token", "You have a new message.");
            //emailNotificationService.SendNotification("rehabomar789@gmail.com", "you have an Email ");
            #endregion



        }
    }
}
