using System;
using System.Text.Json.Serialization;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Подборка товаров
/// </summary>
[Serializable]
public class MarketAlbum : MediaAttachment
{
	/// <inheritdoc />
	protected override string Alias => "market_album";

	/// <summary>
	/// Название подборки
	/// </summary>
	[JsonPropertyName("title")]
	public string Title { get; set; }

	/// <summary>
	/// Обложка подборки, объект, описывающий фотографию.
	/// </summary>
	[JsonPropertyName("photo")]
	public Photo Photo { get; set; }

	/// <summary>
	/// Число товаров в подборке.
	/// </summary>
	[JsonPropertyName("count")]
	public int Count { get; set; }

	/// <summary>
	/// Дата обновления подборки в формате Unixtime.
	/// </summary>
	[JsonPropertyName("updated_time")]
	[JsonConverter(typeof(UnixDateTimeConverter))]
	public DateTime? UpdatedTime { get; set; }
}