public static class RNG
{
    private static Random Rnd = new Random();

    public static int D10()
    {
        return Rnd.Next(1, 11);

    }

    public static int D6()
    {
        return Rnd.Next(1, 7);

    }

}
