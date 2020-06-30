using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVTTBridge
{
    class Glue
    {
        [Init(InitPosition.Bottom)]
        public static void Bottom()
        {
            Script.Write(@"
class ActorSheetGlue extends ActorSheet {
    constructor(...args) {
        super(...args);
        this.BridgeActorSheet = FVTTBridge.Bindings.FoundrySystem.Instance.MakeActorSheet(this);
    }
    

    static get defaultOptions() {
        var options = super.defaultOptions;
        options = FVTTBridge.Bindings.FoundrySystem.Instance.GetOptions(options);
        return options;
    }

    activateListeners(html) {
        super.activateListeners(html);
        this.BridgeActorSheet.ActivateListeners(html);
    }
}

class ActorGlue extends Actor {
    constructor(...args) {
        super(...args);
        this.BridgeActor = FVTTBridge.Bindings.FoundrySystem.Instance.MakeActor();
    }

    prepareData() {
        super.prepareData();
        this.data = this.BridgeActor.PrepareData(this.data);
    }

}
            ");
        }
    }
}
