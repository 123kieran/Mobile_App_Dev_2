using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileAppsProject.Model
{
   public class Sound{
        //varibales with getters and setters 
        public string SoundName { get; set; }
        public SoundCateory SoundCategory { get; set; }
        public string SoundAudio { get; set; }
        public string SoundImage { get; set; }

        /*public arg construct which assigns the variables to the 
          audio files and image files as well as sound name and category  
          via the below enum 
        */    
    public Sound(String soundName, SoundCateory category)
    {
            SoundName = soundName;
            SoundCategory = category;
            SoundAudio = String.Format("/Assets/Audio/{0}/{1}.mp3", category, soundName);
            SoundImage = String.Format("/Assets/Icons/{0}/{0}.png", category, soundName);
    }

    }

    public enum SoundCateory
    {
        //Declaring the Categorys available for searching via by category 
        Peter,
        Lois,
        Meg,
        Chris,
        Brian,
        Stewie
   
    }

    
}
