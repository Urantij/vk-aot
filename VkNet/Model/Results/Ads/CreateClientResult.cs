using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Результат выполнения метода ads.createClients
/// </summary>
[Serializable]
public class CreateClientResult
{
	/// <summary>
	/// Идентификатор созданного объявления.
	/// </summary>
	/// <remarks>Выполнение этого метода может вернуть id = null в случае ошибки</remarks>
	[JsonPropertyName("id")]
	public long? Id { get; set; }

	/// <summary>
	/// Массив объектов UserSpecification
	/// </summary>
	[JsonPropertyName("error_code")]
	public long ErrorCode { get; set; }

	/// <summary>
	/// Массив объектов UserSpecification
	/// </summary>
	[JsonPropertyName("error_desc")]
	public string ErrorDesc { get; set; }
}