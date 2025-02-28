using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Строковая ссылка
/// </summary>
[Serializable]
public class StringLink : MediaAttachment
{
	/// <inheritdoc />
	protected override string Alias => "string";

	/// <summary>
	/// Ссылка
	/// </summary>
	[JsonPropertyName("link")]
	public string Link { get; set; }

	/// <inheritdoc />
	public override string ToString() => Link;
}