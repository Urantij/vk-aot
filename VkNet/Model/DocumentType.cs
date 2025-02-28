using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Тип документа.
/// </summary>
[Serializable]
public class DocumentType
{
	/// <summary>
	/// Идентификатор полученного подарка.
	/// </summary>
	[JsonPropertyName("id")]
	public long Id { get; set; }

	/// <summary>
	/// Текст сообщения, приложенного к подарку.
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; }

	/// <summary>
	/// Количество документов данного типа.
	/// </summary>
	[JsonPropertyName("count")]
	public long Count { get; set; }
}