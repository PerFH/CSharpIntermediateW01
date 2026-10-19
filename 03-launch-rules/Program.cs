Console.WriteLine(CanLaunch(4, 80, true));
// TODO: Legg til de andre testkallene og refaktorer metoden.
static bool CanLaunch(int crewCount, int fuel, bool isHatchClosed)
{
    if (crewCount < 3)
    {
        //hvis crew ikke er lik eller mer enn 3, CanLaunch = false
        return false;
    }
    if (fuel < 50)
    {
        //Hvis fuel ikke er lik eller mer enn 50, CanLaunch = false
        return false;
    }
    if (!isHatchClosed)
    {
        //Hvis ikke hatch er closed, så er CanLaunch false, altså, den har ikke lov til å skyte opp.
        return false;
    }
    return true;
}
