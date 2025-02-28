using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using VkNet.Enums.StringEnums;

namespace VkNet.Model;

/// <summary>
/// Информация о каталоге.
/// </summary>
[Serializable]
public class AudioCatalog
{
	/// <summary>
	/// Название каталога.
	/// </summary>
	[JsonPropertyName("title")]
	public string Title { get; set; }

	/// <summary>
	/// Подзаголовок каталога.
	/// </summary>
	[JsonPropertyName("subtitle")]
	public string Subtitle { get; set; }

	/// <summary>
	/// Тип каталога.
	/// </summary>
	[JsonPropertyName("type")]
	public AudioCatalogType? Type { get; set; }

	/// <summary>
	/// Количество каталогов.
	/// </summary>
	[JsonPropertyName("count")]
	public long Count { get; set; }

	/// <summary>
	/// Источник каталога.
	/// </summary>
	[JsonPropertyName("source")]
	public AudioCatalogSourceType? Source { get; set; }

	/// <summary>
	/// Идентификатор каталога.
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; set; }

	/// <summary>
	/// Идентификатор на следующуюю пачку.
	/// </summary>
	[JsonPropertyName("next_from")]
	public string NextFrom { get; set; }

	/// <summary>
	/// Аудиозаписи.
	/// </summary>
	[JsonPropertyName("audios")]
	public ReadOnlyCollection<AudioCatalogAudio> Audios { get; set; }

	/// <summary>
	/// Обложки.
	/// </summary>
	[JsonPropertyName("thumbs")]
	public ReadOnlyCollection<AudioCover> Thumbs { get; set; }

	/// <summary>
	/// Плейлисты.
	/// </summary>
	[JsonPropertyName("playlists")]
	public ReadOnlyCollection<AudioPlaylist> Playlists { get; set; }

	/// <summary>
	/// Ссылка на аудиозаписи друзей/сообщества.
	/// </summary>
	[JsonPropertyName("items")]
	public ReadOnlyCollection<AudioCatalogItem> Items { get; set; }
}