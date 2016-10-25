using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AndroSyncTunes {
    class iLibrary {
        public IList<String> Albums { get; }
        public IList<String> Artists { get; }

        public iLibrary(List<String> albums, List<String> artists) {
            albums.Sort();
            artists.Sort();
            this.Albums = albums;
            this.Artists = artists;
        }
    }
}
