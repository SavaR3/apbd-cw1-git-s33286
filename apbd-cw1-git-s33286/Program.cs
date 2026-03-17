using System.Text.RegularExpressions;
using apbd_cw1_git_s33286;

try{
    Console.WriteLine("Wprowadź liczby dla statystyki");
    String input =  Console.ReadLine();
    int[] numbers = Regex.Split(input,@"\d+")
                        .Select(x=>int.Parse(x)).ToArray();
                        
    var statisticsHelper = new StatisticsHelper(numbers);
}
catch (FormatException)
{
    Console.WriteLine("Error: Można wprowadzać tylko liczby.");
}