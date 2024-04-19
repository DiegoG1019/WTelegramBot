﻿namespace Telegram.Bot.Types;

/// <summary>
/// Represents the content of a service message, sent whenever a user in the chat triggers a proximity alert set
/// by another user.
/// </summary>
public partial class ProximityAlertTriggered
{
    /// <summary>
    /// User that triggered the alert
    /// </summary>
    public User Traveler { get; set; } = default!;

    /// <summary>
    /// User that set the alert
    /// </summary>
    public User Watcher { get; set; } = default!;

    /// <summary>
    /// The distance between the users
    /// </summary>
    public int Distance { get; set; }
}
