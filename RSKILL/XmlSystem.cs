using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace RSKILL
{
    public class XmlSave
    {
        public static void Save(player Player)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(player));
                StreamWriter writer = new StreamWriter("player.xml");
                serializer.Serialize(writer, Player);
            }
            catch
            {
            }
        }
    }

}
