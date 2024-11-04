// Inheritance is taking existing properties from another class and applying it to a child class.
class Grandma
{
    public string eyeColor = "brown eyes";
}
class Mom : Grandma
{
    public int age = 35;
    public string hairColor = "blonde hair";
    public void speak()
    {
        Console.WriteLine("Hello! How are you?");
    }
}
class Child : Mom
{
    public int age = 8;
    private string secret = "I stole a cookie from mom";
}
class Program
{
    static void Main(string[] args)
    {
        Child child1 = new Child();
        Console.WriteLine(child1.eyeColor);  // Inherited from Grandma
        Console.WriteLine(child1.hairColor); // Inherited from Mom
        Console.WriteLine(child1.age);       // Defined in Child
        child1.speak();                      // Method inherited from Mom


    }
}
