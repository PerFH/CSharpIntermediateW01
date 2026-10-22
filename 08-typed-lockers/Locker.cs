public class Locker<T> // her blir T introdusert, som forteller klassen at den kan jobbe med alle typer informasjon
                       // typen blir definert så fort objektet blir laget
{
    private T _content; //her blir T brukt til å definerer _content som en generisk type

    public Locker(T content) //her er T en del av parameter, og hjelper med å definere content som en generisk type
                             // innenfor dette scopet
    {
        _content = content;
    }

    public T Read() //her blir T brukt til å fortelle metoden at den skal jobbe med generisk type
    {
        return _content;
    }

    public void Replace(T content) //her er T en del av parameter, og hjelper med å definere content som en generisk type 
                                   //innenfor dette scopet
    {
        _content = content;
    }
}
