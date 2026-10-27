# Refleksjon — Paired Beacons

## Plan før koding

- Kode en bit av gangen og test
- være obs på at navnet ikke skal kunne endres utenfor strukturen
- jeg synes det er veldig vanskelig å skrive en plan når oppgavene har et veldig spesifikt fokus, samt instrukser

## Testlogg

| Inndata eller handling | Forventet resultat | Faktisk resultat |
|---|---|---|
| "North", "South" | First er North, Second er South; ShowPair skriver begge | ShowPair skriver Beacon 2x |
| Pair<Beacon> gjort om til Pair<string> | First er North, South er Second; ShowPair skriver begge | som forventet |
| 12, 24 | First er 12, Second er 24; ShowPair skriver begge | som forventet |
| To Beacon-objekter med navn A og B | First.Name er A, Second.Name er B | som forventet
| Nytt par etter første par | Første par er uendret | som forventet |
| beaconPair.First = "hmmm" | Kompileringsfeil; fjern feilkallet før levering | Property or indexer 'Pair<Beacon>.First' cannot be assigned to -- it is read only |

## Forklaring

Hvorfor trenger ikke Pair<T> vite hvilke egenskaper Beacon har? Hva gir generics her som to separate klasser ikke gir?

Mitt svar:

Her samler Pair T objekter som har egenskaper, den trenger ikke vite egenskapene for å samle de. Generics gjør det mulig å lage et par av hva som helst uten å måtte repetere koden flere ganger for hver type.
## Hva endret jeg, og hvorfor?

## Hva trenger jeg mer øving på?
terminologi

## Kommentar
en del av oppgave teksten blir litt vag og forvirrende til tider

