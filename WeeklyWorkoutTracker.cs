/* Justyn Cushing
12/30/23
Course Project Week 3 */

public class WeeklyWorkoutTracker
{
    //Composition of list<workout>
    private List<Workout> weeklyWorkouts;

    //constructor
    public WeeklyWorkoutTracker()
    {
        weeklyWorkouts = new List<Workout>();
    }

    //method using composition and constructor
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

    public List<Workout> DisplayWeeklyWorkouts()
    {
        return weeklyWorkouts;
    }
}