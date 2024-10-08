//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LL.MDE.Components.Qvt.Metamodel.QVTBase
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
    using LL.MDE.Components.Qvt.Metamodel.EMOF;
    using NMF.Models.Repository;
    using LL.MDE.Components.Qvt.Metamodel.EssentialOCL;
    using System.Collections.Specialized;
    
    
    /// <summary>
    /// The public interface for TypedModel
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(TypedModel))]
    [XmlDefaultImplementationTypeAttribute(typeof(TypedModel))]
    [ModelRepresentationClassAttribute("http://www.omg.org/spec/QVT/20140401/QVTBase#//TypedModel")]
    public interface ITypedModel : IModelElement, INamedElement
    {
        
        /// <summary>
        /// The dependsOn property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [DisplayNameAttribute("dependsOn")]
        [CategoryAttribute("TypedModel")]
        [XmlElementNameAttribute("dependsOn")]
        [XmlAttributeAttribute(true)]
        [ConstantAttribute()]
        ISetExpression<ITypedModel> DependsOn
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
        [XmlOppositeAttribute("modelParameter")]
        ITransformation Transformation
        {
            get;
            set;
        }
        
        /// <summary>
        /// The usedPackage property
        /// </summary>
        [LowerBoundAttribute(1)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [DisplayNameAttribute("usedPackage")]
        [CategoryAttribute("TypedModel")]
        [XmlElementNameAttribute("usedPackage")]
        [XmlAttributeAttribute(true)]
        [ConstantAttribute()]
        ISetExpression<IPackage> UsedPackage
        {
            get;
        }
        
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
