﻿namespace Telegram.Bot.Types;

/// <summary>
/// This object represents a file ready to be downloaded. The file can be downloaded via <see cref="WTelegram.Bot.DownloadFile"/>. It is guaranteed that the link will be valid for at least 1 hour. When the link expires, a new one can be requested by calling <see cref="WTelegram.Bot.GetFile">GetFile</see>.
/// </summary>
/// <remarks>
/// The maximum file size to download is 20 MB
/// </remarks>
public partial class File : FileBase
{
    /// <summary>
    /// <em>Optional</em>. File path. Use <see cref="WTelegram.Bot.DownloadFile"/> to get the file.
    /// </summary>
    public string? FilePath { get; set; }
}
