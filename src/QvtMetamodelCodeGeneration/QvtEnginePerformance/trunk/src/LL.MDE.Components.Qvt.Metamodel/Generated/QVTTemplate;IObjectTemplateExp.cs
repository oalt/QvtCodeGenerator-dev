//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LL.MDE.Components.Qvt.Metamodel.QVTTemplate
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
    using LL.MDE.Components.Qvt.Metamodel.EssentialOCL;
    using System.Collections.Specialized;
    using NMF.Models.Repository;
    using LL.MDE.Components.Qvt.Metamodel.EMOF;
    
    
    /// <summary>
    /// The public interface for ObjectTemplateExp
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(ObjectTemplateExp))]
    [XmlDefaultImplementationTypeAttribute(typeof(ObjectTemplateExp))]
    [ModelRepresentationClassAttribute("http://www.omg.org/spec/QVT/20140401/QVTTemplate#//ObjectTemplateExp")]
    public interface IObjectTemplateExp : IModelElement, ITemplateExp
    {
        
        /// <summary>
        /// The part property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [BrowsableAttribute(false)]
        [XmlElementNameAttribute("part")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("objContainer")]
        [ConstantAttribute()]
        IOrderedSetExpression<IPropertyTemplateItem> Part
        {
            get;
        }
        
        /// <summary>
        /// The referredClass property
        /// </summary>
        [DisplayNameAttribute("referredClass")]
        [CategoryAttribute("ObjectTemplateExp")]
        [XmlElementNameAttribute("referredClass")]
        [XmlAttributeAttribute(true)]
        LL.MDE.Components.Qvt.Metamodel.EMOF.IClass ReferredClass
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the ReferredClass property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ReferredClassChanging;
        
        /// <summary>
        /// Gets fired when the ReferredClass property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ReferredClassChanged;
    }
}
