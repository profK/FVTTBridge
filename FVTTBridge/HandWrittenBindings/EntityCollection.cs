using Bridge;
using Bridge.jQuery2;
using System;
using System.Collections;

namespace FVTTBridge.Bindings
{
    [External]
    [Namespace(false)]
    public class EntityCollection:Collection
    {
        public static EntityCollection instance;
        public dynamic[] _source;
        public dynamic[] apps;
        public SidebarDirectory directory;
        public string entity;
        public Entity[] entries;
        public string name;
        [Name("object")]
        public Type typeObject;
        public Entity getName(string name, bool strict)
        {
            //dummy 
            return null;
        }

        public Promise importFromCollection(string collection, string entryId, dynamic updateDataopt, dynamic optionsopt)
        {
            //dummy
            return null;
        }

        public void insert(Entity entity) { }

        public void remove(string id) { }

        public EntityCollection render() {
            //dummy
            return null;
        }
    }
}