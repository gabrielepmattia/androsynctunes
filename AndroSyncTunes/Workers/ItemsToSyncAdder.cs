using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using AndroSyncTunes.Library;
namespace AndroSyncTunes.Workers {

    class ItemsToSyncAdder : IWorker {
        public enum WorkKindType {
            addEntireLibrary, addAllTracksFromArtist, addAllTracksFromAlbum, addAllTracksFromPlaylist
        }

        private MusicLibrary MusicLibrary;
        private bool OnlyChecked;
        private WorkKindType WorkKind;
        private int Item;
        public event EventHandler AddingFinished;
        public ItemsToSyncAdder(MusicLibrary l, WorkKindType k, bool only_checked) {
            MusicLibrary = l;
            OnlyChecked = only_checked;
            WorkKind = k;
        }

        public ItemsToSyncAdder(MusicLibrary l, WorkKindType k, bool only_checked, int item) {
            MusicLibrary = l;
            OnlyChecked = only_checked;
            WorkKind = k;
            Item = item;
        }

        public void DoWork() {
            Console.WriteLine("==> Work Started");
            switch (WorkKind) {
                case WorkKindType.addEntireLibrary:
                    addEntireLibrary();
                    break;
                case WorkKindType.addAllTracksFromArtist:
                    addAllTracksFromArtist(Item);
                    break;
                case WorkKindType.addAllTracksFromAlbum:
                    addAllTracksFromAlbum(Item);
                    break;
                case WorkKindType.addAllTracksFromPlaylist:
                    addAllTracksFromPlaylist(Item);
                    break;
                default: throw new InvalidOperationException();
            }
        }

        public void addEntireLibrary() {
            MusicLibrary.addEntireLibraryToSync(OnlyChecked);
            OnRaiseAddingFinished(new EventArgs());
        }

        public void addAllTracksFromArtist(int artist_i) {
            MusicLibrary.addArtistToSync(artist_i, OnlyChecked);
            OnRaiseAddingFinished(new EventArgs());
        }

        public void addAllTracksFromAlbum(int album_i) {
            MusicLibrary.addAlbumToSync(album_i, OnlyChecked);
            OnRaiseAddingFinished(new EventArgs());
        }

        public void addAllTracksFromPlaylist(int playlist_i) {
            MusicLibrary.addEntireLibraryToSync(OnlyChecked);
            OnRaiseAddingFinished(new EventArgs());
        }
        public void removeAllTracksFromArtist(Artist a) {
            MusicLibrary.addEntireLibraryToSync(OnlyChecked);
        }

        public void removeAllTracksFromAlbum(Album a) {
            MusicLibrary.addEntireLibraryToSync(OnlyChecked);
        }

        // Wrap event invocations inside a protected virtual method
        // to allow derived classes to override the event invocation behavior
        protected virtual void OnRaiseAddingFinished(EventArgs e) {
            // Make a temporary copy of the event to avoid possibility of
            // a race condition if the last subscriber unsubscribes
            // immediately after the null check and before the event is raised.
            EventHandler handler = AddingFinished;

            // Event will be null if there are no subscribers
            if (handler != null) {
                // Format the string to send inside the CustomEventArgs parameter
                //e.Message += String.Format(" at {0}", DateTime.Now.ToString());

                // Use the () operator to raise the event.
                handler(this, e);
            }
        }
    }

}
