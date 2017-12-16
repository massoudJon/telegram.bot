﻿using Telegram.Bot.Types;

namespace Telegram.Bot.Requests
{
    /// <summary>
    /// Get basic info about a file and prepare it for downloading. For the moment, bots can download files of up to 20MB in size. On success, a <see cref="File"/> object is returned.
    /// </summary>
    public class GetFileRequest : RequestBase<File>
    {
        /// <summary>
        /// File identifier to get info about
        /// </summary>
        public string FileId { get; set; }

        /// <summary>
        /// Initializes a new request
        /// </summary>
        public GetFileRequest()
            : base("getFile")
        { }

        /// <summary>
        /// Initializes a new request with <see cref="FileId"/>
        /// </summary>
        /// <param name="fileId">File identifier to get info about</param>
        public GetFileRequest(string fileId)
            : this()
        {
            FileId = fileId;
        }
    }
}