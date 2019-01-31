using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.EntityFrameworkCore.Query.ExpressionTranslators
{
    /// <summary>
    ///     Represents plugin expression fragment translators.
    /// </summary>
    public interface IExpressionFragmentTranslatorPlugin
    {
        /// <summary>
        ///     Gets the expression fragment translators.
        /// </summary>
        IEnumerable<IExpressionFragmentTranslator> Translators { get; }
    }
}
