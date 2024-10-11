using System;
using System.Data.SqlClient;
using System.Text.Json;

namespace database_manager;

class Program
{
    static void Main(string[] args)
    {
        menuDisplay();
        int menuChoice =  int.Parse(Console.ReadLine());
        switch(menuChoice)
        {
            case 1:
                System.Console.WriteLine("hey");
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

        database.connect();
    }

    static void menuDisplay(){
        Console.WriteLine("=====VNOX-DATABASE-MANAGER====");
        Console.WriteLine("[1] Connect to the existing database");
        Console.WriteLine("[2] Add new database");
        Console.WriteLine("[3] Delete existing database connection");
        Console.WriteLine("[4] Direct connect");
        }
}


class database
{
    public static void connect(){

    }

}

