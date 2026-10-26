# Refleksjon — Flight History

## Plan før koding

-

## Testlogg

| Inndata eller handling | Forventet resultat | Faktisk resultat |
|---|---|---|
| Ny historikk, GetSnapshot | Tom liste | Tomme lister |
| Add("Launch"), Add("Orbit") | Count 2; kopi inneholder Launch, Orbit | som forventet |
| Fjern alle elementer fra kopien | Historikken har fortsatt Count 2 | som forventet
| Hent ny kopi, legg til "Landing" i historikken | Kopien har Count 2; historikken har Count 3 | som forventet |
| Clear på historikken | Count 0; tidligere kopi har fortsatt Count 2 | som forventet

## Forklaring

Hva vil fremdeles være delt dersom T senere er en klasse med endringsbare egenskaper?

Mitt svar:
Dersom det hadde blitt gjort om til en klasse så hadde det blitt til en objekt liste. Liste 1 og liste 2 refererer til de samme objektene, så endringer i objektet vil synes i begge listene dersom man inspiserer objektene. 
## Hva endret jeg, og hvorfor?

## Hva trenger jeg mer øving på?
generics sitter bedre og bedre!
