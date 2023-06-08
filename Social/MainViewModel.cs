using Google.Apis.YouTube.v3.Data;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using static MainViewModel;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static UserViewModel;

namespace Social
{
    class OrdersViewModel
    {
        public class Orders
        {
            public string userId { get; set; }

            public string productId { get; set; }

            public string paymentMethod { get; set; }

            public string orderDate { get; set; }

            //public string status { get; set; }
        }
        public ObservableCollection <Orders> Order { get; set; }

        public OrdersViewModel() 
        {

            string connectionString = "Server=localhost;Database=shopping;Uid=root;Pwd= ;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM orders";
            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();

            Order = new ObservableCollection<Orders>();
            while (reader.Read())
            {
                Orders order = new Orders();
                order.userId = reader.GetString("userid");
                order.productId = reader.GetString("productid");
                order.orderDate = reader.GetString("orderDate");
                //order.status = reader.GetString("orderStatus");
                order.paymentMethod = reader.GetString("paymentMethod");
                Order.Add(order);
            }

            reader.Close();
            connection.Close();
        }
    }

    }

    class UserViewModel
    {
        public class Person
        {
            public string username { get; set; }
            public string password { get; set; }
            public string creationDate { get; set; }

        }

        public ObservableCollection <Person> People { get; set;}


        public UserViewModel()
        {
            string connectionString = "Server=localhost;Database=shopping;Uid=root;Pwd= ;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM admin";
            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();

            People = new ObservableCollection<Person>();
            while (reader.Read())
            {
                Person person = new Person();
                person.username = reader.GetString("username");
                person.password = reader.GetString("password");
                person.creationDate = reader.GetString("creationDate");
                People.Add(person);
            }

            reader.Close();
            connection.Close();
        }

    }


class PeopleViewModel
{

    public class People
    {
        public string id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        //public string password { get; set; }
        public string contactno { get; set; }
        public string shippingAddress { get; set; }
        public string shippingCity { get; set; }
        public string shippingPinCode { get; set; }
        public string shippingState { get; set; }

        public string billingCity { get; set; }
        //public string billingState { get; set; }
        public string billingAddress { get; set; }
    }


    public ObservableCollection<People> peoples { get; set; }


    public PeopleViewModel()
    {
        // Получение данных из базы данных
        string connectionString = "Server=localhost;Database=shopping;Uid=root;Pwd= ;";
        MySqlConnection connection = new MySqlConnection(connectionString);
        MySqlCommand command = connection.CreateCommand();
        command.CommandText = "SELECT * FROM users";
        //command.CommandText = "SELECT * FROM orders";
        connection.Open();
        MySqlDataReader reader = command.ExecuteReader();

        // Создание списка элементов данных
        peoples = new ObservableCollection<People>();
        while (reader.Read())
        {
            People people = new People();
            people.id = reader.GetString("id");
            people.name = reader.GetString("name");
            people.email = reader.GetString("email");
            //people.password = reader.GetString("pass");
            people.contactno = reader.GetString("contactno");
            people.shippingCity = reader.GetString("shippingCity");
            people.shippingState = reader.GetString("shippingState");
            people.shippingAddress = reader.GetString("shippingAddress");
            people.shippingPinCode = reader.GetString("shippingPincode");
            people.billingAddress = reader.GetString("billingAddress");
            people.billingCity = reader.GetString("billingCity");
            peoples.Add(people);
        }

    }



}

class MainViewModel
    {
   
        public class Catalog
        {
            public string id { get; set; }
            public string productName { get; set; }
            public string productCompany { get; set; }
            public string productDescription { get; set; }
            public string productPrice { get; set; }
            public string productImage1 { get; set; }
            public string productAvaibility { get; set; }
        }


        public ObservableCollection <Catalog> Catalogs { get; set; }
        
        
        public MainViewModel()
        {
            // Получение данных из базы данных
            string connectionString = "Server=localhost;Database=shopping;Uid=root;Pwd= ;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM products";
            //command.CommandText = "SELECT * FROM orders";
            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();

            // Создание списка элементов данных
            Catalogs = new ObservableCollection<Catalog>();
            while (reader.Read())
            {
                Catalog catalog = new Catalog();
                catalog.id = reader.GetString("id");
                catalog.productName = reader.GetString("productName");
                catalog.productCompany = reader.GetString("productCompany");
                catalog.productDescription = reader.GetString("productDescription");
                catalog.productPrice = reader.GetString("productPrice");
                catalog.productImage1 = reader.GetString("productImage1");
                catalog.productAvaibility = reader.GetString("productAvailability");
                Catalogs.Add(catalog);
            }

        }

       

    }


