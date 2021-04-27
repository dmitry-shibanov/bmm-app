﻿using NUnit.Framework;

namespace BMM.Api.Test.Unit
{
    [TestFixture]
    public class JsonPerformanceTests
    {
        [Test]
        public void PerformanceOfDeserializeIsAcceptable()
        {
            //// Arrange
            //var settings = new JsonSerializerSettings { ContractResolver = new UnderscoreMappingResolver() };
            //var trackCollectionStringFromBmmApi =
            //    "{\"id\":\"84017\",\"name\":\"ghost\",\"type\":\"track_collection\",\"access\":[\"ola.normann\"],\"tracks\":[{\"id\":100243,\"parent_id\":90940,\"is_visible\":true,\"comment\":null,\"order\":1,\"type\":\"track\",\"subtype\":\"song\",\"tags\":[\"ghost-stories\"],\"recorded_at\":\"2019-01-03T14:31:46+00:00\",\"published_at\":\"2019-01-04T20:11:08+00:00\",\"rel\":[{\"type\":\"interpret\",\"name\":\"Coldplay\",\"id\":91209}],\"_meta\":{\"root_parent_id\":90940,\"is_visible\":true,\"modified_at\":\"2019-01-07T13:44:02+00:00\",\"modified_by\":\"simoncostea\",\"title\":\"Always In My Head\",\"language\":\"eng\",\"album\":\"Ghost Stories\",\"tracknumber\":1,\"artist\":\"Coldplay\",\"lyricist\":\"\",\"composer\":\"\",\"publisher\":\"Brunstad Christian Church\",\"itunescompilation\":1,\"attached_picture\":null,\"time\":\"1431\",\"date\":\"0301\",\"year\":\"2019\",\"copyright\":\"Copyright \\u00a9 Stiftelsen Skjulte Skatters Forlag. All Rights Reserved.\",\"bible_references\":[],\"parent\":{\"id\":90940,\"parent_id\":null,\"type\":\"album\",\"bmm_id\":null,\"tags\":[],\"published_at\":\"2019-01-03T14:31:46+00:00\",\"_meta\":{\"is_visible\":true,\"modified_at\":\"2019-03-13T17:45:26+00:00\",\"modified_by\":\"d0c15e39-c315-4025-b9ab-33d51f721788\",\"contained_types\":[\"song\"]},\"cover\":null,\"languages\":[\"en\"],\"language\":\"en\",\"title\":\"Ghost Stories\"},\"root_parent\":{\"id\":90940,\"parent_id\":null,\"type\":\"album\",\"bmm_id\":null,\"tags\":[],\"published_at\":\"2019-01-03T14:31:46+00:00\",\"_meta\":{\"is_visible\":true,\"modified_at\":\"2019-03-13T17:45:26+00:00\",\"modified_by\":\"d0c15e39-c315-4025-b9ab-33d51f721788\",\"contained_types\":[\"song\"]},\"cover\":null,\"languages\":[\"en\"],\"language\":\"en\",\"title\":\"Ghost Stories\"}},\"cover\":null,\"languages\":[\"en\"],\"language\":\"en\",\"title\":\"Always In My Head\",\"publisher\":\"Brunstad Christian Church\",\"copyright\":\"Copyright \\u00a9 Stiftelsen Skjulte Skatters Forlag. All Rights Reserved.\",\"media\":[{\"type\":\"audio\",\"is_visible\":true,\"files\":[{\"mime_type\":\"audio\\/mpeg\",\"size\":8721617,\"duration\":217,\"url\":\"https:\\/\\/int-bmm-api.brunstad.org\\/file\\/protected\\/track\\/100243\\/track_100243_media_en.mp3?last-changed=1552499127\"}]}]},{\"id\":100244,\"parent_id\":90940,\"is_visible\":true,\"comment\":null,\"order\":2,\"type\":\"track\",\"subtype\":\"song\",\"tags\":[\"ghost-stories\"],\"recorded_at\":\"2019-01-03T14:31:46+00:00\",\"published_at\":\"2019-01-04T20:25:22+00:00\",\"rel\":[{\"type\":\"interpret\",\"name\":\"Coldplay\",\"id\":91209}],\"_meta\":{\"root_parent_id\":90940,\"is_visible\":true,\"modified_at\":\"2019-01-04T20:29:00+00:00\",\"modified_by\":\"towa\",\"title\":\"Magic\",\"language\":\"eng\",\"album\":\"Ghost Stories\",\"tracknumber\":2,\"artist\":\"Coldplay\",\"lyricist\":\"\",\"composer\":\"\",\"publisher\":\"Brunstad Christian Church\",\"itunescompilation\":1,\"attached_picture\":null,\"time\":\"1431\",\"date\":\"0301\",\"year\":\"2019\",\"copyright\":\"Copyright \\u00a9 Stiftelsen Skjulte Skatters Forlag. All Rights Reserved.\",\"bible_references\":[],\"parent\":{\"id\":90940,\"parent_id\":null,\"type\":\"album\",\"bmm_id\":null,\"tags\":[],\"published_at\":\"2019-01-03T14:31:46+00:00\",\"_meta\":{\"is_visible\":true,\"modified_at\":\"2019-03-13T17:45:26+00:00\",\"modified_by\":\"d0c15e39-c315-4025-b9ab-33d51f721788\",\"contained_types\":[\"song\"]},\"cover\":null,\"languages\":[\"en\"],\"language\":\"en\",\"title\":\"Ghost Stories\"},\"root_parent\":{\"id\":90940,\"parent_id\":null,\"type\":\"album\",\"bmm_id\":null,\"tags\":[],\"published_at\":\"2019-01-03T14:31:46+00:00\",\"_meta\":{\"is_visible\":true,\"modified_at\":\"2019-03-13T17:45:26+00:00\",\"modified_by\":\"d0c15e39-c315-4025-b9ab-33d51f721788\",\"contained_types\":[\"song\"]},\"cover\":null,\"languages\":[\"en\"],\"language\":\"en\",\"title\":\"Ghost Stories\"}},\"cover\":null,\"languages\":[\"en\"],\"language\":\"en\",\"title\":\"Magic\",\"publisher\":\"Brunstad Christian Church\",\"copyright\":\"Copyright \\u00a9 Stiftelsen Skjulte Skatters Forlag. All Rights Reserved.\",\"media\":[{\"type\":\"audio\",\"is_visible\":true,\"files\":[{\"mime_type\":\"audio\\/mpeg\",\"size\":11403362,\"duration\":286,\"url\":\"https:\\/\\/int-bmm-api.brunstad.org\\/file\\/protected\\/track\\/100244\\/track_100244_media_en.mp3?last-changed=1552499127\"}]}]},{\"id\":100245,\"parent_id\":90940,\"is_visible\":true,\"comment\":null,\"order\":3,\"type\":\"track\",\"subtype\":\"song\",\"tags\":[\"ghost-stories\"],\"recorded_at\":\"2019-01-03T14:31:46+00:00\",\"published_at\":\"2019-01-04T20:26:52+00:00\",\"rel\":[{\"type\":\"interpret\",\"name\":\"Coldplay\",\"id\":91209}],\"_meta\":{\"root_parent_id\":90940,\"is_visible\":true,\"modified_at\":\"2019-01-04T20:29:18+00:00\",\"modified_by\":\"towa\",\"title\":\"Ink\",\"language\":\"eng\",\"album\":\"Ghost Stories\",\"tracknumber\":3,\"artist\":\"Coldplay\",\"lyricist\":\"\",\"composer\":\"\",\"publisher\":\"Brunstad Christian Church\",\"itunescompilation\":1,\"attached_picture\":null,\"time\":\"1431\",\"date\":\"0301\",\"year\":\"2019\",\"copyright\":\"Copyright \\u00a9 Stiftelsen Skjulte Skatters Forlag. All Rights Reserved.\",\"bible_references\":[],\"parent\":{\"id\":90940,\"parent_id\":null,\"type\":\"album\",\"bmm_id\":null,\"tags\":[],\"published_at\":\"2019-01-03T14:31:46+00:00\",\"_meta\":{\"is_visible\":true,\"modified_at\":\"2019-03-13T17:45:26+00:00\",\"modified_by\":\"d0c15e39-c315-4025-b9ab-33d51f721788\",\"contained_types\":[\"song\"]},\"cover\":null,\"languages\":[\"en\"],\"language\":\"en\",\"title\":\"Ghost Stories\"},\"root_parent\":{\"id\":90940,\"parent_id\":null,\"type\":\"album\",\"bmm_id\":null,\"tags\":[],\"published_at\":\"2019-01-03T14:31:46+00:00\",\"_meta\":{\"is_visible\":true,\"modified_at\":\"2019-03-13T17:45:26+00:00\",\"modified_by\":\"d0c15e39-c315-4025-b9ab-33d51f721788\",\"contained_types\":[\"song\"]},\"cover\":null,\"languages\":[\"en\"],\"language\":\"en\",\"title\":\"Ghost Stories\"}},\"cover\":null,\"languages\":[\"en\"],\"language\":\"en\",\"title\":\"Ink\",\"publisher\":\"Brunstad Christian Church\",\"copyright\":\"Copyright \\u00a9 Stiftelsen Skjulte Skatters Forlag. All Rights Reserved.\",\"media\":[{\"type\":\"audio\",\"is_visible\":true,\"files\":[{\"mime_type\":\"audio\\/mpeg\",\"size\":9138021,\"duration\":229,\"url\":\"https:\\/\\/int-bmm-api.brunstad.org\\/file\\/protected\\/track\\/100245\\/track_100245_media_en.mp3?last-changed=1552499127\"}]}]},{\"id\":100246,\"parent_id\":90940,\"is_visible\":true,\"comment\":null,\"order\":4,\"type\":\"track\",\"subtype\":\"song\",\"tags\":[\"ghost-stories\"],\"recorded_at\":\"2019-01-03T14:31:46+00:00\",\"published_at\":\"2019-01-04T20:30:32+00:00\",\"rel\":[{\"type\":\"interpret\",\"name\":\"Coldplay\",\"id\":91209}],\"_meta\":{\"root_parent_id\":90940,\"is_visible\":true,\"modified_at\":\"2019-01-04T20:32:20+00:00\",\"modified_by\":\"towa\",\"title\":\"True Love\",\"language\":\"eng\",\"album\":\"Ghost Stories\",\"tracknumber\":4,\"artist\":\"Coldplay\",\"lyricist\":\"\",\"composer\":\"\",\"publisher\":\"Brunstad Christian Church\",\"itunescompilation\":1,\"attached_picture\":null,\"time\":\"1431\",\"date\":\"0301\",\"year\":\"2019\",\"copyright\":\"Copyright \\u00a9 Stiftelsen Skjulte Skatters Forlag. All Rights Reserved.\",\"bible_references\":[],\"parent\":{\"id\":90940,\"parent_id\":null,\"type\":\"album\",\"bmm_id\":null,\"tags\":[],\"published_at\":\"2019-01-03T14:31:46+00:00\",\"_meta\":{\"is_visible\":true,\"modified_at\":\"2019-03-13T17:45:26+00:00\",\"modified_by\":\"d0c15e39-c315-4025-b9ab-33d51f721788\",\"contained_types\":[\"song\"]},\"cover\":null,\"languages\":[\"en\"],\"language\":\"en\",\"title\":\"Ghost Stories\"},\"root_parent\":{\"id\":90940,\"parent_id\":null,\"type\":\"album\",\"bmm_id\":null,\"tags\":[],\"published_at\":\"2019-01-03T14:31:46+00:00\",\"_meta\":{\"is_visible\":true,\"modified_at\":\"2019-03-13T17:45:26+00:00\",\"modified_by\":\"d0c15e39-c315-4025-b9ab-33d51f721788\",\"contained_types\":[\"song\"]},\"cover\":null,\"languages\":[\"en\"],\"language\":\"en\",\"title\":\"Ghost Stories\"}},\"cover\":null,\"languages\":[\"en\"],\"language\":\"en\",\"title\":\"True Love\",\"publisher\":\"Brunstad Christian Church\",\"copyright\":\"Copyright \\u00a9 Stiftelsen Skjulte Skatters Forlag. All Rights Reserved.\",\"media\":[{\"type\":\"audio\",\"is_visible\":true,\"files\":[{\"mime_type\":\"audio\\/mpeg\",\"size\":9843333,\"duration\":247,\"url\":\"https:\\/\\/int-bmm-api.brunstad.org\\/file\\/protected\\/track\\/100246\\/track_100246_media_en.mp3?last-changed=1552499127\"}]}]},{\"id\":100247,\"parent_id\":90940,\"is_visible\":true,\"comment\":null,\"order\":5,\"type\":\"track\",\"subtype\":\"song\",\"tags\":[\"ghost-stories\"],\"recorded_at\":\"2019-01-03T14:31:46+00:00\",\"published_at\":\"2019-01-04T21:07:18+00:00\",\"rel\":[{\"type\":\"interpret\",\"name\":\"Coldplay\",\"id\":91209}],\"_meta\":{\"root_parent_id\":90940,\"is_visible\":true,\"modified_at\":\"2019-01-04T21:09:00+00:00\",\"modified_by\":\"towa\",\"title\":\"Midnight\",\"language\":\"eng\",\"album\":\"Ghost Stories\",\"tracknumber\":5,\"artist\":\"Coldplay\",\"lyricist\":\"\",\"composer\":\"\",\"publisher\":\"Brunstad Christian Church\",\"itunescompilation\":1,\"attached_picture\":null,\"time\":\"1431\",\"date\":\"0301\",\"year\":\"2019\",\"copyright\":\"Copyright \\u00a9 Stiftelsen Skjulte Skatters Forlag. All Rights Reserved.\",\"bible_references\":[],\"parent\":{\"id\":90940,\"parent_id\":null,\"type\":\"album\",\"bmm_id\":null,\"tags\":[],\"published_at\":\"2019-01-03T14:31:46+00:00\",\"_meta\":{\"is_visible\":true,\"modified_at\":\"2019-03-13T17:45:26+00:00\",\"modified_by\":\"d0c15e39-c315-4025-b9ab-33d51f721788\",\"contained_types\":[\"song\"]},\"cover\":null,\"languages\":[\"en\"],\"language\":\"en\",\"title\":\"Ghost Stories\"},\"root_parent\":{\"id\":90940,\"parent_id\":null,\"type\":\"album\",\"bmm_id\":null,\"tags\":[],\"published_at\":\"2019-01-03T14:31:46+00:00\",\"_meta\":{\"is_visible\":true,\"modified_at\":\"2019-03-13T17:45:26+00:00\",\"modified_by\":\"d0c15e39-c315-4025-b9ab-33d51f721788\",\"contained_types\":[\"song\"]},\"cover\":null,\"languages\":[\"en\"],\"language\":\"en\",\"title\":\"Ghost Stories\"}},\"cover\":null,\"languages\":[\"en\"],\"language\":\"en\",\"title\":\"Midnight\",\"publisher\":\"Brunstad Christian Church\",\"copyright\":\"Copyright \\u00a9 Stiftelsen Skjulte Skatters Forlag. All Rights Reserved.\",\"media\":[{\"type\":\"audio\",\"is_visible\":true,\"files\":[{\"mime_type\":\"audio\\/mpeg\",\"size\":11789977,\"duration\":295,\"url\":\"https:\\/\\/int-bmm-api.brunstad.org\\/file\\/protected\\/track\\/100247\\/track_100247_media_en.mp3?last-changed=1552499127\"}]}]},{\"id\":100248,\"parent_id\":90940,\"is_visible\":true,\"comment\":null,\"order\":6,\"type\":\"track\",\"subtype\":\"song\",\"tags\":[\"ghost-stories\"],\"recorded_at\":\"2019-01-03T14:31:46+00:00\",\"published_at\":\"2019-01-04T21:19:14+00:00\",\"rel\":[{\"type\":\"interpret\",\"name\":\"Coldplay\",\"id\":91209}],\"_meta\":{\"root_parent_id\":90940,\"is_visible\":true,\"modified_at\":\"2019-01-04T21:21:25+00:00\",\"modified_by\":\"towa\",\"title\":\"Another's Arms\",\"language\":\"eng\",\"album\":\"Ghost Stories\",\"tracknumber\":6,\"artist\":\"Coldplay\",\"lyricist\":\"\",\"composer\":\"\",\"publisher\":\"Brunstad Christian Church\",\"itunescompilation\":1,\"attached_picture\":null,\"time\":\"1431\",\"date\":\"0301\",\"year\":\"2019\",\"copyright\":\"Copyright \\u00a9 Stiftelsen Skjulte Skatters Forlag. All Rights Reserved.\",\"bible_references\":[],\"parent\":{\"id\":90940,\"parent_id\":null,\"type\":\"album\",\"bmm_id\":null,\"tags\":[],\"published_at\":\"2019-01-03T14:31:46+00:00\",\"_meta\":{\"is_visible\":true,\"modified_at\":\"2019-03-13T17:45:26+00:00\",\"modified_by\":\"d0c15e39-c315-4025-b9ab-33d51f721788\",\"contained_types\":[\"song\"]},\"cover\":null,\"languages\":[\"en\"],\"language\":\"en\",\"title\":\"Ghost Stories\"},\"root_parent\":{\"id\":90940,\"parent_id\":null,\"type\":\"album\",\"bmm_id\":null,\"tags\":[],\"published_at\":\"2019-01-03T14:31:46+00:00\",\"_meta\":{\"is_visible\":true,\"modified_at\":\"2019-03-13T17:45:26+00:00\",\"modified_by\":\"d0c15e39-c315-4025-b9ab-33d51f721788\",\"contained_types\":[\"song\"]},\"cover\":null,\"languages\":[\"en\"],\"language\":\"en\",\"title\":\"Ghost Stories\"}},\"cover\":null,\"languages\":[\"en\"],\"language\":\"en\",\"title\":\"Another's Arms\",\"publisher\":\"Brunstad Christian Church\",\"copyright\":\"Copyright \\u00a9 Stiftelsen Skjulte Skatters Forlag. All Rights Reserved.\",\"media\":[{\"type\":\"audio\",\"is_visible\":true,\"files\":[{\"mime_type\":\"audio\\/mpeg\",\"size\":9379404,\"duration\":235,\"url\":\"https:\\/\\/int-bmm-api.brunstad.org\\/file\\/protected\\/track\\/100248\\/track_100248_media_en.mp3?last-changed=1552499127\"}]}]},{\"id\":100250,\"parent_id\":90940,\"is_visible\":true,\"comment\":null,\"order\":7,\"type\":\"track\",\"subtype\":\"song\",\"tags\":[\"ghost-stories\"],\"recorded_at\":\"2019-01-03T14:31:46+00:00\",\"published_at\":\"2019-01-07T22:03:29+00:00\",\"rel\":[{\"type\":\"interpret\",\"name\":\"Coldplay\",\"id\":91209}],\"_meta\":{\"root_parent_id\":90940,\"is_visible\":true,\"modified_at\":\"2019-01-07T22:04:51+00:00\",\"modified_by\":\"towa\",\"title\":\"Oceans\",\"language\":\"eng\",\"album\":\"Ghost Stories\",\"tracknumber\":7,\"artist\":\"Coldplay\",\"lyricist\":\"\",\"composer\":\"\",\"publisher\":\"Brunstad Christian Church\",\"itunescompilation\":1,\"attached_picture\":null,\"time\":\"1431\",\"date\":\"0301\",\"year\":\"2019\",\"copyright\":\"Copyright \\u00a9 Stiftelsen Skjulte Skatters Forlag. All Rights Reserved.\",\"bible_references\":[],\"parent\":{\"id\":90940,\"parent_id\":null,\"type\":\"album\",\"bmm_id\":null,\"tags\":[],\"published_at\":\"2019-01-03T14:31:46+00:00\",\"_meta\":{\"is_visible\":true,\"modified_at\":\"2019-03-13T17:45:26+00:00\",\"modified_by\":\"d0c15e39-c315-4025-b9ab-33d51f721788\",\"contained_types\":[\"song\"]},\"cover\":null,\"languages\":[\"en\"],\"language\":\"en\",\"title\":\"Ghost Stories\"},\"root_parent\":{\"id\":90940,\"parent_id\":null,\"type\":\"album\",\"bmm_id\":null,\"tags\":[],\"published_at\":\"2019-01-03T14:31:46+00:00\",\"_meta\":{\"is_visible\":true,\"modified_at\":\"2019-03-13T17:45:26+00:00\",\"modified_by\":\"d0c15e39-c315-4025-b9ab-33d51f721788\",\"contained_types\":[\"song\"]},\"cover\":null,\"languages\":[\"en\"],\"language\":\"en\",\"title\":\"Ghost Stories\"}},\"cover\":null,\"languages\":[\"en\"],\"language\":\"en\",\"title\":\"Oceans\",\"publisher\":\"Brunstad Christian Church\",\"copyright\":\"Copyright \\u00a9 Stiftelsen Skjulte Skatters Forlag. All Rights Reserved.\",\"media\":[{\"type\":\"audio\",\"is_visible\":true,\"files\":[{\"mime_type\":\"audio\\/mpeg\",\"size\":12870400,\"duration\":322,\"url\":\"https:\\/\\/int-bmm-api.brunstad.org\\/file\\/protected\\/track\\/100250\\/track_100250_media_en.mp3?last-changed=1552499127\"}]}]},{\"id\":100249,\"parent_id\":90940,\"is_visible\":true,\"comment\":null,\"order\":8,\"type\":\"track\",\"subtype\":\"song\",\"tags\":[\"ghost-stories\"],\"recorded_at\":\"2019-01-03T14:31:46+00:00\",\"published_at\":\"2019-01-10T03:00:00+00:00\",\"rel\":[{\"type\":\"interpret\",\"name\":\"Coldplay\",\"id\":91209}],\"_meta\":{\"root_parent_id\":90940,\"is_visible\":true,\"modified_at\":\"2019-01-10T10:45:12+00:00\",\"modified_by\":\"simoncostea\",\"title\":\"A Sky Full Of Stars\",\"language\":\"eng\",\"album\":\"Ghost Stories\",\"tracknumber\":8,\"artist\":\"Coldplay\",\"lyricist\":\"\",\"composer\":\"\",\"publisher\":\"Brunstad Christian Church\",\"itunescompilation\":1,\"attached_picture\":null,\"time\":\"1431\",\"date\":\"0301\",\"year\":\"2019\",\"copyright\":\"Copyright \\u00a9 Stiftelsen Skjulte Skatters Forlag. All Rights Reserved.\",\"bible_references\":[],\"parent\":{\"id\":90940,\"parent_id\":null,\"type\":\"album\",\"bmm_id\":null,\"tags\":[],\"published_at\":\"2019-01-03T14:31:46+00:00\",\"_meta\":{\"is_visible\":true,\"modified_at\":\"2019-03-13T17:45:26+00:00\",\"modified_by\":\"d0c15e39-c315-4025-b9ab-33d51f721788\",\"contained_types\":[\"song\"]},\"cover\":null,\"languages\":[\"en\"],\"language\":\"en\",\"title\":\"Ghost Stories\"},\"root_parent\":{\"id\":90940,\"parent_id\":null,\"type\":\"album\",\"bmm_id\":null,\"tags\":[],\"published_at\":\"2019-01-03T14:31:46+00:00\",\"_meta\":{\"is_visible\":true,\"modified_at\":\"2019-03-13T17:45:26+00:00\",\"modified_by\":\"d0c15e39-c315-4025-b9ab-33d51f721788\",\"contained_types\":[\"song\"]},\"cover\":null,\"languages\":[\"en\"],\"language\":\"en\",\"title\":\"Ghost Stories\"}},\"cover\":null,\"languages\":[\"en\"],\"language\":\"en\",\"title\":\"A Sky Full Of Stars\",\"publisher\":\"Brunstad Christian Church\",\"copyright\":\"Copyright \\u00a9 Stiftelsen Skjulte Skatters Forlag. All Rights Reserved.\",\"media\":[{\"type\":\"audio\",\"is_visible\":true,\"files\":[{\"mime_type\":\"audio\\/mpeg\",\"size\":10150543,\"duration\":254,\"url\":\"https:\\/\\/int-bmm-api.brunstad.org\\/file\\/protected\\/track\\/100249\\/track_100249_media_en.mp3?last-changed=1552499127\"}]}]},{\"id\":100251,\"parent_id\":90940,\"is_visible\":true,\"comment\":null,\"order\":9,\"type\":\"track\",\"subtype\":\"song\",\"tags\":[\"ghost-stories\"],\"recorded_at\":\"2019-01-03T14:31:46+00:00\",\"published_at\":\"2019-01-10T19:07:56+00:00\",\"rel\":[{\"type\":\"interpret\",\"name\":\"Coldplay\",\"id\":91209}],\"_meta\":{\"root_parent_id\":90940,\"is_visible\":true,\"modified_at\":\"2019-01-22T21:38:13+00:00\",\"modified_by\":\"towa\",\"title\":\"O\",\"language\":\"eng\",\"album\":\"Ghost Stories\",\"tracknumber\":9,\"artist\":\"Coldplay\",\"lyricist\":\"\",\"composer\":\"\",\"publisher\":\"Brunstad Christian Church\",\"itunescompilation\":1,\"attached_picture\":null,\"time\":\"1431\",\"date\":\"0301\",\"year\":\"2019\",\"copyright\":\"Copyright \\u00a9 Stiftelsen Skjulte Skatters Forlag. All Rights Reserved.\",\"bible_references\":[],\"parent\":{\"id\":90940,\"parent_id\":null,\"type\":\"album\",\"bmm_id\":null,\"tags\":[],\"published_at\":\"2019-01-03T14:31:46+00:00\",\"_meta\":{\"is_visible\":true,\"modified_at\":\"2019-03-13T17:45:26+00:00\",\"modified_by\":\"d0c15e39-c315-4025-b9ab-33d51f721788\",\"contained_types\":[\"song\"]},\"cover\":null,\"languages\":[\"en\"],\"language\":\"en\",\"title\":\"Ghost Stories\"},\"root_parent\":{\"id\":90940,\"parent_id\":null,\"type\":\"album\",\"bmm_id\":null,\"tags\":[],\"published_at\":\"2019-01-03T14:31:46+00:00\",\"_meta\":{\"is_visible\":true,\"modified_at\":\"2019-03-13T17:45:26+00:00\",\"modified_by\":\"d0c15e39-c315-4025-b9ab-33d51f721788\",\"contained_types\":[\"song\"]},\"cover\":null,\"languages\":[\"en\"],\"language\":\"en\",\"title\":\"Ghost Stories\"}},\"cover\":null,\"languages\":[\"en\"],\"language\":\"en\",\"title\":\"O\",\"publisher\":\"Brunstad Christian Church\",\"copyright\":\"Copyright \\u00a9 Stiftelsen Skjulte Skatters Forlag. All Rights Reserved.\",\"media\":[{\"type\":\"audio\",\"is_visible\":true,\"files\":[{\"mime_type\":\"audio\\/mpeg\",\"size\":18675848,\"duration\":467,\"url\":\"https:\\/\\/int-bmm-api.brunstad.org\\/file\\/protected\\/track\\/100251\\/track_100251_media_en.mp3?last-changed=1552499127\"}]}]}]}";

            //var stopwatch = new Stopwatch();

            //// Act
            //stopwatch.Start();
            //var item = JsonConvert.DeserializeObject<TrackCollection>(trackCollectionStringFromBmmApi, settings);
            //stopwatch.Stop();

            //// Assert
            //Assert.Less(stopwatch.ElapsedMilliseconds, 1000); // ToDo: it should be less than 20ms
        }
    }
}