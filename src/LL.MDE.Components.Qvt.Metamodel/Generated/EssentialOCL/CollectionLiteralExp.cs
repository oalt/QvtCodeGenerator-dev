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
    /// The default implementation of the CollectionLiteralExp class
    /// </summary>
    [XmlNamespaceAttribute("http://www.omg.org/spec/QVT/20140401/EssentialOCL")]
    [XmlNamespacePrefixAttribute("essentialocl")]
    [DebuggerDisplayAttribute("CollectionLiteralExp {Name}")]
    public class CollectionLiteralExp : LiteralExp, ICollectionLiteralExp, IModelElement
    {
        
        /// <summary>
        /// The backing field for the Kind property
        /// </summary>
        private Nullable<CollectionKind> _kind;
        
        /// <summary>
        /// The backing field for the Part property
        /// </summary>
        private CollectionLiteralExpPartCollection _part;
        
        private static NMF.Models.Meta.IClass _classInstance;
        
        public CollectionLiteralExp()
        {
            this._part = new CollectionLiteralExpPartCollection(this);
            //this._part.CollectionChanging += this.PartCollectionChanging;
            this._part.CollectionChanged += this.PartCollectionChanged;
        }
        
        /// <summary>
        /// The kind property
        /// </summary>
        [XmlElementNameAttribute("kind")]
        [XmlAttributeAttribute(true)]
        public virtual Nullable<CollectionKind> Kind
        {
            get
            {
                return this._kind;
            }
            set
            {
                if ((this._kind != value))
                {
                    this.OnKindChanging(EventArgs.Empty);
                    this.OnPropertyChanging("Kind");
                    Nullable<CollectionKind> old = this._kind;
                    this._kind = value;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnKindChanged(e);
                    this.OnPropertyChanged("Kind", e);
                }
            }
        }
        
        /// <summary>
        /// The part property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("part")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("collectionLiteralExp")]
        [ConstantAttribute()]
        public virtual ISetExpression<ICollectionLiteralPart> Part
        {
            get
            {
                return this._part;
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new CollectionLiteralExpChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new CollectionLiteralExpReferencedElementsCollection(this));
            }
        }
        
        /// <summary>
        /// Gets fired before the Kind property changes its value
        /// </summary>
        public event EventHandler KindChanging;
        
        /// <summary>
        /// Gets fired when the Kind property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> KindChanged;
        
        /// <summary>
        /// Raises the KindChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnKindChanging(EventArgs eventArgs)
        {
            EventHandler handler = this.KindChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the KindChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnKindChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.KindChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the Part property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        //private void PartCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        //{
        //    this.OnCollectionChanging("Part", e);
        //}
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the Part property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void PartCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Part", e);
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "KIND"))
            {
                return this.Kind;
            }
            return base.GetAttributeValue(attribute, index);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "PART"))
            {
                return this._part;
            }
            return base.GetCollectionForFeature(feature);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "KIND"))
            {
                this.Kind = ((CollectionKind)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override NMF.Models.Meta.IClass GetClass()
        {
            throw new NotSupportedException();
        }
        
        /// <summary>
        /// The collection class to to represent the children of the CollectionLiteralExp class
        /// </summary>
        public class CollectionLiteralExpChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private CollectionLiteralExp _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public CollectionLiteralExpChildrenCollection(CollectionLiteralExp parent)
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
                    count = (count + this._parent.Part.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.Part.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.Part.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                ICollectionLiteralPart partCasted = item.As<ICollectionLiteralPart>();
                if ((partCasted != null))
                {
                    this._parent.Part.Add(partCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Part.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.Part.Contains(item))
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
                IEnumerator<IModelElement> partEnumerator = this._parent.Part.GetEnumerator();
                try
                {
                    for (
                    ; partEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = partEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    partEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                ICollectionLiteralPart collectionLiteralPartItem = item.As<ICollectionLiteralPart>();
                if (((collectionLiteralPartItem != null) 
                            && this._parent.Part.Remove(collectionLiteralPartItem)))
                {
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Part).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the CollectionLiteralExp class
        /// </summary>
        public class CollectionLiteralExpReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private CollectionLiteralExp _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public CollectionLiteralExpReferencedElementsCollection(CollectionLiteralExp parent)
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
                    count = (count + this._parent.Part.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.Part.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.Part.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                ICollectionLiteralPart partCasted = item.As<ICollectionLiteralPart>();
                if ((partCasted != null))
                {
                    this._parent.Part.Add(partCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Part.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.Part.Contains(item))
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
                IEnumerator<IModelElement> partEnumerator = this._parent.Part.GetEnumerator();
                try
                {
                    for (
                    ; partEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = partEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    partEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                ICollectionLiteralPart collectionLiteralPartItem = item.As<ICollectionLiteralPart>();
                if (((collectionLiteralPartItem != null) 
                            && this._parent.Part.Remove(collectionLiteralPartItem)))
                {
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Part).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the kind property
        /// </summary>
        private sealed class KindProxy : ModelPropertyChange<ICollectionLiteralExp, Nullable<CollectionKind>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public KindProxy(ICollectionLiteralExp modelElement) : 
                    base(modelElement, "Kind")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<CollectionKind> Value
            {
                get
                {
                    return this.ModelElement.Kind;
                }
                set
                {
                    this.ModelElement.Kind = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            //protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            //{
            //    this.ModelElement.KindChanged += handler;
            //}
            
            ///// <summary>
            ///// Registers an event handler to subscribe specifically on the changed event for this property
            ///// </summary>
            ///// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            //protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            //{
            //    this.ModelElement.KindChanged -= handler;
            //}
        }
    }
}

