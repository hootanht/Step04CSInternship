using System;
using System.Collections.Generic;
public class Robot
{
    static  HashSet<string> names = new HashSet<string>();
    Random rand = new Random();
    public Robot()
    {
        Reset();
    }
    public string Name
    {
        get;
        private set;
    }
    public void Reset()
    {
        do
        {
            Name = $"{(char)rand.Next(65, 91)}{(char)rand.Next(65, 91)}{rand.Next(0,10)}{rand.Next(0, 10)}{rand.Next(0, 10)}";
        } while (names.Contains(Name));
        names.Add(Name);
    }
   
}