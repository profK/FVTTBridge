using System;
using System.Collections.Generic;
using Bridge;
using Bridge.jQuery2;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FVTTBridge.Bindings;

namespace FVTTBridge
{

    public class BridgeActor
    {
        internal ActorGlue Glue { get; set; }

      
        public BridgeActor(ActorGlue glue)
        {
            Glue = glue;
        }


        #region Accessors
        public dynamic config
        {
            get
            {
                return Glue.config;
            }
        }

        public dynamic apps
        {
            get
            {
                return Glue.apps;
            }
        }

        public Compendium compenidum
        {
            get
            {
                return Glue.compendium;
            }
        }

        public dynamic data
        {
            get
            {
                return Glue.data;
            }
        }

        public Folder folder
        {
            get
            {
                return Glue.folder;
            }
        }

        public string id
        {
            get
            {
                return Glue.id;
            }
        }

        public string img
        {
            get
            {
                return Glue.img;
            }
        }

        public bool isPC
        {
            get
            {
                return Glue.isPC;
            }
        }

        public bool isToken
        {
            get
            {
                return Glue.isToken;
            }
        }

        public FVTTBridge.Bindings.Collection items
        {
            get
            {
                return Glue.items;
            }
        }

        public FVTTBridge.Bindings.Collection itemTypes
        {
            get
            {
                return Glue.itemTypes;
            }
        }

        public bool limited
        {
            get
            {
                return Glue.limited;
            }
        }

        public string name
        {
            get
            {
                return Glue.name;
            }
        }

        public dynamic options
        {
            get
            {
                return Glue.options;
            }
        }

        public bool owner
        {
            get
            {
                return Glue.owner;
            }
        }

        public float permission
        {
            get
            {
                return Glue.permission;
            }
        }

        public BaseEntitySheet sheet
        {
            get
            {
                return Glue.sheet;
            }
        }

        public Token token
        {
            get
            {
                return Glue.token;
            }
        }

        public string uuid
        {
            get
            {
                return Glue.uuid;
            }
        }

        public bool visible
        {
            get
            {
                return Glue.visible;
            }
        }
        #endregion

        #region Methods

        public static Actor createTokenActor(Actor baseActor, Token token)
        {
            return ActorGlue.createTokenActor(baseActor, token);
        }

        public static Actor fromToken(Token token)
        {
            return ActorGlue.fromToken(token);
        }

        public Promise clone(dynamic createData, dynamic options)
        {
            return Glue.clone(createData, options);
        }

        public Promise createEmbeddedEntity(string embeddedName, dynamic data,
            dynamic options)
        {
            return Glue.createEmbeddedEntity(embeddedName, data, options);
        }

        public dynamic delete(dynamic optsToDelete)
        {
            return Glue.delete(optsToDelete);
        }

        public Promise deleteEmbeddedEntity(string embeddedName, dynamic data,
            dynamic options)
        {
            return Glue.deleteEmbeddedEntity(embeddedName, data, options);
        }

        public Promise deleteOwnedItem(string itemId, dynamic options)
        {
            return Glue.deleteOwnedItem(itemId, options);
        }

        public void exportToJSON()
        {
            Glue.exportToJSON();
        }

        public Token[] getActiveTokens(bool linkedopt)
        {
            return Glue.getActiveTokens(linkedopt);
        }

        public Entity[] getEmbeddedCollection(string embeddedName)
        {
            return Glue.getEmbeddedCollection(embeddedName);
        }

        public dynamic getFlag(string scope, string key)
        {
            return Glue.getFlag(scope, key);
        }

        public Item getOwnedItem(object v)
        {
            return Glue.getOwnedItem(v);
        }

        public dynamic getRollData()
        {
            return Glue.getRollData();
        }

        public Promise getTokenImages()
        {
            return Glue.getTokenImages();
        }

        public bool hasPerm(User user, dynamic permission, bool exact)
        {
            return Glue.hasPerm(user, permission, exact);
        }


        public Promise importFromJSON(string json)
        {
            return Glue.importFromJSON(json);
        }

        public Promise importFromJSONDialog()
        {
            return Glue.importFromJSONDialog();
        }

        public void importItemFromCollection(string collection, string entryId)
        {
            Glue.importItemFromCollection(collection, entryId);
        }

        public Promise modifyTokenAttribute(string attribute, float value,
            bool isDelta, bool isBar)
        {
            return Glue.modifyTokenAttribute(attribute, value, isDelta, isBar);
        }

        public Promise setFlag(string scope, string key, dynamic value)
        {
            return Glue.setFlag(scope, key, value);
        }

        public void sortRelative()
        {
            Glue.sortRelative();
        }

        public dynamic toJSON()
        {
            return Glue.toJSON();
        }

        public Promise unsetFlag(string scope, string key)
        {
            return Glue.unsetFlag(scope, key);
        }

        public Promise update(dynamic data, dynamic options)
        {
            return Glue.update(data, options);
        }

        public Promise updateEmbeddedEntity(string embeddedName,
            dynamic data, dynamic options)
        {
            return Glue.updateEmbeddedEntity(embeddedName, data, options);
        }

        public Promise updateOwnedItem(dynamic itemData, dynamic options)
        {
            return Glue.updateOwnedItem(itemData, options);
        }






        public void DeleteOwnedItem(object v)
        {
            Glue.DeleteOwnedItem(v);
        }
        #endregion

        #region Callbacks
        public virtual dynamic PrepareData(dynamic data)
        {
            return data;
        }

        public virtual void initialize()
        {
            Glue.initialize();
        }

        public virtual void prepareData()
        {
            Glue.prepareData();
        }

        public virtual void prepareEmbeddedEntities()
        {
            Glue.prepareEmbeddedEntities();
        }

        public virtual void render(bool force, dynamic context)
        {
            Glue.render(force, context);
        }

        #endregion
    }
}
