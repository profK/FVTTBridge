# FVTTBridge
A FoundryVTT SDK Binding for Bridge.NET C# in Windows Visual Studio.

Bridge.net is a FOSS C# to Javascript compilerfor Visual Studio  and can be downloaded free from https://bridge.net/

To build a system and and autoamtically deploy it to your local Foundry install, modify this code to point 
to your foundry data folder and put it in your project post-build event:


<blockquote>
rmdir /s  /q C:\Users\jeffp\AppData\Local\FoundryVTT\Data\systems\$(TargetName) & C: & mkdir "\Users\jeffp\AppData\Local\FoundryVTT\Data\systems\$(TargetName)" &&  mkdir "\Users\jeffp\AppData\Local\FoundryVTT\Data\systems\$(TargetName)\module"  &&  xcopy  "$(TargetDir)bridge" "\Users\jeffp\AppData\Local\FoundryVTT\Data\systems\$(TargetName)\module" /E &&  xcopy "$(TargetDir)Resources"  "\Users\jeffp\AppData\Local\FoundryVTT\Data\systems\$(TargetName)"  /E
</blockquote>
