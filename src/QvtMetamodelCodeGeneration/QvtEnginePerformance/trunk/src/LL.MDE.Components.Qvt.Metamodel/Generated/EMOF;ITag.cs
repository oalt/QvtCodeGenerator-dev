//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LL.MDE.Components.Qvt.Metamodel.EMOF
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
    using System.Collections.Specialized;
    using NMF.Models.Repository;
    
    
    /// <summary>
    /// The public interface for Tag
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(Tag))]
    [XmlDefaultImplementationTypeAttribute(typeof(Tag))]
    [ModelRepresentationClassAttribute("http://www.omg.org/spec/QVT/20140401/EMOF#//Tag")]
    public interface ITag : IModelElement, IElement
    {
        
        /// <summary>
        /// The name property
        /// </summary>
        [DisplayNameAttribute("name")]
        [CategoryAttribute("Tag")]
        [XmlElementNameAttribute("name")]
        [IdAttribute()]
        [XmlAttributeAttribute(true)]
        string Name
        {
            get;
            set;
        }
        
        /// <summary>
        /// The value property
        /// </summary>
        [DisplayNameAttribute("value")]
        [CategoryAttribute("Tag")]
        [XmlElementNameAttribute("value")]
        [XmlAttributeAttribute(true)]
        string Value
        {
            get;
            set;
        }
        
        /// <summary>
        /// The element property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [DisplayNameAttribute("element")]
        [CategoryAttribute("Tag")]
        [XmlElementNameAttribute("element")]
        [XmlAttributeAttribute(true)]
        [ConstantAttribute()]
        ISetExpression<IElement> Element
        {
            get;
        }
        
        /// <summary>
        /// Gets fired when the Name property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> NameChanged;
        
        /// <summary>
        /// Gets fired before the Name property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> NameChanging;
        
        /// <summary>
        /// Gets fired when the Value property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ValueChanged;
        
        /// <summary>
        /// Gets fired before the Value property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ValueChanging;
    }
}
