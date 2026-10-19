int firstCapacity = 12;
int firstUsedCapacity = 5;
int secondCapacity = 20;
int secondUsedCapacity = 8;
Console.WriteLine($"Remaining: {CalculateRemainingCapacity(firstCapacity, firstUsedCapacity)}");
Console.WriteLine($"Remaining: {CalculateRemainingCapacity(secondCapacity, secondUsedCapacity)}");
// TODO: Trekk ut beregningen i en statisk metode.

static int CalculateRemainingCapacity(int capacity, int usedCapacity)
{
    int remainingCapacity = capacity - usedCapacity;
    return remainingCapacity;    
}
