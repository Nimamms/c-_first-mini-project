namespace DotNetHW2;

    public class User
    {
        public string P_Name { get; set; }
        public bool P_is_admin { get; set; }
        public string P_Email { get; set; }
        public string P_Password { get; set; }
        public int P_Cash { get; set; }

        public User(string name, bool is_admin, string email, string password, int cash)
        {
            P_Name = name;
            P_is_admin = is_admin;
            P_Email = email;
            P_Password = password;
            P_Cash = cash;
        }

        public List<User> all_users = new List<User>();
        
        
        public void sign_up(string name, string email, string password, int cash)
        {
            all_users.Add(new User(name, false, email, password, cash));
        }

        public void sign_in(string name, string password )
        {
            User Nima = new User("Nima",true,"Nima@gmail.com","123",10000);
            bool flag = false;
            all_users.Add(Nima);
            for (int i = 0; i < all_users.Count; i++)
            {
                if (all_users[i].P_Name == name && all_users[i].P_Password == password)
                {
                    flag = true;
                    if(all_users[i].P_is_admin==true)
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
