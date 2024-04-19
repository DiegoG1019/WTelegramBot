﻿using System.Diagnostics.CodeAnalysis;
using Telegram.Bot.Types.ReplyMarkups;

namespace Telegram.Bot.Types.InlineQueryResults;

/// <summary>
/// Base Class for inline results send in response to an <see cref="InlineQuery"/>
/// </summary>
public abstract partial class InlineQueryResult
{
    /// <summary>
    /// Type of the result
    /// </summary>
    public abstract InlineQueryResultType Type { get; }

    /// <summary>
    /// Unique identifier for this result, 1-64 Bytes
    /// </summary>
    public required string Id { get; set; }

    /// <summary>
    /// Optional. Inline keyboard attached to the message
    /// </summary>
    public InlineKeyboardMarkup? ReplyMarkup { get; set; }

    /// <summary>
    /// Initializes a new inline query result
    /// </summary>
    /// <param name="id">Unique identifier for this result, 1-64 Bytes</param>
    [SetsRequiredMembers]
    [Obsolete("Use parameterless constructor with required properties")]
    protected InlineQueryResult(string id) => Id = id;

    /// <summary>
    /// Initializes a new inline query result
    /// </summary>
    protected InlineQueryResult()
    { }
}
