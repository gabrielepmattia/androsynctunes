using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using iTunesLib;

namespace AndroSyncTunes.Library {
    class MusicLibrary {
        public IList<Artist> Artists { get; }
        public IList<Album> Albums { get; }
        public IList<IITTrack> Tracks { get; }
        public IList<IITPlaylist> Playlists { get; }
        public IList<IITTrack> TracksToSync { get; private set; }
        public long TrackToSyncSize { get; private set; }

        public MusicLibrary() {
            iTunesApp o_itunes = new iTunesApp();
            this.Playlists = new List<IITPlaylist>();
            this.TracksToSync = new List<IITTrack>();
            // We remove not-music playlist here
            for (int i = 13; i < o_itunes.LibrarySource.Playlists.Count; i++) {
                Playlists.Add(o_itunes.LibrarySource.Playlists[i]);
            }
            // We select only the Music playlist here
            this.Tracks = new List<IITTrack>();
            this.Albums = new List<Album>();
            this.Artists = new List<Artist>();
            this.TrackToSyncSize = 0;
            foreach (IITTrack track in o_itunes.LibrarySource.Playlists.ItemByName["Music"].Tracks) {
                // We skip not downloaded songs here or missing song that could throw exception
                if (!(track is IITFileOrCDTrack) || ((IITFileOrCDTrack)track).Location == null || track.KindAsString == "iTunes LP") continue;
                Artist artist = addArtist(track.Artist == null ? Resources.GlobalStrings.unknown : track.Artist);
                Album album = addAlbum(track.Album == null ? Resources.GlobalStrings.unknown : track.Album);
                Tracks.Add(track);
                artist.addAlbum(album);
                album.addTrack(track);
            }
            ((List<Artist>)Artists).Sort();
            ((List<Album>)Albums).Sort();
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

        public void addTrackToSync(IITTrack track) {
            // We skip not downloaded songs here
            if (!(track is IITFileOrCDTrack)) return;
            if (!TracksToSync.Contains(track)) {
                this.TracksToSync.Add(track);
                TrackToSyncSize += new System.IO.FileInfo(((IITFileOrCDTrack)track).Location).Length;
            }
        }

        public void clearTracksToSync() {
            TracksToSync = null;
            TracksToSync = new List<IITTrack>();
            TrackToSyncSize = 0;
        }
        // Bulk methods
        public void addEntireLibraryToSync(bool only_checked) {
            clearTracksToSync();
            foreach (IITTrack track in Tracks) {
                // Check if only checked is checked
                if ((only_checked && track.Enabled) || !only_checked) addTrackToSync(track);
            }
        }

        // Debugging methods
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
