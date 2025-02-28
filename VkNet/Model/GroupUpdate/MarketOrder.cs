using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using VkNet.Enums;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Объект, содержащий информацию о заказе.
/// </summary>
[Serializable]
public class MarketOrder : IGroupUpdate
{
	/// <summary>
	/// Идентификатор заказа.
	/// </summary>
	[JsonPropertyName("id")]
	public long? Id { get; set; }

	/// <summary>
	/// Идентификатор сообщества.
	/// </summary>
	[JsonPropertyName("group_id")]
	public long? GroupId { get; set; }

	/// <summary>
	/// Идентификатор покупателя.
	/// </summary>
	[JsonPropertyName("user_id")]
	public long? UserId { get; set; }

	/// <summary>
	/// Идентификатор группы вариантов.
	/// </summary>
	[JsonPropertyName("variants_grouping_id")]
	public long? VariantsGroupingId { get; set; }

	/// <summary>
	/// Массив объектов, каждый из которых может содержать поля:
	/// variant_id (integer) — идентификатор варианта;
	/// variant_name (string) — название варианта;
	/// property_name (string) — название свойства.
	/// </summary>
	[JsonPropertyName("property_values")]
	public List<string> PropertyValues { get; set; }

	/// <summary>
	/// Количество товаров в заказе.
	/// Возвращаются только администратору группы, которой принадлежит товар
	/// </summary>
	[JsonPropertyName("items_count")]
	public long? ItemsCount { get; set; }

	/// <summary>
	/// Количество товара в корзине.
	/// </summary>
	[JsonPropertyName("cart_quantity")]
	public long? CartQuantity { get; set; }

	/// <summary>
	/// Общая стоимость заказа
	/// </summary>
	[JsonPropertyName("total_price")]
	public Price TotalPrice { get; set; }

	/// <summary>
	/// Информация о доставке
	/// </summary>
	[JsonPropertyName("delivery")]
	public Delivery Delivery { get; set; }

	/// <summary>
	/// Информация о покупателе
	/// </summary>
	[JsonPropertyName("recipient")]
	public Recipient Recipient { get; set; }

	/// <summary>
	/// Массив объектов, описывающих товары.
	/// Возвращается не больше 5 случайных товаров заказа.
	/// </summary>
	[JsonPropertyName("preview_order_items")]
	public ReadOnlyCollection<Market> PreviewOrderItems { get; set; }

	/// <summary>
	/// Дата создания заказа в формате Unixtime.
	/// Возвращаются только администратору группы, которой принадлежит товар
	/// </summary>
	[JsonPropertyName("date")]
	[JsonConverter(typeof(UnixDateTimeConverter))]
	public DateTime? Date { get; set; }


	/// <summary>
	/// Номер заказа, состоящий из идентификатора покупателя и идентификатора заказа.
	/// </summary>
	[JsonPropertyName("display_order_id")]
	public string DisplayOrderId { get; set; }

	/// <summary>
	/// Комментарий к заказу.
	/// </summary>
	[JsonPropertyName("comment")]
	public string Comment { get; set; }

	/// <summary>
	/// Является ли вариант основным.
	/// </summary>
	[JsonPropertyName("is_main_variant")]
	public bool IsMainVariant { get; set; }

	/// <summary>
	/// Идентификатор пользователя, который удалил комментарий
	/// </summary>
	[JsonPropertyName("status")]
	public MarketOrderState Status { get; set; }
}