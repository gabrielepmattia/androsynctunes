using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using iTunesLib;

namespace AndroSyncTunes.Library {
    class NewMusicLibrary {
        public IList<Artist> Artists { get; }
        public IList<Album> Albums { get; }
        public IITTrackCollection Tracks { get; }
        public IList<IITPlaylist> Playlists { get; }

        public NewMusicLibrary() {
            iTunesApp o_itunes = new iTunesApp();
            this.Playlists = new List<IITPlaylist>();
            // We remove not-music playlist here
            for(int i = 13; i < o_itunes.LibrarySource.Playlists.Count; i++) {
                Playlists.Add(o_itunes.LibrarySource.Playlists[i]);
            }
            // We select only the Music playlist here
            this.Tracks = o_itunes.LibrarySource.Playlists.ItemByName["Music"].Tracks;
            this.Albums = new List<Album>();
            this.Artists = new List<Artist>();
            foreach (IITTrack track in Tracks) {
                // We skip not downloaded songs here
                if (track.Kind != ITTrackKind.ITTrackKindFile) continue;
                Artist artist = addArtist(track.Artist == null ? Resources.GlobalStrings.unknown : track.Artist);
                Album album = addAlbum(track.Album == null ? Resources.GlobalStrings.unknown : track.Album);
                artist.addAlbum(album);
                album.addTrack(track);
            }
        }

        private Artist addArtist(String name) {
            foreach (Artist artist in Artists) if (artist.Name == name) return artist;
            Artist new_artist = new Artist(name);
            Artists.Add(new_artist);
            return new_artist;
        }
        private Album addAlbum(String name) {
            foreach (Album album in Albums) if (album.Name == name) return album;
            Album new_album = new Album(name);
            Albums.Add(new_album);
            return new_album;
        }

        // Debugging
        public void logAlbums() {
            int i = 0;
            foreach (Album a in Albums) {
                Console.WriteLine("> Album#{0} :: {1}", i, a.Name);
                i++;
            }
        }

        public void logArtists() {
            int i = 0;
            foreach (Artist a in Artists) {
                Console.WriteLine("> Artists#{0} :: {1}", i, a.Name);
                i++;
            }
        }
    }
}
