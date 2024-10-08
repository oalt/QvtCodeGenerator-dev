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
    /// The default implementation of the Pattern class
    /// </summary>
    [XmlNamespaceAttribute("http://www.omg.org/spec/QVT/20140401/QVTBase")]
    [XmlNamespacePrefixAttribute("qvtbase")]
    [ModelRepresentationClassAttribute("http://www.omg.org/spec/QVT/20140401/QVTBase#//Pattern")]
    public partial class Pattern : Element, IPattern, IModelElement
    {
        
        private static Lazy<NMF.Models.Meta.ITypedElement> _bindsToReference = new Lazy<NMF.Models.Meta.ITypedElement>(RetrieveBindsToReference);
        
        /// <summary>
        /// The backing field for the BindsTo property
        /// </summary>
        [DebuggerBrowsableAttribute(DebuggerBrowsableState.Never)]
        private ObservableAssociationSet<IVariable> _bindsTo;
        
        private static Lazy<NMF.Models.Meta.ITypedElement> _predicateReference = new Lazy<NMF.Models.Meta.ITypedElement>(RetrievePredicateReference);
        
        /// <summary>
        /// The backing field for the Predicate property
        /// </summary>
        [DebuggerBrowsableAttribute(DebuggerBrowsableState.Never)]
        private PatternPredicateCollection _predicate;
        
        private static NMF.Models.Meta.IClass _classInstance;
        
        /// <summary>
        /// Creates a new instance
        /// </summary>
        public Pattern()
        {
            this._bindsTo = new ObservableAssociationSet<IVariable>();
            this._bindsTo.CollectionChanging += this.BindsToCollectionChanging;
            this._bindsTo.CollectionChanged += this.BindsToCollectionChanged;
            this._predicate = new PatternPredicateCollection(this);
            this._predicate.CollectionChanging += this.PredicateCollectionChanging;
            this._predicate.CollectionChanged += this.PredicateCollectionChanged;
        }
        
        /// <summary>
        /// The bindsTo property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [DisplayNameAttribute("bindsTo")]
        [CategoryAttribute("Pattern")]
        [XmlElementNameAttribute("bindsTo")]
        [XmlAttributeAttribute(true)]
        [ConstantAttribute()]
        public ISetExpression<IVariable> BindsTo
        {
            get
            {
                return this._bindsTo;
            }
        }
        
        /// <summary>
        /// The predicate property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [BrowsableAttribute(false)]
        [XmlElementNameAttribute("predicate")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("pattern")]
        [ConstantAttribute()]
        public IOrderedSetExpression<IPredicate> Predicate
        {
            get
            {
                return this._predicate;
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new PatternChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new PatternReferencedElementsCollection(this));
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
                    _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("http://www.omg.org/spec/QVT/20140401/QVTBase#//Pattern")));
                }
                return _classInstance;
            }
        }
        
        private static NMF.Models.Meta.ITypedElement RetrieveBindsToReference()
        {
            return ((NMF.Models.Meta.ITypedElement)(((ModelElement)(LL.MDE.Components.Qvt.Metamodel.QVTBase.Pattern.ClassInstance)).Resolve("bindsTo")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the BindsTo property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void BindsToCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("BindsTo", e, _bindsToReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the BindsTo property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void BindsToCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("BindsTo", e, _bindsToReference);
        }
        
        private static NMF.Models.Meta.ITypedElement RetrievePredicateReference()
        {
            return ((NMF.Models.Meta.ITypedElement)(((ModelElement)(LL.MDE.Components.Qvt.Metamodel.QVTBase.Pattern.ClassInstance)).Resolve("predicate")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the Predicate property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void PredicateCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("Predicate", e, _predicateReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the Predicate property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void PredicateCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Predicate", e, _predicateReference);
        }
        
        /// <summary>
        /// Gets the relative URI fragment for the given child model element
        /// </summary>
        /// <returns>A fragment of the relative URI</returns>
        /// <param name="element">The element that should be looked for</param>
        protected override string GetRelativePathForNonIdentifiedChild(IModelElement element)
        {
            int predicateIndex = ModelHelper.IndexOfReference(this.Predicate, element);
            if ((predicateIndex != -1))
            {
                return ModelHelper.CreatePath("predicate", predicateIndex);
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
            if ((reference == "PREDICATE"))
            {
                if ((index < this.Predicate.Count))
                {
                    return this.Predicate[index];
                }
                else
                {
                    return null;
                }
            }
            return base.GetModelElementForReference(reference, index);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "BINDSTO"))
            {
                return this._bindsTo;
            }
            if ((feature == "PREDICATE"))
            {
                return this._predicate;
            }
            return base.GetCollectionForFeature(feature);
        }
        
        /// <summary>
        /// Gets the property name for the given container
        /// </summary>
        /// <returns>The name of the respective container reference</returns>
        /// <param name="container">The container object</param>
        protected override string GetCompositionName(object container)
        {
            if ((container == this._predicate))
            {
                return "predicate";
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
                _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("http://www.omg.org/spec/QVT/20140401/QVTBase#//Pattern")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the Pattern class
        /// </summary>
        public class PatternChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private Pattern _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public PatternChildrenCollection(Pattern parent)
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
                    count = (count + this._parent.Predicate.Count);
                    return count;
                }
            }
            
            /// <summary>
            /// Registers event hooks to keep the collection up to date
            /// </summary>
            protected override void AttachCore()
            {
                this._parent.Predicate.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Unregisters all event hooks registered by AttachCore
            /// </summary>
            protected override void DetachCore()
            {
                this._parent.Predicate.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IPredicate predicateCasted = item.As<IPredicate>();
                if ((predicateCasted != null))
                {
                    this._parent.Predicate.Add(predicateCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Predicate.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.Predicate.Contains(item))
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
                IEnumerator<IModelElement> predicateEnumerator = this._parent.Predicate.GetEnumerator();
                try
                {
                    for (
                    ; predicateEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = predicateEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    predicateEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IPredicate predicateItem = item.As<IPredicate>();
                if (((predicateItem != null) 
                            && this._parent.Predicate.Remove(predicateItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Predicate).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the Pattern class
        /// </summary>
        public class PatternReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private Pattern _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public PatternReferencedElementsCollection(Pattern parent)
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
                    count = (count + this._parent.BindsTo.Count);
                    count = (count + this._parent.Predicate.Count);
                    return count;
                }
            }
            
            /// <summary>
            /// Registers event hooks to keep the collection up to date
            /// </summary>
            protected override void AttachCore()
            {
                this._parent.BindsTo.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.Predicate.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Unregisters all event hooks registered by AttachCore
            /// </summary>
            protected override void DetachCore()
            {
                this._parent.BindsTo.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.Predicate.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IVariable bindsToCasted = item.As<IVariable>();
                if ((bindsToCasted != null))
                {
                    this._parent.BindsTo.Add(bindsToCasted);
                }
                IPredicate predicateCasted = item.As<IPredicate>();
                if ((predicateCasted != null))
                {
                    this._parent.Predicate.Add(predicateCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.BindsTo.Clear();
                this._parent.Predicate.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.BindsTo.Contains(item))
                {
                    return true;
                }
                if (this._parent.Predicate.Contains(item))
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
                IEnumerator<IModelElement> bindsToEnumerator = this._parent.BindsTo.GetEnumerator();
                try
                {
                    for (
                    ; bindsToEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = bindsToEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    bindsToEnumerator.Dispose();
                }
                IEnumerator<IModelElement> predicateEnumerator = this._parent.Predicate.GetEnumerator();
                try
                {
                    for (
                    ; predicateEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = predicateEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    predicateEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IVariable variableItem = item.As<IVariable>();
                if (((variableItem != null) 
                            && this._parent.BindsTo.Remove(variableItem)))
                {
                    return true;
                }
                IPredicate predicateItem = item.As<IPredicate>();
                if (((predicateItem != null) 
                            && this._parent.Predicate.Remove(predicateItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.BindsTo).Concat(this._parent.Predicate).GetEnumerator();
            }
        }
    }
}
