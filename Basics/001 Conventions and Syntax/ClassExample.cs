//Use this file to store your work to demonstrate your understanding of operators
//Make sure your work is different from the instructors examples or your peers

public class CrunchyDog
{ 
    public DogFeatures crustyWhiteDog;
    
    public void RunningDog
    {
        crustyWhiteDog = new DogFeatures();

        Console.WriteLine(crustyWhiteDog.doggoName + "has" + crustyWhiteDog.numEyes + "eyes with a laser power of" + crustyWhiteDog.laserPower);
        Console.WriteLine(crustyWhiteDog.doggoName + "has" + crustyWhiteDog.numLasers + "lasers.")
    }
    
}

public class DogFeatures
{
    public int numLasers = 15;
    public int numEyes = 2;
    public float laserPower = 20.6f;
    public string doggoName = "Cronch";
}

