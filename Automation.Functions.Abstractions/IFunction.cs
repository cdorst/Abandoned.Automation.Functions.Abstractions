using System;

namespace Automation.Functions.Abstractions
{
    /// <summary>
    /// Contains a function that takes a state object as its first
    /// argument, any configuration relevant to the function as its second
    /// argument, and returns the state object
    /// </summary>
    public interface IFunction
    {
        /// <summary>
        /// Contains a function that takes a state object as its first
        /// argument, any configuration relevant to the function as its second
        /// argument, and returns the state object
        /// </summary>
        Func<dynamic, dynamic, dynamic> Function { get; }
    }
}
