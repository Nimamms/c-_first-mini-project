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

        
        
        

        


    }
