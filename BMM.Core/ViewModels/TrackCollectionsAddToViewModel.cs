﻿using System;
using Acr.UserDialogs;
using BMM.Api.Implementation.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using BMM.Api.Framework;
using BMM.Api.Framework.Exceptions;
using BMM.Core.Implementations.FileStorage;
using BMM.Core.Implementations.TrackCollections;
using BMM.Core.Implementations.UI;
using BMM.Core.Implementations.TrackCollections.Exceptions;
using BMM.Core.ViewModels.Base;
using MvvmCross.ViewModels;

namespace BMM.Core.ViewModels
{
    public class TrackCollectionsAddToViewModel : ContentBaseViewModel, IMvxViewModel<TrackCollectionsAddToViewModel.Parameter>
    {
        private readonly ITrackCollectionManager _trackCollectionManager;
        private readonly IUserDialogs _userDialogs;
        private readonly IToastDisplayer _toastDisplayer;
        private int _documentId;
        private DocumentType _documentType;
        private readonly ILogger _logger;

        public TrackCollectionsAddToViewModel(IOfflineTrackCollectionStorage downloader, ITrackCollectionManager trackCollectionManager, IUserDialogs userDialogs,
            IToastDisplayer toastDisplayer, IStorageManager storageManager, ILogger logger)
            : base(downloader, storageManager)
        {
            _trackCollectionManager = trackCollectionManager;
            _userDialogs = userDialogs;
            _toastDisplayer = toastDisplayer;
            _logger = logger;
        }

        public void Prepare(Parameter document)
        {
            _documentId = document.DocumentId;
            _documentType = document.DocumentType;
        }

        protected override async Task DocumentAction(Document item, IList<Track> list)
        {
            var targetTrackCollection = (TrackCollection)item;
            try
            {
                await _trackCollectionManager.AddToTrackCollection(targetTrackCollection, _documentId, _documentType);
                await _toastDisplayer.Success(TextSource.GetText("TrackAddedToTrackCollection"));
            }
            catch (UnsupportedDocumentTypeException)
            {
                await _userDialogs.AlertAsync(TextSource.GetText("FailedToAddUnknownType", _documentType.ToString()));
            }
            catch (AlbumAlreadyInTrackCollectionException)
            {
                await _userDialogs.AlertAsync(TextSource.GetText("AlbumFailedToAddAlreadyExists", targetTrackCollection.Name));
            }
            catch (TrackAlreadyInTrackCollectionException)
            {
                await _userDialogs.AlertAsync(TextSource.GetText("TrackAlreadyExistInTrackCollection", targetTrackCollection.Name));
            }
            catch (BadRequestException ex)
            {
                await _userDialogs.AlertAsync(TextSource.GetText("FailedToAdd", targetTrackCollection.Name));
                _logger.Error("TrackOrAlbumAddedToTrackCollection", "Bad request", ex);
            }
            catch (Exception ex)
            {
                await _userDialogs.AlertAsync(GlobalTextSource.GetText("UnexpectedError"));
                _logger.Error("TrackOrAlbumAddedToTrackCollection", "Unexpected error", ex);
            }

            await _navigationService.Close(this);
        }

        public class Parameter
        {
            /// <summary>
            /// Id of the track or album
            /// </summary>
            public int DocumentId { get; set; }

            /// <summary>
            /// Should be either Track or Album
            /// </summary>
            public DocumentType DocumentType { get; set; }
        }
    }
}