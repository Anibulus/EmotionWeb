using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace EmotionPlatziWeb.Models
{
    public class EmoFace
    {
        public int ID { get; set; }
        public int EmoPictureID { get; set; }

        /*Esto permite colapsar esta parte del codigo*/
        #region
        public int X {get; set;}
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        #endregion

        public virtual EmoPicture Picture { get; set; }
        public virtual ObservableCollection<EmoEmotion> EmoEmotion { get; set; } 
    }
}