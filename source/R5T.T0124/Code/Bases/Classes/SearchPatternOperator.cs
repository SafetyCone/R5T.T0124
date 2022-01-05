using System;


namespace R5T.T0124
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class SearchPatternOperator : ISearchPatternOperator
    {
        #region Static
        
        public static SearchPatternOperator Instance { get; } = new();

        #endregion
    }
}