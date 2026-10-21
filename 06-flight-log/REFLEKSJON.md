# Refleksjon — Flight Log

## Plan før koding

- public int count returner 0, må endres
- add og clear metodene kan få bedre navn

## Testlogg

| Inndata eller handling | Forventet resultat | Faktisk resultat |
|---|---|---|
| Ny logg | 0 | 0 |
| Add("Launch") | 1 | 1 |
| Add("Orbit") | 2 | 2 |
| Clear() | 0 | 0 | 0 |
| Clear() igjen | 0 | 0 |
| Add("") | 1 | 1 |
| Ny logg2 | 0 | 0 |
| 2 Add("Launch") | 1 | 1 |
| 2 Add("Orbit") | 2 | 2 |
| 2 Add("") | 3 | 3 |
| 1 log.Count | 1 | 1 |

## Forklaring

Hva kan gå galt hvis både listen og et eget tellerfelt lagrer antallet?

Mitt svar:
Det som fort kan gå galt er at man glemmer å skrive teller variablen på en metode som trenger den, som gjør telleren unøyaktig, med alt dette kan medføre

## Hva endret jeg, og hvorfor?
endret navn på Add metoden til addEntry, og entret navn på Clear metoden til listClear slik at det er tydelig at de påkaller metoder i koden istedenfor innebygde funksjoner 

## Hva trenger jeg mer øving på?
