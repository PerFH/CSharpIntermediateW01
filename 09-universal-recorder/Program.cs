Recorder<String> stringRecorder = new Recorder<String>();
Recorder<int> intRecorder = new Recorder<int>();
stringRecorder.Add("Orbit");
Console.WriteLine(stringRecorder.Count);
Console.WriteLine(stringRecorder.Contains("Orbit"));
Console.WriteLine(stringRecorder.Contains("orbit"));
intRecorder.Add(7);
intRecorder.Add(7);
Console.WriteLine(intRecorder.Count);
Console.WriteLine(intRecorder.Contains(7));
intRecorder.Clear();
Console.WriteLine(intRecorder.Count);
Console.WriteLine(intRecorder.Contains(7));
Console.WriteLine(stringRecorder.Count);
Console.WriteLine(stringRecorder.Contains("Orbit"));

// TODO: Oppdater kallene når klassen er generalisert, og test med int.
