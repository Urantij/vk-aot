using System;
using System.Text.Json.Serialization;
using VkNet.Enums.SafetyEnums;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// История
/// </summary>
[Serializable]
public class Story : MediaAttachment
{
	/// <inheritdoc />
	protected override string Alias => "story";

	/// <summary>
	/// Дата добавления в Unixtime.
	/// </summary>
	[JsonPropertyName("date")]
	[JsonConverter(typeof(UnixDateTimeConverter))]
	public DateTime? Date { get; set; }

	/// <summary>
	/// <c>true</c>, если срок хранения истории истёк.
	/// </summary>
	[JsonPropertyName("is_expired")]
	public bool? IsExpired { get; set; }

	/// <summary>
	/// <c>true</c>, если история удалена или не существует.
	/// </summary>
	[JsonPropertyName("is_deleted")]
	public bool? IsDeleted { get; set; }

	/// <summary>
	/// Информация о том, может ли пользователь просмотреть историю.
	/// </summary>
	[JsonPropertyName("can_see")]
	public bool CanSee { get; set; }

	/// <summary>
	/// <c>true</c>, если история просмотрена текущим пользователем.
	/// </summary>
	[JsonPropertyName("seen")]
	public bool? Seen { get; set; }

	/// <summary>
	/// Тип истории.
	/// </summary>
	[JsonPropertyName("type")]
	[JsonConverter(typeof(SafetyEnumJsonConverter))]
	public StoryType Type { get; set; }

	/// <summary>
	/// Фотография из истории.
	/// </summary>
	[JsonPropertyName("photo")]
	public Photo Photo { get; set; }

	/// <summary>
	/// Видео из истории.
	/// </summary>
	[JsonPropertyName("video")]
	public Video Video { get; set; }

	/// <summary>
	/// Ссылка для перехода из истории.
	/// </summary>
	[JsonPropertyName("link")]
	public StoryLink Link { get; set; }

	/// <summary>
	/// Идентификатор пользователя, загрузившего историю, ответом на которую является
	/// текущая.
	/// </summary>
	[JsonPropertyName("parent_story_owner_id")]
	public long? ParentStoryOwnerId { get; set; }

	/// <summary>
	/// Идентификатор истории, ответом на которую является текущая.
	/// </summary>
	[JsonPropertyName("parent_story_id")]
	public long? ParentStoryId { get; set; }

	/// <summary>
	/// Родительская история.
	/// </summary>
	[JsonPropertyName("parent_story")]
	public Story ParentStory { get; set; }

	/// <summary>
	/// Информация об ответах на текущую историю.
	/// </summary>
	[JsonPropertyName("replies")]
	public StoryReplies Replies { get; set; }

	/// <summary>
	/// Информация о том, может ли пользователь ответить на историю .
	/// </summary>
	[JsonPropertyName("can_reply")]
	public bool? CanReply { get; set; }

	/// <summary>
	/// Информация о том, может ли пользователь расшарить историю.
	/// </summary>
	[JsonPropertyName("can_share")]
	public bool? CanShare { get; set; }

	/// <summary>
	/// Информация о том, может ли пользователь комментировать историю.
	/// </summary>
	[JsonPropertyName("can_comment")]
	public bool? CanComment { get; set; }

	/// <summary>
	/// Число просмотров.
	/// </summary>
	[JsonPropertyName("views")]
	public int? Views { get; set; }
}