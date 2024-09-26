//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LL.MDE.Components.Qvt.Metamodel.EMOF
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
    using System.Collections.Specialized;
    using NMF.Models.Repository;
    
    
    /// <summary>
    /// The default implementation of the Extent class
    /// </summary>
    [XmlNamespaceAttribute("http://www.omg.org/spec/QVT/20140401/EMOF")]
    [XmlNamespacePrefixAttribute("emof")]
    [ModelRepresentationClassAttribute("http://www.omg.org/spec/QVT/20140401/EMOF#//Extent")]
    public partial class Extent : Object, IExtent, IModelElement
    {
        
        private static System.Lazy<NMF.Models.Meta.IOperation> _elementsOperation = new System.Lazy<NMF.Models.Meta.IOperation>(RetrieveElementsOperation);
        
        private static System.Lazy<NMF.Models.Meta.IOperation> _useContainmentOperation = new System.Lazy<NMF.Models.Meta.IOperation>(RetrieveUseContainmentOperation);
        
        private static NMF.Models.Meta.IClass _classInstance;
        
        /// <summary>
        /// Gets the Class model for this type
        /// </summary>
        public new static NMF.Models.Meta.IClass ClassInstance
        {
            get
            {
                if ((_classInstance == null))
                {
                    _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("http://www.omg.org/spec/QVT/20140401/EMOF#//Extent")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the operation elements gets called
        /// </summary>
        public event System.EventHandler<OperationCallEventArgs> ElementsCalling;
        
        /// <summary>
        /// Gets fired after the operation elements got called
        /// </summary>
        public event System.EventHandler<OperationCallEventArgs> ElementsCalled;
        
        /// <summary>
        /// Gets fired before the operation useContainment gets called
        /// </summary>
        public event System.EventHandler<OperationCallEventArgs> UseContainmentCalling;
        
        /// <summary>
        /// Gets fired after the operation useContainment got called
        /// </summary>
        public event System.EventHandler<OperationCallEventArgs> UseContainmentCalled;
        
        /// <summary>
        /// 
        /// </summary>
        public IReflectiveSequence Elements()
        {
            System.Func<IExtent, IReflectiveSequence> handler = OperationBroker.Instance.GetRegisteredDelegate<System.Func<IExtent, IReflectiveSequence>>(_elementsOperation);
            if ((handler != null))
            {
            }
            else
            {
                throw new System.InvalidOperationException("There is no implementation for method elements registered. Use the method broker " +
                        "to register a method implementation.");
            }
            OperationCallEventArgs e = new OperationCallEventArgs(this, _elementsOperation.Value);
            this.OnElementsCalling(e);
            this.OnBubbledChange(BubbledChangeEventArgs.OperationCalling(this, _elementsOperation.Value, e));
            IReflectiveSequence result = handler.Invoke(this);
            e.Result = result;
            this.OnElementsCalled(e);
            this.OnBubbledChange(BubbledChangeEventArgs.OperationCalled(this, _elementsOperation.Value, e));
            return result;
        }
        
        private static NMF.Models.Meta.IOperation RetrieveElementsOperation()
        {
            return ClassInstance.LookupOperation("elements");
        }
        
        /// <summary>
        /// Raises the ElementsCalling event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnElementsCalling(OperationCallEventArgs eventArgs)
        {
            System.EventHandler<OperationCallEventArgs> handler = this.ElementsCalling;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ElementsCalled event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnElementsCalled(OperationCallEventArgs eventArgs)
        {
            System.EventHandler<OperationCallEventArgs> handler = this.ElementsCalled;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool UseContainment()
        {
            System.Func<IExtent, bool> handler = OperationBroker.Instance.GetRegisteredDelegate<System.Func<IExtent, bool>>(_useContainmentOperation);
            if ((handler != null))
            {
            }
            else
            {
                throw new System.InvalidOperationException("There is no implementation for method useContainment registered. Use the method b" +
                        "roker to register a method implementation.");
            }
            OperationCallEventArgs e = new OperationCallEventArgs(this, _useContainmentOperation.Value);
            this.OnUseContainmentCalling(e);
            this.OnBubbledChange(BubbledChangeEventArgs.OperationCalling(this, _useContainmentOperation.Value, e));
            bool result = handler.Invoke(this);
            e.Result = result;
            this.OnUseContainmentCalled(e);
            this.OnBubbledChange(BubbledChangeEventArgs.OperationCalled(this, _useContainmentOperation.Value, e));
            return result;
        }
        
        private static NMF.Models.Meta.IOperation RetrieveUseContainmentOperation()
        {
            return ClassInstance.LookupOperation("useContainment");
        }
        
        /// <summary>
        /// Raises the UseContainmentCalling event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnUseContainmentCalling(OperationCallEventArgs eventArgs)
        {
            System.EventHandler<OperationCallEventArgs> handler = this.UseContainmentCalling;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the UseContainmentCalled event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnUseContainmentCalled(OperationCallEventArgs eventArgs)
        {
            System.EventHandler<OperationCallEventArgs> handler = this.UseContainmentCalled;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override NMF.Models.Meta.IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("http://www.omg.org/spec/QVT/20140401/EMOF#//Extent")));
            }
            return _classInstance;
        }
    }
}
