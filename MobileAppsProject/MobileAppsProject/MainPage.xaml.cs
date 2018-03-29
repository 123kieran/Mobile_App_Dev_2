using MobileAppsProject.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MobileAppsProject
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private ObservableCollection<Sound> Sounds;
        private List<MenuBoard> Menu;

        public MainPage()
        {
            /**
             * on init add to the side menu a list of  
             * all below clickable menu items with pictures and text
             * sorted by category  
             *  preload tge page with all sounds 
            */
            this.InitializeComponent();
            Sounds = new ObservableCollection<Sound>();
            SoundManagerClass.GetAllSounds(Sounds);
            Menu = new List<MenuBoard>();
            Menu.Add(new MenuBoard { Icon = "Assets/Icons/Peter/Peter.png", MyCategory = SoundCateory.Peter });
            Menu.Add(new MenuBoard { Icon = "Assets/Icons/Lois/Lois.png", MyCategory = SoundCateory.Lois });
            Menu.Add(new MenuBoard { Icon = "Assets/Icons/Meg/Meg.png", MyCategory = SoundCateory.Meg });
            Menu.Add(new MenuBoard { Icon = "Assets/Icons/Chris/Chris.png", MyCategory = SoundCateory.Chris });






        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

     

        private void ListView_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void MenuItemsListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var menu = (MenuBoard)e.ClickedItem;
            CategoryTextBlock.Text = menu.MyCategory.ToString();
            SoundManagerClass.GetSoundsByCategory(Sounds, menu.MyCategory);

            
        }

        private void SoundGridView_ItemClick(object sender, ItemClickEventArgs e)
        {

            var sound = (Sound)e.ClickedItem;
            MyMediaElement.Source = new Uri(this.BaseUri, sound.SoundAudio);

        }
    }
}