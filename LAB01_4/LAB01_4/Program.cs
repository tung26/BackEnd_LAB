using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using LAB01_4;

namespace Asynchronous
{
    class Program
    {
        public static List<User> users = new List<User>();
        public static HttpClient client = new HttpClient();

        public static async Task<List<User>> getUsers()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("https://680e54a2c47cb8074d92c651.mockapi.io/userLab");
                string data = await response.Content.ReadAsStringAsync();
                Console.WriteLine(data);
                var result = JsonSerializer.Deserialize<List<User>>(data);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception($"Cannot load the data!\nError: {ex.Message}");
            }
        }

        public static void showUsers()
        {
            foreach (var item in users)
            {
                Console.WriteLine(item.ToString());
            }
        }

        static async Task Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Loading...");

            try
            {
                users = await getUsers();
                Console.WriteLine("Load Success!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Load Failed! Error: {ex.Message}");
            }

            showUsers();
        }
    }
}
