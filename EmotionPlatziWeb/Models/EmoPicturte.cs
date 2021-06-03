using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace EmotionPlatziWeb.Models
{
    public class EmoPicture
    {
        public int ID { get; set; }
        public string nombre { get; set; }
        public string path { get; set; }

        //Virtual se usa como propiedad de navegacion y sirve solo para c#, exclusivamente para entiry framework
        public virtual ObservableCollection <EmoFace> EmoFace{get; set;}

        public DateTime CreateDate { get; set; } = DateTime.Now;
    }//Fin de cla clase
}