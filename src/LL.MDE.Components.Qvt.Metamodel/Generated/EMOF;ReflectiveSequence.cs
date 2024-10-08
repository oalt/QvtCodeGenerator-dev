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
    /// The default implementation of the ReflectiveSequence class
    /// </summary>
    [XmlNamespaceAttribute("http://www.omg.org/spec/QVT/20140401/EMOF")]
    [XmlNamespacePrefixAttribute("emof")]
    [ModelRepresentationClassAttribute("http://www.omg.org/spec/QVT/20140401/EMOF#//ReflectiveSequence")]
    public partial class ReflectiveSequence : ReflectiveCollection, IReflectiveSequence, IModelElement
    {
        
        private static System.Lazy<NMF.Models.Meta.IOperation> _addOperation = new System.Lazy<NMF.Models.Meta.IOperation>(RetrieveAddOperation);
        
        private static System.Lazy<NMF.Models.Meta.IOperation> _getOperation = new System.Lazy<NMF.Models.Meta.IOperation>(RetrieveGetOperation);
        
        private static System.Lazy<NMF.Models.Meta.IOperation> _removeOperation = new System.Lazy<NMF.Models.Meta.IOperation>(RetrieveRemoveOperation);
        
        private static System.Lazy<NMF.Models.Meta.IOperation> _setOperation = new System.Lazy<NMF.Models.Meta.IOperation>(RetrieveSetOperation);
        
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
                    _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("http://www.omg.org/spec/QVT/20140401/EMOF#//ReflectiveSequence")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the operation add gets called
        /// </summary>
        public event System.EventHandler<OperationCallEventArgs> AddCalling;
        
        /// <summary>
        /// Gets fired after the operation add got called
        /// </summary>
        public event System.EventHandler<OperationCallEventArgs> AddCalled;
        
        /// <summary>
        /// Gets fired before the operation get gets called
        /// </summary>
        public event System.EventHandler<OperationCallEventArgs> GetCalling;
        
        /// <summary>
        /// Gets fired after the operation get got called
        /// </summary>
        public event System.EventHandler<OperationCallEventArgs> GetCalled;
        
        /// <summary>
        /// Gets fired before the operation remove gets called
        /// </summary>
        public event System.EventHandler<OperationCallEventArgs> RemoveCalling;
        
        /// <summary>
        /// Gets fired after the operation remove got called
        /// </summary>
        public event System.EventHandler<OperationCallEventArgs> RemoveCalled;
        
        /// <summary>
        /// Gets fired before the operation set gets called
        /// </summary>
        public event System.EventHandler<OperationCallEventArgs> SetCalling;
        
        /// <summary>
        /// Gets fired after the operation set got called
        /// </summary>
        public event System.EventHandler<OperationCallEventArgs> SetCalled;
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="object"></param>
        public void Add(int index, IObject @object)
        {
            System.Action<IReflectiveSequence, int, IObject> handler = OperationBroker.Instance.GetRegisteredDelegate<System.Action<IReflectiveSequence, int, IObject>>(_addOperation);
            if ((handler != null))
            {
            }
            else
            {
                throw new System.InvalidOperationException("There is no implementation for method add registered. Use the method broker to re" +
                        "gister a method implementation.");
            }
            OperationCallEventArgs e = new OperationCallEventArgs(this, _addOperation.Value, index, @object);
            this.OnAddCalling(e);
            this.OnBubbledChange(BubbledChangeEventArgs.OperationCalling(this, _addOperation.Value, e));
            handler.Invoke(this, index, @object);
            this.OnAddCalled(e);
            this.OnBubbledChange(BubbledChangeEventArgs.OperationCalled(this, _addOperation.Value, e));
        }
        
        private static NMF.Models.Meta.IOperation RetrieveAddOperation()
        {
            return ClassInstance.LookupOperation("add");
        }
        
        /// <summary>
        /// Raises the AddCalling event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnAddCalling(OperationCallEventArgs eventArgs)
        {
            System.EventHandler<OperationCallEventArgs> handler = this.AddCalling;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the AddCalled event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnAddCalled(OperationCallEventArgs eventArgs)
        {
            System.EventHandler<OperationCallEventArgs> handler = this.AddCalled;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        public IObject Get(int index)
        {
            System.Func<IReflectiveSequence, int, IObject> handler = OperationBroker.Instance.GetRegisteredDelegate<System.Func<IReflectiveSequence, int, IObject>>(_getOperation);
            if ((handler != null))
            {
            }
            else
            {
                throw new System.InvalidOperationException("There is no implementation for method get registered. Use the method broker to re" +
                        "gister a method implementation.");
            }
            OperationCallEventArgs e = new OperationCallEventArgs(this, _getOperation.Value, index);
            this.OnGetCalling(e);
            this.OnBubbledChange(BubbledChangeEventArgs.OperationCalling(this, _getOperation.Value, e));
            IObject result = handler.Invoke(this, index);
            e.Result = result;
            this.OnGetCalled(e);
            this.OnBubbledChange(BubbledChangeEventArgs.OperationCalled(this, _getOperation.Value, e));
            return result;
        }
        
        private static NMF.Models.Meta.IOperation RetrieveGetOperation()
        {
            return ClassInstance.LookupOperation("get");
        }
        
        /// <summary>
        /// Raises the GetCalling event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnGetCalling(OperationCallEventArgs eventArgs)
        {
            System.EventHandler<OperationCallEventArgs> handler = this.GetCalling;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the GetCalled event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnGetCalled(OperationCallEventArgs eventArgs)
        {
            System.EventHandler<OperationCallEventArgs> handler = this.GetCalled;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        public IObject Remove(int index)
        {
            System.Func<IReflectiveSequence, int, IObject> handler = OperationBroker.Instance.GetRegisteredDelegate<System.Func<IReflectiveSequence, int, IObject>>(_removeOperation);
            if ((handler != null))
            {
            }
            else
            {
                throw new System.InvalidOperationException("There is no implementation for method remove registered. Use the method broker to" +
                        " register a method implementation.");
            }
            OperationCallEventArgs e = new OperationCallEventArgs(this, _removeOperation.Value, index);
            this.OnRemoveCalling(e);
            this.OnBubbledChange(BubbledChangeEventArgs.OperationCalling(this, _removeOperation.Value, e));
            IObject result = handler.Invoke(this, index);
            e.Result = result;
            this.OnRemoveCalled(e);
            this.OnBubbledChange(BubbledChangeEventArgs.OperationCalled(this, _removeOperation.Value, e));
            return result;
        }
        
        private static NMF.Models.Meta.IOperation RetrieveRemoveOperation()
        {
            return ClassInstance.LookupOperation("remove");
        }
        
        /// <summary>
        /// Raises the RemoveCalling event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRemoveCalling(OperationCallEventArgs eventArgs)
        {
            System.EventHandler<OperationCallEventArgs> handler = this.RemoveCalling;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the RemoveCalled event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRemoveCalled(OperationCallEventArgs eventArgs)
        {
            System.EventHandler<OperationCallEventArgs> handler = this.RemoveCalled;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="object"></param>
        public IObject Set(int index, IObject @object)
        {
            System.Func<IReflectiveSequence, int, IObject, IObject> handler = OperationBroker.Instance.GetRegisteredDelegate<System.Func<IReflectiveSequence, int, IObject, IObject>>(_setOperation);
            if ((handler != null))
            {
            }
            else
            {
                throw new System.InvalidOperationException("There is no implementation for method set registered. Use the method broker to re" +
                        "gister a method implementation.");
            }
            OperationCallEventArgs e = new OperationCallEventArgs(this, _setOperation.Value, index, @object);
            this.OnSetCalling(e);
            this.OnBubbledChange(BubbledChangeEventArgs.OperationCalling(this, _setOperation.Value, e));
            IObject result = handler.Invoke(this, index, @object);
            e.Result = result;
            this.OnSetCalled(e);
            this.OnBubbledChange(BubbledChangeEventArgs.OperationCalled(this, _setOperation.Value, e));
            return result;
        }
        
        private static NMF.Models.Meta.IOperation RetrieveSetOperation()
        {
            return ClassInstance.LookupOperation("set");
        }
        
        /// <summary>
        /// Raises the SetCalling event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSetCalling(OperationCallEventArgs eventArgs)
        {
            System.EventHandler<OperationCallEventArgs> handler = this.SetCalling;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the SetCalled event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSetCalled(OperationCallEventArgs eventArgs)
        {
            System.EventHandler<OperationCallEventArgs> handler = this.SetCalled;
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
                _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("http://www.omg.org/spec/QVT/20140401/EMOF#//ReflectiveSequence")));
            }
            return _classInstance;
        }
    }
}
