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
    /// Denotes a class to implement the operationalImpl reference
    /// </summary>
    public class RelationOperationalImplCollection : ObservableOppositeOrderedSet<IRelation, IRelationImplementation>
    {
        
        /// <summary>
        /// Creates a new instance
        /// </summary>
        /// <param name="parent">the parent Relation</param>
        public RelationOperationalImplCollection(IRelation parent) : 
                base(parent)
        {
        }
        
        private void OnItemParentChanged(object sender, ValueChangedEventArgs e)
        {
            if ((e.NewValue != this.Parent))
            {
                this.Remove(((IRelationImplementation)(sender)));
            }
        }
        
        /// <summary>
        /// Sets the opposite of the given item
        /// </summary>
        /// <param name="item">the item</param>
        /// <param name="newParent">the new parent or null, if the item is removed from the collection</param>
        protected override void SetOpposite(IRelationImplementation item, IRelation newParent)
        {
            if ((newParent != null))
            {
                item.ParentChanged += this.OnItemParentChanged;
                item.Relation = newParent;
            }
            else
            {
                item.ParentChanged -= this.OnItemParentChanged;
                if ((item.Relation == this.Parent))
                {
                    item.Relation = newParent;
                }
            }
        }
    }
}
