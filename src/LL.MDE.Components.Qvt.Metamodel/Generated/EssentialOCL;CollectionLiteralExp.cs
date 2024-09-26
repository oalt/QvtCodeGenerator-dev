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
    /// The default implementation of the CollectionLiteralExp class
    /// </summary>
    [XmlNamespaceAttribute("http://www.omg.org/spec/QVT/20140401/EssentialOCL")]
    [XmlNamespacePrefixAttribute("essentialocl")]
    [ModelRepresentationClassAttribute("http://www.omg.org/spec/QVT/20140401/EssentialOCL#//CollectionLiteralExp")]
    [DebuggerDisplayAttribute("CollectionLiteralExp {Name}")]
    public partial class CollectionLiteralExp : LiteralExp, ICollectionLiteralExp, IModelElement
    {
        
        /// <summary>
        /// The backing field for the Kind property
        /// </summary>
        [DebuggerBrowsableAttribute(DebuggerBrowsableState.Never)]
        private Nullable<CollectionKind> _kind;
        
        private static Lazy<NMF.Models.Meta.ITypedElement> _kindAttribute = new Lazy<NMF.Models.Meta.ITypedElement>(RetrieveKindAttribute);
        
        private static Lazy<NMF.Models.Meta.ITypedElement> _partReference = new Lazy<NMF.Models.Meta.ITypedElement>(RetrievePartReference);
        
        /// <summary>
        /// The backing field for the Part property
        /// </summary>
        [DebuggerBrowsableAttribute(DebuggerBrowsableState.Never)]
        private CollectionLiteralExpPartCollection _part;
        
        private static NMF.Models.Meta.IClass _classInstance;
        
        /// <summary>
        /// Creates a new instance
        /// </summary>
        public CollectionLiteralExp()
        {
            this._part = new CollectionLiteralExpPartCollection(this);
            this._part.CollectionChanging += this.PartCollectionChanging;
            this._part.CollectionChanged += this.PartCollectionChanged;
        }
        
        /// <summary>
        /// The kind property
        /// </summary>
        [DisplayNameAttribute("kind")]
        [CategoryAttribute("CollectionLiteralExp")]
        [XmlElementNameAttribute("kind")]
        [XmlAttributeAttribute(true)]
        public Nullable<CollectionKind> Kind
        {
            get
            {
                return this._kind;
            }
            set
            {
                if ((this._kind != value))
                {
                    Nullable<CollectionKind> old = this._kind;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnKindChanging(e);
                    this.OnPropertyChanging("Kind", e, _kindAttribute);
                    this._kind = value;
                    this.OnKindChanged(e);
                    this.OnPropertyChanged("Kind", e, _kindAttribute);
                }
            }
        }
        
        /// <summary>
        /// The part property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [BrowsableAttribute(false)]
        [XmlElementNameAttribute("part")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("collectionLiteralExp")]
        [ConstantAttribute()]
        public IOrderedSetExpression<ICollectionLiteralPart> Part
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
        /// Gets the Class model for this type
        /// </summary>
        public new static NMF.Models.Meta.IClass ClassInstance
        {
            get
            {
                if ((_classInstance == null))
                {
                    _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("http://www.omg.org/spec/QVT/20140401/EssentialOCL#//CollectionLiteralExp")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired when the Kind property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> KindChanged;
        
        /// <summary>
        /// Gets fired before the Kind property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> KindChanging;
        
        private static NMF.Models.Meta.ITypedElement RetrieveKindAttribute()
        {
            return ((NMF.Models.Meta.ITypedElement)(((ModelElement)(LL.MDE.Components.Qvt.Metamodel.EssentialOCL.CollectionLiteralExp.ClassInstance)).Resolve("kind")));
        }
        
        /// <summary>
        /// Raises the KindChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnKindChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.KindChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the KindChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnKindChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.KindChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static NMF.Models.Meta.ITypedElement RetrievePartReference()
        {
            return ((NMF.Models.Meta.ITypedElement)(((ModelElement)(LL.MDE.Components.Qvt.Metamodel.EssentialOCL.CollectionLiteralExp.ClassInstance)).Resolve("part")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the Part property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void PartCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("Part", e, _partReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the Part property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void PartCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Part", e, _partReference);
        }
        
        /// <summary>
        /// Gets the relative URI fragment for the given child model element
        /// </summary>
        /// <returns>A fragment of the relative URI</returns>
        /// <param name="element">The element that should be looked for</param>
        protected override string GetRelativePathForNonIdentifiedChild(IModelElement element)
        {
            int partIndex = ModelHelper.IndexOfReference(this.Part, element);
            if ((partIndex != -1))
            {
                return ModelHelper.CreatePath("part", partIndex);
            }
            return base.GetRelativePathForNonIdentifiedChild(element);
        }
        
        /// <summary>
        /// Resolves the given URI to a child model element
        /// </summary>
        /// <returns>The model element or null if it could not be found</returns>
        /// <param name="reference">The requested reference name</param>
        /// <param name="index">The index of this reference</param>
        protected override IModelElement GetModelElementForReference(string reference, int index)
        {
            if ((reference == "PART"))
            {
                if ((index < this.Part.Count))
                {
                    return this.Part[index];
                }
                else
                {
                    return null;
                }
            }
            return base.GetModelElementForReference(reference, index);
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
        /// Gets the property expression for the given attribute
        /// </summary>
        /// <returns>An incremental property expression</returns>
        /// <param name="attribute">The requested attribute in upper case</param>
        protected override NMF.Expressions.INotifyExpression<object> GetExpressionForAttribute(string attribute)
        {
            if ((attribute == "KIND"))
            {
                return Observable.Box(new KindProxy(this));
            }
            return base.GetExpressionForAttribute(attribute);
        }
        
        /// <summary>
        /// Gets the property name for the given container
        /// </summary>
        /// <returns>The name of the respective container reference</returns>
        /// <param name="container">The container object</param>
        protected override string GetCompositionName(object container)
        {
            if ((container == this._part))
            {
                return "part";
            }
            return base.GetCompositionName(container);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override NMF.Models.Meta.IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("http://www.omg.org/spec/QVT/20140401/EssentialOCL#//CollectionLiteralExp")));
            }
            return _classInstance;
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
            
            /// <summary>
            /// Registers event hooks to keep the collection up to date
            /// </summary>
            protected override void AttachCore()
            {
                this._parent.Part.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Unregisters all event hooks registered by AttachCore
            /// </summary>
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
            
            /// <summary>
            /// Registers event hooks to keep the collection up to date
            /// </summary>
            protected override void AttachCore()
            {
                this._parent.Part.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Unregisters all event hooks registered by AttachCore
            /// </summary>
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
                    base(modelElement, "kind")
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
        }
    }
}
