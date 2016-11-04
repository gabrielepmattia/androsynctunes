using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using iTunesLib;

namespace AndroSyncTunes.Library {
    class Album : IComparable<Album> {
        public String Name { get; }
        public IList<IITTrack> Tracks { get; }
        public Album(String name) {
            this.Name = name;
            this.Tracks = new List<IITTrack>();
        }
        public void addTrack(IITTrack track) {
            if (!Tracks.Contains(track)) Tracks.Add(track);
        }

        public int CompareTo(Album other) {
            return this.Name.CompareTo(other.Name);
        }
    }
}
