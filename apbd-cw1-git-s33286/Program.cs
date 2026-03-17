using System.Text.RegularExpressions;
using apbd_cw1_git_s33286;

try{
    Console.WriteLine("Wprowadź liczby dla statystyki");
    String input =  Console.ReadLine();
    int[] numbers = Regex.Split(input.Trim(),@"\D+")
                        .Select(x=>int.Parse(x)).ToArray();
                        
    var statisticsHelper = new StatisticsHelper(numbers);
    
    Console.WriteLine("śriednia wartosć twoich liczb: " + 
                      statisticsHelper.CalculateAverage());
    
    Console.WriteLine("max wartosć z twoich liczb: " + 
                      statisticsHelper.CalculateMax());
    
    Console.WriteLine("min wartosć z twoich liczb: " + 
                      statisticsHelper.CalculateMin());
    
    Console.WriteLine("git feature-conflict test");
}
catch (FormatException)
{
    Console.WriteLine("Error: Można wprowadzać tylko liczby.");
}