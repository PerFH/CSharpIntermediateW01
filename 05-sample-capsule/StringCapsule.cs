public class StringCapsule
{
    private string _content = "";

    public StringCapsule(string content)
    {
        _content = content;
        // TODO: Oppbevar argumentet i feltet.
    }

    public string Read()
    {
        // TODO: Returner objektets innhold. Dette er en midlertidig returverdi.
        return _content;
    }

    public void Replace(string content)
    {
        _content = content;
        // TODO: Oppdater feltet.
    }
}
