namespace CatTheoryDotnetCore
{
    public static class Identity
    {
        public static Func<T, T> GetIdentity<T>(this T category)
        {
            return x => x;
        }
    }
}
