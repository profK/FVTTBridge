using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge.Html5;
using Bridge.jQuery2;
using FVTTBridge.Bindings;
using FVTTBridge.Bindings.HTML;
using FVTTBridge.Bindings.Bindings;

namespace ProjectGrinder
{
    public class PGActorSheet:ActorSheet
    {
        string _sheetTab = "description";
        

        public PGActorSheet(ActorSheetGlue glue) : base(glue)
        {
        
        }

       

        delegate void ClickCallback(dynamic clicked);

        public override void ActivateListeners(jQuery htmlObject)
        {

            // Activate tabs
            jQuery tabs = htmlObject.Find(".tabs");
            dynamic opts = new RawJSObject();
            opts.initial = _sheetTab;
            opts.callback = (ClickCallback)ClickTabSelect;
            new Tabs(tabs, opts);

            //
            // Everything below here is only needed if the sheet is editable
            if (!Options.editable) return;

            // Update Inventory Item
            
            htmlObject.Find(".item-edit").Click(ev => {
                jQuery li = jQuery.Select(ev.CurrentTarget).Parents(".item");
                Item item = Actor.getOwnedItem(li.Data("itemId"));
                item.sheet.render(true);
            });

            
            // Delete Inventory Item
            htmlObject.Find(".item-delete").Click(ev => {
                jQuery li = jQuery.Select(ev.CurrentTarget).Parents(".item");
                Actor.DeleteOwnedItem(li.Data("itemId"));
                li.SlideUp(200, () => Render(false));
            });
            // hook stat roll buttons
            htmlObject.Find(".roll_stat_button").Click(ev =>
            {
                Element button = ev.CurrentTarget;
                DoStatRoll(button.GetAttribute("data-statname"));
            });

           
            htmlObject.Find(".roll_skill_button").Click(ev => {
                    Element button = ev.CurrentTarget;
                    DoSkillRoll(button.GetAttribute("data-skillname"));
            });

            // Clear skill pulldown
            htmlObject.Find("#skill_pulldown").Click(ev =>
            {
                htmlObject.Find(ev.CurrentTarget).Val("");
            });

            HTMLCollection clear_pulldowns = Document.GetElementsByClassName("clear_pulldown");
            foreach (Element el in clear_pulldowns)
            {
                el.AddEventListener("click", ev => { htmlObject.Find(ev.CurrentTarget.ToString()).Val(""); }, false);
            }

            htmlObject.Find("#add_skill_button").Click(ev =>
                {
                    jQuery skillname = htmlObject.Find("#skill_pulldown");
                    Console.WriteLine("add skill " + skillname.Val());
                    DoAddSkill(skillname.Val());
            });

            htmlObject.Find("#roll_button").Click(ev =>
            {
                Console.WriteLine("show roll dialog");
                htmlObject.Find("#roll_dialog").Show();
            });

            HTMLCollection action_buttons = Document.GetElementsByClassName("action_button");
            foreach (Element el in action_buttons)
            {
                el.AddEventListener("click", ev =>
                {
                    Element button = (Element) ev.CurrentTarget;
                    DoItemAction(button.GetAttribute("data-itemkey"),
                        button.GetAttribute("data-actionkey"));
                });
            }
        }

       
        private void DoAddSkill(string val)
        {
           Console.WriteLine("add skill "+val);
        }

        private void DoItemAction(string itemKey, string actionKey)
        {
            Console.WriteLine("Do item,action: "+itemKey+","+actionKey);
        }

        private void DoSkillRoll(string skillName)
        {
           Console.WriteLine("Do skil roll: "+skillName);
        }

        private void DoStatRoll(string statname)
        {
            Console.WriteLine("doing roll");
            dynamic data = getData().data;
            dynamic stat = data.stats[statname];
            string rollstr = stat.d8.toString() + "d8";
            float modifier = stat.plus - stat.damage;
            if (modifier > 0)
            {
                rollstr = rollstr + "+" + modifier.ToString();
            }
            else if (modifier < 0)
            {
                rollstr = rollstr + modifier.ToString();
            }
            Console.WriteLine("rolling "+rollstr);
            dynamic opts = new RawJSObject();
            opts.flavor = "Makes a(n) " + statname + " roll...";

            new Roll(rollstr).toMessage(opts);
            
        }

        public void ClickTabSelect(dynamic clicked)
        {
            _sheetTab = clicked.data("tab");
        }
    }

    
}
