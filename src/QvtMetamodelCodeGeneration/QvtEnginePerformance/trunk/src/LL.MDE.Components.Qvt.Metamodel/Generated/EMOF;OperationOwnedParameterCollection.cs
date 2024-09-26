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
    /// Denotes a class to implement the ownedParameter reference
    /// </summary>
    public class OperationOwnedParameterCollection : ObservableOppositeOrderedSet<LL.MDE.Components.Qvt.Metamodel.EMOF.IOperation, LL.MDE.Components.Qvt.Metamodel.EMOF.IParameter>
    {
        
        /// <summary>
        /// Creates a new instance
        /// </summary>
        /// <param name="parent">the parent Operation</param>
        public OperationOwnedParameterCollection(LL.MDE.Components.Qvt.Metamodel.EMOF.IOperation parent) : 
                base(parent)
        {
        }
        
        private void OnItemParentChanged(object sender, ValueChangedEventArgs e)
        {
            if ((e.NewValue != this.Parent))
            {
                this.Remove(((LL.MDE.Components.Qvt.Metamodel.EMOF.IParameter)(sender)));
            }
        }
        
        /// <summary>
        /// Sets the opposite of the given item
        /// </summary>
        /// <param name="item">the item</param>
        /// <param name="newParent">the new parent or null, if the item is removed from the collection</param>
        protected override void SetOpposite(LL.MDE.Components.Qvt.Metamodel.EMOF.IParameter item, LL.MDE.Components.Qvt.Metamodel.EMOF.IOperation newParent)
        {
            if ((newParent != null))
            {
                item.ParentChanged += this.OnItemParentChanged;
                item.Operation = newParent;
            }
            else
            {
                item.ParentChanged -= this.OnItemParentChanged;
                if ((item.Operation == this.Parent))
                {
                    item.Operation = newParent;
                }
            }
        }
    }
}
