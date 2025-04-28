using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01_4
{
    internal class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone {  get; set; }
        public string Id { get; set; }

        public User() { }

        public User(string userName, string passWord, string email, string phone, string id)
        {
            Console.WriteLine(userName);
            Id = id;
            this.Username = userName;
            this.Password = passWord;
            this.Email = email;
            this.Phone = phone;
        }

        public override string ToString()
        {
            return $"id: {Id} - username: {Username} - password: {Password} - email: {Email} - phone: {Phone}";
        }
    }
}
