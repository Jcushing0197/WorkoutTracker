/* Justyn Cushing
12/30/23
Course Project Week 3 */
using System;
using System.Data.SQLite;
using System.Collections.Generic;
public class Program
{
    public static void Main(string[] args)
    {
        const string dbName = "WeeklyWorkout.db";
        Console.WriteLine("\nWeekly Workout Tracker Database Interactions\n");
        SQLiteConnection conn = SQLiteDatabase.Connect(dbName);

        if (conn != null)
        {
            WorkoutDb.CreateTable(conn);

            WeeklyWorkoutTracker weeklyTracker = new WeeklyWorkoutTracker();

            // Create a user
            User user = new User("Justyn Cushing");

            // Add workouts for the user
            weeklyTracker.AddWorkout(user, "Monday", "Squats", 50);
            weeklyTracker.AddWorkout(user, "Wednesday", "Bench Press", 40);
            weeklyTracker.AddWorkout(user, "Friday", "Deadlifts", 60);

            Console.Write("Would you like to add a new workout day to your list? (y/n): ");
            char response = Console.ReadKey().KeyChar;

            if(response == 'y' || response == 'Y')
            {
                Console.WriteLine("\n"); // New line for clarity

                // Prompt for new workout details
                Console.Write("Enter the day of the week: ");
                string newDay = Console.ReadLine();

                Console.Write("Enter the exercise: ");
                string newExercise = Console.ReadLine();

                Console.Write("Enter the weight: ");
                double newWeight;
                while (!double.TryParse(Console.ReadLine(), out newWeight))
                {
                    Console.Write("Invalid input. Please enter a valid weight: ");
                }

                // Add the new workout
                weeklyTracker.AddWorkout(user, newDay, newExercise, newWeight);

                // Add new workout to the database
                WorkoutDb.AddWorkout(conn, weeklyTracker.DisplayWeeklyWorkouts().Last());
            }
            else if (response == 'n' || response == 'N')
            {
                Console.WriteLine("\nThank you for your resonse, here is your tracker.");
            }

            // Display all workouts from the database
            Console.WriteLine("\nAll Workouts in the Database");
            PrintWorkouts(WorkoutDb.GetAllWorkouts(conn));
        }
    }
    private static void PrintWorkouts(List<Workout> workouts)
    {
        foreach (var workout in workouts)
        {
            Console.WriteLine(workout);
        }
    }
}