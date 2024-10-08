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
    /// The default implementation of the LoopExp class
    /// </summary>
    [XmlNamespaceAttribute("http://www.omg.org/spec/QVT/20140401/EssentialOCL")]
    [XmlNamespacePrefixAttribute("essentialocl")]
    [ModelRepresentationClassAttribute("http://www.omg.org/spec/QVT/20140401/EssentialOCL#//LoopExp")]
    [DebuggerDisplayAttribute("LoopExp {Name}")]
    public abstract partial class LoopExp : CallExp, ILoopExp, IModelElement
    {
        
        private static Lazy<NMF.Models.Meta.ITypedElement> _bodyReference = new Lazy<NMF.Models.Meta.ITypedElement>(RetrieveBodyReference);
        
        /// <summary>
        /// The backing field for the Body property
        /// </summary>
        [DebuggerBrowsableAttribute(DebuggerBrowsableState.Never)]
        private IOclExpression _body;
        
        private static Lazy<NMF.Models.Meta.ITypedElement> _iteratorReference = new Lazy<NMF.Models.Meta.ITypedElement>(RetrieveIteratorReference);
        
        /// <summary>
        /// The backing field for the Iterator property
        /// </summary>
        [DebuggerBrowsableAttribute(DebuggerBrowsableState.Never)]
        private ObservableCompositionOrderedSet<IVariable> _iterator;
        
        private static NMF.Models.Meta.IClass _classInstance;
        
        /// <summary>
        /// Creates a new instance
        /// </summary>
        public LoopExp()
        {
            this._iterator = new ObservableCompositionOrderedSet<IVariable>(this);
            this._iterator.CollectionChanging += this.IteratorCollectionChanging;
            this._iterator.CollectionChanged += this.IteratorCollectionChanged;
        }
        
        /// <summary>
        /// The body property
        /// </summary>
        [BrowsableAttribute(false)]
        [XmlElementNameAttribute("body")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        public IOclExpression Body
        {
            get
            {
                return this._body;
            }
            set
            {
                if ((this._body != value))
                {
                    IOclExpression old = this._body;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnBodyChanging(e);
                    this.OnPropertyChanging("Body", e, _bodyReference);
                    this._body = value;
                    if ((old != null))
                    {
                        if ((old.Parent == this))
                        {
                            old.Parent = null;
                        }
                        old.ParentChanged -= this.OnResetBody;
                    }
                    if ((value != null))
                    {
                        value.Parent = this;
                        value.ParentChanged += this.OnResetBody;
                    }
                    this.OnBodyChanged(e);
                    this.OnPropertyChanged("Body", e, _bodyReference);
                }
            }
        }
        
        /// <summary>
        /// The iterator property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [BrowsableAttribute(false)]
        [XmlElementNameAttribute("iterator")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [ConstantAttribute()]
        public IOrderedSetExpression<IVariable> Iterator
        {
            get
            {
                return this._iterator;
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new LoopExpChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new LoopExpReferencedElementsCollection(this));
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
                    _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("http://www.omg.org/spec/QVT/20140401/EssentialOCL#//LoopExp")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Body property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> BodyChanging;
        
        /// <summary>
        /// Gets fired when the Body property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> BodyChanged;
        
        private static NMF.Models.Meta.ITypedElement RetrieveBodyReference()
        {
            return ((NMF.Models.Meta.ITypedElement)(((ModelElement)(LL.MDE.Components.Qvt.Metamodel.EssentialOCL.LoopExp.ClassInstance)).Resolve("body")));
        }
        
        /// <summary>
        /// Raises the BodyChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnBodyChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.BodyChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the BodyChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnBodyChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.BodyChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Body property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetBody(object sender, System.EventArgs eventArgs)
        {
            this.Body = null;
        }
        
        private static NMF.Models.Meta.ITypedElement RetrieveIteratorReference()
        {
            return ((NMF.Models.Meta.ITypedElement)(((ModelElement)(LL.MDE.Components.Qvt.Metamodel.EssentialOCL.LoopExp.ClassInstance)).Resolve("iterator")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the Iterator property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void IteratorCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("Iterator", e, _iteratorReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the Iterator property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void IteratorCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Iterator", e, _iteratorReference);
        }
        
        /// <summary>
        /// Gets the relative URI fragment for the given child model element
        /// </summary>
        /// <returns>A fragment of the relative URI</returns>
        /// <param name="element">The element that should be looked for</param>
        protected override string GetRelativePathForNonIdentifiedChild(IModelElement element)
        {
            if ((element == this.Body))
            {
                return ModelHelper.CreatePath("body");
            }
            int iteratorIndex = ModelHelper.IndexOfReference(this.Iterator, element);
            if ((iteratorIndex != -1))
            {
                return ModelHelper.CreatePath("iterator", iteratorIndex);
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
            if ((reference == "BODY"))
            {
                return this.Body;
            }
            if ((reference == "ITERATOR"))
            {
                if ((index < this.Iterator.Count))
                {
                    return this.Iterator[index];
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
            if ((feature == "ITERATOR"))
            {
                return this._iterator;
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
            if ((feature == "BODY"))
            {
                this.Body = ((IOclExpression)(value));
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
            if ((reference == "BODY"))
            {
                return new BodyProxy(this);
            }
            return base.GetExpressionForReference(reference);
        }
        
        /// <summary>
        /// Gets the property name for the given container
        /// </summary>
        /// <returns>The name of the respective container reference</returns>
        /// <param name="container">The container object</param>
        protected override string GetCompositionName(object container)
        {
            if ((container == this._iterator))
            {
                return "iterator";
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
                _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("http://www.omg.org/spec/QVT/20140401/EssentialOCL#//LoopExp")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the LoopExp class
        /// </summary>
        public class LoopExpChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private LoopExp _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public LoopExpChildrenCollection(LoopExp parent)
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
                    if ((this._parent.Body != null))
                    {
                        count = (count + 1);
                    }
                    count = (count + this._parent.Iterator.Count);
                    return count;
                }
            }
            
            /// <summary>
            /// Registers event hooks to keep the collection up to date
            /// </summary>
            protected override void AttachCore()
            {
                this._parent.BodyChanged += this.PropagateValueChanges;
                this._parent.Iterator.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Unregisters all event hooks registered by AttachCore
            /// </summary>
            protected override void DetachCore()
            {
                this._parent.BodyChanged -= this.PropagateValueChanges;
                this._parent.Iterator.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.Body == null))
                {
                    IOclExpression bodyCasted = item.As<IOclExpression>();
                    if ((bodyCasted != null))
                    {
                        this._parent.Body = bodyCasted;
                        return;
                    }
                }
                IVariable iteratorCasted = item.As<IVariable>();
                if ((iteratorCasted != null))
                {
                    this._parent.Iterator.Add(iteratorCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Body = null;
                this._parent.Iterator.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.Body))
                {
                    return true;
                }
                if (this._parent.Iterator.Contains(item))
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
                if ((this._parent.Body != null))
                {
                    array[arrayIndex] = this._parent.Body;
                    arrayIndex = (arrayIndex + 1);
                }
                IEnumerator<IModelElement> iteratorEnumerator = this._parent.Iterator.GetEnumerator();
                try
                {
                    for (
                    ; iteratorEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = iteratorEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    iteratorEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                if ((this._parent.Body == item))
                {
                    this._parent.Body = null;
                    return true;
                }
                IVariable variableItem = item.As<IVariable>();
                if (((variableItem != null) 
                            && this._parent.Iterator.Remove(variableItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Body).Concat(this._parent.Iterator).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the LoopExp class
        /// </summary>
        public class LoopExpReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private LoopExp _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public LoopExpReferencedElementsCollection(LoopExp parent)
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
                    if ((this._parent.Body != null))
                    {
                        count = (count + 1);
                    }
                    count = (count + this._parent.Iterator.Count);
                    return count;
                }
            }
            
            /// <summary>
            /// Registers event hooks to keep the collection up to date
            /// </summary>
            protected override void AttachCore()
            {
                this._parent.BodyChanged += this.PropagateValueChanges;
                this._parent.Iterator.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Unregisters all event hooks registered by AttachCore
            /// </summary>
            protected override void DetachCore()
            {
                this._parent.BodyChanged -= this.PropagateValueChanges;
                this._parent.Iterator.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.Body == null))
                {
                    IOclExpression bodyCasted = item.As<IOclExpression>();
                    if ((bodyCasted != null))
                    {
                        this._parent.Body = bodyCasted;
                        return;
                    }
                }
                IVariable iteratorCasted = item.As<IVariable>();
                if ((iteratorCasted != null))
                {
                    this._parent.Iterator.Add(iteratorCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Body = null;
                this._parent.Iterator.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.Body))
                {
                    return true;
                }
                if (this._parent.Iterator.Contains(item))
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
                if ((this._parent.Body != null))
                {
                    array[arrayIndex] = this._parent.Body;
                    arrayIndex = (arrayIndex + 1);
                }
                IEnumerator<IModelElement> iteratorEnumerator = this._parent.Iterator.GetEnumerator();
                try
                {
                    for (
                    ; iteratorEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = iteratorEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    iteratorEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                if ((this._parent.Body == item))
                {
                    this._parent.Body = null;
                    return true;
                }
                IVariable variableItem = item.As<IVariable>();
                if (((variableItem != null) 
                            && this._parent.Iterator.Remove(variableItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Body).Concat(this._parent.Iterator).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the body property
        /// </summary>
        private sealed class BodyProxy : ModelPropertyChange<ILoopExp, IOclExpression>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public BodyProxy(ILoopExp modelElement) : 
                    base(modelElement, "body")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IOclExpression Value
            {
                get
                {
                    return this.ModelElement.Body;
                }
                set
                {
                    this.ModelElement.Body = value;
                }
            }
        }
    }
}
