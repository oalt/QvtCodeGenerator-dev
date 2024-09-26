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
    /// The default implementation of the IfExp class
    /// </summary>
    [XmlNamespaceAttribute("http://www.omg.org/spec/QVT/20140401/EssentialOCL")]
    [XmlNamespacePrefixAttribute("essentialocl")]
    [ModelRepresentationClassAttribute("http://www.omg.org/spec/QVT/20140401/EssentialOCL#//IfExp")]
    [DebuggerDisplayAttribute("IfExp {Name}")]
    public partial class IfExp : OclExpression, IIfExp, IModelElement
    {
        
        private static Lazy<NMF.Models.Meta.ITypedElement> _conditionReference = new Lazy<NMF.Models.Meta.ITypedElement>(RetrieveConditionReference);
        
        /// <summary>
        /// The backing field for the Condition property
        /// </summary>
        [DebuggerBrowsableAttribute(DebuggerBrowsableState.Never)]
        private IOclExpression _condition;
        
        private static Lazy<NMF.Models.Meta.ITypedElement> _elseExpressionReference = new Lazy<NMF.Models.Meta.ITypedElement>(RetrieveElseExpressionReference);
        
        /// <summary>
        /// The backing field for the ElseExpression property
        /// </summary>
        [DebuggerBrowsableAttribute(DebuggerBrowsableState.Never)]
        private IOclExpression _elseExpression;
        
        private static Lazy<NMF.Models.Meta.ITypedElement> _thenExpressionReference = new Lazy<NMF.Models.Meta.ITypedElement>(RetrieveThenExpressionReference);
        
        /// <summary>
        /// The backing field for the ThenExpression property
        /// </summary>
        [DebuggerBrowsableAttribute(DebuggerBrowsableState.Never)]
        private IOclExpression _thenExpression;
        
        private static NMF.Models.Meta.IClass _classInstance;
        
        /// <summary>
        /// The condition property
        /// </summary>
        [BrowsableAttribute(false)]
        [XmlElementNameAttribute("condition")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        public IOclExpression Condition
        {
            get
            {
                return this._condition;
            }
            set
            {
                if ((this._condition != value))
                {
                    IOclExpression old = this._condition;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnConditionChanging(e);
                    this.OnPropertyChanging("Condition", e, _conditionReference);
                    this._condition = value;
                    if ((old != null))
                    {
                        if ((old.Parent == this))
                        {
                            old.Parent = null;
                        }
                        old.ParentChanged -= this.OnResetCondition;
                    }
                    if ((value != null))
                    {
                        value.Parent = this;
                        value.ParentChanged += this.OnResetCondition;
                    }
                    this.OnConditionChanged(e);
                    this.OnPropertyChanged("Condition", e, _conditionReference);
                }
            }
        }
        
        /// <summary>
        /// The elseExpression property
        /// </summary>
        [BrowsableAttribute(false)]
        [XmlElementNameAttribute("elseExpression")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        public IOclExpression ElseExpression
        {
            get
            {
                return this._elseExpression;
            }
            set
            {
                if ((this._elseExpression != value))
                {
                    IOclExpression old = this._elseExpression;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnElseExpressionChanging(e);
                    this.OnPropertyChanging("ElseExpression", e, _elseExpressionReference);
                    this._elseExpression = value;
                    if ((old != null))
                    {
                        if ((old.Parent == this))
                        {
                            old.Parent = null;
                        }
                        old.ParentChanged -= this.OnResetElseExpression;
                    }
                    if ((value != null))
                    {
                        value.Parent = this;
                        value.ParentChanged += this.OnResetElseExpression;
                    }
                    this.OnElseExpressionChanged(e);
                    this.OnPropertyChanged("ElseExpression", e, _elseExpressionReference);
                }
            }
        }
        
        /// <summary>
        /// The thenExpression property
        /// </summary>
        [BrowsableAttribute(false)]
        [XmlElementNameAttribute("thenExpression")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        public IOclExpression ThenExpression
        {
            get
            {
                return this._thenExpression;
            }
            set
            {
                if ((this._thenExpression != value))
                {
                    IOclExpression old = this._thenExpression;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnThenExpressionChanging(e);
                    this.OnPropertyChanging("ThenExpression", e, _thenExpressionReference);
                    this._thenExpression = value;
                    if ((old != null))
                    {
                        if ((old.Parent == this))
                        {
                            old.Parent = null;
                        }
                        old.ParentChanged -= this.OnResetThenExpression;
                    }
                    if ((value != null))
                    {
                        value.Parent = this;
                        value.ParentChanged += this.OnResetThenExpression;
                    }
                    this.OnThenExpressionChanged(e);
                    this.OnPropertyChanged("ThenExpression", e, _thenExpressionReference);
                }
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new IfExpChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new IfExpReferencedElementsCollection(this));
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
                    _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("http://www.omg.org/spec/QVT/20140401/EssentialOCL#//IfExp")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Condition property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ConditionChanging;
        
        /// <summary>
        /// Gets fired when the Condition property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ConditionChanged;
        
        /// <summary>
        /// Gets fired before the ElseExpression property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ElseExpressionChanging;
        
        /// <summary>
        /// Gets fired when the ElseExpression property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ElseExpressionChanged;
        
        /// <summary>
        /// Gets fired before the ThenExpression property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ThenExpressionChanging;
        
        /// <summary>
        /// Gets fired when the ThenExpression property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ThenExpressionChanged;
        
        private static NMF.Models.Meta.ITypedElement RetrieveConditionReference()
        {
            return ((NMF.Models.Meta.ITypedElement)(((ModelElement)(LL.MDE.Components.Qvt.Metamodel.EssentialOCL.IfExp.ClassInstance)).Resolve("condition")));
        }
        
        /// <summary>
        /// Raises the ConditionChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnConditionChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ConditionChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ConditionChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnConditionChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ConditionChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Condition property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetCondition(object sender, System.EventArgs eventArgs)
        {
            this.Condition = null;
        }
        
        private static NMF.Models.Meta.ITypedElement RetrieveElseExpressionReference()
        {
            return ((NMF.Models.Meta.ITypedElement)(((ModelElement)(LL.MDE.Components.Qvt.Metamodel.EssentialOCL.IfExp.ClassInstance)).Resolve("elseExpression")));
        }
        
        /// <summary>
        /// Raises the ElseExpressionChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnElseExpressionChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ElseExpressionChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ElseExpressionChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnElseExpressionChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ElseExpressionChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the ElseExpression property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetElseExpression(object sender, System.EventArgs eventArgs)
        {
            this.ElseExpression = null;
        }
        
        private static NMF.Models.Meta.ITypedElement RetrieveThenExpressionReference()
        {
            return ((NMF.Models.Meta.ITypedElement)(((ModelElement)(LL.MDE.Components.Qvt.Metamodel.EssentialOCL.IfExp.ClassInstance)).Resolve("thenExpression")));
        }
        
        /// <summary>
        /// Raises the ThenExpressionChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnThenExpressionChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ThenExpressionChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ThenExpressionChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnThenExpressionChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ThenExpressionChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the ThenExpression property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetThenExpression(object sender, System.EventArgs eventArgs)
        {
            this.ThenExpression = null;
        }
        
        /// <summary>
        /// Gets the relative URI fragment for the given child model element
        /// </summary>
        /// <returns>A fragment of the relative URI</returns>
        /// <param name="element">The element that should be looked for</param>
        protected override string GetRelativePathForNonIdentifiedChild(IModelElement element)
        {
            if ((element == this.Condition))
            {
                return ModelHelper.CreatePath("condition");
            }
            if ((element == this.ElseExpression))
            {
                return ModelHelper.CreatePath("elseExpression");
            }
            if ((element == this.ThenExpression))
            {
                return ModelHelper.CreatePath("thenExpression");
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
            if ((reference == "CONDITION"))
            {
                return this.Condition;
            }
            if ((reference == "ELSEEXPRESSION"))
            {
                return this.ElseExpression;
            }
            if ((reference == "THENEXPRESSION"))
            {
                return this.ThenExpression;
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
            if ((feature == "CONDITION"))
            {
                this.Condition = ((IOclExpression)(value));
                return;
            }
            if ((feature == "ELSEEXPRESSION"))
            {
                this.ElseExpression = ((IOclExpression)(value));
                return;
            }
            if ((feature == "THENEXPRESSION"))
            {
                this.ThenExpression = ((IOclExpression)(value));
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
            if ((reference == "CONDITION"))
            {
                return new ConditionProxy(this);
            }
            if ((reference == "ELSEEXPRESSION"))
            {
                return new ElseExpressionProxy(this);
            }
            if ((reference == "THENEXPRESSION"))
            {
                return new ThenExpressionProxy(this);
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
                _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("http://www.omg.org/spec/QVT/20140401/EssentialOCL#//IfExp")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the IfExp class
        /// </summary>
        public class IfExpChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private IfExp _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public IfExpChildrenCollection(IfExp parent)
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
                    if ((this._parent.Condition != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.ElseExpression != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.ThenExpression != null))
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
                this._parent.ConditionChanged += this.PropagateValueChanges;
                this._parent.ElseExpressionChanged += this.PropagateValueChanges;
                this._parent.ThenExpressionChanged += this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Unregisters all event hooks registered by AttachCore
            /// </summary>
            protected override void DetachCore()
            {
                this._parent.ConditionChanged -= this.PropagateValueChanges;
                this._parent.ElseExpressionChanged -= this.PropagateValueChanges;
                this._parent.ThenExpressionChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.Condition == null))
                {
                    IOclExpression conditionCasted = item.As<IOclExpression>();
                    if ((conditionCasted != null))
                    {
                        this._parent.Condition = conditionCasted;
                        return;
                    }
                }
                if ((this._parent.ElseExpression == null))
                {
                    IOclExpression elseExpressionCasted = item.As<IOclExpression>();
                    if ((elseExpressionCasted != null))
                    {
                        this._parent.ElseExpression = elseExpressionCasted;
                        return;
                    }
                }
                if ((this._parent.ThenExpression == null))
                {
                    IOclExpression thenExpressionCasted = item.As<IOclExpression>();
                    if ((thenExpressionCasted != null))
                    {
                        this._parent.ThenExpression = thenExpressionCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Condition = null;
                this._parent.ElseExpression = null;
                this._parent.ThenExpression = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.Condition))
                {
                    return true;
                }
                if ((item == this._parent.ElseExpression))
                {
                    return true;
                }
                if ((item == this._parent.ThenExpression))
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
                if ((this._parent.Condition != null))
                {
                    array[arrayIndex] = this._parent.Condition;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.ElseExpression != null))
                {
                    array[arrayIndex] = this._parent.ElseExpression;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.ThenExpression != null))
                {
                    array[arrayIndex] = this._parent.ThenExpression;
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
                if ((this._parent.Condition == item))
                {
                    this._parent.Condition = null;
                    return true;
                }
                if ((this._parent.ElseExpression == item))
                {
                    this._parent.ElseExpression = null;
                    return true;
                }
                if ((this._parent.ThenExpression == item))
                {
                    this._parent.ThenExpression = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Condition).Concat(this._parent.ElseExpression).Concat(this._parent.ThenExpression).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the IfExp class
        /// </summary>
        public class IfExpReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private IfExp _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public IfExpReferencedElementsCollection(IfExp parent)
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
                    if ((this._parent.Condition != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.ElseExpression != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.ThenExpression != null))
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
                this._parent.ConditionChanged += this.PropagateValueChanges;
                this._parent.ElseExpressionChanged += this.PropagateValueChanges;
                this._parent.ThenExpressionChanged += this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Unregisters all event hooks registered by AttachCore
            /// </summary>
            protected override void DetachCore()
            {
                this._parent.ConditionChanged -= this.PropagateValueChanges;
                this._parent.ElseExpressionChanged -= this.PropagateValueChanges;
                this._parent.ThenExpressionChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.Condition == null))
                {
                    IOclExpression conditionCasted = item.As<IOclExpression>();
                    if ((conditionCasted != null))
                    {
                        this._parent.Condition = conditionCasted;
                        return;
                    }
                }
                if ((this._parent.ElseExpression == null))
                {
                    IOclExpression elseExpressionCasted = item.As<IOclExpression>();
                    if ((elseExpressionCasted != null))
                    {
                        this._parent.ElseExpression = elseExpressionCasted;
                        return;
                    }
                }
                if ((this._parent.ThenExpression == null))
                {
                    IOclExpression thenExpressionCasted = item.As<IOclExpression>();
                    if ((thenExpressionCasted != null))
                    {
                        this._parent.ThenExpression = thenExpressionCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Condition = null;
                this._parent.ElseExpression = null;
                this._parent.ThenExpression = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.Condition))
                {
                    return true;
                }
                if ((item == this._parent.ElseExpression))
                {
                    return true;
                }
                if ((item == this._parent.ThenExpression))
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
                if ((this._parent.Condition != null))
                {
                    array[arrayIndex] = this._parent.Condition;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.ElseExpression != null))
                {
                    array[arrayIndex] = this._parent.ElseExpression;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.ThenExpression != null))
                {
                    array[arrayIndex] = this._parent.ThenExpression;
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
                if ((this._parent.Condition == item))
                {
                    this._parent.Condition = null;
                    return true;
                }
                if ((this._parent.ElseExpression == item))
                {
                    this._parent.ElseExpression = null;
                    return true;
                }
                if ((this._parent.ThenExpression == item))
                {
                    this._parent.ThenExpression = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Condition).Concat(this._parent.ElseExpression).Concat(this._parent.ThenExpression).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the condition property
        /// </summary>
        private sealed class ConditionProxy : ModelPropertyChange<IIfExp, IOclExpression>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ConditionProxy(IIfExp modelElement) : 
                    base(modelElement, "condition")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IOclExpression Value
            {
                get
                {
                    return this.ModelElement.Condition;
                }
                set
                {
                    this.ModelElement.Condition = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the elseExpression property
        /// </summary>
        private sealed class ElseExpressionProxy : ModelPropertyChange<IIfExp, IOclExpression>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ElseExpressionProxy(IIfExp modelElement) : 
                    base(modelElement, "elseExpression")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IOclExpression Value
            {
                get
                {
                    return this.ModelElement.ElseExpression;
                }
                set
                {
                    this.ModelElement.ElseExpression = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the thenExpression property
        /// </summary>
        private sealed class ThenExpressionProxy : ModelPropertyChange<IIfExp, IOclExpression>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ThenExpressionProxy(IIfExp modelElement) : 
                    base(modelElement, "thenExpression")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IOclExpression Value
            {
                get
                {
                    return this.ModelElement.ThenExpression;
                }
                set
                {
                    this.ModelElement.ThenExpression = value;
                }
            }
        }
    }
}
