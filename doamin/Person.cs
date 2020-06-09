public class Person 
{
    private string name;

    public Person() {
        name = "unkown";
    }

    public Person(string name) {
        this.name = name;
    }

    public string GetName() 
    {
        return this.name;
    }
}