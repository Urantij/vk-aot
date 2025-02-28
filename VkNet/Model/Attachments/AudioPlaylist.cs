using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using VkNet.Enums.StringEnums;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Плейлист.
/// </summary>
[Serializable]
public class AudioPlaylist : MediaAttachment
{
	/// <inheritdoc />
	protected override string Alias => "audio_playlist";

	/// <summary>
	/// Тип плейлиста.
	/// </summary>
	[JsonPropertyName("album_type")]
	public AudioAlbumType? AlbumType { get; set; }

	/// <summary>
	/// Тип плейлиста.
	/// </summary>
	[JsonPropertyName("type")]
	public long Type { get; set; }

	/// <summary>
	/// Название плейлиста.
	/// </summary>
	[JsonPropertyName("title")]
	public string Title { get; set; }

	/// <summary>
	/// Описание плейлиста.
	/// </summary>
	[JsonPropertyName("description")]
	public string Description { get; set; }

	/// <summary>
	/// Список жанров плейлиста.
	/// </summary>
	[JsonPropertyName("genres")]
	public ReadOnlyCollection<AudioPlaylistGenre> Genres { get; set; }

	/// <summary>
	/// Количество аудиозаписей в плейлисте.
	/// </summary>
	[JsonPropertyName("count")]
	public long Count { get; set; }

	/// <summary>
	/// true, если плейлист добавлен в аудиозаписи.
	/// </summary>
	[JsonPropertyName("is_following")]
	public bool IsFollowing { get; set; }

	/// <summary>
	/// Количество добавлений плейлиста.
	/// </summary>
	[JsonPropertyName("followers")]
	public long Followers { get; set; }

	/// <summary>
	/// Общее количество проигрываний плейлиста.
	/// </summary>
	[JsonPropertyName("plays")]
	public long Plays { get; set; }

	/// <summary>
	/// Дата создания плейлиста.
	/// </summary>
	[JsonConverter(typeof(UnixDateTimeConverter))]
	[JsonPropertyName("create_time")]
	public DateTime CreateTime { get; set; }

	/// <summary>
	/// Дата обновления плейлиста.
	/// </summary>
	[JsonConverter(typeof(UnixDateTimeConverter))]
	[JsonPropertyName("update_time")]
	public DateTime UpdateTime { get; set; }

	/// <summary>
	/// Год выпуска альбома.
	/// </summary>
	[JsonPropertyName("year")]
	public long? Year { get; set; }

	/// <summary>
	/// Неизвестно.
	/// </summary>
	[JsonPropertyName("original")]
	public AudioPlaylistOriginal Original { get; set; }

	/// <summary>
	/// Информация о подписчике плейлиста.
	/// </summary>
	[JsonPropertyName("followed")]
	public AudioPlaylistFollower Follower { get; set; }

	/// <summary>
	/// Обложка плейлиста.
	/// </summary>
	[JsonPropertyName("photo")]
	public AudioCover Photo { get; set; }

	/// <summary>
	/// Миниатюры плейлиста.
	/// </summary>
	[JsonPropertyName("thumbs")]
	public ReadOnlyCollection<AudioCover> Thumbs { get; set; }

	/// <summary>
	/// Неизвестно.
	/// </summary>
	[JsonPropertyName("display_owner_ids")]
	public ReadOnlyCollection<long> OwnerIds { get; set; }

	/// <summary>
	/// Главный исполнитель.
	/// </summary>
	[Obsolete("Use MainArtists property instead.")]
	[JsonPropertyName("main_artist")]
	public string MainArtist { get; set; }

	/// <summary>
	/// Список исполнителей.
	/// </summary>
	[Obsolete("Use MainArtists property instead.")]
	[JsonPropertyName("artists")]
	public ReadOnlyCollection<AudioArtist> Artists { get; set; }

	/// <summary>
	/// Список исполнителей.
	/// </summary>
	[JsonPropertyName("main_artists")]
	public ReadOnlyCollection<AudioArtist> MainArtists { get; set; }

	/// <summary>
	/// Список исполнителей.
	/// </summary>
	[JsonPropertyName("featured_artists")]
	public ReadOnlyCollection<AudioArtist> FeaturedArtists { get; set; }

	/// <summary>
	/// Являетя ли откровенным контентом.
	/// </summary>
	[JsonPropertyName("is_explicit")]
	public bool IsExplicit { get; set; }
}