# Refleksjon — Launch Rules

## Plan før koding
- analysere koden
- omvend verdiene slik at samme regel blir fulgt
- gjøre om til en if blokk

## Testlogg

| Inndata eller handling | Forventet resultat | Faktisk resultat |
| 3, 50, true  | true  | true  |
| 2, 50, true  | false | false |
| 3, 49, true  | false | false |
| 3, 50, false | false | false |
| 4, 80, true  | true  | true


## Forklaring

Hvorfor er dette refaktorering og ikke en ny oppskytingsregel?

Mitt svar:
samme reglene gjelder, de er bare strukturert på en annen måte

## Hva endret jeg, og hvorfor?

omvendte reglene på alle punkter:
- hvis mindre enn 3
- hvis mindre enn 50
- hvis ikke lukket
på den måten leter jeg heller etter etter mangler, og hvis ingen er funnet så sender man klar signal, det er mer ryddig både for øynene og maskinen

## Hva trenger jeg mer øving på?
if blokker har jeg god kontroll på