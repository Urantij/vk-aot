using System;
using System.Text.Json.Serialization;
using JetBrains.Annotations;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// платёж через VK Pay
/// </summary>
[Serializable]
public class VkPayTransaction : IGroupUpdate
{
	/// <summary>
	/// Идентификатор пользователя-отправителя перевода.
	/// </summary>
	[JsonPropertyName("from_id")]
	public long? FromId { get; set; }

	/// <summary>
	/// Cумма перевода в тысячных рубля.
	/// </summary>
	[JsonPropertyName("amount")]
	public long Amount { get; set; }

	/// <summary>
	/// Комментарий к переводу.
	/// </summary>
	[CanBeNull]
	[JsonPropertyName("description")]
	public string Description { get; set; }

	/// <summary>
	/// Время отправки перевода в Unixtime.
	/// </summary>
	[JsonConverter(typeof(UnixDateTimeConverter))]
	[JsonPropertyName("date")]
	public DateTime Date { get; set; }
}