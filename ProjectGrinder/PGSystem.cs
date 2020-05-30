using FVTTBridge.Bindings;

namespace ProjectGrinder
{
    class PGSystem:FVTTBridge.Bindings.FoundrySystem
    {
        public override Actor MakeActor()
        {
            return new PGActor();
        }

        public override ActorSheet MakeActorSheet(ActorSheetGlue glue)
        {
            return new PGActorSheet(glue);
        }

        public override dynamic GetOptions(dynamic options)
        {
            options.classes = new[] { "projectgrinder", "sheet", "actor" };
            options.template = "systems/projectgrinder/templates/actor-sheet.html";
            options.width = 600;
            options.height = 600;
            return options;
        }
    }
}
