# Refleksjon — Typed Lockers

## Plan før koding

- ingen spesiell plan, synes denne oppgaven var ganske rett frem

## Testlogg

| Inndata eller handling | Forventet resultat | Faktisk resultat |
|---|---|---|
|Locker Beacon / 42 | Beacon / 42 | Locker`1[System.String/Int32] påkalte read funksjonen feil |
|Locker Beacon / 42 | Beacon / 42 | Beacon / 42 |
|.Replace Relay / 99 | Relay / 99 | Relay / 99 |
|IntLocker "nittini" | nekter å kompilere| nekter å kompilere fordi typen på intlocker ojektet er definert som int
## Forklaring

Hva er forskjellen mellom typeargumentet int og konstruktørargumentet 42?

Mitt svar:
typeargumentet forteller hva for type som kan jobbes med, konstruktør argumentet 42 gir bare en verdi på den int typen metoden krever

## Hva endret jeg, og hvorfor?
ingenting endret utenfor oppgavens krav
## Hva trenger jeg mer øving på?
generiske typer satt litt bedre etter denne oppgaven, trenger fremdeles litt mer vil jeg tro