public class FlightLog
{
    private List<string> _entries = new List<string>();

    public int Count
    {
        get
        {
            return _entries.Count;
        }
    }

    public void AddEntry(string entry)
    {
        _entries.Add(entry);
    }

    public void ListClear()
    {
        _entries.Clear();
    }
}
