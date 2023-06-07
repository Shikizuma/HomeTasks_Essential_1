namespace Task6
{
    internal class Program
    {
        /*
         Завдання 6

        Використовуючи Visual Studio, створіть проект за шаблоном Console Application. Потрібно: Створити клас із ім'ям Address. 
        У тілі класу потрібно створити поля: index, country, city, street, house, apartment. 
        Для кожного поля створити властивість з двома методами доступу. Створити екземпляр класу Address. 
        У поля екземпляра записати інформацію про поштову адресу. Виведіть на екран значення полів, що описують адресу.

         */

        class Address
        {
            private string index;

            public string Index
            {
                get { return index; }
                set { index = value; }
            }

            private string country;

            public string Country
            {
                get { return country; }
                set { country = value; }
            }

            private string city;

            public string City
            {
                get { return city; }
                set { city = value; }
            }

            private string street;

            public string Street
            {
                get { return street; }
                set { street = value; }
            }

            private string house;

            public string House
            {
                get { return house; }
                set { house = value; }
            }

            private string apartment;

            public string Apartment
            {
                get { return apartment; }
                set { apartment = value; }
            }

            public void Show()
            {
                Console.WriteLine("Index: " + Index);
                Console.WriteLine("Country: " + Country);
                Console.WriteLine("City: " + City);
                Console.WriteLine("Street: " + Street);
                Console.WriteLine("House: " + House);
                Console.WriteLine("Apartment: " + Apartment);

            }

        }

        static void Main(string[] args)
        {
            Address address = new Address();
            address.Index = "12345";
            address.Country = "Україна";
            address.City = "Київ";
            address.Street = "Вулиця Шевченка";
            address.House = "10";
            address.Apartment = "5";

            address.Show();
        }
    }
}