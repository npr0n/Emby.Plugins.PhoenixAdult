using MediaBrowser.Controller.Entities.Movies;
using MediaBrowser.Controller.Providers;
using MediaBrowser.Model.Entities;

namespace Emby.Plugins.PhoenixAdult
{
    public class PhoenixAdultExternalId : IExternalId
    {
        public string Name => PhoenixAdultProvider.PluginName;

        public bool Supports(IHasProviderIds item)
            => item is Movie;

        public string Key
            => PhoenixAdultProvider.PluginName;

        public string UrlFormatString
            => null;
    }
}
