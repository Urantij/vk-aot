using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Метка в списке друзей
/// </summary>
[Serializable]
public class FriendList
{
	/// <summary>
	/// Идентификатор метки
	/// </summary>
	[JsonPropertyName("id")]
	public long Id { get; set; }

	/// <summary>
	/// Название метки
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; }

	[JsonPropertyName("list_id")]
	private long ListId
	{
		get => Id;
		set => Id = value;
	}

	[JsonPropertyName("lid")]
	private long Lid
	{
		get => Id;
		set => Id = value;
	}
}