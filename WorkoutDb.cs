using System;
using System.Data.SQLite;
using System.Collections.Generic;

// Composition, Access specifier, and Constructors
public class WorkoutDb
{
    public static void CreateTable(SQLiteConnection conn)
    {
        // SQL statement for creating a new table
        string sql =
            "CREATE TABLE IF NOT EXISTS Workouts (\n"
            + " ID integer PRIMARY KEY\n"
            + " ,User varchar(50)\n"
            + " ,Day varchar(20)\n"
            + " ,Exercise varchar(50)\n"
            + " ,Weight real);";

        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        cmd.ExecuteNonQuery();
    }

    // Method using Composition and Constructors
    public static void AddWorkout(SQLiteConnection conn, Workout workout)
    {
        string sql = string.Format(
            "INSERT INTO Workouts(User, Day, Exercise, Weight) "
            + "VALUES('{0}','{1}','{2}',{3})",
            workout.User.UserName, workout.Day, workout.Exercise, workout.Weight);
        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        cmd.ExecuteNonQuery();
    }

    // Method using Composition, Access specifier, and Constructors
    public static List<Workout> GetAllWorkouts(SQLiteConnection conn)
    {
        List<Workout> workouts = new List<Workout>();
        string sql = "SELECT * FROM Workouts";
        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = sql;

        SQLiteDataReader rdr = cmd.ExecuteReader();

        while (rdr.Read())
        {
            workouts.Add(new Workout
            {
                User = new User(rdr.GetString(1)),
                Day = rdr.GetString(2),
                Exercise = rdr.GetString(3),
                Weight = rdr.GetDouble(4)
            });
        }

        return workouts;
    }
}