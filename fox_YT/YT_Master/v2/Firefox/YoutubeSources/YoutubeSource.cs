using System.Threading;
using YT_Master.v2.Interfaces;

namespace YT_Master.v2.Firefox.YoutubeSources
{
    public class YoutubeSource : YoutubeGeneralOperationsFirefoxBot, IYoutubeSource
    {
        public virtual void WatchVideo()
        {
            Navigate(Url);
            ClickConditionsAcceptation();
            ClickVideoPlay();                                       //added to be sure that video will be played
        }
        
        public virtual void StartFirefox()
        {
            StartBotFirefox();
        }

        public virtual void KillFirefox()
        {
            driver.Close();
            driver.Dispose();
        }
    }
}
