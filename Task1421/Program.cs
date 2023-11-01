using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] words = { "Обезьяна", "Лягушка", "Кот", "Собака", "Черепаха" };

        var wordsInfo = words.Select(w =>
                new
                {  
                    Name = w,
                    Length = w.Length 
                })
            .OrderBy(word => word.Length); 



        foreach (var word in wordsInfo)
            Console.WriteLine($"{word.Name} состоит из {word.Length} букв");
    }
}