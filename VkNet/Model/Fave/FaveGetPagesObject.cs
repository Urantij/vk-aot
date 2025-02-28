using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using VkNet.Enums.StringEnums;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Ответ метода fave.getPages
/// </summary>
[Serializable]
public class FaveGetPagesObject
{
	/// <summary>
	/// Описание страницы.
	/// </summary>
	[JsonPropertyName("description")]
	public string Description { get; set; }

	/// <summary>
	/// Тип страницы.
	/// </summary>
	[JsonPropertyName("type")]
	public UserOrGroupType? Type { get; set; }

	/// <summary>
	/// Метки страницы.
	/// </summary>
	[JsonPropertyName("tags")]
	public IEnumerable<FaveTag> Tags { get; set; }

	/// <summary>
	/// Дата обновления.
	/// </summary>
	[JsonConverter(typeof(UnixDateTimeConverter))]
	[JsonPropertyName("updated_date")]
	public DateTime UpdatedDate { get; set; }

	/// <summary>
	/// Информация о пользователе.
	/// </summary>
	/// <remarks>
	/// См. описание https://vk.com/dev/objects/user
	/// </remarks>
	[JsonPropertyName("user")]
	public User User { get; set; }

	/// <summary>
	/// Информация о сообществе (группе).
	/// </summary>
	/// <remarks>
	/// См. описание http://vk.com/dev/fields_groups
	/// </remarks>
	[JsonPropertyName("group")]
	public Group Group { get; set; }
}