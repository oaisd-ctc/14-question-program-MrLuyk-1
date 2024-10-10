using System;

public class Program
{
    public static void Main(string[] args)
    {
        
        
        
        Console.WriteLine("What is your Name?");
        string?  name = Console.ReadLine();

        Console.WriteLine("How old are you?");
        string?  age = Console.ReadLine();

        Console.WriteLine("What color are your eyes?");
        string?  ecolour = Console.ReadLine();

        Console.WriteLine("What is your hair colour?");
        string?  hcolour = Console.ReadLine();

        Console.WriteLine("Have you ever seen the inside of a Turkish prison?");
        string?  turkish = Console.ReadLine();

        Console.WriteLine("What is your favorite colour?");
        string?  fcolour = Console.ReadLine();

        Console.WriteLine("What is your favorite tv show or movie?");
        string?  tvmovie = Console.ReadLine();

        Console.WriteLine("What is the airspeed velosity of an unladen swallow?");
        string?  velosity = Console.ReadLine();

        Console.WriteLine("What is your favorite class?");
        string?  fclass = Console.ReadLine();

        Console.WriteLine("What is your favotire holiday?");
        string?  fholiday = Console.ReadLine();

        Console.WriteLine("What is your favorite season?");
        string?  fseason = Console.ReadLine();

        Console.WriteLine("What is your dream job?");
        string?  job = Console.ReadLine();

        int agePlusFive = int.Parse(age);

        Console.WriteLine("How many siblings do you have?");
        string?  siblings = Console.ReadLine();
        int sibling = int.Parse(siblings);
        if (sibling >= 2){
            Console.WriteLine("My friend's name is " + name + ". " + name + " is " + age + " years old. " + name + 
                            "'s eye colour is " + ecolour + ". " + name + "'s hair colour is " + hcolour + ". " + name +
                            " might have been to a Turkish prison. " + name + "'s favorite color is " + fcolour + ". " + name +
                            "'s favorite watchable thing is " + tvmovie + ". " + name + " does not know the airspeed velosity of an unladen swallow. "
                             + name + "'s favorite class is " + fclass + ". " + name + "'s favorite holiday is boxing day." + name +
                             "'s favorite season is " + fseason + ". " + name + "'s dream job is " + job + ". " + name + 
                            " will be " + (agePlusFive + 5) + " in five years. " + name + " has siblings");

        }
        else if (sibling == 1){
            Console.WriteLine("My friend's name is " + name + ". " + name + " is " + age + " years old. " + name + 
                            "'s eye colour is " + ecolour + ". " + name + "'s hair colour is " + hcolour + ". " + name +
                            " might have been to a Turkish prison. " + name + "'s favorite color is " + fcolour + ". " + name +
                            "'s favorite watchable thing is " + tvmovie + ". " + name + " does not know the airspeed velosity of an unladen swallow. "
                             + name + "'s favorite class is " + fclass + ". " + name + "'s favorite holiday is boxing day." + name +
                             "'s favorite season is " + fseason + ". " + name + "'s dream job is " + job + ". " + name + 
                            " will be " + (agePlusFive + 5) + " in five years. " + name + " has one sibling");
        }
        else {
            Console.WriteLine("My friend's name is " + name + ". " + name + " is " + age + " years old. " + name + 
                            "'s eye colour is " + ecolour + ". " + name + "'s hair colour is " + hcolour + ". " + name +
                            " might have been to a Turkish prison. " + name + "'s favorite color is " + fcolour + ". " + name +
                            "'s favorite watchable thing is " + tvmovie + ". " + name + " does not know the airspeed velosity of an unladen swallow. "
                             + name + "'s favorite class is " + fclass + ". " + name + "'s favorite holiday is boxing day." + name +
                             "'s favorite season is " + fseason + ". " + name + "'s dream job is " + job + ". " + name + 
                            " will be " + (agePlusFive + 5) + " in five years. " + name + " has no siblings");
        }
    }
}