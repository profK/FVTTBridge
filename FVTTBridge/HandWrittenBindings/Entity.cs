using Bridge;
using Bridge.jQuery2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVTTBridge.Bindings
{
    [External]
    [Namespace(false)]
    public class Entity
    {
        
        #region fields
        public Entity(dynamic data, dynamic options) { }
        public EntityCollection collection;
        public dynamic config;
        public string entity;
        public Application[] apps;
        public Compendium compendium;
        public dynamic data;
        public Folder folder;
        public string id;
        public Boolean limited;
        public string name;
        public dynamic options;
        public bool owner;
        public float permission;
        public BaseEntitySheet sheet;
        public string uuid;
        public bool visible;
        #endregion

        #region methods
        public virtual void activateSocketListeners(Socket socket) { }
        public virtual bool can(User user, string action, Entity target) {
            //dummy
            return false;
        }

        public virtual Promise create(dynamic data, dynamic options)
        {
            //dummy
            return null;
        }

        public virtual Promise delete(dynamic data, dynamic options)
        {
            //dummy
            return null;
        }

        public virtual Promise update(dynamic data, dynamic options)
        {
            //dummy
            return null;
        }

        public Promise clone(dynamic createData, dynamic options)
        {
            //dummy
            return null;
        }

        public Promise createEmbeddedEntity(string embeddedName, dynamic data, dynamic options)
        {
            //dummy
            return null;
        }

        public Promise delete(dynamic options)
        {
            //dummy
            return null;
        }

        public Promise deleteEmbeddedEntity(string embeddedName, dynamic data, dynamic options)
        {
            //dummy
            return null;
        }

        public void exportToJSON() { }

        public dynamic[] getEmbeddedCollection(string embeddedName) {
            //dummy
            return null;
        }

        public dynamic getEmbeddedEntity(string embeddedName, string id, bool strict) {
            //dummy
            return null;
        }

        public dynamic getFlag(string scope, string key)
        {
            //dummy
            return null;
        }

        public bool hasPerm(User user, string permission, bool exact)
        {
            //dummy
            return false;
        }

        public Promise importFromJSON(string json)
        {
            //dummy
            return null;
        }

        public Promise importFromJSONDialog()
        {
            //dummy
            return null;
        }

        public Promise setFlag(string scope, string key, dynamic value) {
            //dummy
            return null;
        }

        public Promise sortRelative()
        {
            //dummy
            return null;
        }

        public dynamic toJSON() {
            //dummy
            return null;
        }

        public Promise unsetFlag(string scope, string key)
        {
            //dummy
            return null;
        }

        public Promise updateEmbeddedEntity(string embeddedName, dynamic data, dynamic options)
        {
            //dummy
            return null;
        }


        #endregion

        #region callbacks
        public virtual void initialize() { }
        public virtual void prepareData() { }
        public virtual void prepareEmbeddedEntities() { }
        public virtual void render(bool force, dynamic context) { }


        #endregion

    }
}
