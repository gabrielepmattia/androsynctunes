using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using iTunesLib;

namespace AndroSyncTunes.Library {
    class Artist : IComparable<Artist> {
        public String Name { get; }
        public IList<Album> Albums { get; }
        public Artist(String name) {
            this.Name = name;
            this.Albums = new List<Album>();
        }
        public Album addAlbum(String name) {
            foreach (Album album in Albums) if (album.Name == name) return album;
            Album new_album = new Album(name);
            Albums.Add(new_album);
            return new_album;
        }
        public void addAlbum(Album album) {
            if (!Albums.Contains(album)) Albums.Add(album);
        }

        public int CompareTo(Artist other) {
            return this.Name.CompareTo(other.Name);
        }
    }
}
