using System;

namespace CWHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Room room = new Room("Kitchen");
            room.AddPerson(new Person("Hans"));
            room.AddPerson(new Person("Peter"));
            room.AddPerson(new Person("Marry"));
            room.WhoIsInTheRoom();
        }
    }
}
