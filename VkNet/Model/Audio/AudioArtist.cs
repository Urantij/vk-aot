using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Информация об артисте/группе.
/// </summary>
[Serializable]
public class AudioArtist
{
	/// <summary>
	/// Идентификатор артиста/группы.
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; set; }

	/// <summary>
	/// Имя артиста/название группы.
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; }

	/// <summary>
	/// Неизвестно (получено экспериментально).
	/// </summary>
	[JsonPropertyName("domain")]
	public string Domain { get; set; }
}