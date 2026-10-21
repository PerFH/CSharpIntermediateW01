# Refleksjon — Twin Recorders

## Plan før koding

- NumberRecorder og TextRecorder ser identiske ut bortsett fra type


## Testlogg

| Inndata eller handling | Forventet resultat | Faktisk resultat |
|---|---|---|
| Legg til "Orbit" / 7 | Begge har Count 1 | begge har count 1
| Søk etter "Orbit" / 7 | Begge gir true | begge gir true
| Søk etter "Landing" / 9 | Begge gir false | begge gir false
| Clear på begge | Begge har Count 0 og finner ikke gammel verdi | begge har verdi 0
| Søk etter "Orbit" / 7 | begge gir false | begge gir false
| Clear på tom beholder | Count forblir 0 | count forblir 0

## Forklaring

Hva måtte vært forskjellig i reglene for at du ville beholdt to separate klasser?

Mitt svar:
Hvis text og numbers behandlet dataen på forskjellig måte, f.eks. at numbers skulle finne median og tekst skulle sorteres alfabetisk
## Hva endret jeg, og hvorfor?
jeg endret void Clear() i både NumberRecorder og TextRecorder til å inkludere en funksjon som kunne tømme lista siden listen er privat er dette nødvendig
## Hva trenger jeg mer øving på?
tydeligvis navnekonvensjoner, i forrige oppgave endret jeg navn add og clear funksjonen, siden det er innebydge funksjoner, tenkte kanskje det var en liten bonus ting, men når den samme navnekonvensjonen er brukt her blir jeg i tvil
