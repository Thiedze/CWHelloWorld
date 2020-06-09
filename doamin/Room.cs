using System;
using System.Collections.Generic;

public class Room 
{

    private string name;

    private List<Person> persons;

    public Room(string name) 
    {
        this.name = name;    
        this.persons = new List<Person>();
    }

    public void AddPerson(Person person) 
    {
        this.persons.Add(person);
    } 

    public void WhoIsInTheRoom() 
    {
        foreach (Person person in this.persons)
        {
            Console.WriteLine(person.GetName());
        }

        Console.WriteLine("are sitting in the " + this.name);
    }

}