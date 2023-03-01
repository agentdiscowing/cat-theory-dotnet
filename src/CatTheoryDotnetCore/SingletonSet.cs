namespace CatTheoryDotnetCore
{
    public static class SingletonSet
    {
        // maps any type to the singleton set void (set of void can only have one object - void)
        public static void Unit<T>(T input) { }
    }
}
