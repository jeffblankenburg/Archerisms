using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Archerisms
{
    public partial class MainPage : PhoneApplicationPage
    {

        List<SoundByte> SoundBytes = new List<SoundByte>();
        
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            LoadSounds();
            UpdateMenu();
            SoundBox.MediaOpened += SoundBox_MediaOpened;
        }

        protected override void OnNavigatingFrom(System.Windows.Navigation.NavigatingCancelEventArgs e)
        {
            base.OnNavigatingFrom(e);
            SoundBox.MediaOpened -= SoundBox_MediaOpened;
        }

        private void LoadSounds()
        {
            SoundBytes.Clear();
            SoundBytes.Add(new SoundByte { CharacterID = 0, Name = "what do you even do here?", MediaLocation = "/audio/uncensored/SterlingArcher/analyzeData.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 0, Name = "baby lsd", MediaLocation = "/audio/uncensored/SterlingArcher/babyLSD.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 0, Name = "you have a certain thickness", MediaLocation = "/audio/uncensored/SterlingArcher/certainthickness.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 0, Name = "what else could go wrong?", MediaLocation = "/audio/uncensored/SterlingArcher/whatelsecouldgowrong.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 0, Name = "not passable", MediaLocation = "/audio/uncensored/SterlingArcher/notpassable.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 0, Name = "lying is 95%", MediaLocation = "/audio/uncensored/SterlingArcher/lyingis95%.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 0, Name = "cookie elves", MediaLocation = "/audio/uncensored/SterlingArcher/cookieelves.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 0, Name = "leave a message at the tone", MediaLocation = "/audio/uncensored/SterlingArcher/leaveamessage.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 0, Name = "funny word", MediaLocation = "/audio/uncensored/SterlingArcher/funnyword.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 0, Name = "how did i spend that much?", MediaLocation = "/audio/uncensored/SterlingArcher/thatmuchmoney.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 0, Name = "you sneeze glitter", MediaLocation = "/audio/uncensored/SterlingArcher/sneezeglitter.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 0, Name = "a ruse", MediaLocation = "/audio/uncensored/SterlingArcher/aRuse.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 0, Name = "best grandma ever", MediaLocation = "/audio/uncensored/SterlingArcher/bestGrandmaEver.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 0, Name = "bloody mary prayer", MediaLocation = "/audio/uncensored/SterlingArcher/BloodyMaryPrayer.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 0, Name = "thanks a lot, sundance", MediaLocation = "/audio/uncensored/SterlingArcher/Bitch_Sundance.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 0, Name = "taking candy from a baby", MediaLocation = "/audio/uncensored/SterlingArcher/candyhatingbaby.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 0, Name = "cosplay enthusiasts", MediaLocation = "/audio/uncensored/SterlingArcher/Cosplay_Enthusiasts.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 0, Name = "danger zone", MediaLocation = "/audio/uncensored/SterlingArcher/dangerZone.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 0, Name = "dead prime minister", MediaLocation = "/audio/uncensored/SterlingArcher/deadPrimeMinister.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 0, Name = "do not wind her up", MediaLocation = "/audio/uncensored/SterlingArcher/donotwindherup.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 0, Name = "thought i drank too much", MediaLocation = "/audio/uncensored/SterlingArcher/drankTooMuch.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 0, Name = "drinking arm", MediaLocation = "/audio/uncensored/SterlingArcher/drinkingArm.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 0, Name = "fingered", MediaLocation = "/audio/uncensored/SterlingArcher/fingeredEw.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 0, Name = "grieving process", MediaLocation = "/audio/uncensored/SterlingArcher/grievingProcess.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 0, Name = "gummi bears", MediaLocation = "/audio/uncensored/SterlingArcher/gummiBears.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 0, Name = "hogs of war", MediaLocation = "/audio/uncensored/SterlingArcher/hogsOfWar.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 0, Name = "how was that racist?", MediaLocation = "/audio/uncensored/SterlingArcher/howsThatRacist.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 0, Name = "just pout", MediaLocation = "/audio/uncensored/SterlingArcher/justpout.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 0, Name = "kenny loggins", MediaLocation = "/audio/uncensored/SterlingArcher/k_log.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 0, Name = "lana!", MediaLocation = "/audio/uncensored/SterlingArcher/lana.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 0, Name = "last words", MediaLocation = "/audio/uncensored/SterlingArcher/last_words.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 0, Name = "laughing at your name", MediaLocation = "/audio/uncensored/SterlingArcher/laughingAtName.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 0, Name = "lemon curd", MediaLocation = "/audio/uncensored/SterlingArcher/lemonCurd.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 0, Name = "life insurance", MediaLocation = "/audio/uncensored/SterlingArcher/life_insur.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 0, Name = "liquor and therapy", MediaLocation = "/audio/uncensored/SterlingArcher/liquorandtherapy.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 0, Name = "making you talk", MediaLocation = "/audio/uncensored/SterlingArcher/makingyoutalk.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 0, Name = "i really miss the zima", MediaLocation = "/audio/uncensored/SterlingArcher/missZima.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 0, Name = "mutiny of clowns", MediaLocation = "/audio/uncensored/SterlingArcher/mutinyOfClowns.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 0, Name = "now i'm done", MediaLocation = "/audio/uncensored/SterlingArcher/nowImDone.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 0, Name = "paging dr. birthday boy", MediaLocation = "/audio/uncensored/SterlingArcher/pagingDrBirthdayBoy.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 0, Name = "let's play some cards", MediaLocation = "/audio/uncensored/SterlingArcher/playCards.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 0, Name = "rich people problems", MediaLocation = "/audio/uncensored/SterlingArcher/richProblems.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 0, Name = "security is atrocious", MediaLocation = "/audio/uncensored/SterlingArcher/security_Atrocious.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 0, Name = "spite me", MediaLocation = "/audio/uncensored/SterlingArcher/Spite_Me.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 0, Name = "you two owe me an apology", MediaLocation = "/audio/uncensored/SterlingArcher/u2oweApology.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 0, Name = "you're so ugly when you cry", MediaLocation = "/audio/uncensored/SterlingArcher/Ugly_Cry.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 0, Name = "used to pretend", MediaLocation = "/audio/uncensored/SterlingArcher/Used_To_Pretend.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 0, Name = "picturing whore island", MediaLocation = "/audio/uncensored/SterlingArcher/whore_island.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 0, Name = "misreading the situation?", MediaLocation = "/audio/uncensored/SterlingArcher/zentai.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 1, Name = "you don't want to be here", MediaLocation = "/audio/uncensored/LanaKane/bang_dudes.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 1, Name = "personal affairs", MediaLocation = "/audio/uncensored/LanaKane/personalaffairs.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 1, Name = "that is so classic her", MediaLocation = "/audio/uncensored/LanaKane/classic_her.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 1, Name = "don't speak to me. ever.", MediaLocation = "/audio/uncensored/LanaKane/dont_speak.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 1, Name = "get out", MediaLocation = "/audio/uncensored/LanaKane/get_out.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 1, Name = "get the porno", MediaLocation = "/audio/uncensored/LanaKane/get_the_porno.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 1, Name = "go already!", MediaLocation = "/audio/uncensored/LanaKane/goAlready.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 1, Name = "hit me", MediaLocation = "/audio/uncensored/LanaKane/hitMe.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 1, Name = "i'll just be here", MediaLocation = "/audio/uncensored/LanaKane/ill_be_here.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 1, Name = "is that what you want?", MediaLocation = "/audio/uncensored/LanaKane/is_that_what.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 1, Name = "chainsmoking joints", MediaLocation = "/audio/uncensored/LanaKane/jointsTampons.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 1, Name = "he just gets a pass?", MediaLocation = "/audio/uncensored/LanaKane/milton_berle.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 1, Name = "nope!", MediaLocation = "/audio/uncensored/LanaKane/nope.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 1, Name = "everybody strap in", MediaLocation = "/audio/uncensored/LanaKane/strapInstrapOn.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 2, Name = "that's how you get ants!", MediaLocation = "/audio/uncensored/MaloryArcher/ants.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 2, Name = "crack whore red", MediaLocation = "/audio/uncensored/MaloryArcher/crack_whore_red.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 2, Name = "dumb as you are stupid", MediaLocation = "/audio/uncensored/MaloryArcher/dumbStupid.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 2, Name = "for the record", MediaLocation = "/audio/uncensored/MaloryArcher/forTheRecord.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 2, Name = "people in hell want ice water", MediaLocation = "/audio/uncensored/MaloryArcher/icewater.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 2, Name = "name a noun", MediaLocation = "/audio/uncensored/MaloryArcher/nameAnoun.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 2, Name = "name a place", MediaLocation = "/audio/uncensored/MaloryArcher/nameAplace.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 2, Name = "open my own salad", MediaLocation = "/audio/uncensored/MaloryArcher/Open_Salad.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 2, Name = "pez dispenser", MediaLocation = "/audio/uncensored/MaloryArcher/Pez_Dispenser.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 2, Name = "same entitled crap", MediaLocation = "/audio/uncensored/MaloryArcher/same_entitled_crap.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 2, Name = "there's a niche", MediaLocation = "/audio/uncensored/MaloryArcher/theresAniche.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 2, Name = "trying to parent", MediaLocation = "/audio/uncensored/MaloryArcher/trying2parent.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 2, Name = "whore island", MediaLocation = "/audio/uncensored/MaloryArcher/Whore_Island.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 2, Name = "whorediot", MediaLocation = "/audio/uncensored/MaloryArcher/whorediot.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 2, Name = "well then shup up!", MediaLocation = "/audio/uncensored/MaloryArcher/wordsFailedMe.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 2, Name = "rhetorical question", MediaLocation = "/audio/uncensored/MaloryArcher/rhetorical.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 2, Name = "drink all day", MediaLocation = "/audio/uncensored/MaloryArcher/drinkallday.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 3, Name = "complicated to explain", MediaLocation = "/audio/uncensored/CyrilFiggis/hard2explain.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 3, Name = "bulletin board", MediaLocation = "/audio/uncensored/CyrilFiggis/bulletinboard.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 3, Name = "she's kinda weird that way", MediaLocation = "/audio/uncensored/CyrilFiggis/weirdthatway.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 3, Name = "what am i going to tell her?", MediaLocation = "/audio/uncensored/CyrilFiggis/whatamigoingtotellher.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 3, Name = "they are pretty big", MediaLocation = "/audio/uncensored/CyrilFiggis/prettybig.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 4, Name = "good pussy", MediaLocation = "/audio/uncensored/PamPoovey/GoodPussy.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 4, Name = "newsletters", MediaLocation = "/audio/uncensored/PamPoovey/Newsletters.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 4, Name = "cooch chili", MediaLocation = "/audio/uncensored/PamPoovey/coochChili.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 4, Name = "you geeks are bad ass!", MediaLocation = "/audio/uncensored/PamPoovey/geeksBadAss.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 4, Name = "space!", MediaLocation = "/audio/uncensored/PamPoovey/holyShitSpace.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 4, Name = "nice things", MediaLocation = "/audio/uncensored/PamPoovey/nice_things.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 4, Name = "no limit unicorn", MediaLocation = "/audio/uncensored/PamPoovey/noLimitUnicorn.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 4, Name = "snacks", MediaLocation = "/audio/uncensored/PamPoovey/snacks.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 4, Name = "internets", MediaLocation = "/audio/uncensored/PamPoovey/internets.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 4, Name = "inappropriate workplace topic", MediaLocation = "/audio/uncensored/PamPoovey/workplacetopic.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 4, Name = "i could get used to this", MediaLocation = "/audio/uncensored/PamPoovey/getusedtothis.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 5, Name = "duh", MediaLocation = "/audio/uncensored/CherylTunt/duhNoShit.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 5, Name = "i think i need help", MediaLocation = "/audio/uncensored/CherylTunt/needhelpNoShit.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 5, Name = "all you have to say", MediaLocation = "/audio/uncensored/CherylTunt/allyouhavetosay.mp3" });
            SoundBytes.Add(new SoundByte { CharacterID = 6, Name = "nice things!", MediaLocation = "/audio/uncensored/LenTrexler/nice_things.mp3" });

        }

        void SoundBox_MediaOpened(object sender, RoutedEventArgs e)
        {
            SoundBox.Play();
        }

        private void Panorama_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateMenu();
        }

        private void UpdateMenu()
        {
            ApplicationBar.MenuItems.Clear();

            int index = MainPanorama.SelectedIndex;
            if (index == -1) index = 0;

            var temp = from s in SoundBytes
                       where s.CharacterID == index
                       orderby s.Name
                       select s;

            foreach (SoundByte s in temp)
            {
                ApplicationBarMenuItem abmi = new ApplicationBarMenuItem { Text = s.Name };
                abmi.Click += abmi_Click;
                ApplicationBar.MenuItems.Add(abmi);
            }
        }

        void abmi_Click(object sender, EventArgs e)
        {
            ApplicationBarMenuItem abmi = sender as ApplicationBarMenuItem;

            var mediasource = (from s in SoundBytes
                              where s.Name == abmi.Text
                              select s).ToList();
            SoundByte sb = mediasource[0];
            SoundBox.Source = new Uri(sb.MediaLocation, UriKind.Relative);
        }

        private void Archer_DoubleTap(object sender, GestureEventArgs e)
        {
            InstructionBox.Visibility = Visibility.Collapsed;
            var sounds = (from s in SoundBytes where s.CharacterID == 0 select s).ToList();
            int i = sounds.Count();

            Random r = new Random();
            int random = r.Next(0, i - 1);
            SoundByte sb = sounds[random];
            SoundBox.Source = new Uri(sb.MediaLocation, UriKind.Relative);
        }

        private void Lana_DoubleTap(object sender, GestureEventArgs e)
        {
            InstructionBox.Visibility = Visibility.Collapsed;
            var sounds = (from s in SoundBytes where s.CharacterID == 1 select s).ToList();
            int i = sounds.Count();

            Random r = new Random();
            int random = r.Next(0, i - 1);
            SoundByte sb = sounds[random];
            SoundBox.Source = new Uri(sb.MediaLocation, UriKind.Relative);
        }

        private void Malory_DoubleTap(object sender, GestureEventArgs e)
        {
            InstructionBox.Visibility = Visibility.Collapsed;
            var sounds = (from s in SoundBytes where s.CharacterID == 2 select s).ToList();
            int i = sounds.Count();

            Random r = new Random();
            int random = r.Next(0, i - 1);
            SoundByte sb = sounds[random];
            SoundBox.Source = new Uri(sb.MediaLocation, UriKind.Relative);
        }

        private void Cyril_DoubleTap(object sender, GestureEventArgs e)
        {
            InstructionBox.Visibility = Visibility.Collapsed;
            var sounds = (from s in SoundBytes where s.CharacterID == 3 select s).ToList();
            int i = sounds.Count();

            Random r = new Random();
            int random = r.Next(0, i - 1);
            SoundByte sb = sounds[random];
            SoundBox.Source = new Uri(sb.MediaLocation, UriKind.Relative);
        }

        private void Pam_DoubleTap(object sender, GestureEventArgs e)
        {
            InstructionBox.Visibility = Visibility.Collapsed;
            var sounds = (from s in SoundBytes where s.CharacterID == 4 select s).ToList();
            int i = sounds.Count();

            Random r = new Random();
            int random = r.Next(0, i - 1);
            SoundByte sb = sounds[random];
            SoundBox.Source = new Uri(sb.MediaLocation, UriKind.Relative);
        }

        private void Cheryl_DoubleTap(object sender, GestureEventArgs e)
        {
            InstructionBox.Visibility = Visibility.Collapsed;
            var sounds = (from s in SoundBytes where s.CharacterID == 5 select s).ToList();
            int i = sounds.Count();

            Random r = new Random();
            int random = r.Next(0, i - 1);
            SoundByte sb = sounds[random];
            SoundBox.Source = new Uri(sb.MediaLocation, UriKind.Relative);
        }

        private void Len_DoubleTap(object sender, GestureEventArgs e)
        {
            InstructionBox.Visibility = Visibility.Collapsed;
            var sounds = (from s in SoundBytes where s.CharacterID == 6 select s).ToList();
            int i = sounds.Count();

            Random r = new Random();
            int random = r.Next(0, i - 1);
            SoundByte sb = sounds[random];
            SoundBox.Source = new Uri(sb.MediaLocation, UriKind.Relative);
        }
    }
}