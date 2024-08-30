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
using LL.MDE.Components.Qvt.Metamodel.EssentialOCL;
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

namespace LL.MDE.Components.Qvt.Metamodel.QVTBase
{
    
    
    /// <summary>
    /// The default implementation of the Domain class
    /// </summary>
    [XmlNamespaceAttribute("http://www.omg.org/spec/QVT/20140401/QVTBase")]
    [XmlNamespacePrefixAttribute("qvtbase")]
    [DebuggerDisplayAttribute("Domain {Name}")]
    public abstract class Domain : NamedElement, IDomain, IModelElement
    {
        
        /// <summary>
        /// The backing field for the IsCheckable property
        /// </summary>
        private Nullable<bool> _isCheckable;
        
        /// <summary>
        /// The backing field for the IsEnforceable property
        /// </summary>
        private Nullable<bool> _isEnforceable;
        
        /// <summary>
        /// The backing field for the TypedModel property
        /// </summary>
        private ITypedModel _typedModel;
        
        private static NMF.Models.Meta.IClass _classInstance;
        
        /// <summary>
        /// The isCheckable property
        /// </summary>
        [XmlElementNameAttribute("isCheckable")]
        [XmlAttributeAttribute(true)]
        public virtual Nullable<bool> IsCheckable
        {
            get
            {
                return this._isCheckable;
            }
            set
            {
                if ((this._isCheckable != value))
                {
                    this.OnIsCheckableChanging(EventArgs.Empty);
                    this.OnPropertyChanging("IsCheckable");
                    Nullable<bool> old = this._isCheckable;
                    this._isCheckable = value;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnIsCheckableChanged(e);
                    this.OnPropertyChanged("IsCheckable", e);
                }
            }
        }
        
        /// <summary>
        /// The isEnforceable property
        /// </summary>
        [XmlElementNameAttribute("isEnforceable")]
        [XmlAttributeAttribute(true)]
        public virtual Nullable<bool> IsEnforceable
        {
            get
            {
                return this._isEnforceable;
            }
            set
            {
                if ((this._isEnforceable != value))
                {
                    this.OnIsEnforceableChanging(EventArgs.Empty);
                    this.OnPropertyChanging("IsEnforceable");
                    Nullable<bool> old = this._isEnforceable;
                    this._isEnforceable = value;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnIsEnforceableChanged(e);
                    this.OnPropertyChanged("IsEnforceable", e);
                }
            }
        }
        
        /// <summary>
        /// The rule property
        /// </summary>
        [XmlElementNameAttribute("rule")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("domain")]
        public virtual IRule Rule
        {
            get
            {
                return ModelHelper.CastAs<IRule>(this.Parent);
            }
            set
            {
                this.Parent = value;
            }
        }
        
        /// <summary>
        /// The typedModel property
        /// </summary>
        [XmlElementNameAttribute("typedModel")]
        [XmlAttributeAttribute(true)]
        public virtual ITypedModel TypedModel
        {
            get
            {
                return this._typedModel;
            }
            set
            {
                if ((this._typedModel != value))
                {
                    this.OnTypedModelChanging(EventArgs.Empty);
                    this.OnPropertyChanging("TypedModel");
                    ITypedModel old = this._typedModel;
                    this._typedModel = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetTypedModel;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetTypedModel;
                    }
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnTypedModelChanged(e);
                    this.OnPropertyChanged("TypedModel", e);
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
                return base.ReferencedElements.Concat(new DomainReferencedElementsCollection(this));
            }
        }
        
        /// <summary>
        /// Gets fired before the IsCheckable property changes its value
        /// </summary>
        public event EventHandler IsCheckableChanging;
        
        /// <summary>
        /// Gets fired when the IsCheckable property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> IsCheckableChanged;
        
        /// <summary>
        /// Gets fired before the IsEnforceable property changes its value
        /// </summary>
        public event EventHandler IsEnforceableChanging;
        
        /// <summary>
        /// Gets fired when the IsEnforceable property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> IsEnforceableChanged;
        
        /// <summary>
        /// Gets fired when the Rule property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> RuleChanged;
        
        /// <summary>
        /// Gets fired before the TypedModel property changes its value
        /// </summary>
        public event EventHandler TypedModelChanging;
        
        /// <summary>
        /// Gets fired when the TypedModel property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> TypedModelChanged;
        
        /// <summary>
        /// Raises the IsCheckableChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnIsCheckableChanging(EventArgs eventArgs)
        {
            EventHandler handler = this.IsCheckableChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the IsCheckableChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnIsCheckableChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.IsCheckableChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the IsEnforceableChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnIsEnforceableChanging(EventArgs eventArgs)
        {
            EventHandler handler = this.IsEnforceableChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the IsEnforceableChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnIsEnforceableChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.IsEnforceableChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the RuleChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRuleChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.RuleChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Gets called when the parent model element of the current model element changes
        /// </summary>
        /// <param name="oldParent">The old parent model element</param>
        /// <param name="newParent">The new parent model element</param>
        protected override void OnParentChanged(IModelElement newParent, IModelElement oldParent)
        {
            IRule oldRule = ModelHelper.CastAs<IRule>(oldParent);
            IRule newRule = ModelHelper.CastAs<IRule>(newParent);
            if ((oldRule != null))
            {
                oldRule.Domain.Remove(this);
            }
            if ((newRule != null))
            {
                newRule.Domain.Add(this);
            }
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldRule, newRule);
            this.OnRuleChanged(e);
            this.OnPropertyChanged("Rule", e);
        }
        
        /// <summary>
        /// Raises the TypedModelChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTypedModelChanging(EventArgs eventArgs)
        {
            EventHandler handler = this.TypedModelChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the TypedModelChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTypedModelChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.TypedModelChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the TypedModel property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetTypedModel(object sender, System.EventArgs eventArgs)
        {
            this.TypedModel = null;
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "ISCHECKABLE"))
            {
                return this.IsCheckable;
            }
            if ((attribute == "ISENFORCEABLE"))
            {
                return this.IsEnforceable;
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
            if ((feature == "RULE"))
            {
                this.Rule = ((IRule)(value));
                return;
            }
            if ((feature == "TYPEDMODEL"))
            {
                this.TypedModel = ((ITypedModel)(value));
                return;
            }
            if ((feature == "ISCHECKABLE"))
            {
                this.IsCheckable = ((bool)(value));
                return;
            }
            if ((feature == "ISENFORCEABLE"))
            {
                this.IsEnforceable = ((bool)(value));
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
            if ((attribute == "RULE"))
            {
                return new RuleProxy(this);
            }
            if ((attribute == "TYPEDMODEL"))
            {
                return new TypedModelProxy(this);
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
            if ((reference == "RULE"))
            {
                return new RuleProxy(this);
            }
            if ((reference == "TYPEDMODEL"))
            {
                return new TypedModelProxy(this);
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
        /// The collection class to to represent the children of the Domain class
        /// </summary>
        public class DomainReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private Domain _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public DomainReferencedElementsCollection(Domain parent)
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
                    if ((this._parent.Rule != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.TypedModel != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.RuleChanged += this.PropagateValueChanges;
                this._parent.TypedModelChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.RuleChanged -= this.PropagateValueChanges;
                this._parent.TypedModelChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.Rule == null))
                {
                    IRule ruleCasted = item.As<IRule>();
                    if ((ruleCasted != null))
                    {
                        this._parent.Rule = ruleCasted;
                        return;
                    }
                }
                if ((this._parent.TypedModel == null))
                {
                    ITypedModel typedModelCasted = item.As<ITypedModel>();
                    if ((typedModelCasted != null))
                    {
                        this._parent.TypedModel = typedModelCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Rule = null;
                this._parent.TypedModel = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.Rule))
                {
                    return true;
                }
                if ((item == this._parent.TypedModel))
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
                if ((this._parent.Rule != null))
                {
                    array[arrayIndex] = this._parent.Rule;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.TypedModel != null))
                {
                    array[arrayIndex] = this._parent.TypedModel;
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
                if ((this._parent.Rule == item))
                {
                    this._parent.Rule = null;
                    return true;
                }
                if ((this._parent.TypedModel == item))
                {
                    this._parent.TypedModel = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Rule).Concat(this._parent.TypedModel).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the isCheckable property
        /// </summary>
        private sealed class IsCheckableProxy : ModelPropertyChange<IDomain, Nullable<bool>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public IsCheckableProxy(IDomain modelElement) : 
                    base(modelElement, "IsCheckable")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<bool> Value
            {
                get
                {
                    return this.ModelElement.IsCheckable;
                }
                set
                {
                    this.ModelElement.IsCheckable = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            //protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            //{
            //    this.ModelElement.IsCheckableChanged += handler;
            //}
            
            ///// <summary>
            ///// Registers an event handler to subscribe specifically on the changed event for this property
            ///// </summary>
            ///// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            //protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            //{
            //    this.ModelElement.IsCheckableChanged -= handler;
            //}
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the isEnforceable property
        /// </summary>
        private sealed class IsEnforceableProxy : ModelPropertyChange<IDomain, Nullable<bool>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public IsEnforceableProxy(IDomain modelElement) : 
                    base(modelElement, "IsEnforcable")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<bool> Value
            {
                get
                {
                    return this.ModelElement.IsEnforceable;
                }
                set
                {
                    this.ModelElement.IsEnforceable = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            //protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            //{
            //    this.ModelElement.IsEnforceableChanged += handler;
            //}
            
            ///// <summary>
            ///// Registers an event handler to subscribe specifically on the changed event for this property
            ///// </summary>
            ///// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            //protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            //{
            //    this.ModelElement.IsEnforceableChanged -= handler;
            //}
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the rule property
        /// </summary>
        private sealed class RuleProxy : ModelPropertyChange<IDomain, IRule>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public RuleProxy(IDomain modelElement) : 
                    base(modelElement, "Rule")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IRule Value
            {
                get
                {
                    return this.ModelElement.Rule;
                }
                set
                {
                    this.ModelElement.Rule = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            //protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            //{
            //    this.ModelElement.RuleChanged += handler;
            //}
            
            ///// <summary>
            ///// Registers an event handler to subscribe specifically on the changed event for this property
            ///// </summary>
            ///// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            //protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            //{
            //    this.ModelElement.RuleChanged -= handler;
            //}
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the typedModel property
        /// </summary>
        private sealed class TypedModelProxy : ModelPropertyChange<IDomain, ITypedModel>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public TypedModelProxy(IDomain modelElement) : 
                    base(modelElement, "TypedModel")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ITypedModel Value
            {
                get
                {
                    return this.ModelElement.TypedModel;
                }
                set
                {
                    this.ModelElement.TypedModel = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            //protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            //{
            //    this.ModelElement.TypedModelChanged += handler;
            //}
            
            ///// <summary>
            ///// Registers an event handler to subscribe specifically on the changed event for this property
            ///// </summary>
            ///// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            //protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            //{
            //    this.ModelElement.TypedModelChanged -= handler;
            //}
        }
    }
}

