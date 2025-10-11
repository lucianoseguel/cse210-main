using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hi! this is your Summary of your buy.");

        //First Client
        Client client_1 = new Client();
        client_1.SetClient(
    "Ricardo Darín",
    "Calle Falsa",
    "123",
    "Buenos Aires",
    "CABA",
    "Argentina"
);

        //Second Client
        Client client_2 = new Client();
        client_2.SetClient(
    "Homer J. Simpson",
    "Avenida Siempreviva",
    "742",
    "Springfield",
    "Desconocida",
    "EE.UU"
);

        //Third Client
        Client client_3 = new Client();
        client_3.SetClient(
    "Xuxa Meneghel",
    "Rua Dos Bobos",
    "1530",
    "São Paulo",
    "São Paulo",
    "Brasil"
);

        //------------Products-------------
        // Product 1
        Product product1 = new Product
        {
            _id = 101,
            _name = "Laptop Gamer Stellaris X1",
            _price = 1250.99f,
        };

        // Product 2
        Product product2 = new Product
        {
            _id = 102,
            _name = "Mecanic Keyboard RGB Chroma",
            _price = 85.50f,
        };

        // Product 3
        Product product3 = new Product
        {
            _id = 103,
            _name = "Mouse Wireless Ergonomic",
            _price = 25.00f,
        };

        // Product 4
        Product product4 = new Product
        {
            _id = 104,
            _name = "TV Curve 4K 27 In ",
            _price = 399.99f,
        };


        //------------------------MAKING ORDERS--------------------------
        Order order_1 = new Order();
        order_1.client = client_1; //Set client and products
        order_1.Addproduct(product4, 4);
        order_1.Addproduct(product1, 10);
        order_1.Addproduct(product3, 1);


        Order order_2 = new Order();
        order_2.client = client_1; //Set client and products
        order_2.Addproduct(product4, 4);
        order_2.Addproduct(product1, 6);
        order_2.Addproduct(product3, 7);


        Order order_3 = new Order();
        order_3.client = client_1; //Set client and products
        order_3.Addproduct(product4, 8);
        order_3.Addproduct(product1, 20);
        order_3.Addproduct(product3, 3);


        //------Display ORDERS--------
        order_1.DisplayOrderDetails();
        order_1.DisplaySendTicket();
        
        order_2.DisplayOrderDetails();
        order_2.DisplaySendTicket();

        order_3.DisplayOrderDetails();
        order_3.DisplaySendTicket();



    }

    public class Product
    {
        public int _id;

        public string _name;

        public float _price;

        public int _cuantity;

        public float GetTotalPrice()
        { //Get the total price

            return _price * _cuantity;
        }
        
        public void SetCuantity(int cuant)
        {
            _cuantity = cuant;
        }

    }

    public class Client
    {
        public string _name;

        public Direction _address;

        public void DisplayDirection()
        {
            Console.WriteLine(_address.GetWholeDirection());
        }

        public void SetClient (string name, string street, string number, string city, string province, string country)
        {
            _name = name;
            Direction address = new Direction();
            address.SetDirection(street,number,city,province,country);
            _address = address;
            
        }
    }

    public class Direction
    {
        private string _street;
        private string _number;
        private string _city;
        private string _province;
        private string _country;

        public bool InEuu()
        {
            if (_country != "EE.UU")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void SetDirection(string street, string number, string city, string province, string country)
        {
            _street = street;
            _number = number;
            _city = city;
            _province = province;
            _country = country;
        }

        public string GetWholeDirection() //return the whole direction
        {
            return $"Street: {_street} \n Number: {_number} \n City: {_city} \n Province / State: {_province} \n Country: {_country}";

        }
    }
    
    public class Order
    {
        List<Product> _Order = new List<Product>();
        public float _total;

        public Client client;


        public void Addproduct(Product toadd, int cuantity)
        {
            toadd._cuantity = cuantity;
            _Order.Add(toadd);
            
        }

        public void GetOrderPrice()
        //GEt the total cost of the order 
        {
            List<float> costs = new List<float>();
            for (int i = 0; i < _Order.Count(); i++)
            {
                costs.Add(_Order[i].GetTotalPrice());
            }

            if (client._address.InEuu() == true)
            {

                _total = costs.Sum() + 5;
                Console.WriteLine($"Tax in EE.UU ---> $5");
            }
            else
            {
                _total = costs.Sum() + 35;
                Console.WriteLine($"Tax out EE.UU ---> $35");
            }

        }

        public void DisplayOrderDetails()
        {            
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Client --> {client._name}");

            for (int i = 0; i < _Order.Count(); i++)
            {
                Console.WriteLine($"Product {_Order[i]._name} ${_Order[i]._price} --> {_Order[i]._cuantity}");
            }

            GetOrderPrice(); //Get the whole price of order
            
            Console.WriteLine($"Total: {_total}");

            Console.WriteLine("--------------------------------");

        }
        
        public void DisplaySendTicket()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"{client._name} \n {client._address.GetWholeDirection()}");
        }

    }
}