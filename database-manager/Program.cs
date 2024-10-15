// CHANGES:
// 1. Imrpoved the UI


using System;
using System.Data.SqlClient;
using System.Text.Json;
using MySql.Data.MySqlClient;


namespace database_manager;

class Program
{


    static void Main(string[] args)
    {
        string jsonFilePath = "saved-db.json";

        string jsonString = File.ReadAllText(jsonFilePath);

        Database database = JsonSerializer.Deserialize<Database>(jsonString);

        Menu.Display();

        int menuChoice =  int.Parse(Console.ReadLine());
        switch(menuChoice)
        {
            case 1:
                Database.Connect();
                break;

            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
        }

        

    }

}


public class Database
{
    public static string ServerName {get; set;}
    public static string NameDb {get; set;}
    public static string Username {get; set;}
    public static string Password {get; set;}




    public static void Connect(){
        
    string connectionString = $"Server={Database.ServerName}; Database={Database.NameDb}; Uid={Database.Username}; Pwd={Database.Password};";

    using (MySqlConnection connection = new MySqlConnection(connectionString))
    {
        try
        {
            connection.Open();
            Console.WriteLine("Connection successful!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Connection failed: " + ex.Messeage);
        }

        //TODO: Something is wrong with the connecting function. This may be an Program or Server issue. NEEDS FIXING
    }
}


}

public class Menu
{
    public static void Display(){
        Console.WriteLine("=====VNOX-DATABASE-MANAGER====");
        Console.WriteLine("[1] Connect to the existing database");
        Console.WriteLine("[2] Add new database");
        Console.WriteLine("[3] Delete existing database connection");
        Console.WriteLine("[4] Direct connect");
        Console.Write("Choice: ");
    }
}



