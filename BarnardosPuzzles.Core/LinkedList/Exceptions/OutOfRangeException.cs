using System;
using System.Runtime.Serialization;
using BarnardosPuzzles.Core.ExceptionHandling;

namespace BarnardosPuzzles.Core.LinkedList.Exceptions
{
    public class OutOfRangeException : CustomExceptionBase
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="OutOfRangeException"/> class.
        /// </summary>
        /// <param name="index">The index.</param>
        public OutOfRangeException(int index)
            : base(string.Format("The '{0}' index {1}", index, Resource.IsOutOfRange))
        {
            // Add any type-specific logic, and supply the default message.
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutOfRangeException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public OutOfRangeException(string message)
            : base(message)
        {
            // Add any type-specific logic.
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutOfRangeException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="innerException">The inner exception.</param>
        public OutOfRangeException(string message, Exception innerException)
            : base(message, innerException)
        {
            // Add any type-specific logic for inner exceptions.
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutOfRangeException"/> class.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo"/> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext"/> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">
        /// The <paramref name="info"/> parameter is null.
        /// </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">
        /// The class name is null or <see cref="P:System.Exception.HResult"/> is zero (0).
        /// </exception>
        protected OutOfRangeException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            // Implement type-specific serialization constructor logic.
        }

        #endregion
    }
}