using Bridge;
using Bridge.jQuery2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static Retyped.es2015_core;

namespace FVTTBridge.Bindings
{
    [External]
    [Namespace(false)]
    public class Combat
    {
        public static dynamic config;
        public dynamic combattant;
        public Array<dynamic> combatants;
        public float round;
        public dynamic scene;
        public dynamic settings;
        public Boolean started;
        public float turn;
        public Array<dynamic> turns; // not sure what type the array is

        public Promise activate()
        {
            //dummy
            return null;
        }

        public void createCombatant() { }
        public void deleteCombatant() { }
        public Promise endCombat()
        {
            //dummy
            return null;
        }

        public void getCombatant() { }

        public void getCombatantByToken() { }

        public Promise nextRound()
        {
            //dumy
            return null;
        }

        public Promise nextTurn()
        {
            //dummy
            return  null;
        }

        public virtual void prepareEmbeddedEntities() { }

        public Promise previousRound()
        {
            //dummy
            return null;
        }

        public Promise previousTurn()
        {
            //dummy
            return null;
        }

        public Promise resetAll()
        {
            //dummy
            return null;
        }

        public void rollAll(params dynamic[] args) { }

        public Promise rollInitiative(Array<string>ids, string formula, dynamic messageOptions)
        {
            //dummy
            return null;
        }

        public void rollNPC(params dynamic[] args) { }

        public void setInitiative(string id, float value) { }

        public Array<dynamic> setupTurns() {
            //dummy
            return null;
        
        }

        public Promise startCombat()
        {
            //dummy
            return null;
        }

        public void updateCombatant() { } // docs have no params?

    }
}
