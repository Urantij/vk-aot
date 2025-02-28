using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using VkNet.Enums;
using VkNet.Enums.SafetyEnums;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Информация о продукте.
/// </summary>
[Serializable]
public class Market : MediaAttachment
{
	/// <inheritdoc />
	protected override string Alias => "market";

	private long? _id;

	/// <summary>
	/// Id
	/// </summary>
	[JsonPropertyName("id")]
	public new long? Id
	{
		get => _id;

		set => _id = value ?? -1;
	}

	/// <summary>
	/// Название товара
	/// </summary>
	[JsonPropertyName("title")]
	public string Title { get; set; }

	/// <summary>
	/// Текст описания товара
	/// </summary>
	[JsonPropertyName("description")]
	public string Description { get; set; }

	/// <summary>
	/// Цена
	/// </summary>
	[JsonPropertyName("price")]
	public Price Price { get; set; }

	/// <summary>
	/// Габариты товара.
	/// </summary>
	[JsonPropertyName("dimensions")]
	public Dimensions Dimensions { get; set; }

	/// <summary>
	/// Категория товара
	/// </summary>
	[JsonPropertyName("category")]
	public MarketCategory Category { get; set; }

	/// <summary>
	/// URL изображения-обложки товара
	/// </summary>
	[JsonPropertyName("thumb_photo")]
	public Uri ThumbPhoto { get; set; }

	/// <summary>
	/// Дата создания товара в формате Unixtime.
	/// </summary>
	[JsonPropertyName("date")]
	[JsonConverter(typeof(UnixDateTimeConverter))]
	public DateTime? Date { get; set; }

	/// <summary>
	/// Статус доступности товара
	/// </summary>
	[JsonPropertyName("availability")]
	public ProductAvailability Availability { get; set; }

	/// <summary>
	/// Изображения товара
	/// </summary>
	[JsonPropertyName("photos")]
	public ReadOnlyCollection<Photo> Photos { get; set; }

	/// <summary>
	/// Возможность комментировать товар для текущего пользователя
	/// </summary>
	[JsonPropertyName("can_comment")]
	public bool? CanComment { get; set; }

	/// <summary>
	/// Возможность сделать репост товара для текущего пользователя
	/// </summary>
	[JsonPropertyName("can_repost")]
	public bool? CanRepost { get; set; }

	/// <summary>
	/// Информация об отметках «Мне нравится»
	/// </summary>
	[JsonPropertyName("likes")]
	public Likes Likes { get; set; }

	/// <summary>
	/// Cсылка на товар во внешних ресурсах.
	/// </summary>
	[JsonPropertyName("url")]
	public Uri Url { get; set; }

	/// <summary>
	/// Текст на кнопке товара.
	/// </summary>
	[JsonPropertyName("button_title")]
	[JsonConverter(typeof(SafetyEnumJsonConverter))]
	public MarketItemButtonTitle ButtonTitle { get; set; }

	/// <summary>
	/// Преобразовать вложение в строку.
	/// </summary>
	/// <returns>
	/// Строковое представление
	/// </returns>
	public override string ToString()
	{
		var result = $"{Alias}{OwnerId}_{Id}";

		return string.IsNullOrWhiteSpace(AccessKey)
			? result
			: $"{result}_{AccessKey}";
	}
}