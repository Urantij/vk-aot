using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// E-Mail.
/// </summary>
[Serializable]
public class Email
{
	/// <summary>
	/// Идентификатор e-mail
	/// </summary>
	[JsonPropertyName("id")]
	public int Id { get; set; }

	/// <summary>
	/// Адрес e-mail
	/// </summary>
	[JsonPropertyName("address")]
	public string Address { get; set; }
}