/* Justyn Cushing
12/30/23
Course Project Week 3 */
using System;
using System.Data.SQLite;
using System.Collections.Generic;

//Access specifier and constructor 
public class User
{
    //Property with public access specifier
    public string UserName { get; set; }

    //Constructor
    public User(string userName)
    {
        UserName = userName;
    }
}
