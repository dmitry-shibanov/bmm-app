﻿using BMM.Api.Implementation.Models;
using BMM.Core.ViewModels;
using MvvmCross.DroidX.RecyclerView.ItemTemplates;

namespace BMM.UI.Droid.Application.TemplateSelectors
{
    public static class ViewTypes
    {
        public const int Track = 0;
        public const int Contributor = 2;
        public const int TrackCollection = 3;
        public const int TrackList = 4;
        public const int NullObject = 5;
        public const int Unknown = 6;
        public const int PinnedItem = 7;
        public const int Header = 10;
        public const int LiveRadio = 11;
        public const int FraKaareTeaser = 12;
        public const int AslaksenTeaser = 13;
        public const int ChapterHeader = 14;
        public const int DiscoverSectionHeader = 15;
        public const int Streak = 16;
        public const int SharedTrackCollectionHeader = 17;
        public const int PlaylistsCollection = 18;
        public const int InfoMessage = 19;
        public const int SimpleMargin = 20;
        public const int ContinueListeningCollection = 21;
    }

    public class DocumentTemplateSelector : MvxTemplateSelector<CellWrapperViewModel<Document>>
    {
        public override int GetItemLayoutId(int fromViewType)
        {
            switch (fromViewType)
            {
                case ViewTypes.Track:
                    return Resource.Layout.listitem_track;

                case ViewTypes.Contributor:
                    return Resource.Layout.listitem_contributor;

                case ViewTypes.TrackCollection:
                    return Resource.Layout.listitem_trackcollection;

                case ViewTypes.PinnedItem:
                    return Resource.Layout.listitem_pinned_item;

                case ViewTypes.TrackList:
                    return Resource.Layout.listitem_featured_playlist;

                case ViewTypes.DiscoverSectionHeader:
                    return Resource.Layout.listitem_discover_section_header;

                case ViewTypes.Streak:
                    return Resource.Layout.listitem_streak;

                case ViewTypes.NullObject:
                    return Resource.Layout.listitem_isfullyloaded;

                case ViewTypes.ChapterHeader:
                    return Resource.Layout.listitem_chapter_header;

                case ViewTypes.PlaylistsCollection:
                    return Resource.Layout.listitem_covers_carousel_collection;

                case ViewTypes.InfoMessage:
                    return Resource.Layout.listitem_info_message;
                
                case ViewTypes.SimpleMargin:
                    return Resource.Layout.listitem_simple_margin;
                
                case ViewTypes.ContinueListeningCollection:
                    return Resource.Layout.listitem_continue_listening_collection;
                
                default:
                    return Resource.Layout.listitem_track;
            }
        }

        protected override int SelectItemViewType(CellWrapperViewModel<Document> forItemObject)
        {
            if (forItemObject?.Item == null)
            {
                return ViewTypes.NullObject;
            }

            switch (forItemObject.Item.DocumentType)
            {
                case DocumentType.Track:
                    return ViewTypes.Track;

                case DocumentType.Contributor:
                    return ViewTypes.Contributor;

                case DocumentType.TrackCollection:
                    return ViewTypes.TrackCollection;

                case DocumentType.PinnedItem:
                    return ViewTypes.PinnedItem;

                case DocumentType.Album:
                case DocumentType.Playlist:
                case DocumentType.Podcast:
                    return ViewTypes.TrackList;

                case DocumentType.ChapterHeader:
                    return ViewTypes.ChapterHeader;

                case DocumentType.DiscoverSectionHeader:
                    return ViewTypes.DiscoverSectionHeader;

                case DocumentType.ListeningStreak:
                    return ViewTypes.Streak;

                case DocumentType.PlaylistsCollection:
                    return ViewTypes.PlaylistsCollection;

                case DocumentType.InfoMessage:
                    return ViewTypes.InfoMessage;
                
                case DocumentType.LiveRadio:
                    return ViewTypes.LiveRadio;
                
                case DocumentType.AslaksenTeaser:
                    return ViewTypes.AslaksenTeaser;
                
                case DocumentType.FraKaareTeaser:
                    return ViewTypes.FraKaareTeaser;
                
                case DocumentType.SimpleMargin:
                    return ViewTypes.SimpleMargin;
                
                case DocumentType.ContinueListeningCollection:
                    return ViewTypes.ContinueListeningCollection;
                
                default:
                    return ViewTypes.Unknown;
            }
        }
    }
}

