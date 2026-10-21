# Refleksjon — Signal Types

Notis:
- string label
- var retries
- string result
- string label
- RepeatLabel krever en string
## Plan før koding



## Testlogg

| Inndata eller handling | Forventet resultat | Faktisk resultat |
|---|---|---|
| messages.Add(42) | String | int, men programmet prøver å gjøre det om til string |
| var retries | allerede definert som en int på linje 2 | int |
| messages.add("42") | programmet klarer å compile | programmet klarte å compile
| retries = 3 | programmet klarer å compile | programmet klarte å compile

## Forklaring

Er string i List<string> en tekstverdi eller en type? Hvorfor kan ikke var retries senere bli tekst?

Mitt svar:
string her er en type, som sier at denne listen skal inneholde strings
var kan brukes når man ikke het vet hva typen skal være, men var blir fremdeles låst fast til den typen den hører til så fort man får definert den

## Hva endret jeg, og hvorfor?
- Jeg endret messages.Add(42) til ("42") siden listen er av typen string
- Jeg endret results = "three" til 3 pga. den er definert som en int
- Jeg skrev Console.WriteLine($"Number of messages: {messages.Count}") fordi lister bruker .count og ikke .length som arrays gjør.

## Hva trenger jeg mer øving på?
Føler jeg behersker forskjellige typer og hvorfor de ikke kan blandes veldig godt.
