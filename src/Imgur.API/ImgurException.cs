﻿using System;
using System.Runtime.Serialization;

namespace Imgur.API
{
    /// <summary>
    /// The exception that is thrown when an error is found in a response from an Imgur endpoint.
    /// </summary>
    [Serializable]
    public class ImgurException : Exception
    {
        /// <summary>
        /// The exception that is thrown when an error is found in a response from an Imgur endpoint.
        /// </summary>
        public ImgurException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ImgurException class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public ImgurException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ImgurException class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="innerException">The exception that is the cause of the current exception.</param>
        public ImgurException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// The exception that is thrown when an error is found in a response from an Imgur endpoint.
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        protected ImgurException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
