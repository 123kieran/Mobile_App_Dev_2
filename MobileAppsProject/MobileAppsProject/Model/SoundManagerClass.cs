using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileAppsProject.Model
{
    public class SoundManagerClass
    {
        //get all sounds in the local storage folders 
        public static void GetAllSounds(ObservableCollection<Sound> sounds)
        {
            //call method get all sounds 
            var allSounds = getSounds();
            sounds.Clear(); //clear any existing sounds 
            allSounds.ForEach(p => sounds.Add(p));//lambda expression to get all sounds added  
        }

        //get all sounds by category
        public static void GetSoundsByCategory(ObservableCollection<Sound> sounds, SoundCateory MySoundCategory)
        {
            //call method get all sounds 
            var allSounds = getSounds();
            // filter all sounds and assign all sounds to 
            //there subcategory via lambda expression
            var SoundByCategory = allSounds.Where(P => P.SoundCategory == MySoundCategory).ToList();  
            sounds.Clear();
            SoundByCategory.ForEach(p => sounds.Add(p));

        }

        //Arraylist of Type Sound method called getSounds 
        private static List<Sound> getSounds()
        {
            //declare a new list add the available sounds to it 
            //as seen below return the list back when called 
            var sounds = new List<Sound>();
            
            //Add Sounds to List 
            sounds.Add(new Sound("dangerous", SoundCateory.Peter));
            sounds.Add(new Sound("howseverybodydoing", SoundCateory.Peter));
            sounds.Add(new Sound("youcouldnotbemorewrong", SoundCateory.Peter));
            sounds.Add(new Sound("youlikethat", SoundCateory.Peter));

            sounds.Add(new Sound("badperson", SoundCateory.Lois));
            sounds.Add(new Sound("watchingyou", SoundCateory.Lois));
            sounds.Add(new Sound("whatchoice", SoundCateory.Lois));
            sounds.Add(new Sound("XmasEve", SoundCateory.Lois));

            sounds.Add(new Sound("alone", SoundCateory.Meg));
            sounds.Add(new Sound("lando", SoundCateory.Meg));
            sounds.Add(new Sound("lastminute", SoundCateory.Meg));

            sounds.Add(new Sound("Evilmonkey", SoundCateory.Chris));
            sounds.Add(new Sound("Moocow", SoundCateory.Chris));
            sounds.Add(new Sound("Myinvisiblefriend", SoundCateory.Chris));
            sounds.Add(new Sound("Peedinmypants", SoundCateory.Chris));

            sounds.Add(new Sound("Ass", SoundCateory.Brian));
            sounds.Add(new Sound("Cheerios", SoundCateory.Brian));
            sounds.Add(new Sound("Drymartini", SoundCateory.Brian));
            sounds.Add(new Sound("Rapmusic", SoundCateory.Brian));

            sounds.Add(new Sound("BeDestroyed", SoundCateory.Stewie));
            sounds.Add(new Sound("IhavethePOWER", SoundCateory.Stewie));
            sounds.Add(new Sound("Sheugly", SoundCateory.Stewie));
            sounds.Add(new Sound("Wemeetagain", SoundCateory.Stewie));

            sounds.Add(new Sound("Giggidi", SoundCateory.Quagmire));
            sounds.Add(new Sound("Quagmire", SoundCateory.Quagmire));

            sounds.Add(new Sound("Breakyourlegs", SoundCateory.Cleveland));
            sounds.Add(new Sound("Partyoverhere", SoundCateory.Cleveland));

            sounds.Add(new Sound("Designateddriver", SoundCateory.Joe));
            sounds.Add(new Sound("Wheelchair", SoundCateory.Joe));

            //returns the sounds
            return sounds;

        }
    }
}
