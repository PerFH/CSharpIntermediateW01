using Microsoft.VisualBasic;

Console.WriteLine("Paired Beacons");
Beacon firstBeacon = new Beacon ("A");
Beacon secondBeacon = new Beacon ("B");
Pair<Beacon> beaconPair = new Pair<Beacon> (firstBeacon, secondBeacon);
Pair<int> intPair = new Pair<int> (12, 24);
Pair<string> stringPair = new Pair<string> ("North", "South");
PairDisplay.ShowPair(intPair);
PairDisplay.ShowPair(stringPair);
Console.WriteLine($"{beaconPair.First.Name}\n{beaconPair.Second.Name}");
Pair<int> intPair2 = new Pair<int> (8, 16);
PairDisplay.ShowPair(intPair);
PairDisplay.ShowPair(intPair2);
