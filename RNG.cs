public static class RNG
{
    private static Random Rnd = new Random();


    public static int D10 {
        get => Dee10();
    
    }
    public static int D6 { 
    get => Dee6();
    }


    public static int Dee10()
    {
        return Rnd.Next(1, 11);

    }

    public static int Dee6()
    {
        return Rnd.Next(1, 7);

    }

}
