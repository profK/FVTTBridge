using FVTTBridge;

namespace ProjectGrinder
{
    class PGSystem:FVTTBridge.FoundrySystem
    {
        public override Actor MakeActor()
        {
            return new PGActor();
        }

        public override ActorSheet MakeActorSheet()
        {
            return new PGActorSheet();
        }
    }
}
