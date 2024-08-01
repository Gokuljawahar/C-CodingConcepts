using System;

public struct Player
{
    public string Name { get; set; }
    public int YearsPlaying { get; set; }

    public Player(string name, int yearsPlaying)
    {
        Name = name;
        YearsPlaying = yearsPlaying;
    }

    public void print(){
        Console.WriteLine("name of the player" + Name);
        Console.WriteLine("years the player played" + YearsPlaying);
    }
}


public class Program{
    public static void Main(string[] args){
        Player player = new Player("sample",12);
        player.print();
        Player player2 = new Player("sample1",112);
        player2.print();
       
    }
}