using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Places Add Params
/// </summary>
[Serializable]
public class PlacesAddParams
{
	/// <summary>
	/// Название нового места
	/// </summary>
	[JsonPropertyName("title")]
	public string Title { get; set; }

	/// <summary>
	/// Географическая широта нового места, заданная в градусах (от -90 до 90)
	/// </summary>
	[JsonPropertyName("latitude")]
	public decimal Latitude { get; set; }

	/// <summary>
	/// Географическая долгота нового места, заданная в градусах (от -180 до 180)
	/// </summary>
	[JsonPropertyName("longitude")]
	public decimal Longitude { get; set; }

	/// <summary>
	/// Строка с адресом нового места (например, Невский просп. 1)
	/// </summary>
	[JsonPropertyName("address")]
	public string Address { get; set; }

	/// <summary>
	/// Идентификатор типа нового места, полученный методом places.getTypes
	/// </summary>
	[JsonPropertyName("type")]
	public ulong Type { get; set; }

	/// <summary>
	/// Идентификатор страны нового места, полученный методом places.getCountries
	/// </summary>
	[JsonPropertyName("country")]
	public ulong Country { get; set; }

	/// <summary>
	/// Идентификатор города нового места, полученный методом places.getCities
	/// </summary>
	[JsonPropertyName("city")]
	public ulong City { get; set; }
}