﻿namespace Telegram.Bot.Types;

/// <summary>This object represents an audio file to be treated as music by the Telegram clients.</summary>
public partial class Audio : FileBase
{
    /// <summary>Duration of the audio in seconds as defined by sender</summary>
    public int Duration { get; set; }

    /// <summary><em>Optional</em>. Performer of the audio as defined by sender or by audio tags</summary>
    public string? Performer { get; set; }

    /// <summary><em>Optional</em>. Title of the audio as defined by sender or by audio tags</summary>
    public string? Title { get; set; }

    /// <summary><em>Optional</em>. Original filename as defined by sender</summary>
    public string? FileName { get; set; }

    /// <summary><em>Optional</em>. MIME type of the file as defined by sender</summary>
    public string? MimeType { get; set; }

    /// <summary><em>Optional</em>. Thumbnail of the album cover to which the music file belongs</summary>
    public PhotoSize? Thumbnail { get; set; }
}
