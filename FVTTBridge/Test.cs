using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVTTBridge
{
    public class Test
    {
        public static void Main(string[] args)
        {
            new MySystem();
        }
    }

    class MySystem : System
    {
       
        public override Type ActorType
        {
            get
            {
                return typeof(ActorChild);
            }
        }

        public override Type ActorSheetType
        {
            get
            {
                return typeof(ActorSheetChild);
            }
        }

        protected override void SystemInit()
        {
            base.SystemInit();
            Globals.CONFIG.Actor.entityClass = typeof(ActorChild);
        }
    }

    class ActorChild : Actor
    {
        public ActorChild()
        {

        }

        public override dynamic prepareData()
        {
            var baseData = base.prepareData();
            baseData.Skills = new String[]{"foo"};
            return baseData;
        }
    }

    class ActorSheetChild : ActorSheet
    {
        
    }
}
