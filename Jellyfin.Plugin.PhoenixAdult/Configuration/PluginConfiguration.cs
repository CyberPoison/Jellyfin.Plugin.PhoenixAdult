using System;
using MediaBrowser.Model.Plugins;

namespace PhoenixAdult.Configuration
{
    public enum JAVActorNamingStyle
    {
        WesternStyle = 0,
        JapaneseStyle = 1,
    }

    public class PluginConfiguration : BasePluginConfiguration
    {
        public PluginConfiguration()
        {
            this.DatabaseUpdateURL = "https://api.github.com/repos/DirtyRacer1337/Jellyfin.Plugin.PhoenixAdult/contents/data";
            this.DatabaseHash = string.Empty;
            this.TokenStorage = string.Empty;

            this.UID = Guid.NewGuid().ToString();
            this.DisableAnalytics = false;

            this.DefaultSiteName = string.Empty;
            this.DisableActors = false;
            this.DisableImageValidation = false;
            this.DisableImageSize = false;

            this.JAVActorNamingStyle = JAVActorNamingStyle.WesternStyle;
        }

        public string DatabaseUpdateURL { get; set; }

        public string DatabaseHash { get; set; }

        public string TokenStorage { get; set; }

        public string UID { get; set; }

        public bool DisableAnalytics { get; set; }

        public string DefaultSiteName { get; set; }

        public bool DisableActors { get; set; }

        public bool DisableImageValidation { get; set; }

        public bool DisableImageSize { get; set; }

        public JAVActorNamingStyle JAVActorNamingStyle { get; set; }
    }
}
