using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;


namespace PokemonGo_Map_Launcher
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
       
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Bulbasaur.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Bulbasaur"":""False""", @"""Bulbasaur"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Bulbasaur"":""True""", @"""Bulbasaur"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Ivysaur.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Ivysaur"":""False""", @"""Ivysaur"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Ivysaur"":""True""", @"""Ivysaur"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Venusaur.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Venusaur"":""False""", @"""Venusaur"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Venusaur"":""True""", @"""Venusaur"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Charmander.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Charmander"":""False""", @"""Charmander"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Charmander"":""True""", @"""Charmander"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Charmeleon.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Charmeleon"":""False""", @"""Charmeleon"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Charmeleon"":""True""", @"""Charmeleon"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Charizard.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Charizard"":""False""", @"""Charizard"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Charizard"":""True""", @"""Charizard"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Squirtle.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Squirtle"":""False""", @"""Squirtle"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Squirtle"":""True""", @"""Squirtle"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Wartortle.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Wartortle"":""False""", @"""Wartortle"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Wartortle"":""True""", @"""Wartortle"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Blastoise.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Blastoise"":""False""", @"""Blastoise"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Blastoise"":""True""", @"""Blastoise"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Caterpie.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Caterpie"":""False""", @"""Caterpie"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Caterpie"":""True""", @"""Caterpie"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Metapod.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Metapod"":""False""", @"""Metapod"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Metapod"":""True""", @"""Metapod"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Butterfree.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Butterfree"":""False""", @"""Butterfree"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Butterfree"":""True""", @"""Butterfree"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Weedle.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Weedle"":""False""", @"""Weedle"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Weedle"":""True""", @"""Weedle"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Kakuna.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Kakuna"":""False""", @"""Kakuna"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Kakuna"":""True""", @"""Kakuna"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Beedrill.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Beedrill"":""False""", @"""Beedrill"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Beedrill"":""True""", @"""Beedrill"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Pidgey.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Pidgey"":""False""", @"""Pidgey"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Pidgey"":""True""", @"""Pidgey"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Pidgeotto.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Pidgeotto"":""False""", @"""Pidgeotto"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Pidgeotto"":""True""", @"""Pidgeotto"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Pidgeot.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Pidgeot"":""False""", @"""Pidgeot"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Pidgeot"":""True""", @"""Pidgeot"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Rattata.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Rattata"":""False""", @"""Rattata"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Rattata"":""True""", @"""Rattata"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Raticate.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Raticate"":""False""", @"""Raticate"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Raticate"":""True""", @"""Raticate"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Spearow.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Spearow"":""False""", @"""Spearow"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Spearow"":""True""", @"""Spearow"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Fearow.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Fearow"":""False""", @"""Fearow"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Fearow"":""True""", @"""Fearow"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Ekans.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Ekans"":""False""", @"""Ekans"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Ekans"":""True""", @"""Ekans"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Arbok.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Arbok"":""False""", @"""Arbok"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Arbok"":""True""", @"""Arbok"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Pikachu.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Pikachu"":""False""", @"""Pikachu"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Pikachu"":""True""", @"""Pikachu"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Raichu.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Raichu"":""False""", @"""Raichu"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Raichu"":""True""", @"""Raichu"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Sandshrew.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Sandshrew"":""False""", @"""Sandshrew"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Sandshrew"":""True""", @"""Sandshrew"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Sandslash.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Sandslash"":""False""", @"""Sandslash"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Sandslash"":""True""", @"""Sandslash"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Nidoran.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Nidoran♀"":""False""", @"""Nidoran♀"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Nidoran♀"":""True""", @"""Nidoran♀"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Nidorina.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Nidorina"":""False""", @"""Nidorina"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Nidorina"":""True""", @"""Nidorina"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Nidoqueen.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Nidoqueen"":""False""", @"""Nidoqueen"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Nidoqueen"":""True""", @"""Nidoqueen"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (NidoranM.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Nidoran♂"":""False""", @"""Nidoran♂"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Nidoran♂"":""True""", @"""Nidoran♂"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Nidorino.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Nidorino"":""False""", @"""Nidorino"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Nidorino"":""True""", @"""Nidorino"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Nidoking.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Nidoking"":""False""", @"""Nidoking"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Nidoking"":""True""", @"""Nidoking"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Clefairy.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Clefairy"":""False""", @"""Clefairy"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Clefairy"":""True""", @"""Clefairy"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Clefable.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Clefable"":""False""", @"""Clefable"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Clefable"":""True""", @"""Clefable"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Vulpix.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Vulpix"":""False""", @"""Vulpix"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Vulpix"":""True""", @"""Vulpix"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Ninetales.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Ninetales"":""False""", @"""Ninetales"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Ninetales"":""True""", @"""Ninetales"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Jigglypuff.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Jigglypuff"":""False""", @"""Jigglypuff"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Jigglypuff"":""True""", @"""Jigglypuff"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Wigglytuff.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Wigglytuff"":""False""", @"""Wigglytuff"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Wigglytuff"":""True""", @"""Wigglytuff"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Zubat.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Zubat"":""False""", @"""Zubat"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Zubat"":""True""", @"""Zubat"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Golbat.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Golbat"":""False""", @"""Golbat"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Golbat"":""True""", @"""Golbat"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Oddish.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Oddish"":""False""", @"""Oddish"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Oddish"":""True""", @"""Oddish"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Gloom.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Gloom"":""False""", @"""Gloom"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Gloom"":""True""", @"""Gloom"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Vileplume.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Vileplume"":""False""", @"""Vileplume"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Vileplume"":""True""", @"""Vileplume"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Paras.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Paras"":""False""", @"""Paras"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Paras"":""True""", @"""Paras"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Parasect.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Parasect"":""False""", @"""Parasect"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Parasect"":""True""", @"""Parasect"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Venonat.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Venonat"":""False""", @"""Venonat"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Venonat"":""True""", @"""Venonat"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Venomoth.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Venomoth"":""False""", @"""Venomoth"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Venomoth"":""True""", @"""Venomoth"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Diglett.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Diglett"":""False""", @"""Diglett"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Diglett"":""True""", @"""Diglett"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Dugtrio.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Dugtrio"":""False""", @"""Dugtrio"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Dugtrio"":""True""", @"""Dugtrio"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Meowth.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Meowth"":""False""", @"""Meowth"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Meowth"":""True""", @"""Meowth"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Persian.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Persian"":""False""", @"""Persian"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Persian"":""True""", @"""Persian"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Psyduck.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Psyduck"":""False""", @"""Psyduck"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Psyduck"":""True""", @"""Psyduck"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Golduck.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Golduck"":""False""", @"""Golduck"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Golduck"":""True""", @"""Golduck"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Mankey.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Mankey"":""False""", @"""Mankey"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Mankey"":""True""", @"""Mankey"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Primeape.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Primeape"":""False""", @"""Primeape"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Primeape"":""True""", @"""Primeape"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Growlithe.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Growlithe"":""False""", @"""Growlithe"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Growlithe"":""True""", @"""Growlithe"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Arcanine.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Arcanine"":""False""", @"""Arcanine"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Arcanine"":""True""", @"""Arcanine"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Poliwag.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Poliwag"":""False""", @"""Poliwag"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Poliwag"":""True""", @"""Poliwag"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Poliwhirl.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Poliwhirl"":""False""", @"""Poliwhirl"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Poliwhirl"":""True""", @"""Poliwhirl"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Poliwrath.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Poliwrath"":""False""", @"""Poliwrath"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Poliwrath"":""True""", @"""Poliwrath"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Abra.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Abra"":""False""", @"""Abra"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Abra"":""True""", @"""Abra"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Kadabra.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Kadabra"":""False""", @"""Kadabra"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Kadabra"":""True""", @"""Kadabra"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Alakazam.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Alakazam"":""False""", @"""Alakazam"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Alakazam"":""True""", @"""Alakazam"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Machop.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Machop"":""False""", @"""Machop"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Machop"":""True""", @"""Machop"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Machoke.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Machoke"":""False""", @"""Machoke"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Machoke"":""True""", @"""Machoke"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Machamp.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Machamp"":""False""", @"""Machamp"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Machamp"":""True""", @"""Machamp"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Bellsprout.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Bellsprout"":""False""", @"""Bellsprout"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Bellsprout"":""True""", @"""Bellsprout"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Weepinbell.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Weepinbell"":""False""", @"""Weepinbell"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Weepinbell"":""True""", @"""Weepinbell"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Victreebel.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Victreebel"":""False""", @"""Victreebel"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Victreebel"":""True""", @"""Victreebel"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Tentacool.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Tentacool"":""False""", @"""Tentacool"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Tentacool"":""True""", @"""Tentacool"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Tentacruel.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Tentacruel"":""False""", @"""Tentacruel"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Tentacruel"":""True""", @"""Tentacruel"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Geodude.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Geodude"":""False""", @"""Geodude"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Geodude"":""True""", @"""Geodude"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Graveler.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Graveler"":""False""", @"""Graveler"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Graveler"":""True""", @"""Graveler"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Golem.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Golem"":""False""", @"""Golem"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Golem"":""True""", @"""Golem"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Ponyta.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Ponyta"":""False""", @"""Ponyta"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Ponyta"":""True""", @"""Ponyta"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Rapidash.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Rapidash"":""False""", @"""Rapidash"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Rapidash"":""True""", @"""Rapidash"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Slowpoke.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Slowpoke"":""False""", @"""Slowpoke"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Slowpoke"":""True""", @"""Slowpoke"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Slowbro.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Slowbro"":""False""", @"""Slowbro"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Slowbro"":""True""", @"""Slowbro"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Magnemite.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Magnemite"":""False""", @"""Magnemite"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Magnemite"":""True""", @"""Magnemite"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Magneton.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Magneton"":""False""", @"""Magneton"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Magneton"":""True""", @"""Magneton"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Farfetch.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Farfetch'd"":""False""", @"""Farfetch'd"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Farfetch'd"":""True""", @"""Farfetch'd"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Doduo.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Doduo"":""False""", @"""Doduo"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Doduo"":""True""", @"""Doduo"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Dodrio.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Dodrio"":""False""", @"""Dodrio"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Dodrio"":""True""", @"""Dodrio"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Seel.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Seel"":""False""", @"""Seel"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Seel"":""True""", @"""Seel"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Dewgong.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Dewgong"":""False""", @"""Dewgong"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Dewgong"":""True""", @"""Dewgong"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Grimer.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Grimer"":""False""", @"""Grimer"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Grimer"":""True""", @"""Grimer"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Muk.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Muk"":""False""", @"""Muk"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Muk"":""True""", @"""Muk"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Shellder.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Shellder"":""False""", @"""Shellder"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Shellder"":""True""", @"""Shellder"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Cloyster.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Cloyster"":""False""", @"""Cloyster"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Cloyster"":""True""", @"""Cloyster"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Gastly.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Gastly"":""False""", @"""Gastly"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Gastly"":""True""", @"""Gastly"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Haunter.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Haunter"":""False""", @"""Haunter"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Haunter"":""True""", @"""Haunter"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Gengar.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Gengar"":""False""", @"""Gengar"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Gengar"":""True""", @"""Gengar"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Onix.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Onix"":""False""", @"""Onix"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Onix"":""True""", @"""Onix"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Drowzee.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Drowzee"":""False""", @"""Drowzee"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Drowzee"":""True""", @"""Drowzee"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Hypno.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Hypno"":""False""", @"""Hypno"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Hypno"":""True""", @"""Hypno"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Krabby.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Krabby"":""False""", @"""Krabby"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Krabby"":""True""", @"""Krabby"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Kingler.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Kingler"":""False""", @"""Kingler"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Kingler"":""True""", @"""Kingler"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Voltorb.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Voltorb"":""False""", @"""Voltorb"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Voltorb"":""True""", @"""Voltorb"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Electrode.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Electrode"":""False""", @"""Electrode"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Electrode"":""True""", @"""Electrode"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Exeggcute.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Exeggcute"":""False""", @"""Exeggcute"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Exeggcute"":""True""", @"""Exeggcute"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Exeggutor.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Exeggutor"":""False""", @"""Exeggutor"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Exeggutor"":""True""", @"""Exeggutor"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Cubone.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Cubone"":""False""", @"""Cubone"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Cubone"":""True""", @"""Cubone"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Marowak.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Marowak"":""False""", @"""Marowak"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Marowak"":""True""", @"""Marowak"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Hitmonlee.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Hitmonlee"":""False""", @"""Hitmonlee"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Hitmonlee"":""True""", @"""Hitmonlee"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Hitmonchan.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Hitmonchan"":""False""", @"""Hitmonchan"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Hitmonchan"":""True""", @"""Hitmonchan"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Lickitung.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Lickitung"":""False""", @"""Lickitung"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Lickitung"":""True""", @"""Lickitung"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Koffing.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Koffing"":""False""", @"""Koffing"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Koffing"":""True""", @"""Koffing"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Weezing.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Weezing"":""False""", @"""Weezing"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Weezing"":""True""", @"""Weezing"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Rhyhorn.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Rhyhorn"":""False""", @"""Rhyhorn"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Rhyhorn"":""True""", @"""Rhyhorn"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Rhydon.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Rhydon"":""False""", @"""Rhydon"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Rhydon"":""True""", @"""Rhydon"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Chansey.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Chansey"":""False""", @"""Chansey"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Chansey"":""True""", @"""Chansey"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Tangela.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Tangela"":""False""", @"""Tangela"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Tangela"":""True""", @"""Tangela"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Kangaskhan.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Kangaskhan"":""False""", @"""Kangaskhan"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Kangaskhan"":""True""", @"""Kangaskhan"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Horsea.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Horsea"":""False""", @"""Horsea"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Horsea"":""True""", @"""Horsea"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Seadra.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Seadra"":""False""", @"""Seadra"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Seadra"":""True""", @"""Seadra"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Goldeen.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Goldeen"":""False""", @"""Goldeen"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Goldeen"":""True""", @"""Goldeen"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Seaking.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Seaking"":""False""", @"""Seaking"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Seaking"":""True""", @"""Seaking"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Staryu.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Staryu"":""False""", @"""Staryu"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Staryu"":""True""", @"""Staryu"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Starmie.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Starmie"":""False""", @"""Starmie"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Starmie"":""True""", @"""Starmie"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (MrMime.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Mr. Mime"":""False""", @"""Mr. Mime"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Mr. Mime"":""True""", @"""Mr. Mime"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Scyther.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Scyther"":""False""", @"""Scyther"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Scyther"":""True""", @"""Scyther"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Jynx.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Jynx"":""False""", @"""Jynx"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Jynx"":""True""", @"""Jynx"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Electabuzz.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Electabuzz"":""False""", @"""Electabuzz"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Electabuzz"":""True""", @"""Electabuzz"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Magmar.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Magmar"":""False""", @"""Magmar"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Magmar"":""True""", @"""Magmar"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Pinsir.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Pinsir"":""False""", @"""Pinsir"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Pinsir"":""True""", @"""Pinsir"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Tauros.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Tauros"":""False""", @"""Tauros"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Tauros"":""True""", @"""Tauros"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Magikarp.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Magikarp"":""False""", @"""Magikarp"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Magikarp"":""True""", @"""Magikarp"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Gyarados.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Gyarados"":""False""", @"""Gyarados"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Gyarados"":""True""", @"""Gyarados"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Lapras.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Lapras"":""False""", @"""Lapras"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Lapras"":""True""", @"""Lapras"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Ditto.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Ditto"":""False""", @"""Ditto"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Ditto"":""True""", @"""Ditto"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Eevee.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Eevee"":""False""", @"""Eevee"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Eevee"":""True""", @"""Eevee"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Vaporeon.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Vaporeon"":""False""", @"""Vaporeon"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Vaporeon"":""True""", @"""Vaporeon"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Jolteon.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Jolteon"":""False""", @"""Jolteon"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Jolteon"":""True""", @"""Jolteon"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Flareon.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Flareon"":""False""", @"""Flareon"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Flareon"":""True""", @"""Flareon"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Porygon.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Porygon"":""False""", @"""Porygon"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Porygon"":""True""", @"""Porygon"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Rhyhorn.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Omanyte"":""False""", @"""Omanyte"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Omanyte"":""True""", @"""Omanyte"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Omastar.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Omastar"":""False""", @"""Omastar"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Omastar"":""True""", @"""Omastar"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Kabuto.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Kabuto"":""False""", @"""Kabuto"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Kabuto"":""True""", @"""Kabuto"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Kabutops.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Kabutops"":""False""", @"""Kabutops"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Kabutops"":""True""", @"""Kabutops"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Aerodactyl.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Aerodactyl"":""False""", @"""Aerodactyl"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Aerodactyl"":""True""", @"""Aerodactyl"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Snorlax.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Snorlax"":""False""", @"""Snorlax"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Snorlax"":""True""", @"""Snorlax"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Articuno.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Articuno"":""False""", @"""Articuno"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Articuno"":""True""", @"""Articuno"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Zapdos.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Zapdos"":""False""", @"""Zapdos"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Zapdos"":""True""", @"""Zapdos"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Moltres.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Moltres"":""False""", @"""Moltres"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Moltres"":""True""", @"""Moltres"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Dratini.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Dratini"":""False""", @"""Dratini"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Dratini"":""True""", @"""Dratini"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Dragonair.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Dragonair"":""False""", @"""Dragonair"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Dragonair"":""True""", @"""Dragonair"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Dragonite.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Dragonite"":""False""", @"""Dragonite"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Dragonite"":""True""", @"""Dragonite"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Mewtwo.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Mewtwo"":""False""", @"""Mewtwo"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Mewtwo"":""True""", @"""Mewtwo"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (Mew.Checked)
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Mew"":""False""", @"""Mew"":""True""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }
            else
            {
                string text = File.ReadAllText(@".\PokeAlarm\alarms.json");
                text = text.Replace(@"""Mew"":""True""", @"""Mew"":""False""");
                File.WriteAllText(@".\PokeAlarm\alarms.json", text);
            }

            if (enable_push.Checked)
            {
                var lines = File.ReadAllLines(@".\PokeAlarm\alarms.json");
                lines[8] = @"			""active"":""True"",";
                lines[10] = @"			""api_key"":" + push_api.Text + "";
                File.WriteAllLines(@".\PokeAlarm\alarms.json", lines);
            }
            else
            {
                var lines = File.ReadAllLines(@".\PokeAlarm\alarms.json");
                lines[8] = @"			""active"":""False"",";
                lines[10] = @"			""api_key"":" + push_api.Text + "";
                File.WriteAllLines(@".\PokeAlarm\alarms.json", lines);
            }

            if (enable_slack.Checked)
            {
                var lines = File.ReadAllLines(@".\PokeAlarm\alarms.json");
                lines[19] = @"			""active"": ""True"",";
                lines[21] = @"			""api_key"":" + slack_api.Text + "";
                File.WriteAllLines(@".\PokeAlarm\alarms.json", lines);
            }
            else
            {
                var lines = File.ReadAllLines(@".\PokeAlarm\alarms.json");
                lines[19] = @"			""active"": ""False"",";
                lines[21] = @"			""api_key"":" + slack_api.Text + "";
                File.WriteAllLines(@".\PokeAlarm\alarms.json", lines);
            }

            if (enable_twitter.Checked)
            {
                var lines = File.ReadAllLines(@".\PokeAlarm\alarms.json");
                lines[38] = @"			""active"": ""True"",";
                lines[40] = @"			""access_token"": " + access_token.Text + ",";
                lines[41] = @"			""access_secret"": " + access_secret.Text + ",";
                lines[42] = @"			""consumer_key"": " + consumer_key.Text + ",";
                lines[43] = @"			""consumer_secret"": " + consumer_secret.Text + "";
                File.WriteAllLines(@".\PokeAlarm\alarms.json", lines);
            }
            else
            {
                var lines = File.ReadAllLines(@".\PokeAlarm\alarms.json");
                lines[38] = @"			""active"": ""False"",";
                lines[40] = @"			""access_token"": " + access_token.Text + ",";
                lines[41] = @"			""access_secret"": " + access_secret.Text + ",";
                lines[42] = @"			""consumer_key"": " + consumer_key.Text + ",";
                lines[43] = @"			""consumer_secret"": " + consumer_secret.Text + "";
                File.WriteAllLines(@".\PokeAlarm\alarms.json", lines);
            }




        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.bulbasaur = Bulbasaur.Checked;
            Properties.Settings.Default.Ivysaur = Ivysaur.Checked;
            Properties.Settings.Default.Venusaur = Venusaur.Checked;
            Properties.Settings.Default.Charmander = Charmander.Checked;
            Properties.Settings.Default.Charmeleon = Charmeleon.Checked;
            Properties.Settings.Default.Charizard = Charizard.Checked;
            Properties.Settings.Default.Squirtle = Squirtle.Checked;
            Properties.Settings.Default.Wartortle = Wartortle.Checked;
            Properties.Settings.Default.Blastoise = Blastoise.Checked;
            Properties.Settings.Default.Caterpie = Caterpie.Checked;
            Properties.Settings.Default.Metapod = Metapod.Checked;
            Properties.Settings.Default.Butterfree = Butterfree.Checked;
            Properties.Settings.Default.Weedle = Weedle.Checked;
            Properties.Settings.Default.Kakuna = Kakuna.Checked;
            Properties.Settings.Default.Beedrill = Beedrill.Checked;
            Properties.Settings.Default.Pidgey = Pidgey.Checked;
            Properties.Settings.Default.Pidgeotto = Pidgeotto.Checked;
            Properties.Settings.Default.Pidgeot = Pidgeot.Checked;
            Properties.Settings.Default.Rattata = Rattata.Checked;
            Properties.Settings.Default.Raticate = Raticate.Checked;
            Properties.Settings.Default.Spearow = Spearow.Checked;
            Properties.Settings.Default.Fearow = Fearow.Checked;
            Properties.Settings.Default.Ekans = Ekans.Checked;
            Properties.Settings.Default.Arbok = Arbok.Checked;
            Properties.Settings.Default.Pikachu = Pikachu.Checked;
            Properties.Settings.Default.Raichu = Raichu.Checked;
            Properties.Settings.Default.Sandshrew = Sandshrew.Checked;
            Properties.Settings.Default.Sandslash = Sandslash.Checked;
            Properties.Settings.Default.NidoranF = Nidoran.Checked;
            Properties.Settings.Default.Nidorina = Nidorina.Checked;
            Properties.Settings.Default.Nidoqueen = Nidoqueen.Checked;
            Properties.Settings.Default.NidoranM = NidoranM.Checked;
            Properties.Settings.Default.Nidorino = Nidorino.Checked;
            Properties.Settings.Default.Nidoking = Nidoking.Checked;
            Properties.Settings.Default.Clefairy = Clefairy.Checked;
            Properties.Settings.Default.Clefable = Clefable.Checked;
            Properties.Settings.Default.Vulpix = Vulpix.Checked;
            Properties.Settings.Default.Ninetales = Ninetales.Checked;
            Properties.Settings.Default.Jigglypuff = Jigglypuff.Checked;
            Properties.Settings.Default.Wigglytuff = Wigglytuff.Checked;
            Properties.Settings.Default.Zubat = Zubat.Checked;
            Properties.Settings.Default.Golbat = Golbat.Checked;
            Properties.Settings.Default.Oddish = Oddish.Checked;
            Properties.Settings.Default.Gloom = Gloom.Checked;
            Properties.Settings.Default.Vileplume = Vileplume.Checked;
            Properties.Settings.Default.Paras = Paras.Checked;
            Properties.Settings.Default.Parasect = Parasect.Checked;
            Properties.Settings.Default.Venonat = Venonat.Checked;
            Properties.Settings.Default.Venomoth = Venomoth.Checked;
            Properties.Settings.Default.Diglett = Diglett.Checked;
            Properties.Settings.Default.Dugtrio = Dugtrio.Checked;
            Properties.Settings.Default.Meowth = Meowth.Checked;
            Properties.Settings.Default.Persian = Persian.Checked;
            Properties.Settings.Default.Psyduck = Psyduck.Checked;
            Properties.Settings.Default.Golduck = Golduck.Checked;
            Properties.Settings.Default.Mankey = Mankey.Checked;
            Properties.Settings.Default.Primeape = Primeape.Checked;
            Properties.Settings.Default.Growlithe = Growlithe.Checked;
            Properties.Settings.Default.Arcanine = Arcanine.Checked;
            Properties.Settings.Default.Poliwag = Poliwag.Checked;
            Properties.Settings.Default.Poliwhirl = Poliwhirl.Checked;
            Properties.Settings.Default.Poliwrath = Poliwrath.Checked;
            Properties.Settings.Default.Abra = Abra.Checked;
            Properties.Settings.Default.Kadabra = Kadabra.Checked;
            Properties.Settings.Default.Alakazam = Alakazam.Checked;
            Properties.Settings.Default.Machop = Machop.Checked;
            Properties.Settings.Default.Machoke = Machoke.Checked;
            Properties.Settings.Default.Machamp = Machamp.Checked;
            Properties.Settings.Default.Bellsprout = Bellsprout.Checked;
            Properties.Settings.Default.Weepinbell = Weepinbell.Checked;
            Properties.Settings.Default.Victreebel = Victreebel.Checked;
            Properties.Settings.Default.Tentacool = Tentacool.Checked;
            Properties.Settings.Default.Tentacruel = Tentacruel.Checked;
            Properties.Settings.Default.Geodude = Geodude.Checked;
            Properties.Settings.Default.Graveler = Graveler.Checked;
            Properties.Settings.Default.Golem = Golem.Checked;
            Properties.Settings.Default.Ponyta = Ponyta.Checked;
            Properties.Settings.Default.Rapidash = Rapidash.Checked;
            Properties.Settings.Default.Slowpoke = Slowpoke.Checked;
            Properties.Settings.Default.Slowbro = Slowbro.Checked;
            Properties.Settings.Default.Magnemite = Magnemite.Checked;
            Properties.Settings.Default.Farfetch = Farfetch.Checked;
            Properties.Settings.Default.Doduo = Doduo.Checked;
            Properties.Settings.Default.Dodrio = Dodrio.Checked;
            Properties.Settings.Default.Seel = Seel.Checked;
            Properties.Settings.Default.Dewgong = Dewgong.Checked;
            Properties.Settings.Default.Grimer = Grimer.Checked;
            Properties.Settings.Default.Muk = Muk.Checked;
            Properties.Settings.Default.Shellder = Shellder.Checked;
            Properties.Settings.Default.Cloyster = Cloyster.Checked;
            Properties.Settings.Default.Gastly = Gastly.Checked;
            Properties.Settings.Default.Haunter = Haunter.Checked;
            Properties.Settings.Default.Gengar = Gengar.Checked;
            Properties.Settings.Default.Onix = Onix.Checked;
            Properties.Settings.Default.Drowzee = Drowzee.Checked;
            Properties.Settings.Default.Hypno = Hypno.Checked;
            Properties.Settings.Default.Krabby = Krabby.Checked;
            Properties.Settings.Default.Kingler = Kingler.Checked;
            Properties.Settings.Default.Voltorb = Voltorb.Checked;
            Properties.Settings.Default.Electrode = Electrode.Checked;
            Properties.Settings.Default.Exeggcute = Exeggcute.Checked;
            Properties.Settings.Default.Exeggutor = Exeggutor.Checked;
            Properties.Settings.Default.Cubone = Cubone.Checked;
            Properties.Settings.Default.Marowak = Marowak.Checked;
            Properties.Settings.Default.Hitmonlee = Hitmonlee.Checked;
            Properties.Settings.Default.Hitmonchan = Hitmonchan.Checked;
            Properties.Settings.Default.Lickitung = Lickitung.Checked;
            Properties.Settings.Default.Koffing = Koffing.Checked;
            Properties.Settings.Default.Weezing = Weezing.Checked;
            Properties.Settings.Default.Rhyhorn = Rhyhorn.Checked;
            Properties.Settings.Default.Rhydon = Rhydon.Checked;
            Properties.Settings.Default.Chansey = Chansey.Checked;
            Properties.Settings.Default.Tangela = Tangela.Checked;
            Properties.Settings.Default.Kangaskhan = Kangaskhan.Checked;
            Properties.Settings.Default.Horsea = Horsea.Checked;
            Properties.Settings.Default.Seadra = Seadra.Checked;
            Properties.Settings.Default.Goldeen = Goldeen.Checked;
            Properties.Settings.Default.Seaking = Seaking.Checked;
            Properties.Settings.Default.Staryu = Staryu.Checked;
            Properties.Settings.Default.Starmie = Starmie.Checked;
            Properties.Settings.Default.MrMime = MrMime.Checked;
            Properties.Settings.Default.Scyther = Scyther.Checked;
            Properties.Settings.Default.Jynx = Jynx.Checked;
            Properties.Settings.Default.Electabuzz = Electabuzz.Checked;
            Properties.Settings.Default.Magmar = Magmar.Checked;
            Properties.Settings.Default.Pinsir = Pinsir.Checked;
            Properties.Settings.Default.Tauros = Tauros.Checked;
            Properties.Settings.Default.Magikarp = Magikarp.Checked;
            Properties.Settings.Default.Gyarados = Gyarados.Checked;
            Properties.Settings.Default.Lapras = Lapras.Checked;
            Properties.Settings.Default.Ditto = Ditto.Checked;
            Properties.Settings.Default.Eevee = Eevee.Checked;
            Properties.Settings.Default.Vaporeon = Vaporeon.Checked;
            Properties.Settings.Default.Jolteon = Jolteon.Checked;
            Properties.Settings.Default.Flareon = Flareon.Checked;
            Properties.Settings.Default.Porygon = Porygon.Checked;
            Properties.Settings.Default.Omanyte = Omanyte.Checked;
            Properties.Settings.Default.Omastar = Omastar.Checked;
            Properties.Settings.Default.Kabuto = Kabuto.Checked;
            Properties.Settings.Default.Kabutops = Kabutops.Checked;
            Properties.Settings.Default.Aerodactyl = Aerodactyl.Checked;
            Properties.Settings.Default.Snorlax = Snorlax.Checked;
            Properties.Settings.Default.Articuno = Articuno.Checked;
            Properties.Settings.Default.Zapdos = Zapdos.Checked;
            Properties.Settings.Default.Moltres = Moltres.Checked;
            Properties.Settings.Default.Dratini = Dratini.Checked;
            Properties.Settings.Default.Dragonair = Dragonair.Checked;
            Properties.Settings.Default.Dragonite = Dragonite.Checked;
            Properties.Settings.Default.Mewtwo = Mewtwo.Checked;
            Properties.Settings.Default.Mew = Mew.Checked;
            Properties.Settings.Default.enable_push = enable_push.Checked;
            Properties.Settings.Default.enable_twitter = enable_twitter.Checked;
            Properties.Settings.Default.enable_slack = enable_twitter.Checked;
            Properties.Settings.Default.pushapi = push_api.Text;
            Properties.Settings.Default.slackapi = slack_api.Text;
            Properties.Settings.Default.access_token = access_token.Text;
            Properties.Settings.Default.access_secret = access_secret.Text;
            Properties.Settings.Default.consumer_key = consumer_key.Text;
            Properties.Settings.Default.consumer_secret = consumer_secret.Text;
            Properties.Settings.Default.Save();
        }

        private void flowLayoutPanel23_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel26_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
