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
            // filter all sounds and assign all sounds to there subcategory via lambda expression
            var SoundByCategory = allSounds.Where(P => P.SoundCategory == MySoundCategory).ToList();  
            sounds.Clear();
            SoundByCategory.ForEach(p => sounds.Add(p));

        }

        //Arraylist of Type Sound method called getSounds 
        private static List<Sound> getSounds()
        {
            //declare a new list add the available sounds to it as seen below return the list back when called 
            var sounds = new List<Sound>();
            
            //Add Sounds to List 
            sounds.Add(new Sound("dangerous", SoundCateory.Peter));
            sounds.Add(new Sound("howseverybodydoing", SoundCateory.Peter));
            sounds.Add(new Sound("youcouldnotbemorewrong", SoundCateory.Peter));
            sounds.Add(new Sound("youlikethat", SoundCateory.Peter));





            return sounds;

        }
    }
}
