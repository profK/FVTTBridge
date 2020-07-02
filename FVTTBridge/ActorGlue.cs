using Bridge;
using Newtonsoft.Json;
using System;
using Bridge.Html5;
using Bridge.jQuery2;

namespace FVTTBridge.Bindings
{
    [External]
    [Namespace(false)]
    public class ActorGlue
    {
        internal object config;
        internal dynamic apps;
        internal Compendium compendium;
        internal dynamic data;
        internal Folder folder;
        internal string id;
        internal string img;
        internal bool isPC;
        internal bool isToken;
        internal Collection items;
        internal Collection itemTypes;
        internal bool limited;
        internal string name;
        internal dynamic options;
        internal bool owner;
        internal float permission;
        internal BaseEntitySheet sheet;
        internal Token token;
        internal string uuid;
        internal bool visible;

        public Actor Actor { get; }

        internal Item getOwnedItem(object v)
        {
            // dummy body
            return null;
        }

        internal void DeleteOwnedItem(object v)
        {
           // dummy body
        }

        internal static Actor createTokenActor(Actor baseActor, Token token)
        {
            throw new NotImplementedException();
        }

        internal static Actor fromToken(Token token)
        {
            throw new NotImplementedException();
        }

        internal Bridge.jQuery2.Promise clone(dynamic createData, dynamic options)
        {
            throw new NotImplementedException();
        }

        internal Promise createEmbeddedEntity(string embeddedName, dynamic data, dynamic options)
        {
            throw new NotImplementedException();
        }

        internal dynamic delete(dynamic optsToDelete)
        {
            throw new NotImplementedException();
        }

        internal Promise deleteEmbeddedEntity(string embeddedName, dynamic data, dynamic
            options)
        {
            throw new NotImplementedException();
        }

        internal Promise deleteOwnedItem(string itemId, dynamic options)
        {
            throw new NotImplementedException();
        }

        internal void exportToJSON()
        {
            throw new NotImplementedException();
        }

        internal Token[] getActiveTokens(bool linkedopt)
        {
            throw new NotImplementedException();
        }

        internal Entity[] getEmbeddedCollection(string embeddedName)
        {
            throw new NotImplementedException();
        }

        internal dynamic getFlag(string scope, string key)
        {
            throw new NotImplementedException();
        }

        internal dynamic getRollData()
        {
            throw new NotImplementedException();
        }

        internal Promise getTokenImages()
        {
            throw new NotImplementedException();
        }

        internal bool hasPerm(User user, dynamic permission, bool exact)
        {
            throw new NotImplementedException();
        }

        internal Promise importFromJSON(string json)
        {
            throw new NotImplementedException();
        }

        internal Promise importFromJSONDialog()
        {
            throw new NotImplementedException();
        }

        internal void importItemFromCollection(string collection, string entryId)
        {
            throw new NotImplementedException();
        }

        internal void initialize()
        {
            throw new NotImplementedException();
        }

        internal Promise modifyTokenAttribute(string attribute, float value, bool isDelta, bool isBar)
        {
            throw new NotImplementedException();
        }

        internal void prepareData()
        {
            throw new NotImplementedException();
        }

        internal void prepareEmbeddedEntities()
        {
            throw new NotImplementedException();
        }

        internal void render(bool force, dynamic context)
        {
            throw new NotImplementedException();
        }

        internal Promise setFlag(string scope, string key, dynamic value)
        {
            throw new NotImplementedException();
        }

        internal void sortRelative()
        {
            throw new NotImplementedException();
        }

        internal dynamic toJSON()
        {
            throw new NotImplementedException();
        }

        internal Promise unsetFlag(string scope, string key)
        {
            throw new NotImplementedException();
        }

        internal Promise update(dynamic data, dynamic options)
        {
            throw new NotImplementedException();
        }

        internal Promise updateEmbeddedEntity(string embeddedName, dynamic data, dynamic options)
        {
            throw new NotImplementedException();
        }

        internal Promise updateOwnedItem(dynamic itemData, dynamic options)
        {
            throw new NotImplementedException();
        }
    }
}
