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
    /// The public interface for LoopExp
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(LoopExp))]
    [XmlDefaultImplementationTypeAttribute(typeof(LoopExp))]
    [ModelRepresentationClassAttribute("http://www.omg.org/spec/QVT/20140401/EssentialOCL#//LoopExp")]
    public interface ILoopExp : IModelElement, IOclExpression, ICallExp
    {
        
        /// <summary>
        /// The body property
        /// </summary>
        [BrowsableAttribute(false)]
        [XmlElementNameAttribute("body")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        IOclExpression Body
        {
            get;
            set;
        }
        
        /// <summary>
        /// The iterator property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [BrowsableAttribute(false)]
        [XmlElementNameAttribute("iterator")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [ConstantAttribute()]
        IOrderedSetExpression<IVariable> Iterator
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the Body property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BodyChanging;
        
        /// <summary>
        /// Gets fired when the Body property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BodyChanged;
    }
}
