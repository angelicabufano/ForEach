using System.Diagnostics.CodeAnalysis;

namespace ForEach;

internal class Program {
    static void Main(string[] args) {

        int[] nbrs = {
            754, 233, 509, 792, 700, 596, 833, 658, 998, 742,
            187, 754, 308, 914, 489, 867, 717, 586, 929, 467,
            460, 241, 770, 324, 599, 259, 120, 800, 336, 609,
            690, 134, 598, 249, 282, 574, 334, 956, 659, 214,
            435, 643, 809, 874, 906, 620, 328, 369, 426, 561
        };

        int highest = 99;       // int.MinValue
        int lowest = 1000;      // int.MaxValue
        int sum = 0;
        // int average = 0;        // add and divide by 50

        foreach(var nbr in nbrs) { 

            if(nbr > highest) {
                highest = nbr;
            }
            if(nbr < lowest) {
                lowest = nbr;
            }
            
            sum += nbr;           // sum = sum + nbr;
        }

        var average = sum / nbrs.Length;        // average = sum / 50;         // can also do {sum / nbrs.Length} on the print line instead of {average}

        Console.WriteLine($"The highest number is {highest}, the lowest number is {lowest}, and the average is {average}.");

    }
}
