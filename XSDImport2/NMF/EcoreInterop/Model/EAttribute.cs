//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMF.Collections.Generic;
using NMF.Collections.ObjectModel;
using NMF.Expressions;
using NMF.Expressions.Linq;
using NMF.Models;
using NMF.Models.Collections;
using NMF.Models.Expressions;
using NMF.Models.Meta;
using NMF.Models.Repository;
using NMF.Serialization;
using NMF.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace NMF.Interop.Ecore
{
    
    
    /// <summary>
    /// The default implementation of the EAttribute class
    /// </summary>
    [XmlNamespaceAttribute("http://www.eclipse.org/emf/2002/Ecore")]
    [XmlNamespacePrefixAttribute("ecore")]
    [ModelRepresentationClassAttribute("http://www.eclipse.org/emf/2002/Ecore#//EAttribute/")]
    [DebuggerDisplayAttribute("EAttribute {Name}")]
    public class EAttribute : EStructuralFeature, IEAttribute, IModelElement
    {
        
        /// <summary>
        /// The backing field for the ID property
        /// </summary>
        private Nullable<bool> _iD;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The iD property
        /// </summary>
        [XmlElementNameAttribute("iD")]
        [XmlAttributeAttribute(true)]
        public virtual Nullable<bool> ID
        {
            get
            {
                return this._iD;
            }
            set
            {
                if ((this._iD != value))
                {
                    this.OnIDChanging(EventArgs.Empty);
                    this.OnPropertyChanging("ID");
                    Nullable<bool> old = this._iD;
                    this._iD = value;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnIDChanged(e);
                    this.OnPropertyChanged("ID", e);
                }
            }
        }
        
        /// <summary>
        /// Gets the Class model for this type
        /// </summary>
        public new static IClass ClassInstance
        {
            get
            {
                if ((_classInstance == null))
                {
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.eclipse.org/emf/2002/Ecore#//EAttribute/")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the ID property changes its value
        /// </summary>
        public event EventHandler IDChanging;
        
        /// <summary>
        /// Gets fired when the ID property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> IDChanged;
        
        /// <summary>
        /// Raises the IDChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnIDChanging(EventArgs eventArgs)
        {
            EventHandler handler = this.IDChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the IDChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnIDChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.IDChanged;
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
            if ((attribute == "ID"))
            {
                return this.ID;
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
            if ((feature == "ID"))
            {
                this.ID = ((bool)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.eclipse.org/emf/2002/Ecore#//EAttribute/")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the iD property
        /// </summary>
        private sealed class IDProxy : ModelPropertyChange<IEAttribute, Nullable<bool>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public IDProxy(IEAttribute modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<bool> Value
            {
                get
                {
                    return this.ModelElement.ID;
                }
                set
                {
                    this.ModelElement.ID = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.IDChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.IDChanged -= handler;
            }
        }
    }
}

