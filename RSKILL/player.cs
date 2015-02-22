using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace RSKILL
{
    public class player
    {
        public int atk {get; set;}
        public int str {get; set;}
        public int def {get; set;}
        public int con {get; set;}
        public int mag {get; set;}
        public int rng {get; set;}
        public int pray {get; set;}
        public int sum {get; set;}


        public player()
        {
            this.atk = 99;
            this.str = 99;
            this.def = 99;
            this.con = 99;
            this.mag = 99;
            this.rng = 99;
            this.pray = 99;
            this.sum = 99;
        }
        public player(int ATK, int STR, int DEF, int CON, int MAG, int RNG, int PRAY, int SUM)
        {
            this.atk = ATK;
            this.str = STR;
            this.def = DEF;
            this.con = CON;
            this.mag = MAG;
            this.rng = RNG;
            this.pray = PRAY;
            this.sum = SUM;
        }
        public double combatLevel()
        {
            double combatlvl = 0;
            double cmb = (def + con + Math.Floor(pray / 2d) + Math.Floor(sum / 2d)) * 0.25;
            double warrior = (atk + str) * 0.325, ranger = rng * 0.4875, mage = mag * 0.4875;
            combatlvl = Math.Floor((cmb + Math.Max(warrior, Math.Max(ranger, mage))));
            return combatlvl;
        }
        public void Save()
        {
            using (FileStream stream = new FileStream("Player.xml", FileMode.Create))
            {
                XmlSerializer serialize = new XmlSerializer(typeof(player));
                serialize.Serialize(stream, this);
            }
        }
        public static player LoadFromFile()
        {
            using (FileStream stream = new FileStream("Player.xml", FileMode.Open))
            {
                XmlSerializer serialize = new XmlSerializer(typeof(player));
                return (player)serialize.Deserialize(stream);
            }

        }

    }

}
