using System;
using System.Text.Json.Serialization;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Подкаст
/// </summary>
[Serializable]
public class Podcast : MediaAttachment
{
	/// <inheritdoc />
	protected override string Alias => "podcast";

	/// <summary>
	/// Заголовок подкаста
	/// </summary>
	[JsonPropertyName("podcast_title")]
	public string PodcastTitle { get; set; }

	/// <summary>
	/// Исполнитель
	/// </summary>
	[JsonPropertyName("artist")]
	public string Artist { get; set; }

	/// <summary>
	/// Заголовок
	/// </summary>
	[JsonPropertyName("title")]
	public string Title { get; set; }

	/// <summary>
	/// Длительность
	/// </summary>
	[JsonPropertyName("duration")]
	public long? Duration { get; set; }

	/// <summary>
	/// Дата
	/// </summary>
	[JsonPropertyName("date")]
	[JsonConverter(typeof(UnixDateTimeConverter))]
	public DateTime? Date { get; set; }

	/// <summary>
	/// <c>Uri</c> на подкаст
	/// </summary>
	[JsonPropertyName("url")]
	public Uri Url { get; set; }

	/// <summary>
	/// Идентификатор текста песни
	/// </summary>
	[JsonPropertyName("lyrics_id")]
	public long? LyricsId { get; set; }

	/// <summary>
	/// Не искать
	/// </summary>
	[JsonPropertyName("no_search")]
	public bool? NoSearch { get; set; }

	/// <summary>
	/// Высокое качество
	/// </summary>
	[JsonPropertyName("is_hq")]
	public bool? IsHq { get; set; }

	/// <summary>
	/// Явный
	/// </summary>
	[JsonPropertyName("is_explicit")]
	public bool? IsExplicit { get; set; }

	/// <summary>
	/// Информация о подкасте
	/// </summary>
	[JsonPropertyName("podcast_info")]
	public PodcastInfo PodcastInfo { get; set; }

	/// <summary>
	/// Код трека.
	/// </summary>
	[JsonPropertyName("track_code")]
	public string TrackCode { get; set; }
}