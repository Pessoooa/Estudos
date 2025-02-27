using System;
using Dapper;
using Microsoft.Data.SqlClient;
using Blog.Models;
using Dapper.Contrib.Extensions;

namespace Blog
{
    class Program
    {
        private const string  CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=True;";
        static void Main(string[] args)
        {
            //ReadUser();
            //CreateUser();
            //UpdateUser();
            //DeleteUser();
        }

        public static void ReadUsers()
        {
            using(var connection = new SqlConnection(CONNECTION_STRING))
            {
                var users = connection.GetAll<User>();

                foreach(var user in users){
                    Console.WriteLine(user.Name);
                }
            }

        }

        public static void ReadUser()
        {
            using(var connection = new SqlConnection(CONNECTION_STRING))
            {
                var user = connection.Get<User>(1);
                    Console.WriteLine(user.Name);
            }

        }

        public static void CreateUser()
        {
            var user = new User()
            {
                Bio = "8x Microsoft MVP",
                Email = "andre@balta.io",
                Image = "https://balta.io/andrebaltieri.jpg",
                Name = "André Baltieri",
                Slug = "andre-baltieri",
                PasswordHash = Guid.NewGuid().ToString()
            };

            using(var connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Insert<User>(user);
                Console.WriteLine("Cadastro Realizado.");
            }

        }

        public static void UpdateUser()
        {
            var user = new User()
            {
                Id=2,
                Bio = "Equipe | Balta",
                Email = "andre@balta.io",
                Image = "https://balta.io/andrebaltieri.jpg",
                Name = "André Baltieri",
                Slug = "andre-baltieri",
                PasswordHash = Guid.NewGuid().ToString()
            };

            using(var connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Update<User>(user);
                Console.WriteLine("Atualização Realizada.");
            }

        }

        public static void DeleteUser()
        {
            using(var connection = new SqlConnection(CONNECTION_STRING))
            {
                var user = connection.Get<User>(2);
                connection.Delete<User>(user);
                Console.WriteLine("Exclusão Realizada.");
            }

        }
    }
}