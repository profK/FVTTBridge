﻿//Note that this extends the global ActorSheet javascript class provided
// by Foundry VTT, NOT the FVTTBridge.ActorSheet class generated by Actor.cs


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