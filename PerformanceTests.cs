namespace CupOfT;

using System.Diagnostics;
//  This code tests the performance of the Methods in the Cup class.

public class PerformanceTest
{
    public static void RunPerformanceTests()
    {
        // Test 1: See how long it takes to do a setItem
        Console.WriteLine("\nPerformance Test 1 - SetItem");
        Stopwatch stopwatch = new Stopwatch();
        Cup<int> testBox = new Cup<int>(3);
        stopwatch.Start();
        testBox.SetDataValue(4);
        stopwatch.Stop();
        Console.WriteLine($"Time taken to set a value: {stopwatch.ElapsedTicks} ticks");
        
        // see how long it takes to do a GetItem
        Console.WriteLine("\nPerformance Test 2 - GetItem");
        stopwatch.Restart(); // clears time and start timer again
        var x = testBox.GetDataValue();
        stopwatch.Stop();
        Console.WriteLine($"Time taken  to get a data value: {stopwatch.ElapsedTicks} ticks");    
        
    }
}
