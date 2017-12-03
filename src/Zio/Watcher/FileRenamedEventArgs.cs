﻿
namespace Zio.Watcher
{
    /// <summary>
    /// Represents a file or directory rename event.
    /// </summary>
    /// <inheritdoc />
    public class FileRenamedEventArgs : FileChangedEventArgs
    {
        /// <summary>
        /// Absolute path to the old location of the file or directory.
        /// </summary>
        public UPath OldFullPath { get; }

        /// <summary>
        /// Old name of the file or directory.
        /// </summary>
        public string OldName { get; }

        public FileRenamedEventArgs(WatcherChangeTypes changeType, UPath fullPath, UPath oldFullPath)
            : base(changeType, fullPath)
        {
            fullPath.AssertNotNull(nameof(oldFullPath));
            fullPath.AssertAbsolute(nameof(oldFullPath));

            OldFullPath = oldFullPath;
            OldName = oldFullPath.GetName();
        }
    }
}
