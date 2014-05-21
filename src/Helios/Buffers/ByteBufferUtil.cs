﻿namespace Helios.Buffers
{
    /// <summary>
    /// Utility class for working with direct <see cref="ByteBuffer"/> instances
    /// </summary>
    public static class ByteBufferUtil
    {
        /// <summary>
        /// Default initial capacity = 256 bytes
        /// </summary>
        public const int DEFAULT_INITIAL_CAPACITY = 256;

        /// <summary>
        /// Default max capacity = 80mb
        /// </summary>
        public const int DEFAULT_MAX_CAPACITY = DEFAULT_INITIAL_CAPACITY*20;
    }
}
