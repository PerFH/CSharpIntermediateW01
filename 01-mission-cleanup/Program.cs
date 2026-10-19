var crewMembers = new List<string> 
{
    //Liste over hvem som er med på oppdraget
    "Ada", 
    "Bo", 
    "Cy" 
};


Console.WriteLine($"Crew: {crewMembers.Count}");
//Konsollen forteller hvor mange crewmembers som er i lista

if (crewMembers.Count>=3)
{
    //Hvis det er 3 eller mer, så får vi grønt lys
    Console.WriteLine("Ready");
}
else
{
    //hvis ikke så får vi beskjed om å vente
    Console.WriteLine("Waiting");
}



