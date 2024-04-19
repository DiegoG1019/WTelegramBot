﻿namespace Telegram.Bot.Types;

/// <summary>
/// This object represents a service message about a user boosting a chat.
/// </summary>
public partial class ChatBoostAdded
{
    /// <summary>
    /// Number of boosts added by the user
    /// </summary>
    public int BoostCount { get; set; }
}
