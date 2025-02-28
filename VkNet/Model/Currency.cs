using System;
using System.Text.Json.Serialization;
using VkNet.Utils;

namespace VkNet.Model;

/// <summary>
/// Валюта.
/// </summary>
[Serializable]
public class Currency
{
	/// <summary>
	/// Идентификатор валюты
	/// </summary>
	[JsonPropertyName("id")]
	public long? Id { get; set; }

	/// <summary>
	/// Буквенное обозначение валюты
	/// </summary>
	[Obsolete(ObsoleteText.ObsoleteCyrillicProperty)]
	[JsonPropertyName("currency")]
	public string Сurrency { get; set; }

	/// <summary>
	/// Буквенное обозначение валюты
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; }
}