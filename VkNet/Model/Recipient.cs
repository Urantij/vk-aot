using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Информация о покупател.
/// </summary>
[Serializable]
public class Recipient
{
	/// <summary>
	/// имя покупателя.
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; }

	/// <summary>
	/// номер покупателя..
	/// </summary>
	[JsonPropertyName("phone")]
	public string Phone { get; set; }

	/// <summary>
	///  строковое представление информации о покупателе.
	/// </summary>
	[JsonPropertyName("display_text")]
	public string DisplayText  { get; set; }

}