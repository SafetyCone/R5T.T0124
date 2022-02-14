using System;

using R5T.Magyar;

using R5T.T0124;


namespace System
{
    public static class ISearchPatternExtensions
    {
        public static string All(this ISearchPattern _)
        {
            return Strings.Asterix;
        }
    }
}