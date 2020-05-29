using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FVTTBridge;

namespace ProjectGrinder
{
    public class PGActorSheet:ActorSheet
    {
        public override dynamic GetOptions(dynamic options)
        {
            options.classes = new[] {"projectgrinder", "sheet", "actor"};
            options.template = "systems/projectgrinder/templates/actor-sheet.html";
            options.width = 600;
            options.height = 600;

            return options;
        }
    }
}
