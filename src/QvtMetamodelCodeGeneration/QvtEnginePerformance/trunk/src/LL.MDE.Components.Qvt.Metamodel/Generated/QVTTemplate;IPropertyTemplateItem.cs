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
    /// The public interface for PropertyTemplateItem
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(PropertyTemplateItem))]
    [XmlDefaultImplementationTypeAttribute(typeof(PropertyTemplateItem))]
    [ModelRepresentationClassAttribute("http://www.omg.org/spec/QVT/20140401/QVTTemplate#//PropertyTemplateItem")]
    public interface IPropertyTemplateItem : IModelElement, IElement
    {
        
        /// <summary>
        /// The isOpposite property
        /// </summary>
        [DefaultValueAttribute(false)]
        [DisplayNameAttribute("isOpposite")]
        [CategoryAttribute("PropertyTemplateItem")]
        [XmlElementNameAttribute("isOpposite")]
        [XmlAttributeAttribute(true)]
        Nullable<bool> IsOpposite
        {
            get;
            set;
        }
        
        /// <summary>
        /// The objContainer property
        /// </summary>
        [BrowsableAttribute(false)]
        [XmlElementNameAttribute("objContainer")]
        [XmlAttributeAttribute(true)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlOppositeAttribute("part")]
        IObjectTemplateExp ObjContainer
        {
            get;
            set;
        }
        
        /// <summary>
        /// The referredProperty property
        /// </summary>
        [DisplayNameAttribute("referredProperty")]
        [CategoryAttribute("PropertyTemplateItem")]
        [XmlElementNameAttribute("referredProperty")]
        [XmlAttributeAttribute(true)]
        IProperty ReferredProperty
        {
            get;
            set;
        }
        
        /// <summary>
        /// The value property
        /// </summary>
        [BrowsableAttribute(false)]
        [XmlElementNameAttribute("value")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        IOclExpression Value
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired when the IsOpposite property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> IsOppositeChanged;
        
        /// <summary>
        /// Gets fired before the IsOpposite property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> IsOppositeChanging;
        
        /// <summary>
        /// Gets fired before the ObjContainer property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ObjContainerChanging;
        
        /// <summary>
        /// Gets fired when the ObjContainer property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ObjContainerChanged;
        
        /// <summary>
        /// Gets fired before the ReferredProperty property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ReferredPropertyChanging;
        
        /// <summary>
        /// Gets fired when the ReferredProperty property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ReferredPropertyChanged;
        
        /// <summary>
        /// Gets fired before the Value property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ValueChanging;
        
        /// <summary>
        /// Gets fired when the Value property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ValueChanged;
    }
}
