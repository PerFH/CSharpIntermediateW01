Console.WriteLine("Typed Lockers");
Locker<string> StringLocker = new Locker<string>("Beacon");
Locker<int> IntLocker = new Locker<int>(42);
Console.WriteLine(StringLocker.Read());
Console.WriteLine(IntLocker.Read());
StringLocker.Replace("Relay");
IntLocker.Replace(99);
Console.WriteLine(StringLocker.Read());
Console.WriteLine(IntLocker.Read());
//IntLocker.Replace("Nittini")