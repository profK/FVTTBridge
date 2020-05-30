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
            /*
            htmlObject.Find(".item-edit").Click(ev => {
                jQuery li = jQuery.Select(ev.CurrentTarget).Parents(".item");
                Item item = Actor.getOwnedItem(li.Data("itemId"));
                item.sheet.render(true);
            });*/

            
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

            /*
            // hook skil lroll buttons
            html.find('.roll_skill_button').click(ev => {
                const button = ev.currentTarget
              this.DoSkillRoll(button.getAttribute('data-skillname'))
            });

            // Clear skill pulldown
            $("#skill_pulldown").click(ev => {
                 console.log("click")
              $(ev.currentTarget).val("")
            });

                    var clear_pulldowns = document.getElementsByClassName("clear_pulldown")
            for (let el of clear_pulldowns)
                    {
                        el.addEventListener("click", ev => {
                $(ev.currentTarget).val("")
                        }, false)
            }

            $("#add_skill_button").click(ev => {
                 var skillname = $("#skill_pulldown")
              console.log("add skill " + skillname.val())
              this.DoAddSkill(skillname.val())
            })

            $("#roll_button").click(ev => {
                 console.log('show roll dialog')
              $("#roll_dialog").show()
            })

            var action_buttons = document.getElementsByClassName("action_button")
            for (let el of action_buttons)
                    {
                        el.addEventListener("click", ev => {
                            const button = ev.currentTarget
                          this.DoItemAction(button.getAttribute('data-itemkey'),
                    button.getAttribute('data-actionkey'))
                        })*/
        }

        private void DoStatRoll(string statname)
        {
            Console.WriteLine("doing roll");
            dynamic data = GetData().data;
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
