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
    /// The public interface for Factory
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(Factory))]
    [XmlDefaultImplementationTypeAttribute(typeof(Factory))]
    [ModelRepresentationClassAttribute("http://www.omg.org/spec/QVT/20140401/EMOF#//Factory")]
    public interface IFactory : IModelElement, IElement
    {
        
        /// <summary>
        /// The package property
        /// </summary>
        [DisplayNameAttribute("package")]
        [CategoryAttribute("Factory")]
        [XmlElementNameAttribute("package")]
        [XmlAttributeAttribute(true)]
        IPackage Package
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the operation convertToString gets called
        /// </summary>
        event System.EventHandler<OperationCallEventArgs> ConvertToStringCalling;
        
        /// <summary>
        /// Gets fired after the operation convertToString got called
        /// </summary>
        event System.EventHandler<OperationCallEventArgs> ConvertToStringCalled;
        
        /// <summary>
        /// Gets fired before the operation create gets called
        /// </summary>
        event System.EventHandler<OperationCallEventArgs> CreateCalling;
        
        /// <summary>
        /// Gets fired after the operation create got called
        /// </summary>
        event System.EventHandler<OperationCallEventArgs> CreateCalled;
        
        /// <summary>
        /// Gets fired before the operation createFromString gets called
        /// </summary>
        event System.EventHandler<OperationCallEventArgs> CreateFromStringCalling;
        
        /// <summary>
        /// Gets fired after the operation createFromString got called
        /// </summary>
        event System.EventHandler<OperationCallEventArgs> CreateFromStringCalled;
        
        /// <summary>
        /// Gets fired before the Package property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PackageChanging;
        
        /// <summary>
        /// Gets fired when the Package property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PackageChanged;
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataType"></param>
        /// <param name="object"></param>
        string ConvertToString(LL.MDE.Components.Qvt.Metamodel.EMOF.IDataType dataType, IObject @object);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="metaClass"></param>
        IElement Create(LL.MDE.Components.Qvt.Metamodel.EMOF.IClass metaClass);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataType"></param>
        /// <param name="string"></param>
        IObject CreateFromString(LL.MDE.Components.Qvt.Metamodel.EMOF.IDataType dataType, string @string);
    }
}
