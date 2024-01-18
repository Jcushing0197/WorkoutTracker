Project Proposal:
Application Description - a paragraph (3-4 sentences) explaining what your
application is and what it is supposed to do.
Application is a weight tracker for gym goers. They can input there personal
information to create there profile and then log there workouts by week so
they can keep track of what weights there using and see how they increase
as time goes on.

• Purpose - explain the purpose of your application - why is this something that
should be created, what value does it provide?
Many people who go to the gym seriously carry a notebook or use the notes
app on there phone to keep track of there weights. This app will make it easy
to have everything stored and be able to track without having pages of notes.

• Output - explain what type of output/information your application will output to
the terminal window
Application will output the users profile information and there weights by week
example:
Justyn Cushing
27 years old
150 lbs
Week 1:
Bench Press: 150 lbs
Squat: 250 lbs
Chest Press: 100 lbs
Week 2:
Bench Press: 150 lbs
Squat 260 lbs
Chest Press 110 lbs

• Data Storage - describe, generally, what data your application will store
Will store values such as name, exercise, weeks

---------------------------------------------------------------------------------------------------------------------
Initial Project Design:
public class User
{
public string UserName { get; set; }
public User(string userName)
{
UserName = userName;
}
}
public class Workout
{
public string Day { get; set; }
public string Exercise { get; set; }
public double Weight { get; set; }
public User User { get; set; }
public override string ToString()
{
return $"On {Day}, {User.UserName} performs {Exercise} with a weight of {Weight}
kg.";
}
}
public class WeeklyWorkoutTracker
{
private List<Workout> weeklyWorkouts;
public WeeklyWorkoutTracker()
{
weeklyWorkouts = new List<Workout>();
}
public void AddWorkout(User user, string day, string exercise, double weight)
{
Workout workout = new Workout
{
User = user,
Day = day,
Exercise = exercise,
Weight = weight
};
weeklyWorkouts.Add(workout);
}
public void DisplayWeeklyWorkouts()
{
foreach (var workout in weeklyWorkouts)
{
Console.WriteLine(workout);
}
}
}
class Program
{
static void Main()
{
WeeklyWorkoutTracker weeklyTracker = new WeeklyWorkoutTracker();
// Create a user
User user = new User("JohnDoe");
// Add workouts for the user
weeklyTracker.AddWorkout(user, "Monday", "Squats", 50);
weeklyTracker.AddWorkout(user, "Wednesday", "Bench Press", 40);
weeklyTracker.AddWorkout(user, "Friday", "Deadlifts", 60);
// Display the weekly workouts for the user
weeklyTracker.DisplayWeeklyWorkouts();
}
}
weeklyTracker.AddWorkout("Monday", "Squats", 50);
weeklyTracker.AddWorkout("Wednesday", "Bench Press", 40);
weeklyTracker.AddWorkout("Friday", "Deadlifts", 60);
weeklyTracker.DisplayWeeklyWorkouts();
}
}
Tables, fields/data types:
-Workouts
WorkoutID Int (primary key)
UserID int
Day varchar(50)
Exercise varchar(50)
Weight int
foreign key (userID) references Users(UserID) – allows a relationship between the 2
tables for the the association of workouts to a specific user
-Users
UserID Int (Primary key)
UserName varchar(50)


------------------------------------------------------------------------------------------------------------------------


Project Summary:
My project is a Weekly Workout Tracker. It allows users to track their weekly workouts, store them in a SQLite database, and retrieve the workout history.
Key Features:
1.	Database Interaction: Utilizes SQLite for database storage, creating tables to store workout details.
2.	Object-Oriented Design: Implements classes for User, WeeklyWorkoutTracker, Workout, and WorkoutDb.
3.	User Interaction: The main program prompts the user to add new workouts, displays the current workout list, and interacts with the database.
Challenges Faced:
•	I struggled a little with some of the code and had to simplify my original idea. I was thinking of things that are beyond my knowledge.
•	I also had a hard time getting the database to store user input at first.
Successes and Achievements:
•	Successful implementation of CRUD operations on the SQLite database.
•	The initial code went really well and I hardly had to make any changes from my week 2 into week 3

Project Requirements:
1.	Database Interaction:
•	Design Element: Utilizes a DatabaseConnector interface and an abstract class for database connection.
•	Implementation: Concrete class SQLiteDatabase implements the database connection.

2.	User Class:
•	Design Element: User class with a UserName property and a constructor.
•	Implementation: User class implemented with a constructor to initialize the UserName.

3.	WeeklyWorkoutTracker:
•	Design Element: Composition of List<Workout> for tracking weekly workouts.
•	Implementation: WeeklyWorkoutTracker class with methods to add workouts and display weekly workouts.

6.	Workout Class:
•	Design Element: Properties for Day, Exercise, Weight, and User with polymorphism.
•	Implementation: Workout class implemented with properties and ToString override.

4.	WorkoutDb:
•	Design Element: Database operations for creating tables, adding workouts, and retrieving all workouts.
•	Implementation: WorkoutDb class with methods to create tables, add workouts, and retrieve all workouts from the database.
This project effectively meets the course requirements by implementing database interaction, object-oriented design principles, and providing a user-friendly interface for tracking and displaying weekly workouts. 

