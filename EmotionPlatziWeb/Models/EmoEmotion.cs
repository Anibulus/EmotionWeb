using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmotionPlatziWeb.Models
{
    public class EmoEmotion
    {
        public int ID { get; set; }
        public float score { get; set; }
        public int emoFaceID { get; set; }

        public EmoEmotionEnum emotionType{get; set;}

        public virtual EmoFace EmoFace { get; set; }
    }

}