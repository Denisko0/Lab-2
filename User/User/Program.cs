using System;

namespace User
{
    public class User
    {
        private string name;
        private string surname;
        private int age;
        private readonly DateTime joinDate = DateTime.Now;
        private string login;

        public User(string name, string surname, int age, string login)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Login = login;
        }

        public DateTime JoinDate => joinDate;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Age { get => age; set => age = value; }
        public string Login { get => login; set => login = value; }

        public override string ToString()
        {
            return $"Name: {Name,-3} Surname: {Surname,-2} Login: {Login,-2} Age: {Age,-2} Joined: {JoinDate.ToShortDateString()}";
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Ilon", "Mask", 50, "IlonMask228");
            Console.WriteLine(user.ToString());
        }
    }
}
