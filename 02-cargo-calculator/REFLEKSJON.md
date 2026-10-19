# Refleksjon — Cargo Calculator

## Plan før koding

- 

## Testlogg

| Inndata eller handling | Forventet resultat | Faktisk resultat |
| Kjørt startkode | Remaining: 7, Remaining 12| Remaining: 7, Remaining 12|
| endret used til over kapasitet| Remaining: -, Remaining: -| Remaining: -8, Remaining -10|
| skrevet ny metode | Remaining: 7, Remaining 12, x2| Remaining 7, Remaining: 12 2x|
| slettet gammel konsoll writeline| Remaining: 7, Remaining 12| 

## Forklaring

Hva er parameterne, argumentene og returverdien i ett av kallene dine?

Mitt svar:
Parametre: int capacity, int usedCapacity
Argumenter: firstCapacity, firstUsedCapacity
            secondCapacity, secondUsedCapacity
Returnverdien er en int remainingCapacity, som er resultatet av

## Hva endret jeg, og hvorfor?
Console.WriteLine ble skrevet om etter at metoden hadde blitt skrevet, slik at output ikke kom i duplikat

## Hva trenger jeg mer øving på?
føler alt sitter ganske godt her