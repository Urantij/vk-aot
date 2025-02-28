using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Тип места
/// </summary>
[Serializable]
public class PlaceType
{
	/// <summary>
	/// Идентификатор
	/// </summary>
	[JsonPropertyName("id")]
	public long Id { get; set; }

	/// <summary>
	/// Наименование
	/// </summary>
	[JsonPropertyName("title")]
	public string Title { get; set; }

	/// <summary>
	/// URL адрес к иконке
	/// </summary>
	[JsonPropertyName("icon")]
	public Uri Icon { get; set; }
}