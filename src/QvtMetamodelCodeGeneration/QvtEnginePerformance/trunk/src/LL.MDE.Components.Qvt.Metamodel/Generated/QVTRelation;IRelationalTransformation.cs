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
    /// The public interface for RelationalTransformation
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(RelationalTransformation))]
    [XmlDefaultImplementationTypeAttribute(typeof(RelationalTransformation))]
    [ModelRepresentationClassAttribute("http://www.omg.org/spec/QVT/20140401/QVTRelation#//RelationalTransformation")]
    public interface IRelationalTransformation : IModelElement, ITransformation
    {
        
        /// <summary>
        /// The ownedKey property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [BrowsableAttribute(false)]
        [XmlElementNameAttribute("ownedKey")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("transformation")]
        [ConstantAttribute()]
        IOrderedSetExpression<IKey> OwnedKey
        {
            get;
        }
    }
}
