﻿namespace BMM.Core.Implementations.Analytics
{
    public class Event
    {
        public const string PlayTrack = "Playback started";
        public const string TrackFinished = "Track finished";
        public const string QueueCompleted = "Queue completed";
        public const string TrackHasBeenAddedToEndOfQueue = "Track has been added to the end of the queue";
        public const string TrackHasBeenAddedToBePlayedNext = "Track has been added to be played next";
        public const string MediaBrowserConnectionFailed = "Media browser connection failed";
        public const string MediaBrowserConnectionSuspended = "Media browser connection suspended";
        public const string OptionsMenuHasBeenOpened = "Options menu has been opened";
        public const string TrackHasBeenDownloaded = "Track has been downloaded";
        public const string TrackDownloadingException = "Exception during track downloading";
        public const string PlaylistNotFoundException = "Playlist not found exception";
        public const string ViewModelOpenedFormat = "{0} opened";
        public const string EmptyPlayer = "Empty player";
        public const string AlbumResumed = "Album resumed";
        public const string LyricsOpened = "Lyrics opened";
        public const string TrackLanguageChanged = "Track language changed";
        public const string BackgroundActivityRestrictedPopupShown = "Background Activity restricted popup shown";
        public const string SleepTimerOptionsOpened = "Sleep timer options menu opened";
        public const string SleepTimerOptionSelected = "Sleep timer option selected";
        public const string PlaybackSpeedOptionsOpened = "Playback speed options menu opened";
        public const string PlaybackSpeedChanged = "Playback speed changed";
        public const string SiriSearch = "Siri search";
        public const string SiriMusicPlayed = "Siri music played";
        public const string SiriFromKaarePlayed = "Siri From Kåre played";
        public const string SiriDifferentLanguage = "Different Siri language";
    }
}