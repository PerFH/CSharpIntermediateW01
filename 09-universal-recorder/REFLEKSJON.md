# Refleksjon — Universal Recorder

## Plan før koding

- Følg oppgavens instrukser

## Testlogg

| Inndata eller handling | Forventet resultat | Faktisk resultat |
|---|---|---|
| Ny recorder int, count+contains 7| 0, false | 0, false |
| intRecorder.Add(7) 2x| 2, true | 2, true |
| intRecorder.Clear() | 0, false | 0, false |
| Tekstbeholder med "Orbit" | Contains("Orbit") true, Contains("orbit") false | true, false |
| intRecorder og stringRecorder påvirker ikke hverandre |
 
## Forklaring

Hvorfor er det feil å erstatte absolutt alle typer i klassen med T?

Mitt svar:
I dette tilfellet, count holder bare styr på antallet, den vil alltid være en int
Clear manipulerer egentlig ikke noen typer, den bare tømmer listen
contains leter etter hva man søker på, den vil alltid returnere true eller false, trenger ikke å gjøre generisk, selv om den krever en definisjon av item

## Hva endret jeg, og hvorfor?
endret navn på recorder til stringRecorder, to ting kan ikke ha samme navn

## Hva trenger jeg mer øving på?
generifisering av syntaxer, blir litt usikker