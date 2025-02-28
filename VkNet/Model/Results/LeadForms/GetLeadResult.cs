using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Lead.
/// </summary>
[Serializable]
public class GetLeadResult
{
	/// <summary>
	/// идентификатор заявки
	/// </summary>
	[JsonPropertyName("lead_id")]
	public long LeadId { get; set; }

	/// <summary>
	/// идентификатор пользователя, оставившего заявку
	/// </summary>
	[JsonPropertyName("user_id")]
	public long UserId { get; set; }

	/// <summary>
	/// дата и время оставления заявки в формате unix timestamp
	/// </summary>
	[JsonPropertyName("date")]
	[JsonConverter(typeof(UnixDateTimeConverter))]
	public DateTime Date { get; set; }

	/// <summary>
	/// информация об ответах на вопросы — массив структур со следующими полями
	/// </summary>
	[JsonPropertyName("answers")]
	public ReadOnlyCollection<LeadAnswerInfo> Answers { get; set; }

	/// <summary>
	/// идентификатор рекламного объявления, с которого пришла заявка (поле отсутствует в случае, если заявка пришла не из рекламного объявления).
	/// </summary>
	[JsonPropertyName("ad_id")]
	public long? AdId { get; set; }
}