using System;


namespace R5T.T0124
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class SearchPattern : ISearchPattern
    {
        #region Static
        
        public static SearchPattern Instance { get; } = new();

        #endregion
    }
}