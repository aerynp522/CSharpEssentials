using System;

public class CrunchyDog
{ 
    public DogFeatures crustyWhiteDog;
    
    public void Main()
    {
        crustyWhiteDog = new DogFeatures();

        Console.WriteLine(crustyWhiteDog.doggoName + " has " + crustyWhiteDog.numEyes + " eyes with a laser power of " + crustyWhiteDog.laserPower);
        Console.WriteLine(crustyWhiteDog.doggoName + " has " + crustyWhiteDog.numLasers + " lasers all over his body.");
    }
    
}

public class DogFeatures
{
    public int numLasers = 15;
    public int numEyes = 2;
    public float laserPower = 20.6f;
    public string doggoName = "Cronch";
}