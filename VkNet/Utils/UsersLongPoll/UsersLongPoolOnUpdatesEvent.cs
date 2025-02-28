#nullable enable
using System.Collections.Generic;
using VkNet.Model;

namespace VkNet.Utils.UsersLongPoll;

/// <summary>
/// Обёртка для UsersLongPollUpdatesHandlerParams.OnUpdates, в которой содержится вся информация о текущем массиве событий лонгпула для пользователя.
/// </summary>
public class UsersLongPollOnUpdatesEvent
{
	/// <summary>
	/// Обновление в событиях пользователя.
	/// </summary>
	public LongPollHistoryJsonResponse Response;

	/// <summary>
	/// Обработанные сообщения из Response
	/// </summary>
	public List<UserMessageEvent> Messages;
}