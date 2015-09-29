﻿using System;
using System.Collections.Generic;
using Imgur.API.JsonConverters;
using Newtonsoft.Json;

namespace Imgur.API.Models.Impl
{
    /// <summary>
    ///     Represents an images comment.
    /// </summary>
    public class Comment : IComment
    {
        /// <summary>
        ///     The ID for the comment.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        ///     The Id of the image that the comment is for.
        /// </summary>
        public string ImageId { get; set; }

        /// <summary>
        ///     The comment itself.
        /// </summary>
        public string CommentText { get; set; }

        /// <summary>
        ///     Username of the author of the comment.
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        ///     The account ID for the author.
        /// </summary>
        public int AuthorId { get; set; }

        /// <summary>
        ///     If this comment was done to an album.
        /// </summary>
        public bool OnAlbum { get; set; }

        /// <summary>
        ///     The ID of the album cover image, this is what should be displayed for album comments.
        /// </summary>
        public string AlbumCover { get; set; }

        /// <summary>
        ///     Number of upvotes for the comment.
        /// </summary>
        public int Ups { get; set; }

        /// <summary>
        ///     The number of downvotes for the comment.
        /// </summary>
        public int Downs { get; set; }

        /// <summary>
        ///     The number of upvotes - downvotes.
        /// </summary>
        public float Points { get; set; }

        /// <summary>
        ///     Utc timestamp of creation, converted from epoch time.
        /// </summary>
        public DateTimeOffset DateTime { get; set; }

        /// <summary>
        ///     If this is a reply, this will be the value of the CommentId for the caption this a reply for.
        /// </summary>
        public int? ParentId { get; set; }

        /// <summary>
        ///     Marked true if this caption has been deleted.
        /// </summary>
        public bool Deleted { get; set; }

        /// <summary>
        ///     The current user's vote on the comment. null if not signed in or if the user hasn't voted on it.
        /// </summary>
        public string Vote { get; set; }

        /// <summary>
        ///     All of the replies for this comment. If there are no replies to the comment then this is an empty set.
        /// </summary>
        [JsonConverter(typeof (EnumerableConverter<Comment>))]
        public IEnumerable<IComment>[] Children { get; set; }
    }
}