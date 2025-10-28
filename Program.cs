Task 1 - CAR    
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("BMW", 150);
            myCar.Drive();
            myCar.Speed = 400;
            myCar.Drive(); 
            myCar.Speed = -50;
            myCar.Drive();
        }
    }
}
Task 2 - Phone 
        static void Main(string[] args)
        {
            Phone myPhone = new Phone("Samsung", 150); 
            myPhone.Use(); 
            myPhone.Use(); 
            myPhone.Use(); 
        }
    }
}
Task 3 - Book
        static void Main(string[] args)
        {
            try
            {
                Book myBook = new Book(""); 
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message); 
            }
            Book warAndPeace = new Book("Война и мир");
            warAndPeace.Pages = 1200; 
            warAndPeace.Info(); 
            Book shortHistory = new Book("Краткая история");
            shortHistory.Info(); 
        }
    }
}
Task 4 - Player
        static void Main(string[] args)
        {
            try
            {
                Player player = new Player("Alex", 0, 100); 
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Player player2 = new Player("Alex", 5, 70);
            player2.TakeDamage(20);
            player2.TakeDamage(40); 
            player2.TakeDamage(10);
        }
    }
}
Task 5 - Product
    static void Main(string[] args)
    {
        try
        {
            Product laptop = new Product("Ноутбук", 1000, 20);
            laptop.Show();
            laptop.Discount = 10;
            laptop.Show();
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        try
        {
            Product invalidProduct = new Product("Неправильный продукт", -100, 20);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
