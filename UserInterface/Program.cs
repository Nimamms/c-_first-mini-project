using DotNetHW2;

public class Program
{ 
    User User_test = new User(" ",false,"","",0);
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("              1-sign in \n" +
                              "              2-sign up \n ");
            var inp = Console.ReadLine();
            if (inp == "1")
            {
                console.writeline("name : \n");
                console.readline();
                console.writeline("password : \n");
                User_test.sign_in();
            }
            else if (inp == "2")
            {
                
            }
            else
            {
                Console.WriteLine("Wrong input");
            }
        }
    }
    
}