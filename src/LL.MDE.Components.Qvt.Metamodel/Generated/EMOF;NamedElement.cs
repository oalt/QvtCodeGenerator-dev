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
    /// The default implementation of the NamedElement class
    /// </summary>
    [XmlIdentifierAttribute("name")]
    [XmlNamespaceAttribute("http://www.omg.org/spec/QVT/20140401/EMOF")]
    [XmlNamespacePrefixAttribute("emof")]
    [ModelRepresentationClassAttribute("http://www.omg.org/spec/QVT/20140401/EMOF#//NamedElement")]
    [DebuggerDisplayAttribute("NamedElement {Name}")]
    public abstract partial class NamedElement : Element, INamedElement, IModelElement
    {
        
        /// <summary>
        /// The backing field for the Name property
        /// </summary>
        [DebuggerBrowsableAttribute(DebuggerBrowsableState.Never)]
        private string _name;
        
        private static Lazy<NMF.Models.Meta.ITypedElement> _nameAttribute = new Lazy<NMF.Models.Meta.ITypedElement>(RetrieveNameAttribute);
        
        private static NMF.Models.Meta.IClass _classInstance;
        
        /// <summary>
        /// The name property
        /// </summary>
        [DisplayNameAttribute("name")]
        [CategoryAttribute("NamedElement")]
        [XmlElementNameAttribute("name")]
        [IdAttribute()]
        [XmlAttributeAttribute(true)]
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                if ((this._name != value))
                {
                    string old = this._name;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnNameChanging(e);
                    this.OnPropertyChanging("Name", e, _nameAttribute);
                    this._name = value;
                    this.OnNameChanged(e);
                    this.OnPropertyChanged("Name", e, _nameAttribute);
                }
            }
        }
        
        /// <summary>
        /// Gets the Class model for this type
        /// </summary>
        public new static NMF.Models.Meta.IClass ClassInstance
        {
            get
            {
                if ((_classInstance == null))
                {
                    _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("http://www.omg.org/spec/QVT/20140401/EMOF#//NamedElement")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets a value indicating whether the current model element can be identified by an attribute value
        /// </summary>
        public override bool IsIdentified
        {
            get
            {
                return true;
            }
        }
        
        /// <summary>
        /// Gets fired when the Name property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> NameChanged;
        
        /// <summary>
        /// Gets fired before the Name property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> NameChanging;
        
        private static NMF.Models.Meta.ITypedElement RetrieveNameAttribute()
        {
            return ((NMF.Models.Meta.ITypedElement)(((ModelElement)(LL.MDE.Components.Qvt.Metamodel.EMOF.NamedElement.ClassInstance)).Resolve("name")));
        }
        
        /// <summary>
        /// Raises the NameChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnNameChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.NameChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the NameChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnNameChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.NameChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "NAME"))
            {
                return this.Name;
            }
            return base.GetAttributeValue(attribute, index);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "NAME"))
            {
                this.Name = ((string)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the property expression for the given attribute
        /// </summary>
        /// <returns>An incremental property expression</returns>
        /// <param name="attribute">The requested attribute in upper case</param>
        protected override NMF.Expressions.INotifyExpression<object> GetExpressionForAttribute(string attribute)
        {
            if ((attribute == "NAME"))
            {
                return new NameProxy(this);
            }
            return base.GetExpressionForAttribute(attribute);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override NMF.Models.Meta.IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("http://www.omg.org/spec/QVT/20140401/EMOF#//NamedElement")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// Gets the identifier string for this model element
        /// </summary>
        /// <returns>The identifier string</returns>
        public override string ToIdentifierString()
        {
            if ((this.Name == null))
            {
                return null;
            }
            return this.Name.ToString();
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the name property
        /// </summary>
        private sealed class NameProxy : ModelPropertyChange<INamedElement, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public NameProxy(INamedElement modelElement) : 
                    base(modelElement, "name")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.Name;
                }
                set
                {
                    this.ModelElement.Name = value;
                }
            }
        }
    }
}
