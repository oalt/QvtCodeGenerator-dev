//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LL.MDE.Components.Qvt.Metamodel.QVTRelation
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
    using LL.MDE.Components.Qvt.Metamodel.QVTBase;
    using LL.MDE.Components.Qvt.Metamodel.QVTTemplate;
    using NMF.Models.Repository;
    using LL.MDE.Components.Qvt.Metamodel.EMOF;
    using System.Collections.Specialized;
    using LL.MDE.Components.Qvt.Metamodel.EssentialOCL;
    
    
    /// <summary>
    /// The default implementation of the DomainPattern class
    /// </summary>
    [XmlNamespaceAttribute("http://www.omg.org/spec/QVT/20140401/QVTRelation")]
    [XmlNamespacePrefixAttribute("qvtrelation")]
    [ModelRepresentationClassAttribute("http://www.omg.org/spec/QVT/20140401/QVTRelation#//DomainPattern")]
    public partial class DomainPattern : Pattern, IDomainPattern, IModelElement
    {
        
        private static Lazy<NMF.Models.Meta.ITypedElement> _relationDomainReference = new Lazy<NMF.Models.Meta.ITypedElement>(RetrieveRelationDomainReference);
        
        private static Lazy<NMF.Models.Meta.ITypedElement> _templateExpressionReference = new Lazy<NMF.Models.Meta.ITypedElement>(RetrieveTemplateExpressionReference);
        
        /// <summary>
        /// The backing field for the TemplateExpression property
        /// </summary>
        [DebuggerBrowsableAttribute(DebuggerBrowsableState.Never)]
        private ITemplateExp _templateExpression;
        
        private static NMF.Models.Meta.IClass _classInstance;
        
        /// <summary>
        /// The relationDomain property
        /// </summary>
        [BrowsableAttribute(false)]
        [XmlElementNameAttribute("relationDomain")]
        [XmlAttributeAttribute(true)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlOppositeAttribute("pattern")]
        public IRelationDomain RelationDomain
        {
            get
            {
                return ModelHelper.CastAs<IRelationDomain>(this.Parent);
            }
            set
            {
                this.Parent = value;
            }
        }
        
        /// <summary>
        /// The templateExpression property
        /// </summary>
        [BrowsableAttribute(false)]
        [XmlElementNameAttribute("templateExpression")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        public ITemplateExp TemplateExpression
        {
            get
            {
                return this._templateExpression;
            }
            set
            {
                if ((this._templateExpression != value))
                {
                    ITemplateExp old = this._templateExpression;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnTemplateExpressionChanging(e);
                    this.OnPropertyChanging("TemplateExpression", e, _templateExpressionReference);
                    this._templateExpression = value;
                    if ((old != null))
                    {
                        if ((old.Parent == this))
                        {
                            old.Parent = null;
                        }
                        old.ParentChanged -= this.OnResetTemplateExpression;
                    }
                    if ((value != null))
                    {
                        value.Parent = this;
                        value.ParentChanged += this.OnResetTemplateExpression;
                    }
                    this.OnTemplateExpressionChanged(e);
                    this.OnPropertyChanged("TemplateExpression", e, _templateExpressionReference);
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
                return base.Children.Concat(new DomainPatternChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new DomainPatternReferencedElementsCollection(this));
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
                    _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("http://www.omg.org/spec/QVT/20140401/QVTRelation#//DomainPattern")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the RelationDomain property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> RelationDomainChanging;
        
        /// <summary>
        /// Gets fired when the RelationDomain property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> RelationDomainChanged;
        
        /// <summary>
        /// Gets fired before the TemplateExpression property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TemplateExpressionChanging;
        
        /// <summary>
        /// Gets fired when the TemplateExpression property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TemplateExpressionChanged;
        
        private static NMF.Models.Meta.ITypedElement RetrieveRelationDomainReference()
        {
            return ((NMF.Models.Meta.ITypedElement)(((ModelElement)(LL.MDE.Components.Qvt.Metamodel.QVTRelation.DomainPattern.ClassInstance)).Resolve("relationDomain")));
        }
        
        /// <summary>
        /// Raises the RelationDomainChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRelationDomainChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.RelationDomainChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Gets called when the parent model element of the current model element is about to change
        /// </summary>
        /// <param name="oldParent">The old parent model element</param>
        /// <param name="newParent">The new parent model element</param>
        protected override void OnParentChanging(IModelElement newParent, IModelElement oldParent)
        {
            IRelationDomain oldRelationDomain = ModelHelper.CastAs<IRelationDomain>(oldParent);
            IRelationDomain newRelationDomain = ModelHelper.CastAs<IRelationDomain>(newParent);
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldRelationDomain, newRelationDomain);
            this.OnRelationDomainChanging(e);
            this.OnPropertyChanging("RelationDomain", e, _relationDomainReference);
        }
        
        /// <summary>
        /// Raises the RelationDomainChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRelationDomainChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.RelationDomainChanged;
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
            IRelationDomain oldRelationDomain = ModelHelper.CastAs<IRelationDomain>(oldParent);
            IRelationDomain newRelationDomain = ModelHelper.CastAs<IRelationDomain>(newParent);
            if ((oldRelationDomain != null))
            {
                oldRelationDomain.Pattern = null;
            }
            if ((newRelationDomain != null))
            {
                newRelationDomain.Pattern = this;
            }
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldRelationDomain, newRelationDomain);
            this.OnRelationDomainChanged(e);
            this.OnPropertyChanged("RelationDomain", e, _relationDomainReference);
            base.OnParentChanged(newParent, oldParent);
        }
        
        private static NMF.Models.Meta.ITypedElement RetrieveTemplateExpressionReference()
        {
            return ((NMF.Models.Meta.ITypedElement)(((ModelElement)(LL.MDE.Components.Qvt.Metamodel.QVTRelation.DomainPattern.ClassInstance)).Resolve("templateExpression")));
        }
        
        /// <summary>
        /// Raises the TemplateExpressionChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTemplateExpressionChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TemplateExpressionChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the TemplateExpressionChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTemplateExpressionChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TemplateExpressionChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the TemplateExpression property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetTemplateExpression(object sender, System.EventArgs eventArgs)
        {
            this.TemplateExpression = null;
        }
        
        /// <summary>
        /// Gets the relative URI fragment for the given child model element
        /// </summary>
        /// <returns>A fragment of the relative URI</returns>
        /// <param name="element">The element that should be looked for</param>
        protected override string GetRelativePathForNonIdentifiedChild(IModelElement element)
        {
            if ((element == this.TemplateExpression))
            {
                return ModelHelper.CreatePath("templateExpression");
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
            if ((reference == "RELATIONDOMAIN"))
            {
                return this.RelationDomain;
            }
            if ((reference == "TEMPLATEEXPRESSION"))
            {
                return this.TemplateExpression;
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
            if ((feature == "RELATIONDOMAIN"))
            {
                this.RelationDomain = ((IRelationDomain)(value));
                return;
            }
            if ((feature == "TEMPLATEEXPRESSION"))
            {
                this.TemplateExpression = ((ITemplateExp)(value));
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
            if ((reference == "RELATIONDOMAIN"))
            {
                return new RelationDomainProxy(this);
            }
            if ((reference == "TEMPLATEEXPRESSION"))
            {
                return new TemplateExpressionProxy(this);
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
                _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("http://www.omg.org/spec/QVT/20140401/QVTRelation#//DomainPattern")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the DomainPattern class
        /// </summary>
        public class DomainPatternChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private DomainPattern _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public DomainPatternChildrenCollection(DomainPattern parent)
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
                    if ((this._parent.TemplateExpression != null))
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
                this._parent.TemplateExpressionChanged += this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Unregisters all event hooks registered by AttachCore
            /// </summary>
            protected override void DetachCore()
            {
                this._parent.TemplateExpressionChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.TemplateExpression == null))
                {
                    ITemplateExp templateExpressionCasted = item.As<ITemplateExp>();
                    if ((templateExpressionCasted != null))
                    {
                        this._parent.TemplateExpression = templateExpressionCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.TemplateExpression = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.TemplateExpression))
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
                if ((this._parent.TemplateExpression != null))
                {
                    array[arrayIndex] = this._parent.TemplateExpression;
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
                if ((this._parent.TemplateExpression == item))
                {
                    this._parent.TemplateExpression = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.TemplateExpression).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the DomainPattern class
        /// </summary>
        public class DomainPatternReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private DomainPattern _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public DomainPatternReferencedElementsCollection(DomainPattern parent)
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
                    if ((this._parent.RelationDomain != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.TemplateExpression != null))
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
                this._parent.RelationDomainChanged += this.PropagateValueChanges;
                this._parent.TemplateExpressionChanged += this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Unregisters all event hooks registered by AttachCore
            /// </summary>
            protected override void DetachCore()
            {
                this._parent.RelationDomainChanged -= this.PropagateValueChanges;
                this._parent.TemplateExpressionChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.RelationDomain == null))
                {
                    IRelationDomain relationDomainCasted = item.As<IRelationDomain>();
                    if ((relationDomainCasted != null))
                    {
                        this._parent.RelationDomain = relationDomainCasted;
                        return;
                    }
                }
                if ((this._parent.TemplateExpression == null))
                {
                    ITemplateExp templateExpressionCasted = item.As<ITemplateExp>();
                    if ((templateExpressionCasted != null))
                    {
                        this._parent.TemplateExpression = templateExpressionCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.RelationDomain = null;
                this._parent.TemplateExpression = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.RelationDomain))
                {
                    return true;
                }
                if ((item == this._parent.TemplateExpression))
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
                if ((this._parent.RelationDomain != null))
                {
                    array[arrayIndex] = this._parent.RelationDomain;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.TemplateExpression != null))
                {
                    array[arrayIndex] = this._parent.TemplateExpression;
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
                if ((this._parent.RelationDomain == item))
                {
                    this._parent.RelationDomain = null;
                    return true;
                }
                if ((this._parent.TemplateExpression == item))
                {
                    this._parent.TemplateExpression = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.RelationDomain).Concat(this._parent.TemplateExpression).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the relationDomain property
        /// </summary>
        private sealed class RelationDomainProxy : ModelPropertyChange<IDomainPattern, IRelationDomain>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public RelationDomainProxy(IDomainPattern modelElement) : 
                    base(modelElement, "relationDomain")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IRelationDomain Value
            {
                get
                {
                    return this.ModelElement.RelationDomain;
                }
                set
                {
                    this.ModelElement.RelationDomain = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the templateExpression property
        /// </summary>
        private sealed class TemplateExpressionProxy : ModelPropertyChange<IDomainPattern, ITemplateExp>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public TemplateExpressionProxy(IDomainPattern modelElement) : 
                    base(modelElement, "templateExpression")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ITemplateExp Value
            {
                get
                {
                    return this.ModelElement.TemplateExpression;
                }
                set
                {
                    this.ModelElement.TemplateExpression = value;
                }
            }
        }
    }
}
