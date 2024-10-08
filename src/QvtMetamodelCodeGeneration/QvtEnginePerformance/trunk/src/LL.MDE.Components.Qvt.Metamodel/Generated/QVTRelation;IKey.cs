//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LL.MDE.Components.Qvt.Metamodel.QVTRelation
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
    using LL.MDE.Components.Qvt.Metamodel.QVTBase;
    using LL.MDE.Components.Qvt.Metamodel.QVTTemplate;
    using NMF.Models.Repository;
    using LL.MDE.Components.Qvt.Metamodel.EMOF;
    using System.Collections.Specialized;
    using LL.MDE.Components.Qvt.Metamodel.EssentialOCL;
    
    
    /// <summary>
    /// The public interface for Key
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(Key))]
    [XmlDefaultImplementationTypeAttribute(typeof(Key))]
    [ModelRepresentationClassAttribute("http://www.omg.org/spec/QVT/20140401/QVTRelation#//Key")]
    public interface IKey : IModelElement, IElement
    {
        
        /// <summary>
        /// The identifies property
        /// </summary>
        [DisplayNameAttribute("identifies")]
        [CategoryAttribute("Key")]
        [XmlElementNameAttribute("identifies")]
        [XmlAttributeAttribute(true)]
        LL.MDE.Components.Qvt.Metamodel.EMOF.IClass Identifies
        {
            get;
            set;
        }
        
        /// <summary>
        /// The oppositePart property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [DisplayNameAttribute("oppositePart")]
        [CategoryAttribute("Key")]
        [XmlElementNameAttribute("oppositePart")]
        [XmlAttributeAttribute(true)]
        [ConstantAttribute()]
        ISetExpression<IProperty> OppositePart
        {
            get;
        }
        
        /// <summary>
        /// The part property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [DisplayNameAttribute("part")]
        [CategoryAttribute("Key")]
        [XmlElementNameAttribute("part")]
        [XmlAttributeAttribute(true)]
        [ConstantAttribute()]
        ISetExpression<IProperty> Part
        {
            get;
        }
        
        /// <summary>
        /// The transformation property
        /// </summary>
        [BrowsableAttribute(false)]
        [XmlElementNameAttribute("transformation")]
        [XmlAttributeAttribute(true)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlOppositeAttribute("ownedKey")]
        IRelationalTransformation Transformation
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the Identifies property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> IdentifiesChanging;
        
        /// <summary>
        /// Gets fired when the Identifies property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> IdentifiesChanged;
        
        /// <summary>
        /// Gets fired before the Transformation property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TransformationChanging;
        
        /// <summary>
        /// Gets fired when the Transformation property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TransformationChanged;
    }
}
