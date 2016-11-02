using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

using iTunesLib;

namespace AndroSyncTunes.Library {
    /// <summary>
    /// This class is an abstraction of the iTunes Library that includes also Artists and Albums
    /// </summary>
    class MusicLibrary {
        public IList<String> Albums { get; }
        public IList<String> Artists { get; }
        //public Dictionary<String, IITPlaylist> Playlists { get; }
        public IList<KeyValuePair<String, IITPlaylist>> Playlists { get; }

        public MusicLibrary(List<String> albums, List<String> artists, IITPlaylistCollection playlists) {
            albums.Sort();
            artists.Sort();
            this.Albums = albums;
            this.Artists = artists;
            this.Playlists = new List<KeyValuePair<String, IITPlaylist>>();
            foreach (IITPlaylist playlist in playlists) {
                Playlists.Add(new KeyValuePair<String, IITPlaylist>(playlist.Name, playlist));
            }
            //TODO sort the playlist array
        }
    }
}
