using System.Collections;
using DotNetHW2;

namespace Service;

public class ItemService : IItemService
{
    public List<User> AllUsers = new List<User>();
    private ArrayList items = new ArrayList();

    public bool additem(Item item)
    {
        items.Add(item);
        return true;
    }
    public void sign_up(string name, string email, string password, int cash)
    {
        AllUsers.Add(new User(name, false, email, password, cash));
        Console.WriteLine("you added to the list successfully");
    }
    public void sign_in(string name, string password )
    {
        User Nima = new User("Nima",true,"Nima@gmail.com","123",10000);
        bool flag = false;
        AllUsers.Add(Nima);
        for (int i = 0; i < AllUsers.Count; i++)
        {
            if (AllUsers[i].P_Name == name && AllUsers[i].P_Password == password)
            {
                flag = true;
                if(AllUsers[i].P_is_admin==true)
                {
                    Console.WriteLine("is admin \n");
                    // admin_window();
                }
                else
                {
                    // user_window();
                }
            }
        }

        if (!flag)
        {
            Console.WriteLine(" your name or password is incorrect.");
        }
    }
}