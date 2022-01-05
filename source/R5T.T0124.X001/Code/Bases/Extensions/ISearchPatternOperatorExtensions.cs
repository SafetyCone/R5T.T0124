using System;

using R5T.T0124;

using Instances = R5T.T0124.X001.Instances;


namespace System
{
    public static class ISearchPatternOperatorExtensions
    {
        public static string AllFilesWithExtension(this ISearchPatternOperator _,
            string fileExtension)
        {
            var output = $"{Instances.SearchPattern.All()}{fileExtension}";
            return output;
        }
    }
}
