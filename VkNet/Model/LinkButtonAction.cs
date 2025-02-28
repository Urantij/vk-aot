using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Действие кнопки
/// </summary>
[Serializable]
public class LinkButtonAction
{
	/// <summary>
	/// Тип действия. Возможные значения.
	/// </summary>
	[JsonPropertyName("type")]
	public string Type { get; set; }

	/// <summary>
	/// Ссылка на которую ведет кнопка.
	/// </summary>
	[JsonPropertyName("url")]
	public Uri Uri { get; set; }

	/// <summary>
	/// Назначание действия
	/// </summary>
	[JsonPropertyName("target")]
	public string Target { get; set; }

	/// <summary>
	/// Идентификатор группы
	/// </summary>
	[JsonPropertyName("group_id")]
	public long? GroupId { get; set; }
}