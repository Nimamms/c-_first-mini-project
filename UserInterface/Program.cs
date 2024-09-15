using DotNetHW2;

public class Program
{ 
    public static void Main(string[] args)
    {
        User User_test = new User(" ",false,"","",0);

        
        while (true)
        {
            Console.WriteLine("              1-sign in \n" +
                              "              2-sign up \n ");
            var inp = Console.ReadLine();
            if (inp == "1")
            {
                Console.WriteLine("name : \n");
                string name = Console.ReadLine();
                Console.WriteLine("password : \n");
                string pass = Console.ReadLine();
                
                User_test.sign_in(name , pass);
            }
            else if (inp == "2")
            {
                Console.WriteLine("name : \n");
                string name = Console.ReadLine();
                Console.WriteLine("password : \n");
                string pass = Console.ReadLine();
                Console.WriteLine("gmail : \n");
                string gmail = Console.ReadLine();
                Console.WriteLine("cash : \n");
                string inpp = Console.ReadLine();
                int l_cash = Convert.ToInt32(inpp);
                User_test.sign_up(name, pass, gmail, l_cash);
                Console.WriteLine("you added successfully \n");
                
            }
            else
            {
                Console.WriteLine("Wrong input");
            }
        }
    }
    
}