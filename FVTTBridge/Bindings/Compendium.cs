using Bridge;
using Bridge.jQuery2;
using System;
using System.Runtime.CompilerServices;
using static Retyped.es2015_core;

namespace FVTTBridge.Bindings
{
    [External]
    [Namespace(false)]
    public class Compendium
    {
        public Compendium(dynamic metadata, dynamic optioins) { }

        public static dynamic defaultOptions;

        public Entity cls;

        public string collection;

        public string entity;
        public Array<Entity> index;
        public bool locked;
        public dynamic metadata;
        [Name("private")]
        public bool isPrivate;
        public string title;

        public Promise create(dynamic metadata, dynamic options)
        {
            //dummy
            return null;
        }

        public void close() { }
        public Promise configure(dynamic settings) {
            //dummy
            return null;
        }

        public Promise createEntity(dynamic data, dynamic options)
        {
            //dummy
            return null;
        }

        public Promise delete()
        {
            //dummy
            return null;
        }

        public Promise deleteEntity(string id, dynamic options)
        {
            //dummy
            return null;
        }
        public Promise duplicate(string label)
        {
            //dummy
            return null;
        }
        public Promise getContent()
        {
            //dummy
            return null;
        }
        public virtual dynamic getData()
        {
            //DUMMY
            return null;
        }

        public virtual Promise getEntity(string entryId)
        {
            //dummy
            return null;
        }

        public virtual Promise getIndex()
        {
            //dummy
            return null;
        }

        public Promise importEntity(Entity entity)
        {
            //dummy
            return null;
        }

        public Promise migrate()
        {
            //dummy
            return null;
        }

        public void search(string searchString) { }

        public Promise updateEntity(dynamic data, dynamic options)
        {
            //dummy
            return null;
        }


    }
}