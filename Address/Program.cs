using System;

namespace Address
{
    public class Address
    {
        private string country;
        private string house;
        private string index;
        private string city;
        private int flat;
        private string street;
        private int entrance;



        public string Index { get => index; set => index = value; }
        public string House { get => house; set => house = value; }
        public int Flat { get => flat; set => flat = value; }
        public string Street { get => street; set => street = value; }
        public string Country { get => country; set => country = value; }
        public string City { get => city; set => city = value; }
        public int Entrance { get => entrance; set => entrance = value; }
        public override string ToString()
        {
            return $"{Index}, {Street} {House} {Entrance}, {City}; {Country}: {Flat}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address
            {
                Index = "08500",
                Country = "Ukraine",
                City = "Fastiv",
                Street = "Strokova",
                House = "3C",
                Entrance = 3,
                Flat = 20
            };

            Console.WriteLine(address.ToString());
        }
    }
}
