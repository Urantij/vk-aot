using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using VkNet.Enums.StringEnums;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Продукт
/// </summary>
[Serializable]
public class Product
{
	/// <summary>
	/// Идентификатор продукта
	/// </summary>
	[JsonPropertyName("id")]
	public long Id { get; set; }

	/// <summary>
	/// Тип продукта
	/// </summary>
	[JsonPropertyName("type")]
	[JsonConverter(typeof(TolerantStringEnumConverter))]
	public ProductType Type { get; set; }

	/// <summary>
	/// Является ли продукт новым
	/// </summary>
	[JsonPropertyName("is_new")]
	public bool IsNew { get; set; }

	/// <summary>
	/// Копирайт
	/// </summary>
	[JsonPropertyName("copyright")]
	public string Copyright { get; set; }

	/// <summary>
	/// Куплен ли продукт
	/// </summary>
	[JsonPropertyName("purchased")]
	public bool Purchased { get; set; }

	/// <summary>
	/// Активен ли продукт
	/// </summary>
	[JsonPropertyName("active")]
	public bool Active { get; set; }

	/// <summary>
	/// Является ли продукт рекламным
	/// </summary>
	[JsonPropertyName("promoted ")]
	public bool Promoted { get; set; }

	/// <summary>
	/// Дата покупки
	/// </summary>
	[JsonPropertyName("purchase_date")]
	[JsonConverter(converterType: typeof(UnixDateTimeConverter))]
	public DateTime? PurchaseDate { get; set; }

	/// <summary>
	/// Название продукта
	/// </summary>
	[JsonPropertyName("title")]
	public string Title { get; set; }

	/// <summary>
	/// Стикеры
	/// </summary>
	[JsonPropertyName("stickers")]
	public List<Sticker> Stickers { get; set; }

	/// <summary>
	/// Иконка продукта
	/// </summary>
	[JsonPropertyName("icon")]
	public Icon Icon { get; set; }

	/// <summary>
	/// Превью
	/// </summary>
	[JsonPropertyName("previews")]
	public List<Image> Previews { get; set; }
}