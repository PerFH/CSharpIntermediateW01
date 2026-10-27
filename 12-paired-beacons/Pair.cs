public class Pair<T>
{
    private T _first;
    private T _second;
    public Pair (T first, T second)
    {
        _first = first;
        _second = second;
    }
    public T First => _first;
    public T Second => _second;
}
public static class PairDisplay
{
    public static void ShowPair<T>(Pair<T> pair)
    {
        Console.WriteLine(pair.First);
        Console.WriteLine(pair.Second);
    }
}