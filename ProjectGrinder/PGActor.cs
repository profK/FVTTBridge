using System;
using FVTTBridge.Bindings;
using System.Reflection;

namespace ProjectGrinder
{

    public class PGActor : Actor
    {
        public override dynamic PrepareData(dynamic data)
        {
            if (data.hasOwnProperty("name") && !data.name)
            {
                data.name = "New Actor";
            }

            data.data.all_stats = Globals.CONFIG.stats;
            data.data.all_skills = Globals.CONFIG.skills;
            data.data.isGM = Globals.GAME.user.isGM;

            //calculate stat roll
            //calc d8s
            string[] propNames = GetOwnPropertyNames(data.data.stats);
            foreach (string stat in propNames) 
            {
                var obj = data.data.stats[stat];
                obj.d8 = Math.Truncate(((float)obj.value) / 5);
                obj.plus = ((float)obj.value) % 5;
                float tot = (float)obj.plus - (float)obj.damage;
                string plusstr;
                if (tot < 0)
                {
                    plusstr = tot.ToString();
                }
                else if (tot > 0)
                {
                    string tstr = tot.ToString();
                    plusstr = "+" + tstr;
                }
                else
                { 
                    plusstr = "";
                }

                obj.plusstr = plusstr;

            }

            //calc skill rolls
            if (data.data.hasOwnProperty("skills"))
            {
                string[] skillNames = GetOwnPropertyNames(data.data.skills);
                foreach (string skillName in skillNames)
                {

                    try
                    {
                        var skill = data.data.skills[skillName];
                        string statname = skill.current_stat;
                        var stat = data.data.stats[statname];
                        skill.d8 = Math.Truncate((float) stat.value / 5);
                        skill.plusstr = stat.plusstr;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Warning: " + e.Message);
                    }

                }
            }

            return data;
        }
    }
}
