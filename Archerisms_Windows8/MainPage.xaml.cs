using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Archerisms_Windows8
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        List<Character> Characters = new List<Character>();
        
        public MainPage()
        {
            this.InitializeComponent();
        }


        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            LoadCharacters();
            SoundBox.MediaOpened += SoundBox_MediaOpened;
        }

        protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
        {
            SoundBox.MediaOpened -= SoundBox_MediaOpened;
        }

        void SoundBox_MediaOpened(object sender, RoutedEventArgs e)
        {
            SoundBox.Play();
        }

        private void LoadCharacters()
        {
            Character sterling = new Character{ Name="Sterling Archer", SortOrder = 1, HeadLocation = "images/SterlingArcher.png"};
            sterling.SoundBytes.Add(new SoundByte { Name = "what do you even do here?", MediaLocation = "/audio/uncensored/SterlingArcher/analyzeData.mp3" });
            sterling.SoundBytes.Add(new SoundByte { Name = "baby lsd", MediaLocation = "/audio/uncensored/SterlingArcher/babyLSD.mp3" });
            sterling.SoundBytes.Add(new SoundByte { Name = "you have a certain thickness", MediaLocation = "/audio/uncensored/SterlingArcher/certainthickness.mp3" });
            sterling.SoundBytes.Add(new SoundByte { Name = "what else could go wrong?", MediaLocation = "/audio/uncensored/SterlingArcher/whatelsecouldgowrong.mp3" });
            sterling.SoundBytes.Add(new SoundByte { Name = "not passable", MediaLocation = "/audio/uncensored/SterlingArcher/notpassable.mp3" });
            sterling.SoundBytes.Add(new SoundByte { Name = "lying is 95%", MediaLocation = "/audio/uncensored/SterlingArcher/lyingis95.mp3" });
            sterling.SoundBytes.Add(new SoundByte { Name = "cookie elves", MediaLocation = "/audio/uncensored/SterlingArcher/cookieelves.mp3" });
            sterling.SoundBytes.Add(new SoundByte { Name = "leave a message at the tone", MediaLocation = "/audio/uncensored/SterlingArcher/leaveamessage.mp3" });
            sterling.SoundBytes.Add(new SoundByte { Name = "funny word", MediaLocation = "/audio/uncensored/SterlingArcher/funnyword.mp3" });
            sterling.SoundBytes.Add(new SoundByte { Name = "how did i spend that much?", MediaLocation = "/audio/uncensored/SterlingArcher/thatmuchmoney.mp3" });
            sterling.SoundBytes.Add(new SoundByte { Name = "you sneeze glitter", MediaLocation = "/audio/uncensored/SterlingArcher/sneezeglitter.mp3" });
            sterling.SoundBytes.Add(new SoundByte { Name = "a ruse", MediaLocation = "/audio/uncensored/SterlingArcher/aRuse.mp3" });
            sterling.SoundBytes.Add(new SoundByte { Name = "best grandma ever", MediaLocation = "/audio/uncensored/SterlingArcher/bestGrandmaEver.mp3" });
            sterling.SoundBytes.Add(new SoundByte { Name = "bloody mary prayer", MediaLocation = "/audio/uncensored/SterlingArcher/BloodyMaryPrayer.mp3" });
            sterling.SoundBytes.Add(new SoundByte { Name = "thanks a lot, sundance", MediaLocation = "/audio/uncensored/SterlingArcher/Bitch_Sundance.mp3" });
            sterling.SoundBytes.Add(new SoundByte { Name = "taking candy from a baby", MediaLocation = "/audio/uncensored/SterlingArcher/candyhatingbaby.mp3" });
            sterling.SoundBytes.Add(new SoundByte { Name = "cosplay enthusiasts", MediaLocation = "/audio/uncensored/SterlingArcher/Cosplay_Enthusiasts.mp3" });
            sterling.SoundBytes.Add(new SoundByte { Name = "danger zone", MediaLocation = "/audio/uncensored/SterlingArcher/dangerZone.mp3" });
            sterling.SoundBytes.Add(new SoundByte { Name = "dead prime minister", MediaLocation = "/audio/uncensored/SterlingArcher/deadPrimeMinister.mp3" });
            sterling.SoundBytes.Add(new SoundByte { Name = "do not wind her up", MediaLocation = "/audio/uncensored/SterlingArcher/donotwindherup.mp3" });
            sterling.SoundBytes.Add(new SoundByte { Name = "thought i drank too much", MediaLocation = "/audio/uncensored/SterlingArcher/drankTooMuch.mp3" });
            sterling.SoundBytes.Add(new SoundByte { Name = "drinking arm", MediaLocation = "/audio/uncensored/SterlingArcher/drinkingArm.mp3" });
            sterling.SoundBytes.Add(new SoundByte { Name = "fingered", MediaLocation = "/audio/uncensored/SterlingArcher/fingeredEw.mp3" });
            sterling.SoundBytes.Add(new SoundByte { Name = "grieving process", MediaLocation = "/audio/uncensored/SterlingArcher/grievingProcess.mp3" });
            sterling.SoundBytes.Add(new SoundByte { Name = "gummi bears", MediaLocation = "/audio/uncensored/SterlingArcher/gummiBears.mp3" });
            sterling.SoundBytes.Add(new SoundByte { Name = "hogs of war", MediaLocation = "/audio/uncensored/SterlingArcher/hogsOfWar.mp3" });
            sterling.SoundBytes.Add(new SoundByte { Name = "how was that racist?", MediaLocation = "/audio/uncensored/SterlingArcher/howsThatRacist.mp3" });
            sterling.SoundBytes.Add(new SoundByte { Name = "just pout", MediaLocation = "/audio/uncensored/SterlingArcher/justpout.mp3" });
            sterling.SoundBytes.Add(new SoundByte { Name = "kenny loggins", MediaLocation = "/audio/uncensored/SterlingArcher/k_log.mp3" });
            sterling.SoundBytes.Add(new SoundByte { Name = "lana!", MediaLocation = "/audio/uncensored/SterlingArcher/lana.mp3" });
            sterling.SoundBytes.Add(new SoundByte { Name = "last words", MediaLocation = "/audio/uncensored/SterlingArcher/last_words.mp3" });
            sterling.SoundBytes.Add(new SoundByte { Name = "laughing at your name", MediaLocation = "/audio/uncensored/SterlingArcher/laughingAtName.mp3" });
            sterling.SoundBytes.Add(new SoundByte { Name = "lemon curd", MediaLocation = "/audio/uncensored/SterlingArcher/lemonCurd.mp3" });
            sterling.SoundBytes.Add(new SoundByte { Name = "life insurance", MediaLocation = "/audio/uncensored/SterlingArcher/life_insur.mp3" });
            sterling.SoundBytes.Add(new SoundByte { Name = "liquor and therapy", MediaLocation = "/audio/uncensored/SterlingArcher/liquorandtherapy.mp3" });
            sterling.SoundBytes.Add(new SoundByte { Name = "making you talk", MediaLocation = "/audio/uncensored/SterlingArcher/makingyoutalk.mp3" });
            sterling.SoundBytes.Add(new SoundByte { Name = "i really miss the zima", MediaLocation = "/audio/uncensored/SterlingArcher/missZima.mp3" });
            sterling.SoundBytes.Add(new SoundByte { Name = "mutiny of clowns", MediaLocation = "/audio/uncensored/SterlingArcher/mutinyOfClowns.mp3" });
            sterling.SoundBytes.Add(new SoundByte { Name = "now i'm done", MediaLocation = "/audio/uncensored/SterlingArcher/nowImDone.mp3" });
            sterling.SoundBytes.Add(new SoundByte { Name = "paging dr. birthday boy", MediaLocation = "/audio/uncensored/SterlingArcher/pagingDrBirthdayBoy.mp3" });
            sterling.SoundBytes.Add(new SoundByte { Name = "let's play some cards", MediaLocation = "/audio/uncensored/SterlingArcher/playCards.mp3" });
            sterling.SoundBytes.Add(new SoundByte { Name = "rich people problems", MediaLocation = "/audio/uncensored/SterlingArcher/richProblems.mp3" });
            sterling.SoundBytes.Add(new SoundByte { Name = "security is atrocious", MediaLocation = "/audio/uncensored/SterlingArcher/security_Atrocious.mp3" });
            sterling.SoundBytes.Add(new SoundByte { Name = "spite me", MediaLocation = "/audio/uncensored/SterlingArcher/Spite_Me.mp3" });
            sterling.SoundBytes.Add(new SoundByte { Name = "you two owe me an apology", MediaLocation = "/audio/uncensored/SterlingArcher/u2oweApology.mp3" });
            sterling.SoundBytes.Add(new SoundByte { Name = "you're so ugly when you cry", MediaLocation = "/audio/uncensored/SterlingArcher/Ugly_Cry.mp3" });
            sterling.SoundBytes.Add(new SoundByte { Name = "used to pretend", MediaLocation = "/audio/uncensored/SterlingArcher/Used_To_Pretend.mp3" });
            sterling.SoundBytes.Add(new SoundByte { Name = "picturing whore island", MediaLocation = "/audio/uncensored/SterlingArcher/whore_island.mp3" });
            sterling.SoundBytes.Add(new SoundByte { Name = "misreading the situation?", MediaLocation = "/audio/uncensored/SterlingArcher/zentai.mp3" });
            Characters.Add(sterling);

            Character lana = new Character { Name = "Lana Kane", SortOrder = 2, HeadLocation = "images/LanaKane.png" };
            lana.SoundBytes.Add(new SoundByte { Name = "you don't want to be here", MediaLocation = "/audio/uncensored/LanaKane/bang_dudes.mp3" });
            lana.SoundBytes.Add(new SoundByte { Name = "personal affairs", MediaLocation = "/audio/uncensored/LanaKane/personalaffairs.mp3" });
            lana.SoundBytes.Add(new SoundByte { Name = "that is so classic her", MediaLocation = "/audio/uncensored/LanaKane/classic_her.mp3" });
            lana.SoundBytes.Add(new SoundByte { Name = "don't speak to me. ever.", MediaLocation = "/audio/uncensored/LanaKane/dont_speak.mp3" });
            lana.SoundBytes.Add(new SoundByte { Name = "get out", MediaLocation = "/audio/uncensored/LanaKane/get_out.mp3" });
            lana.SoundBytes.Add(new SoundByte { Name = "get the porno", MediaLocation = "/audio/uncensored/LanaKane/get_the_porno.mp3" });
            lana.SoundBytes.Add(new SoundByte { Name = "go already!", MediaLocation = "/audio/uncensored/LanaKane/goAlready.mp3" });
            lana.SoundBytes.Add(new SoundByte { Name = "hit me", MediaLocation = "/audio/uncensored/LanaKane/hitMe.mp3" });
            lana.SoundBytes.Add(new SoundByte { Name = "i'll just be here", MediaLocation = "/audio/uncensored/LanaKane/ill_be_here.mp3" });
            lana.SoundBytes.Add(new SoundByte { Name = "is that what you want?", MediaLocation = "/audio/uncensored/LanaKane/is_that_what.mp3" });
            lana.SoundBytes.Add(new SoundByte { Name = "chainsmoking joints", MediaLocation = "/audio/uncensored/LanaKane/jointsTampons.mp3" });
            lana.SoundBytes.Add(new SoundByte { Name = "he just gets a pass?", MediaLocation = "/audio/uncensored/LanaKane/milton_berle.mp3" });
            lana.SoundBytes.Add(new SoundByte { Name = "nope!", MediaLocation = "/audio/uncensored/LanaKane/nope.mp3" });
            lana.SoundBytes.Add(new SoundByte { Name = "everybody strap in", MediaLocation = "/audio/uncensored/LanaKane/strapInstrapOn.mp3" });
            Characters.Add(lana);

            Character malory = new Character { Name = "Malory Archer", SortOrder = 3, HeadLocation = "images/MaloryArcher.png" };
            malory.SoundBytes.Add(new SoundByte { Name = "that's how you get ants!", MediaLocation = "/audio/uncensored/MaloryArcher/ants.mp3" });
            malory.SoundBytes.Add(new SoundByte { Name = "crack whore red", MediaLocation = "/audio/uncensored/MaloryArcher/crack_whore_red.mp3" });
            malory.SoundBytes.Add(new SoundByte { Name = "dumb as you are stupid", MediaLocation = "/audio/uncensored/MaloryArcher/dumbStupid.mp3" });
            malory.SoundBytes.Add(new SoundByte { Name = "for the record", MediaLocation = "/audio/uncensored/MaloryArcher/forTheRecord.mp3" });
            malory.SoundBytes.Add(new SoundByte { Name = "people in hell want ice water", MediaLocation = "/audio/uncensored/MaloryArcher/icewater.mp3" });
            malory.SoundBytes.Add(new SoundByte { Name = "name a noun", MediaLocation = "/audio/uncensored/MaloryArcher/nameAnoun.mp3" });
            malory.SoundBytes.Add(new SoundByte { Name = "name a place", MediaLocation = "/audio/uncensored/MaloryArcher/nameAplace.mp3" });
            malory.SoundBytes.Add(new SoundByte { Name = "open my own salad", MediaLocation = "/audio/uncensored/MaloryArcher/Open_Salad.mp3" });
            malory.SoundBytes.Add(new SoundByte { Name = "pez dispenser", MediaLocation = "/audio/uncensored/MaloryArcher/Pez_Dispenser.mp3" });
            malory.SoundBytes.Add(new SoundByte { Name = "same entitled crap", MediaLocation = "/audio/uncensored/MaloryArcher/same_entitled_crap.mp3" });
            malory.SoundBytes.Add(new SoundByte { Name = "there's a niche", MediaLocation = "/audio/uncensored/MaloryArcher/theresAniche.mp3" });
            malory.SoundBytes.Add(new SoundByte { Name = "trying to parent", MediaLocation = "/audio/uncensored/MaloryArcher/trying2parent.mp3" });
            malory.SoundBytes.Add(new SoundByte { Name = "whore island", MediaLocation = "/audio/uncensored/MaloryArcher/Whore_Island.mp3" });
            malory.SoundBytes.Add(new SoundByte { Name = "whorediot", MediaLocation = "/audio/uncensored/MaloryArcher/whorediot.mp3" });
            malory.SoundBytes.Add(new SoundByte { Name = "well then shup up!", MediaLocation = "/audio/uncensored/MaloryArcher/wordsFailedMe.mp3" });
            malory.SoundBytes.Add(new SoundByte { Name = "rhetorical question", MediaLocation = "/audio/uncensored/MaloryArcher/rhetorical.mp3" });
            malory.SoundBytes.Add(new SoundByte { Name = "drink all day", MediaLocation = "/audio/uncensored/MaloryArcher/drinkallday.mp3" });
            Characters.Add(malory);

            Character cyril = new Character { Name = "Cyril Figgis", SortOrder = 4, HeadLocation = "images/CyrilFiggis.png" };
            cyril.SoundBytes.Add(new SoundByte { Name = "complicated to explain", MediaLocation = "/audio/uncensored/CyrilFiggis/hard2explain.mp3" });
            cyril.SoundBytes.Add(new SoundByte { Name = "bulletin board", MediaLocation = "/audio/uncensored/CyrilFiggis/bulletinboard.mp3" });
            cyril.SoundBytes.Add(new SoundByte { Name = "she's kinda weird that way", MediaLocation = "/audio/uncensored/CyrilFiggis/weirdthatway.mp3" });
            cyril.SoundBytes.Add(new SoundByte { Name = "what am i going to tell her?", MediaLocation = "/audio/uncensored/CyrilFiggis/whatamigoingtotellher.mp3" });
            cyril.SoundBytes.Add(new SoundByte { Name = "they are pretty big", MediaLocation = "/audio/uncensored/CyrilFiggis/prettybig.mp3" });
            Characters.Add(cyril);

            Character pam = new Character { Name = "Pam Poovey", SortOrder = 5, HeadLocation = "images/PamPoovey.png" };
            pam.SoundBytes.Add(new SoundByte { Name = "good pussy", MediaLocation = "/audio/uncensored/PamPoovey/GoodPussy.mp3" });
            pam.SoundBytes.Add(new SoundByte { Name = "newsletters", MediaLocation = "/audio/uncensored/PamPoovey/Newsletters.mp3" });
            pam.SoundBytes.Add(new SoundByte { Name = "cooch chili", MediaLocation = "/audio/uncensored/PamPoovey/coochChili.mp3" });
            pam.SoundBytes.Add(new SoundByte { Name = "you geeks are bad ass!", MediaLocation = "/audio/uncensored/PamPoovey/geeksBadAss.mp3" });
            pam.SoundBytes.Add(new SoundByte { Name = "space!", MediaLocation = "/audio/uncensored/PamPoovey/holyShitSpace.mp3" });
            pam.SoundBytes.Add(new SoundByte { Name = "nice things", MediaLocation = "/audio/uncensored/PamPoovey/nice_things.mp3" });
            pam.SoundBytes.Add(new SoundByte { Name = "no limit unicorn", MediaLocation = "/audio/uncensored/PamPoovey/noLimitUnicorn.mp3" });
            pam.SoundBytes.Add(new SoundByte { Name = "snacks", MediaLocation = "/audio/uncensored/PamPoovey/snacks.mp3" });
            pam.SoundBytes.Add(new SoundByte { Name = "internets", MediaLocation = "/audio/uncensored/PamPoovey/internets.mp3" });
            pam.SoundBytes.Add(new SoundByte { Name = "inappropriate workplace topic", MediaLocation = "/audio/uncensored/PamPoovey/workplacetopic.mp3" });
            pam.SoundBytes.Add(new SoundByte { Name = "i could get used to this", MediaLocation = "/audio/uncensored/PamPoovey/getusedtothis.mp3" });
            Characters.Add(pam);

            Character cheryl = new Character { Name = "Cheryl Tunt", SortOrder = 6, HeadLocation = "images/CherylTunt.png" };
            cheryl.SoundBytes.Add(new SoundByte { Name = "duh", MediaLocation = "/audio/uncensored/CherylTunt/duhNoShit.mp3" });
            cheryl.SoundBytes.Add(new SoundByte { Name = "i think i need help", MediaLocation = "/audio/uncensored/CherylTunt/needhelpNoShit.mp3" });
            cheryl.SoundBytes.Add(new SoundByte { Name = "all you have to say", MediaLocation = "/audio/uncensored/CherylTunt/allyouhavetosay.mp3" });
            Characters.Add(cheryl);

            Character len = new Character { Name = "Len Trexler", SortOrder = 7, HeadLocation = "images/LenTrexler.png" };
            len.SoundBytes.Add(new SoundByte { Name = "nice things!", MediaLocation = "/audio/uncensored/LenTrexler/nice_things.mp3" });
            Characters.Add(len);

            CharacterFlip.ItemsSource = from c in Characters
                                        orderby c.SortOrder ascending
                                        select c;
        }

        private void TextBlock_Tapped(object sender, TappedRoutedEventArgs e)
        {
            TextBlock tb = sender as TextBlock;
            SoundByte sb = tb.DataContext as SoundByte;
            SoundBox.Source = new Uri("ms-appx:" + sb.MediaLocation, UriKind.Absolute);
        }
    }
}
