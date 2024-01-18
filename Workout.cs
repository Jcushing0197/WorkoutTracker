/* Justyn Cushing
12/30/23
Course Project Week 3 */
using System;
using System.Data.SQLite;
using System.Collections.Generic;

//composition, access specidfier, and constructor
public class Workout
{
    public string? Day { get; set; }
    public string? Exercise { get; set; }
    public double Weight { get; set; }
    public User? User { get; set; }

    //polymorphism and override
    public override string ToString()
    {
        return $"On {Day}, {User?.UserName} performed {Exercise} with a weight of {Weight} lbs.\n";
    }
}
