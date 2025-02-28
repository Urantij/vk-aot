using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using VkNet.Enums;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Аудиозапись пользователя или группы.
/// См. описание http://vk.com/dev/audio_object
/// </summary>
[Serializable]
public class Audio : MediaAttachment, IGroupUpdate
{
	/// <inheritdoc />
	protected override string Alias => "audio";

	/// <summary>
	/// Исполнитель аудиозаписи.
	/// </summary>
	[JsonPropertyName("artist")]
	public string Artist { get; set; }

	/// <summary>
	/// Название композиции.
	/// </summary>
	[JsonPropertyName("title")]
	public string Title { get; set; }

	/// <summary>
	/// Длительность аудиозаписи в секундах.
	/// </summary>
	[JsonPropertyName("duration")]
	public int Duration { get; set; }

	/// <summary>
	/// Дата добавления.
	/// </summary>
	[JsonConverter(typeof(UnixDateTimeConverter))]
	[JsonPropertyName("date")]
	public DateTime Date { get; set; }

	/// <summary>
	/// Ссылка на аудиозапись (привязана к ip-адресу клиентского приложения).
	/// </summary>
	[JsonPropertyName("url")]
	public Uri Url { get; set; }

	/// <summary>
	/// Альбом аудиозаписи.
	/// </summary>
	[JsonPropertyName("album")]
	public AudioAlbum Album { get; set; }

	/// <summary>
	/// <c>true</c>, если аудиозапись лицензируется.
	/// </summary>
	[JsonPropertyName("is_licensed")]
	public bool? IsLicensed { get; set; }

	/// <summary>
	/// <c>true</c>, если аудиозапись в высоком качестве.
	/// </summary>
	[JsonPropertyName("is_hq")]
	public bool? IsHq { get; set; }

	/// <summary>
	/// Жанр аудиозаписи.
	/// </summary>
	[JsonPropertyName("track_genre_id")]
	public AudioGenre? TrackGenre { get; set; }

	/// <summary>
	/// Жанр аудиозаписи.
	/// </summary>
	[JsonPropertyName("genre")]
	public AudioGenre? Genre { get; set; }

	/// <summary>
	/// Идентификатор текста аудиозаписи (если доступно).
	/// </summary>
	[JsonPropertyName("lyrics_id")]
	public long? LyricsId { get; set; }

	/// <summary>
	/// Содержит ли трек ненормативную лексику.
	/// </summary>
	[JsonPropertyName("is_explicit")]
	public bool IsExplicit { get; set; }

	/// <summary>
	/// Получено экспериментально
	/// </summary>
	[JsonPropertyName("is_focus_track")]
	public bool IsFocusTrack { get; set; }

	/// <summary>
	/// Возможно ли использование обложки этого трека в "Историях" (получено экспериментально)
	/// </summary>
	[JsonPropertyName("stories_cover_allowed")]
	public bool? StoriesCoverAllowed { get; set; }

	/// <summary>
	/// Возможно ли использование этого трека в "Историях" (получено экспериментально)
	/// </summary>
	[JsonPropertyName("stories_allowed")]
	public bool? StoriesAllowed { get; set; }

	/// <summary>
	/// Возможно ли использование этого трека в "Клипах" (получено экспериментально)
	/// </summary>
	[JsonPropertyName("short_videos_allowed")]
	public bool? ShortVideosAllowed { get; set; }

	/// <summary>
	/// Список главных исполнителей.
	/// </summary>
	[JsonPropertyName("main_artists")]
	public IEnumerable<AudioArtist> MainArtists { get; set; }

	/// <summary>
	/// Список второстепенных исполнителей.
	/// </summary>
	[JsonPropertyName("featured_artists")]
	public IEnumerable<AudioArtist> FeaturedArtists { get; set; }

	/// <summary>
	/// Подзаголовок(?)  композиции.
	/// </summary>
	[JsonPropertyName("subtitle")]
	public string Subtitle { get; set; }

	/// <summary>
	/// Неизвестно (получено экспериментально).
	/// </summary>
	[JsonPropertyName("track_code")]
	public string TrackCode { get; set; }

	/// <summary>
	/// Неизвестно (получено экспериментально).
	/// </summary>
	[JsonPropertyName("content_restricted")]
	public long ContentRestricted { get; set; }

	[JsonPropertyName("genre_id")]
	private AudioGenre? GenreId
	{
		get => Genre;
		set => Genre = value;
	}
}