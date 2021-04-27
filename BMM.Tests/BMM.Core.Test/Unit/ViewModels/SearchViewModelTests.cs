﻿using System.Collections.Generic;
using System.ComponentModel;
using System.Reactive.Linq;
using System.Threading.Tasks;
using Akavache;
using BMM.Api.Implementation.Models;
using BMM.Core.Helpers;
using BMM.Core.Test.Unit.ViewModels.Base;
using BMM.Core.ViewModels;
using Moq;
using NUnit.Framework;

namespace BMM.Core.Test.Unit.ViewModels
{
    [TestFixture]
    public class SearchViewModelTests : DocumentViewModelTests
    {
        protected SearchViewModel ViewModel { get; set; }

        protected override void AdditionalSetup()
        {
            base.AdditionalSetup();

            ViewModel = new SearchViewModel();
        }

        [Test]
        public void Initialization()
        {
            Setup();

            Assert.IsNotNull(ViewModel.LoadMoreCommand);
            Assert.True(ViewModel.IsFullyLoaded);
            Assert.IsEmpty(ViewModel.Documents);
            Assert.That(ViewModel.SearchTerm, Is.Null.Or.Empty);
            Assert.IsNotNull(ViewModel.ShufflePlayCommand);

            Assert.IsEmpty(ViewModel.SearchSuggestions);
            Assert.IsEmpty(ViewModel.SearchHistory);
            Assert.False(ViewModel.ShowSuggestions);
            Assert.False(ViewModel.ShowHistory);
            Assert.True(ViewModel.NoResults);
            Assert.False(ViewModel.SearchExecuted);
            Assert.That(ViewModel.SearchTerm, Is.Null.Or.Empty);
            Assert.IsNotNull(ViewModel.SearchCommand);
            Assert.IsNotNull(ViewModel.SearchByTermCommand);
            Assert.IsNotNull(ViewModel.DeleteHistoryCommand);
        }

        [Test]
        public void Basic()
        {
            Setup();

            ViewModel.BlobCache = new InMemoryBlobCache();

            var propertyChangedEvents = new List<PropertyChangedEventArgs>();
            ViewModel.PropertyChanged += (sender, e) => propertyChangedEvents.Add(e);

            var task = ViewModel.Initialize();

            Assert.True(task.IsCompleted);

            Assert.IsNotNull(ViewModel.LoadMoreCommand);
            Assert.IsEmpty(ViewModel.Documents);
            Assert.That(ViewModel.SearchTerm, Is.Null.Or.Empty);
            Assert.IsNotNull(ViewModel.ShufflePlayCommand);

            Assert.IsEmpty(ViewModel.SearchSuggestions);
            Assert.IsEmpty(ViewModel.SearchHistory);
            Assert.False(ViewModel.ShowSuggestions);
            Assert.False(ViewModel.ShowHistory);
            Assert.True(ViewModel.NoResults);
            Assert.False(ViewModel.SearchExecuted);
            Assert.That(ViewModel.SearchTerm, Is.Null.Or.Empty);
            Assert.IsNotNull(ViewModel.SearchCommand);
            Assert.IsNotNull(ViewModel.SearchByTermCommand);
            Assert.IsNotNull(ViewModel.DeleteHistoryCommand);
        }

        [Test]
        public void PrefilledHistory()
        {
            Setup();

            ViewModel.BlobCache = new InMemoryBlobCache();

            ViewModel.BlobCache.InsertObject<List<string>>(StorageKeys.History, new List<string>{ "foo", "bar", "test" }).Wait();

            var propertyChangedEvents = new List<PropertyChangedEventArgs>();
            ViewModel.PropertyChanged += (sender, e) => propertyChangedEvents.Add(e);

            var task = ViewModel.Initialize();

            Assert.True(task.IsCompleted);

            Assert.IsNotNull(ViewModel.LoadMoreCommand);
            Assert.IsEmpty(ViewModel.Documents);
            Assert.That(ViewModel.SearchTerm, Is.Null.Or.Empty);
            Assert.IsNotNull(ViewModel.ShufflePlayCommand);

            Assert.IsEmpty(ViewModel.SearchSuggestions);
            Assert.AreEqual(3, ViewModel.SearchHistory.Count);
            Assert.False(ViewModel.ShowSuggestions);
            Assert.True(ViewModel.ShowHistory);
            Assert.True(ViewModel.NoResults);
            Assert.False(ViewModel.SearchExecuted);
            Assert.That(ViewModel.SearchTerm, Is.Null.Or.Empty);
            Assert.IsNotNull(ViewModel.SearchCommand);
            Assert.IsNotNull(ViewModel.SearchByTermCommand);
            Assert.IsNotNull(ViewModel.DeleteHistoryCommand);
        }

        [Test]
        public async Task LoadItems_ShouldHandleNullValueAndDisplayEmptyDocument()
        {
            // Arrange
            Setup();
            Client.Setup(x => x.Search.GetAll(It.IsAny<string>(), It.IsAny<int>(), It.IsAny<int>(), null,null,null,null,null,null,null))
                .Returns(Task.FromResult<IList<Document>>(null));
            var searchViewModel = new SearchViewModel()
            {
                SearchTerm = "test"
            };

            // Act
            await searchViewModel.LoadItems();

            // Assert
            Assert.IsEmpty(searchViewModel.Documents);
        }
    }
}