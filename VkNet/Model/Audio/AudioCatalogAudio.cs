using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Информация об аудиозаписи каталога.
/// </summary>
[Serializable]
public class AudioCatalogAudio
{
	/// <summary>
	/// Имя исполнителя.
	/// </summary>
	[JsonPropertyName("artist")]
	public string Artist { get; set; }

	/// <summary>
	/// Идентификатор владельца аудиозаписи.
	/// </summary>
	[JsonPropertyName("owner_id")]
	public long OwnerId { get; set; }

	/// <summary>
	/// Название альбома.
	/// </summary>
	[JsonPropertyName("title")]
	public string Title { get; set; }

	/// <summary>
	/// Длительность.
	/// </summary>
	[JsonPropertyName("duration")]
	public int Duration { get; set; }

	/// <summary>
	/// Идентификатор.
	/// </summary>
	[JsonPropertyName("id")]
	public long Id { get; set; }

	/// <summary>
	/// Ключ доступа.
	/// </summary>
	[JsonPropertyName("access_key")]
	public string AccessKey { get; set; }

	/// <summary>
	/// Реклама.
	/// </summary>
	[JsonPropertyName("ads")]
	public AudioCatalogAudioAds Ads { get; set; }

	/// <summary>
	/// Ключ доступа.
	/// </summary>
	[JsonPropertyName("is_explicit")]
	public bool IsExplicit { get; set; }

	/// <summary>
	/// Реклама.
	/// </summary>
	[JsonPropertyName("is_focus_track")]
	public bool IsFocusTrack { get; set; }

	/// <summary>
	/// Ключ доступа.
	/// </summary>
	[JsonPropertyName("track_code")]
	public string TrackCode { get; set; }

	/// <summary>
	/// Реклама.
	/// </summary>
	[JsonPropertyName("url")]
	public string Url { get; set; }

	/// <summary>
	/// Ключ доступа.
	/// </summary>
	[JsonPropertyName("date")]
	[JsonConverter(typeof(UnixDateTimeConverter))]
	public DateTime Date { get; set; }

	/// <summary>
	/// Альбом.
	/// </summary>
	[JsonPropertyName("album")]
	public AudioAlbum Album { get; set; }

	/// <summary>
	/// Главные исполнители.
	/// </summary>
	[JsonPropertyName("main_artists")]
	public ReadOnlyCollection<AudioArtist> MainArtists { get; set; }

	/// <summary>
	/// Вторичные исполнители.
	/// </summary>
	[JsonPropertyName("featured_artists")]
	public ReadOnlyCollection<AudioArtist> FeaturedArtists { get; set; }

	/// <summary>
	/// Разрешены ли истории.
	/// </summary>
	[JsonPropertyName("stories_allowed")]
	public bool StoriesAllowed { get; set; }
}