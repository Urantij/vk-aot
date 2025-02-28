#nullable enable
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using VkNet.Model;

namespace VkNet.Utils.UsersLongPoll;

/// <summary>
/// Методы для обработки событий лонгпула у сообществ.
/// </summary>
public static class UsersLongPollHelpers
{
	/// <summary>
	/// Метод для получения сообщений из массива JObject, который не бросает исключений, но вместе с сообщениями возвращает ошибки при десериализации, если таковые имеются.
	/// </summary>
	/// <param name="jObjectMessages">Этот массив получается из метода api.Messages.GetLongPollHistory&lt;LongPollHistoryResponse&lt;JObject&gt;&gt;().Messages</param>
	/// <returns>
	/// Возвращает список сообщений пользователя
	/// </returns>
	public static List<UserMessageEvent> GetUserMessageEvents(IEnumerable<JsonObject> jObjectMessages)
	{
		var userMessageEvents = new List<UserMessageEvent>();

		foreach (var jObjectMessage in jObjectMessages)
		{
			try
			{
				var message = jObjectMessage.Deserialize<Message>(GlobalJsonSerializerOptions.Options);

				userMessageEvents.Add(new()
				{
					Message = message,
					RawMessage = jObjectMessage
				});
			}
			catch (System.Exception ex)
			{
				userMessageEvents.Add(new()
				{
					Exception = ex,
					RawMessage = jObjectMessage
				});
			}
		}

		return userMessageEvents;
	}
}