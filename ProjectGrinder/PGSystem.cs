using FVTTBridge.Bindings;
using System;

namespace ProjectGrinder
{
    class PGSystem:FVTTBridge.Bindings.FoundrySystem
    {
        public PGSystem() : base()
        {
            Globals.CONFIG.stats = new[]
            {
                "deftness", "agility", "strength", "toughness", "perception",
                "mind", "spirituality", "willpower", "beauty", "presence"
            };
            Globals.CONFIG.skills = new[]
            {
                "Acrobatics", "Air vehicles", "Area of Knowledge", "Beast Riding", "Charm",
                "Climbing", "Dodge", "Energy Weapons", "Find", "Fire Combat", "First Aid",
                "Heavy Weapons", "Hide", "Intimidation", "Land Vehicle", "Language",
                "Lifting", "Long Jumping", "Maneuver", "Melee Weapons", "Missile Weapons",
                "Persuasion", "Prestidigitation", "Professional Skill", "Running",
                "Security Systems", "Stealth", "Survival", "Swimming", "Taunt",
                "Test of Will", "Tracking", "Trick", "Unarmed Combat", "Water Vehicles"
            };
        }
        public override Type ActorType
        {
            get
            {
                return typeof(PGActor);

            }
        }

        public override Type ActorSheetType
        {
            get
            {
                return typeof(PGActorSheet);
            }
           
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
