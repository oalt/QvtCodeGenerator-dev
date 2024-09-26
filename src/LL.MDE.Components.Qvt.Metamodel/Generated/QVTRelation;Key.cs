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
    /// The default implementation of the Key class
    /// </summary>
    [XmlNamespaceAttribute("http://www.omg.org/spec/QVT/20140401/QVTRelation")]
    [XmlNamespacePrefixAttribute("qvtrelation")]
    [ModelRepresentationClassAttribute("http://www.omg.org/spec/QVT/20140401/QVTRelation#//Key")]
    public partial class Key : Element, IKey, IModelElement
    {
        
        private static Lazy<NMF.Models.Meta.ITypedElement> _identifiesReference = new Lazy<NMF.Models.Meta.ITypedElement>(RetrieveIdentifiesReference);
        
        /// <summary>
        /// The backing field for the Identifies property
        /// </summary>
        [DebuggerBrowsableAttribute(DebuggerBrowsableState.Never)]
        private LL.MDE.Components.Qvt.Metamodel.EMOF.IClass _identifies;
        
        private static Lazy<NMF.Models.Meta.ITypedElement> _oppositePartReference = new Lazy<NMF.Models.Meta.ITypedElement>(RetrieveOppositePartReference);
        
        /// <summary>
        /// The backing field for the OppositePart property
        /// </summary>
        [DebuggerBrowsableAttribute(DebuggerBrowsableState.Never)]
        private ObservableAssociationSet<IProperty> _oppositePart;
        
        private static Lazy<NMF.Models.Meta.ITypedElement> _partReference = new Lazy<NMF.Models.Meta.ITypedElement>(RetrievePartReference);
        
        /// <summary>
        /// The backing field for the Part property
        /// </summary>
        [DebuggerBrowsableAttribute(DebuggerBrowsableState.Never)]
        private ObservableAssociationSet<IProperty> _part;
        
        private static Lazy<NMF.Models.Meta.ITypedElement> _transformationReference = new Lazy<NMF.Models.Meta.ITypedElement>(RetrieveTransformationReference);
        
        private static NMF.Models.Meta.IClass _classInstance;
        
        /// <summary>
        /// Creates a new instance
        /// </summary>
        public Key()
        {
            this._oppositePart = new ObservableAssociationSet<IProperty>();
            this._oppositePart.CollectionChanging += this.OppositePartCollectionChanging;
            this._oppositePart.CollectionChanged += this.OppositePartCollectionChanged;
            this._part = new ObservableAssociationSet<IProperty>();
            this._part.CollectionChanging += this.PartCollectionChanging;
            this._part.CollectionChanged += this.PartCollectionChanged;
        }
        
        /// <summary>
        /// The identifies property
        /// </summary>
        [DisplayNameAttribute("identifies")]
        [CategoryAttribute("Key")]
        [XmlElementNameAttribute("identifies")]
        [XmlAttributeAttribute(true)]
        public LL.MDE.Components.Qvt.Metamodel.EMOF.IClass Identifies
        {
            get
            {
                return this._identifies;
            }
            set
            {
                if ((this._identifies != value))
                {
                    LL.MDE.Components.Qvt.Metamodel.EMOF.IClass old = this._identifies;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnIdentifiesChanging(e);
                    this.OnPropertyChanging("Identifies", e, _identifiesReference);
                    this._identifies = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetIdentifies;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetIdentifies;
                    }
                    this.OnIdentifiesChanged(e);
                    this.OnPropertyChanged("Identifies", e, _identifiesReference);
                }
            }
        }
        
        /// <summary>
        /// The oppositePart property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [DisplayNameAttribute("oppositePart")]
        [CategoryAttribute("Key")]
        [XmlElementNameAttribute("oppositePart")]
        [XmlAttributeAttribute(true)]
        [ConstantAttribute()]
        public ISetExpression<IProperty> OppositePart
        {
            get
            {
                return this._oppositePart;
            }
        }
        
        /// <summary>
        /// The part property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [DisplayNameAttribute("part")]
        [CategoryAttribute("Key")]
        [XmlElementNameAttribute("part")]
        [XmlAttributeAttribute(true)]
        [ConstantAttribute()]
        public ISetExpression<IProperty> Part
        {
            get
            {
                return this._part;
            }
        }
        
        /// <summary>
        /// The transformation property
        /// </summary>
        [BrowsableAttribute(false)]
        [XmlElementNameAttribute("transformation")]
        [XmlAttributeAttribute(true)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlOppositeAttribute("ownedKey")]
        public IRelationalTransformation Transformation
        {
            get
            {
                return ModelHelper.CastAs<IRelationalTransformation>(this.Parent);
            }
            set
            {
                this.Parent = value;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new KeyReferencedElementsCollection(this));
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
                    _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("http://www.omg.org/spec/QVT/20140401/QVTRelation#//Key")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Identifies property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> IdentifiesChanging;
        
        /// <summary>
        /// Gets fired when the Identifies property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> IdentifiesChanged;
        
        /// <summary>
        /// Gets fired before the Transformation property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TransformationChanging;
        
        /// <summary>
        /// Gets fired when the Transformation property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TransformationChanged;
        
        private static NMF.Models.Meta.ITypedElement RetrieveIdentifiesReference()
        {
            return ((NMF.Models.Meta.ITypedElement)(((ModelElement)(LL.MDE.Components.Qvt.Metamodel.QVTRelation.Key.ClassInstance)).Resolve("identifies")));
        }
        
        /// <summary>
        /// Raises the IdentifiesChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnIdentifiesChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.IdentifiesChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the IdentifiesChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnIdentifiesChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.IdentifiesChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Identifies property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetIdentifies(object sender, System.EventArgs eventArgs)
        {
            this.Identifies = null;
        }
        
        private static NMF.Models.Meta.ITypedElement RetrieveOppositePartReference()
        {
            return ((NMF.Models.Meta.ITypedElement)(((ModelElement)(LL.MDE.Components.Qvt.Metamodel.QVTRelation.Key.ClassInstance)).Resolve("oppositePart")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the OppositePart property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void OppositePartCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("OppositePart", e, _oppositePartReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the OppositePart property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void OppositePartCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("OppositePart", e, _oppositePartReference);
        }
        
        private static NMF.Models.Meta.ITypedElement RetrievePartReference()
        {
            return ((NMF.Models.Meta.ITypedElement)(((ModelElement)(LL.MDE.Components.Qvt.Metamodel.QVTRelation.Key.ClassInstance)).Resolve("part")));
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
        
        private static NMF.Models.Meta.ITypedElement RetrieveTransformationReference()
        {
            return ((NMF.Models.Meta.ITypedElement)(((ModelElement)(LL.MDE.Components.Qvt.Metamodel.QVTRelation.Key.ClassInstance)).Resolve("transformation")));
        }
        
        /// <summary>
        /// Raises the TransformationChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTransformationChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TransformationChanging;
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
            IRelationalTransformation oldTransformation = ModelHelper.CastAs<IRelationalTransformation>(oldParent);
            IRelationalTransformation newTransformation = ModelHelper.CastAs<IRelationalTransformation>(newParent);
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldTransformation, newTransformation);
            this.OnTransformationChanging(e);
            this.OnPropertyChanging("Transformation", e, _transformationReference);
        }
        
        /// <summary>
        /// Raises the TransformationChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTransformationChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TransformationChanged;
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
            IRelationalTransformation oldTransformation = ModelHelper.CastAs<IRelationalTransformation>(oldParent);
            IRelationalTransformation newTransformation = ModelHelper.CastAs<IRelationalTransformation>(newParent);
            if ((oldTransformation != null))
            {
                oldTransformation.OwnedKey.Remove(this);
            }
            if ((newTransformation != null))
            {
                newTransformation.OwnedKey.Add(this);
            }
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldTransformation, newTransformation);
            this.OnTransformationChanged(e);
            this.OnPropertyChanged("Transformation", e, _transformationReference);
            base.OnParentChanged(newParent, oldParent);
        }
        
        /// <summary>
        /// Resolves the given URI to a child model element
        /// </summary>
        /// <returns>The model element or null if it could not be found</returns>
        /// <param name="reference">The requested reference name</param>
        /// <param name="index">The index of this reference</param>
        protected override IModelElement GetModelElementForReference(string reference, int index)
        {
            if ((reference == "IDENTIFIES"))
            {
                return this.Identifies;
            }
            if ((reference == "TRANSFORMATION"))
            {
                return this.Transformation;
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
            if ((feature == "OPPOSITEPART"))
            {
                return this._oppositePart;
            }
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
            if ((feature == "IDENTIFIES"))
            {
                this.Identifies = ((LL.MDE.Components.Qvt.Metamodel.EMOF.IClass)(value));
                return;
            }
            if ((feature == "TRANSFORMATION"))
            {
                this.Transformation = ((IRelationalTransformation)(value));
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
            if ((reference == "IDENTIFIES"))
            {
                return new IdentifiesProxy(this);
            }
            if ((reference == "TRANSFORMATION"))
            {
                return new TransformationProxy(this);
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
                _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("http://www.omg.org/spec/QVT/20140401/QVTRelation#//Key")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the Key class
        /// </summary>
        public class KeyReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private Key _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public KeyReferencedElementsCollection(Key parent)
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
                    if ((this._parent.Identifies != null))
                    {
                        count = (count + 1);
                    }
                    count = (count + this._parent.OppositePart.Count);
                    count = (count + this._parent.Part.Count);
                    if ((this._parent.Transformation != null))
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
                this._parent.IdentifiesChanged += this.PropagateValueChanges;
                this._parent.OppositePart.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.Part.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.TransformationChanged += this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Unregisters all event hooks registered by AttachCore
            /// </summary>
            protected override void DetachCore()
            {
                this._parent.IdentifiesChanged -= this.PropagateValueChanges;
                this._parent.OppositePart.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.Part.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.TransformationChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.Identifies == null))
                {
                    LL.MDE.Components.Qvt.Metamodel.EMOF.IClass identifiesCasted = item.As<LL.MDE.Components.Qvt.Metamodel.EMOF.IClass>();
                    if ((identifiesCasted != null))
                    {
                        this._parent.Identifies = identifiesCasted;
                        return;
                    }
                }
                IProperty oppositePartCasted = item.As<IProperty>();
                if ((oppositePartCasted != null))
                {
                    this._parent.OppositePart.Add(oppositePartCasted);
                }
                IProperty partCasted = item.As<IProperty>();
                if ((partCasted != null))
                {
                    this._parent.Part.Add(partCasted);
                }
                if ((this._parent.Transformation == null))
                {
                    IRelationalTransformation transformationCasted = item.As<IRelationalTransformation>();
                    if ((transformationCasted != null))
                    {
                        this._parent.Transformation = transformationCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Identifies = null;
                this._parent.OppositePart.Clear();
                this._parent.Part.Clear();
                this._parent.Transformation = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.Identifies))
                {
                    return true;
                }
                if (this._parent.OppositePart.Contains(item))
                {
                    return true;
                }
                if (this._parent.Part.Contains(item))
                {
                    return true;
                }
                if ((item == this._parent.Transformation))
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
                if ((this._parent.Identifies != null))
                {
                    array[arrayIndex] = this._parent.Identifies;
                    arrayIndex = (arrayIndex + 1);
                }
                IEnumerator<IModelElement> oppositePartEnumerator = this._parent.OppositePart.GetEnumerator();
                try
                {
                    for (
                    ; oppositePartEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = oppositePartEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    oppositePartEnumerator.Dispose();
                }
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
                if ((this._parent.Transformation != null))
                {
                    array[arrayIndex] = this._parent.Transformation;
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
                if ((this._parent.Identifies == item))
                {
                    this._parent.Identifies = null;
                    return true;
                }
                IProperty propertyItem = item.As<IProperty>();
                if (((propertyItem != null) 
                            && this._parent.OppositePart.Remove(propertyItem)))
                {
                    return true;
                }
                if (((propertyItem != null) 
                            && this._parent.Part.Remove(propertyItem)))
                {
                    return true;
                }
                if ((this._parent.Transformation == item))
                {
                    this._parent.Transformation = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Identifies).Concat(this._parent.OppositePart).Concat(this._parent.Part).Concat(this._parent.Transformation).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the identifies property
        /// </summary>
        private sealed class IdentifiesProxy : ModelPropertyChange<IKey, LL.MDE.Components.Qvt.Metamodel.EMOF.IClass>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public IdentifiesProxy(IKey modelElement) : 
                    base(modelElement, "identifies")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override LL.MDE.Components.Qvt.Metamodel.EMOF.IClass Value
            {
                get
                {
                    return this.ModelElement.Identifies;
                }
                set
                {
                    this.ModelElement.Identifies = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the transformation property
        /// </summary>
        private sealed class TransformationProxy : ModelPropertyChange<IKey, IRelationalTransformation>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public TransformationProxy(IKey modelElement) : 
                    base(modelElement, "transformation")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IRelationalTransformation Value
            {
                get
                {
                    return this.ModelElement.Transformation;
                }
                set
                {
                    this.ModelElement.Transformation = value;
                }
            }
        }
    }
}
