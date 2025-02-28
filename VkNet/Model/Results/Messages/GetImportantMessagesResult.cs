using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using VkNet.Utils;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Параметры метода Messages.GetImportantMessages
/// </summary>
[Serializable]
public class GetImportantMessagesResult
{
	/// <summary>
	/// Сообщения
	/// </summary>
	[JsonPropertyName("messages")]
	[VkCollectionConverter<Message>]
	public VkCollection<Message> Messages { get; set; }

	/// <summary>
	/// Профили пользователей
	/// </summary>
	[JsonPropertyName("profiles")]
	public ReadOnlyCollection<User> Profiles { get; set; }

	/// <summary>
	/// Беседы
	/// </summary>
	[JsonPropertyName("conversations")]
	public ReadOnlyCollection<Conversation> Conversations { get; set; }
}