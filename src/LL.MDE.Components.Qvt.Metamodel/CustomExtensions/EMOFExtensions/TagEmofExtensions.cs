using LL.MDE.Components.Qvt.Metamodel.EMOF;
using NMF.Models;
using System.Collections.Generic;

namespace LL.MDE.Components.Qvt.Metamodel.CustomExtensions.EMOFExtensions
{
    public static class TagEmofExtensions
    {
        private static readonly Dictionary<IModelElement, Dictionary<string, ITag>> _allTags = new Dictionary<IModelElement, Dictionary<string, ITag>>();

        public static ITag GetTag(this IModelElement modelElement, string name)
        {
            ITag result = null;

            if (_allTags.ContainsKey(modelElement))
            {
                Dictionary<string, ITag> tags = _allTags[modelElement];
                if (tags.ContainsKey(name))
                {
                    result = _allTags[modelElement][name];
                }
            }

            return result;
        }

        public static void SetOrAddTag(this IModelElement modelElement, string name, string value)
        {
            if (_allTags.ContainsKey(modelElement))
            {
                Dictionary<string, ITag> elementTags = _allTags[modelElement];
                if (elementTags.ContainsKey(name))
                {
                    elementTags[name].Value = value;
                }
                else
                {
                    elementTags.Add(name, CreateNewTag(name, value));
                }
            }
            else
            {
                Dictionary<string, ITag> elementTags = new Dictionary<string, ITag>();
                elementTags.Add(name, CreateNewTag(name, value));
                _allTags.Add(modelElement, elementTags);
            }
        }

        private static ITag CreateNewTag(string name, string value)
        {
            ITag result = new Tag();
            
            result.Name = name;
            result.Value = value;

            return result;
        }
    }
}
