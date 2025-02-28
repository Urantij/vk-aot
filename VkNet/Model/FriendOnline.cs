using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Результат запроса Friends.FriendOnline
/// </summary>
[Serializable]
[JsonConverter(typeof(FriendOnlineJsonConverter))]
public class FriendOnline
{
	/// <summary>
	/// Online
	/// </summary>
	[JsonPropertyName("online")]
	public ReadOnlyCollection<long> Online { get; set; }

	/// <summary>
	/// Online с мобильного телефона.
	/// </summary>
	[JsonPropertyName("online_mobile")]
	public ReadOnlyCollection<long> MobileOnline { get; set; }
}