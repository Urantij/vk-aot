using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Информация о доставке
/// </summary>
[Serializable]
public class Delivery
{
	/// <summary>
	/// адрес доставки.
	/// </summary>
	[JsonPropertyName("address")]
	public string Address { get; set; }

	/// <summary>
	/// тип доставки.
	/// </summary>
	[JsonPropertyName("type")]
	public string Type { get; set; }

	/// <summary>
	/// трек-номер для отслеживания заказа.
	/// </summary>
	[JsonPropertyName("track_number")]
	public string TrackNumber { get; set; }

	/// <summary>
	///  ссылка для отслеживания заказа по трек-номеру.
	/// </summary>
	[JsonPropertyName("track_link")]
	public string TrackLink { get; set; }

	/// <summary>
	/// информация о пункте выдачи.
	/// </summary>
	[JsonPropertyName("delivery_point ")]
	public string DeliveryPoint  { get; set; }
}