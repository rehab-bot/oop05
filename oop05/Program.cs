namespace oop05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region EX01
            //Circle circle = new Circle(5);
            // Rectangle rectangle = new Rectangle(4, 6);
            // circle.DisplayShapeInfo();
            // rectangle.DisplayShapeInfo(); 
            #endregion
            BasicAuthenticationService basicAuthenticationService = new BasicAuthenticationService()
            { Password = "password", Username = "admin", Role = "Administrator" };
           
            Console.WriteLine(basicAuthenticationService.AuthenticateUser());
        
            Console.WriteLine(basicAuthenticationService.AuthorizeUser());
        }
    }
}
