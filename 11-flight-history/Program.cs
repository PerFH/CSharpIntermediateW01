History<string> history = new History<string>();
history.Add("Launch");
history.Add("Orbit");
List<string> snapshot = history.GetSnapshot();
Console.WriteLine(history.Count);
Console.WriteLine(snapshot.Count);
history.Add("Landing");
history.Clear();
Console.WriteLine(history.Count);
Console.WriteLine(snapshot.Count);
foreach (var item in snapshot)
{
    Console.WriteLine(item);
}

//history.Add(99)
//int compiler ikke når listen allerede er definert som en string
