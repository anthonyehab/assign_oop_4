using assign_oop_4;
using System;
using System.Runtime.Intrinsics.X86;
using static System.Net.Mime.MediaTypeNames;

namespace demo_oop_4
{

    class program
    {

       
        static void main(string[] args)
        {
            #region part 1

            #region 1.question 1
            //            What is the primary purpose of an interface in C#?
            //a) To provide a way to implement multiple inheritance
            //b) To define a blueprint for a class  //this is the aswer 
            //c) To declare abstract methods and properties
            //d) To create instances of objects

            #endregion
            #region 2.question 2
            //            Which of the following is NOT a valid access modifier for interface members in C#?
            //a) private  // this the answer
            //b) protected
            //c) internal
            //d) public

            #endregion
            #region 3.question 3
            //Can an interface contain fields in C#?
            //a) Yes
            //b) No // this is the answer
            //c) Only if they are static
            //d) Only if they are readonly

            #endregion
            #region 4.question 4
            //            In C#, can an interface inherit from another interface?
            //a) No, interfaces cannot inherit from each other
            //b) Yes, interfaces can inherit from multiple interfaces // this is the answer
            //c) Yes, but only if they have the same methods
            //d) Only if the interfaces are in the same namespace

            #endregion
            #region 5.question 5
            //Which keyword is used to implement an interface in a class in C#?
            //a) inherit
            //b) use
            //c) extends
            //d) implements //this is the answer


            #endregion
            #region 6. question 6
            //Can an interface contain static methods in C#?
            //a) Yes  // this is the answer
            //b) No
            //c) Only if the interface is sealed
            //d) Only if the methods are private

            #endregion
            #region 7. question 7
            //In C#, can an interface have explicit access modifiers for its members?
            //a) Yes, for all members
            //b) No, all members are implicitly public // this is the answer
            //c) Yes, but only for abstract members
            //d) Only if the interface is sealed

            #endregion
            #region 8.question 8
            //            What is the purpose of an explicit interface implementation in C#?
            //a) To hide the interface members from outside access
            //b) To provide a clear separation between interface and class members // THIS IS the answer
            //c) To allow multiple classes to implement the same interface
            //d) To speed up method resolution

            #endregion
            #region 9. question 9
            //What is the purpose of an explicit interface implementation in C#?
            //            a) To hide the interface members from outside access // this is the answer
            //            b) To provide a clear separation between interface and class members
            //c) To allow multiple classes to implement the same interface
            //d) To speed up method resolution

            #endregion
            #region 10. question 10
            //How can a C# class implement multiple interfaces?
            //            a) By using the "implements" keyword
            //            b) By using the "extends" keyword
            //            c) By separating interface names with commas // this is the answer
            //d) A class cannot implement multiple interfaces


            #endregion
            #endregion
            #region part 2
            #region 1. question 1
            /////Define an interface named IShape with a property Area and a method DisplayShapeInfo.Create two interfaces, ICircle and IRectangle, that inherit from IShape.Implement these interfaces in classes Circle and Rectangle. Test your implementation by creating instances of both classes and displaying their shape information.
            //circle circle = new circle { Radius = 5.0 };
            //rectangle rectangle = new rectangle { Length = 4.0, Width = 6.0 };


            //circle.DisplayShapeInfo();
            //Console.WriteLine();
            //rectangle.DisplayShapeInfo();

            #endregion
            #region 2. question 2
            IAuthenticationService authService = new BasicAuthenticationService();

           
            string username = "admin";
            string password = "password";
            bool isAuthenticated = authService.AuthenticateUser(username, password);
            Console.WriteLine($"User {username} is authenticated: {isAuthenticated}");


            string role = "admin";
            bool isAuthorized = authService.AuthorizeUser(username, role);
            Console.WriteLine($"User {username} is authorized for role {role}: {isAuthorized}");
            #endregion
            #region 3. question 3
            //INotificationService emailService = new EmailNotificationService();
            //INotificationService smsService = new SmsNotificationService();
            //INotificationService pushService = new PushNotificationService();

          
            //string recipient = "the main recipient";
            //string message = "Hello, this is a  notification.";

            //emailService.SendNotification(recipient, message);
            //smsService.SendNotification(recipient, message);
            //pushService.SendNotification(recipient, message);
            #endregion
            #endregion
        }



}

}