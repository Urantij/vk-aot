using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Создаёт пиксель ретаргетинга.
/// </summary>
[Serializable]
public class CreateTargetPixelParams
{
	/// <summary>
	/// Идентификатор рекламного кабинета.
	/// </summary>
	[JsonPropertyName("account_id")]
	public long AccountId { get; set; }

	/// <summary>
	/// Id клиента, в рекламном кабинете которого будет создаваться пиксель.
	/// </summary>
	[JsonPropertyName("client_id")]
	public long? ClientId { get; set; }

	/// <summary>
	/// Название пикселя — строка до 64 символов.
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; }

	/// <summary>
	/// Домен сайта, на котором будет размещен пиксель.
	/// </summary>
	[JsonPropertyName("domain")]
	public string Domain { get; set; }

	/// <summary>
	/// Идентификатор категории сайта, на котором будет размещен пиксель.
	/// </summary>
	[JsonPropertyName("category_id")]
	public long CategoryId { get; set; }
}