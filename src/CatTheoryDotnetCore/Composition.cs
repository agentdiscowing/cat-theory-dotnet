namespace CatTheoryDotnetCore
{
    public static class Composition
    {
        public static Func<TInput, TOutput> Compose<TInput, TOutput, TLink>(this Func<TLink, TOutput> outer, Func<TInput, TLink> inner)
        {
            return (TInput x) => outer(inner(x));
        }

    }
}