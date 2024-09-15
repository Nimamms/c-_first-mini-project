namespace DotNetHW2;


    //abstract if we don't want to use that object
    public abstract class Item
    {
        public string P_name { get; set; }
        public int P_price { get; set; }
        public int P_quantity { get; set; }

        protected Item(string name, int price, int quantity)
        {
            P_name = name;
            P_price = price;
            P_quantity = quantity;
        }

    }

    public class Note_book : Item
    {
        public int Num_pages { get; set; }

        public Note_book(string name, int price, int quantity, int numPages)
            : base(name, price, quantity)
        {
            Num_pages = numPages;
        }
    }

    public class pen : Item
    {
        public string P_model;
        public pen(string name, int price, int quantity, int numPages ,string model)
         : base(name, price, quantity)
        {
            P_model = model;
        }
    }
    

