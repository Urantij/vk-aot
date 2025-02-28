using System;
using System.Text.Json.Serialization;
using VkNet.Enums.StringEnums;

namespace VkNet.Model;

/// <summary>
/// Информация о родственнике.
/// См. описание http://vk.com/dev/fields
/// </summary>
[Serializable]
public class Relative
{
	/// <summary>
	/// Идентификатор родственника.
	/// </summary>
	[JsonPropertyName("id")]
	public long Id { get; set; }

	/// <summary>
	/// Тип родственника (sibling и т.п.)
	/// </summary>
	[JsonPropertyName("type")]
	public RelativeType? Type { get; set; }

	/// <summary>
	/// Имя родственника, если он не является пользователем ВКонтакте.
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; }

	[JsonPropertyName("user_id")]
	private long UserId
	{
		get => Id;
		set => Id = value;
	}

	[JsonPropertyName("uid")]
	private long Uid
	{
		get => Id;
		set => Id = value;
	}
}