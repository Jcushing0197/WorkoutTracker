using System;
using System.Data.SQLite;
using System.Collections.Generic;
public class SQLiteDatabase
{
    //implementation of Connect method using SQLite
    public static SQLiteConnection Connect(string database)
    {
        string cs = @"Data Source=" + database;
        SQLiteConnection conn = new SQLiteConnection(cs);

        try
        {
            conn.Open();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        return conn;
    }
}