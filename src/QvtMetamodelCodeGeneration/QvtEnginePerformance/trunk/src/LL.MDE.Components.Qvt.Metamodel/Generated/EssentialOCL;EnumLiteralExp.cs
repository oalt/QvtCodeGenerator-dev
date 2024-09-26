//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LL.MDE.Components.Qvt.Metamodel.EssentialOCL
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
    using NMF.Models.Repository;
    using System.Collections.Specialized;
    using LL.MDE.Components.Qvt.Metamodel.EMOF;
    
    
    /// <summary>
    /// The default implementation of the EnumLiteralExp class
    /// </summary>
    [XmlNamespaceAttribute("http://www.omg.org/spec/QVT/20140401/EssentialOCL")]
    [XmlNamespacePrefixAttribute("essentialocl")]
    [ModelRepresentationClassAttribute("http://www.omg.org/spec/QVT/20140401/EssentialOCL#//EnumLiteralExp")]
    [DebuggerDisplayAttribute("EnumLiteralExp {Name}")]
    public partial class EnumLiteralExp : LiteralExp, IEnumLiteralExp, IModelElement
    {
        
        private static Lazy<NMF.Models.Meta.ITypedElement> _referredEnumLiteralReference = new Lazy<NMF.Models.Meta.ITypedElement>(RetrieveReferredEnumLiteralReference);
        
        /// <summary>
        /// The backing field for the ReferredEnumLiteral property
        /// </summary>
        [DebuggerBrowsableAttribute(DebuggerBrowsableState.Never)]
        private IEnumerationLiteral _referredEnumLiteral;
        
        private static NMF.Models.Meta.IClass _classInstance;
        
        /// <summary>
        /// The referredEnumLiteral property
        /// </summary>
        [DisplayNameAttribute("referredEnumLiteral")]
        [CategoryAttribute("EnumLiteralExp")]
        [XmlElementNameAttribute("referredEnumLiteral")]
        [XmlAttributeAttribute(true)]
        public IEnumerationLiteral ReferredEnumLiteral
        {
            get
            {
                return this._referredEnumLiteral;
            }
            set
            {
                if ((this._referredEnumLiteral != value))
                {
                    IEnumerationLiteral old = this._referredEnumLiteral;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnReferredEnumLiteralChanging(e);
                    this.OnPropertyChanging("ReferredEnumLiteral", e, _referredEnumLiteralReference);
                    this._referredEnumLiteral = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetReferredEnumLiteral;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetReferredEnumLiteral;
                    }
                    this.OnReferredEnumLiteralChanged(e);
                    this.OnPropertyChanged("ReferredEnumLiteral", e, _referredEnumLiteralReference);
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
                return base.ReferencedElements.Concat(new EnumLiteralExpReferencedElementsCollection(this));
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
                    _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("http://www.omg.org/spec/QVT/20140401/EssentialOCL#//EnumLiteralExp")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the ReferredEnumLiteral property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ReferredEnumLiteralChanging;
        
        /// <summary>
        /// Gets fired when the ReferredEnumLiteral property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ReferredEnumLiteralChanged;
        
        private static NMF.Models.Meta.ITypedElement RetrieveReferredEnumLiteralReference()
        {
            return ((NMF.Models.Meta.ITypedElement)(((ModelElement)(LL.MDE.Components.Qvt.Metamodel.EssentialOCL.EnumLiteralExp.ClassInstance)).Resolve("referredEnumLiteral")));
        }
        
        /// <summary>
        /// Raises the ReferredEnumLiteralChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnReferredEnumLiteralChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ReferredEnumLiteralChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ReferredEnumLiteralChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnReferredEnumLiteralChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ReferredEnumLiteralChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the ReferredEnumLiteral property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetReferredEnumLiteral(object sender, System.EventArgs eventArgs)
        {
            this.ReferredEnumLiteral = null;
        }
        
        /// <summary>
        /// Resolves the given URI to a child model element
        /// </summary>
        /// <returns>The model element or null if it could not be found</returns>
        /// <param name="reference">The requested reference name</param>
        /// <param name="index">The index of this reference</param>
        protected override IModelElement GetModelElementForReference(string reference, int index)
        {
            if ((reference == "REFERREDENUMLITERAL"))
            {
                return this.ReferredEnumLiteral;
            }
            return base.GetModelElementForReference(reference, index);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "REFERREDENUMLITERAL"))
            {
                this.ReferredEnumLiteral = ((IEnumerationLiteral)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the property expression for the given reference
        /// </summary>
        /// <returns>An incremental property expression</returns>
        /// <param name="reference">The requested reference in upper case</param>
        protected override NMF.Expressions.INotifyExpression<NMF.Models.IModelElement> GetExpressionForReference(string reference)
        {
            if ((reference == "REFERREDENUMLITERAL"))
            {
                return new ReferredEnumLiteralProxy(this);
            }
            return base.GetExpressionForReference(reference);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override NMF.Models.Meta.IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("http://www.omg.org/spec/QVT/20140401/EssentialOCL#//EnumLiteralExp")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the EnumLiteralExp class
        /// </summary>
        public class EnumLiteralExpReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private EnumLiteralExp _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public EnumLiteralExpReferencedElementsCollection(EnumLiteralExp parent)
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
                    if ((this._parent.ReferredEnumLiteral != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            /// <summary>
            /// Registers event hooks to keep the collection up to date
            /// </summary>
            protected override void AttachCore()
            {
                this._parent.ReferredEnumLiteralChanged += this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Unregisters all event hooks registered by AttachCore
            /// </summary>
            protected override void DetachCore()
            {
                this._parent.ReferredEnumLiteralChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.ReferredEnumLiteral == null))
                {
                    IEnumerationLiteral referredEnumLiteralCasted = item.As<IEnumerationLiteral>();
                    if ((referredEnumLiteralCasted != null))
                    {
                        this._parent.ReferredEnumLiteral = referredEnumLiteralCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ReferredEnumLiteral = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.ReferredEnumLiteral))
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
                if ((this._parent.ReferredEnumLiteral != null))
                {
                    array[arrayIndex] = this._parent.ReferredEnumLiteral;
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
                if ((this._parent.ReferredEnumLiteral == item))
                {
                    this._parent.ReferredEnumLiteral = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ReferredEnumLiteral).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the referredEnumLiteral property
        /// </summary>
        private sealed class ReferredEnumLiteralProxy : ModelPropertyChange<IEnumLiteralExp, IEnumerationLiteral>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ReferredEnumLiteralProxy(IEnumLiteralExp modelElement) : 
                    base(modelElement, "referredEnumLiteral")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IEnumerationLiteral Value
            {
                get
                {
                    return this.ModelElement.ReferredEnumLiteral;
                }
                set
                {
                    this.ModelElement.ReferredEnumLiteral = value;
                }
            }
        }
    }
}
