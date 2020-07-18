# FVTTBridge
A FoundryVTT SDK Binding for Bridge.NET C# in Windows Visual Studio.

Bridge.net is a FOSS C# to Javascript compiler for Visual Studio  and can be downloaded free from https://bridge.net/

The FVTTBridge SDK runtime is installed as a module from this url: https://profk.github.io/FVTTBridge/FVTTBridge/module.json

To build a system and and autoamtically deploy it to your local Foundry install, modify this code to point 
to your foundry data folder and put it in your project post-build event:


<blockquote>
rmdir /s  /q C:\Users\jeffp\AppData\Local\FoundryVTT\Data\systems\$(TargetName) & C: & mkdir "\Users\jeffp\AppData\Local\FoundryVTT\Data\systems\$(TargetName)" &&  mkdir "\Users\jeffp\AppData\Local\FoundryVTT\Data\systems\$(TargetName)\module"  &&  xcopy  "$(TargetDir)bridge" "\Users\jeffp\AppData\Local\FoundryVTT\Data\systems\$(TargetName)\module" /E &&  xcopy "$(TargetDir)Resources"  "\Users\jeffp\AppData\Local\FoundryVTT\Data\systems\$(TargetName)"  /E
</blockquote>

See the example system.json in the test system FVTTBridgeTest to see how to reference the runtime

## Usages Notes

The bindings are all in the FVTTBridge.Bindings directory and namesapce.  All the bindings use dynamic parameters and return tyypes except for function delegeates which are of type Action.  This is because the bdinings are auto-generated from the actual FOundry javascript code and Javascript has no type information.  Refer to the
Foundry Javascript API docs for p;arameter types expected.

The core of a system is a suibclass of the FOundrySystem class.  The core of a module is a subclass of the FoundryModule class.  Due to anincomaptability issue with C# and Javascript, <ins>you do NOT create subclasses of Actor and ActorSheet when using FVTTBRidge</ins>.  Instead you create sub classes of BridgeActor and BridgeActorSheet and return these classes as the ActorType and ActorSheetType from your FoundrySystem subclass (see the FVTTBridgeTest example).
