//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LL.MDE.Components.Qvt.Metamodel.EssentialOCL
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Linq;
    using NMF.Expressions;
    using NMF.Expressions.Linq;
    using NMF.Models;
    using NMF.Models.Meta;
    using NMF.Models.Collections;
    using NMF.Models.Expressions;
    using NMF.Collections.Generic;
    using NMF.Collections.ObjectModel;
    using NMF.Serialization;
    using NMF.Utilities;
    using NMF.Models.Repository;
    using System.Collections.Specialized;
    using LL.MDE.Components.Qvt.Metamodel.EMOF;
    
    
    /// <summary>
    /// The public interface for StringLiteralExp
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(StringLiteralExp))]
    [XmlDefaultImplementationTypeAttribute(typeof(StringLiteralExp))]
    [ModelRepresentationClassAttribute("http://www.omg.org/spec/QVT/20140401/EssentialOCL#//StringLiteralExp")]
    public interface IStringLiteralExp : IModelElement, IPrimitiveLiteralExp
    {
        
        /// <summary>
        /// The stringSymbol property
        /// </summary>
        [DisplayNameAttribute("stringSymbol")]
        [CategoryAttribute("StringLiteralExp")]
        [XmlElementNameAttribute("stringSymbol")]
        [XmlAttributeAttribute(true)]
        string StringSymbol
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired when the StringSymbol property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> StringSymbolChanged;
        
        /// <summary>
        /// Gets fired before the StringSymbol property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> StringSymbolChanging;
    }
}
