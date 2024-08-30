//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LL.MDE.Components.Qvt.Metamodel.EMOF;
using NMF.Collections.Generic;
using NMF.Collections.ObjectModel;
using NMF.Expressions;
using NMF.Expressions.Linq;
using NMF.Models;
using NMF.Models.Collections;
using NMF.Models.Expressions;
using NMF.Serialization;
using NMF.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace LL.MDE.Components.Qvt.Metamodel.EssentialOCL
{
    
    
    /// <summary>
    /// The default implementation of the TypeExp class
    /// </summary>
    [XmlNamespaceAttribute("http://www.omg.org/spec/QVT/20140401/EssentialOCL")]
    [XmlNamespacePrefixAttribute("essentialocl")]
    [DebuggerDisplayAttribute("TypeExp {Name}")]
    public class TypeExp : OclExpression, ITypeExp, IModelElement
    {
        
        /// <summary>
        /// The backing field for the ReferredType property
        /// </summary>
        private IType _referredType;
        
        private static NMF.Models.Meta.IClass _classInstance;
        
        /// <summary>
        /// The referredType property
        /// </summary>
        [XmlElementNameAttribute("referredType")]
        [XmlAttributeAttribute(true)]
        public virtual IType ReferredType
        {
            get
            {
                return this._referredType;
            }
            set
            {
                if ((this._referredType != value))
                {
                    this.OnReferredTypeChanging(EventArgs.Empty);
                    this.OnPropertyChanging("ReferredType");
                    IType old = this._referredType;
                    this._referredType = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetReferredType;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetReferredType;
                    }
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnReferredTypeChanged(e);
                    this.OnPropertyChanged("ReferredType", e);
                }
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new TypeExpReferencedElementsCollection(this));
            }
        }
        
        /// <summary>
        /// Gets fired before the ReferredType property changes its value
        /// </summary>
        public event EventHandler ReferredTypeChanging;
        
        /// <summary>
        /// Gets fired when the ReferredType property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> ReferredTypeChanged;
        
        /// <summary>
        /// Raises the ReferredTypeChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnReferredTypeChanging(EventArgs eventArgs)
        {
            EventHandler handler = this.ReferredTypeChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ReferredTypeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnReferredTypeChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.ReferredTypeChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the ReferredType property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetReferredType(object sender, System.EventArgs eventArgs)
        {
            this.ReferredType = null;
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "REFERREDTYPE"))
            {
                this.ReferredType = ((IType)(value));
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
            if ((attribute == "REFERREDTYPE"))
            {
                return new ReferredTypeProxy(this);
            }
            return base.GetExpressionForAttribute(attribute);
        }
        
        /// <summary>
        /// Gets the property expression for the given reference
        /// </summary>
        /// <returns>An incremental property expression</returns>
        /// <param name="reference">The requested reference in upper case</param>
        protected override NMF.Expressions.INotifyExpression<NMF.Models.IModelElement> GetExpressionForReference(string reference)
        {
            if ((reference == "REFERREDTYPE"))
            {
                return new ReferredTypeProxy(this);
            }
            return base.GetExpressionForReference(reference);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override NMF.Models.Meta.IClass GetClass()
        {
            throw new NotSupportedException();
        }
        
        /// <summary>
        /// The collection class to to represent the children of the TypeExp class
        /// </summary>
        public class TypeExpReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private TypeExp _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public TypeExpReferencedElementsCollection(TypeExp parent)
            {
                this._parent = parent;
            }
            
            /// <summary>
            /// Gets the amount of elements contained in this collection
            /// </summary>
            public override int Count
            {
                get
                {
                    int count = 0;
                    if ((this._parent.ReferredType != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ReferredTypeChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ReferredTypeChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.ReferredType == null))
                {
                    IType referredTypeCasted = item.As<IType>();
                    if ((referredTypeCasted != null))
                    {
                        this._parent.ReferredType = referredTypeCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ReferredType = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.ReferredType))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Copies the contents of the collection to the given array starting from the given array index
            /// </summary>
            /// <param name="array">The array in which the elements should be copied</param>
            /// <param name="arrayIndex">The starting index</param>
            public override void CopyTo(IModelElement[] array, int arrayIndex)
            {
                if ((this._parent.ReferredType != null))
                {
                    array[arrayIndex] = this._parent.ReferredType;
                    arrayIndex = (arrayIndex + 1);
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                if ((this._parent.ReferredType == item))
                {
                    this._parent.ReferredType = null;
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Gets an enumerator that enumerates the collection
            /// </summary>
            /// <returns>A generic enumerator</returns>
            public override IEnumerator<IModelElement> GetEnumerator()
            {
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ReferredType).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the referredType property
        /// </summary>
        private sealed class ReferredTypeProxy : ModelPropertyChange<ITypeExp, IType>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ReferredTypeProxy(ITypeExp modelElement) : 
                    base(modelElement, "ReferredType")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IType Value
            {
                get
                {
                    return this.ModelElement.ReferredType;
                }
                set
                {
                    this.ModelElement.ReferredType = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            //protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            //{
            //    this.ModelElement.ReferredTypeChanged += handler;
            //}
            
            ///// <summary>
            ///// Registers an event handler to subscribe specifically on the changed event for this property
            ///// </summary>
            ///// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            //protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            //{
            //    this.ModelElement.ReferredTypeChanged -= handler;
            //}
        }
    }
}

