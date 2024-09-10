public static class RNG
{
    private static Random Rnd = new Random();

    public static int RollD10()
    {
        return Rnd.Next(1, 11);

    }
}
