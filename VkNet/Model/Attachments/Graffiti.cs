using System;
using System.Text.Json.Serialization;
using JetBrains.Annotations;

namespace VkNet.Model;

/// <summary>
/// Граффити.
/// См. описание http://vk.com/dev/attachments_w
/// </summary>
[Serializable]
public class Graffiti : MediaAttachment
{
	/// <inheritdoc />
	protected override string Alias => "graffiti";

	/// <summary>
	/// Адрес изображения для предпросмотра.
	/// </summary>
	[Obsolete("Это свойство устарело, используйте Uri Url")]
	[JsonPropertyName("photo_200")]
	[CanBeNull]
	public string Photo200 { get; set; }

	/// <summary>
	/// Адрес полноразмерного изображения.
	/// </summary>
	[Obsolete("Это свойство устарело, используйте Uri Url")]
	[JsonPropertyName("photo_586")]
	[CanBeNull]
	public string Photo586 { get; set; }

	/// <summary>
	/// Адрес граффити, по которому его можно загрузить.
	/// </summary>
	[JsonPropertyName("url")]
	[CanBeNull]
	public Uri Url { get; set; }

	/// <summary>
	/// Ширина изображения в px.
	/// </summary>
	[JsonPropertyName("width")]
	public int? Width { get; set; }

	/// <summary>
	/// Высота изображения в px.
	/// </summary>
	[JsonPropertyName("height")]
	public int? Height { get; set; }
}