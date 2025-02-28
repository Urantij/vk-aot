using System;
using System.Text.Json.Serialization;
using VkNet.Abstractions;

namespace VkNet.Model;

/// <summary>
/// Параметры метода <see cref="IGroupsCategory"/>.<see cref="IGroupsCategoryAsync.SetLongPollSettingsAsync"/>
/// </summary>
[Serializable]
public class SetLongPollSettingsParams
{
	/// <summary>
	/// Идентификатор сообщества. положительное число, обязательный параметр
	/// </summary>
	[JsonPropertyName("group_id")]
	public ulong GroupId { get; set; }

	/// <summary>
	/// Версия API строка
	/// </summary>
	[JsonPropertyName("api_version")]
	public string ApiVersion { get; set; }

	/// <summary>
	/// 1 — включить Bots Long Poll, 0 — отключить. флаг, может принимать значения 1 или 0
	/// </summary>
	[JsonPropertyName("enabled")]
	public bool Enabled { get; set; }

	/// <summary>
	/// Уведомления о новых сообщениях (0 — выключить, 1 — включить). флаг, может принимать значения 1 или 0
	/// </summary>
	[JsonPropertyName("message_new")]
	public bool MessageNew { get; set; }

	/// <summary>
	/// Уведомления об исходящем сообщении (0 — выключить, 1 — включить). флаг, может принимать значения 1 или 0
	/// </summary>
	[JsonPropertyName("message_reply")]
	public bool MessageReply { get; set; }

	/// <summary>
	/// Уведомления о подписке на сообщения  (0 — выключить, 1 — включить). флаг, может принимать значения 1 или 0
	/// </summary>
	[JsonPropertyName("message_allow")]
	public bool MessageAllow { get; set; }

	/// <summary>
	/// Уведомления о запрете на сообщения (0 — выключить, 1 — включить). флаг, может принимать значения 1 или 0
	/// </summary>
	[JsonPropertyName("message_deny")]
	public bool MessageDeny { get; set; }

	/// <summary>
	/// Уведомления о редактировании сообщения (0 — выключить, 1 — включить). флаг, может принимать значения 1 или 0
	/// </summary>
	[JsonPropertyName("message_edit")]
	public bool MessageEdit { get; set; }

	/// <summary>
	/// Флаг, может принимать значения 1 или 0
	/// </summary>
	[JsonPropertyName("message_typing_state")]
	public bool MessageTypingState { get; set; }

	/// <summary>
	/// Уведомления о добавлении новой фотографии (0 — выключить, 1 — включить). флаг, может принимать значения 1 или 0
	/// </summary>
	[JsonPropertyName("photo_new")]
	public bool PhotoNew { get; set; }

	/// <summary>
	/// Уведомления о добавлении новой аудиозаписи (0 — выключить, 1 — включить). флаг, может принимать значения 1 или 0
	/// </summary>
	[JsonPropertyName("audio_new")]
	public bool AudioNew { get; set; }

	/// <summary>
	/// Уведомления о добавлении новой видеозаписи (0 — выключить, 1 — включить). флаг, может принимать значения 1 или 0
	/// </summary>
	[JsonPropertyName("video_new")]
	public bool VideoNew { get; set; }

	/// <summary>
	/// Уведомления о добавлении нового комментария на стене (0 — выключить, 1 — включить). флаг, может принимать значения 1 или 0
	/// </summary>
	[JsonPropertyName("wall_reply_new")]
	public bool WallReplyNew { get; set; }

	/// <summary>
	/// Уведомления о редактировании комментария на стене (0 — выключить, 1 — включить). флаг, может принимать значения 1 или 0
	/// </summary>
	[JsonPropertyName("wall_reply_edit")]
	public bool WallReplyEdit { get; set; }

	/// <summary>
	/// Уведомления об удалении комментария на стене (0 — выключить, 1 — включить). флаг, может принимать значения 1 или 0
	/// </summary>
	[JsonPropertyName("wall_reply_delete")]
	public bool WallReplyDelete { get; set; }

	/// <summary>
	/// Уведомления о восстановлении комментария на стене (0 — выключить, 1 — включить). флаг, может принимать значения 1 или 0
	/// </summary>
	[JsonPropertyName("wall_reply_restore")]
	public bool WallReplyRestore { get; set; }

	/// <summary>
	/// Уведомления о новой записи на стене (0 — выключить, 1 — включить). флаг, может принимать значения 1 или 0
	/// </summary>
	[JsonPropertyName("wall_post_new")]
	public bool WallPostNew { get; set; }

	/// <summary>
	/// Уведомления о репосте записи (0 — выключить, 1 — включить). флаг, может принимать значения 1 или 0
	/// </summary>
	[JsonPropertyName("wall_repost")]
	public bool WallRepost { get; set; }

	/// <summary>
	/// Уведомления о создании комментария в обсуждении (0 — выключить, 1 — включить). флаг, может принимать значения 1 или 0
	/// </summary>
	[JsonPropertyName("board_post_new")]
	public bool BoardPostNew { get; set; }

	/// <summary>
	/// Уведомления о редактировании комментария в обсуждении (0 — выключить, 1 — включить). флаг, может принимать значения 1 или 0
	/// </summary>
	[JsonPropertyName("board_post_edit")]
	public bool BoardPostEdit { get; set; }

	/// <summary>
	/// Уведомление о восстановлении комментария в обсуждении (0 — выключить, 1 — включить). флаг, может принимать значения 1 или 0
	/// </summary>
	[JsonPropertyName("board_post_restore")]
	public bool BoardPostRestore { get; set; }

	/// <summary>
	/// Уведомления об удалении комментария в обсуждении (0 — выключить, 1 — включить). флаг, может принимать значения 1 или 0
	/// </summary>
	[JsonPropertyName("board_post_delete")]
	public bool BoardPostDelete { get; set; }

	/// <summary>
	/// Уведомления о добавлении нового комментария к фото (0 — выключить, 1 — включить). флаг, может принимать значения 1 или 0
	/// </summary>
	[JsonPropertyName("photo_comment_new")]
	public bool PhotoCommentNew { get; set; }

	/// <summary>
	/// Уведомления о редактировании комментария к фото (0 — выключить, 1 — включить). флаг, может принимать значения 1 или 0
	/// </summary>
	[JsonPropertyName("photo_comment_edit")]
	public bool PhotoCommentEdit { get; set; }

	/// <summary>
	/// Уведомления об удалении комментария к фото (0 — выключить, 1 — включить). флаг, может принимать значения 1 или 0
	/// </summary>
	[JsonPropertyName("photo_comment_delete")]
	public bool PhotoCommentDelete { get; set; }

	/// <summary>
	/// Уведомления о восстановлении комментария к фото (0 — выключить, 1 — включить). флаг, может принимать значения 1 или 0
	/// </summary>
	[JsonPropertyName("photo_comment_restore")]
	public bool PhotoCommentRestore { get; set; }

	/// <summary>
	/// Уведомления о добавлении нового комментария к видео (0 — выключить, 1 — включить). флаг, может принимать значения 1 или 0
	/// </summary>
	[JsonPropertyName("video_comment_new")]
	public bool VideoCommentNew { get; set; }

	/// <summary>
	/// Уведомления о редактировании комментария к видео (0 — выключить, 1 — включить). флаг, может принимать значения 1 или 0
	/// </summary>
	[JsonPropertyName("video_comment_edit")]
	public bool VideoCommentEdit { get; set; }

	/// <summary>
	/// Уведомления об удалении комментария к видео (0 — выключить, 1 — включить). флаг, может принимать значения 1 или 0
	/// </summary>
	[JsonPropertyName("video_comment_delete")]
	public bool VideoCommentDelete { get; set; }

	/// <summary>
	/// Уведомления о восстановлении комментария к видео (0 — выключить, 1 — включить). флаг, может принимать значения 1 или 0
	/// </summary>
	[JsonPropertyName("video_comment_restore")]
	public bool VideoCommentRestore { get; set; }

	/// <summary>
	/// Уведомления о добавлении нового комментария к товару (0 — выключить, 1 — включить). флаг, может принимать значения 1 или 0
	/// </summary>
	[JsonPropertyName("market_comment_new")]
	public bool MarketCommentNew { get; set; }

	/// <summary>
	/// Уведомления о редактировании комментария к товару (0 — выключить, 1 — включить). флаг, может принимать значения 1 или 0
	/// </summary>
	[JsonPropertyName("market_comment_edit")]
	public bool MarketCommentEdit { get; set; }

	/// <summary>
	/// Уведомления об удалении комментария к товару (0 — выключить, 1 — включить). флаг, может принимать значения 1 или 0
	/// </summary>
	[JsonPropertyName("market_comment_delete")]
	public bool MarketCommentDelete { get; set; }

	/// <summary>
	/// Уведомления о восстановлении комментария к товару (0 — выключить, 1 — включить). флаг, может принимать значения 1 или 0
	/// </summary>
	[JsonPropertyName("market_comment_restore")]
	public bool MarketCommentRestore { get; set; }

	/// <summary>
	/// Уведомления о новом голосе в публичных опросах (0 — выключить, 1 — включить). флаг, может принимать значения 1 или 0
	/// </summary>
	[JsonPropertyName("poll_vote_new")]
	public bool PollVoteNew { get; set; }

	/// <summary>
	/// Уведомления о вступлении в сообщество (0 — выключить, 1 — включить). флаг, может принимать значения 1 или 0
	/// </summary>
	[JsonPropertyName("group_join")]
	public bool GroupJoin { get; set; }

	/// <summary>
	/// Уведомления о выходе из сообщества (0 — выключить, 1 — включить). флаг, может принимать значения 1 или 0
	/// </summary>
	[JsonPropertyName("group_leave")]
	public bool GroupLeave { get; set; }

	/// <summary>
	/// Уведомления об изменении настроек (0 — выключить, 1 — включить). флаг, может принимать значения 1 или 0
	/// </summary>
	[JsonPropertyName("group_change_settings")]
	public bool GroupChangeSettings { get; set; }

	/// <summary>
	/// Уведомления об изменении главной фотографии (0 — выключить, 1 — включить). флаг, может принимать значения 1 или 0
	/// </summary>
	[JsonPropertyName("group_change_photo")]
	public bool GroupChangePhoto { get; set; }

	/// <summary>
	/// Уведомления об изменении руководства (0 — выключить, 1 — включить). флаг, может принимать значения 1 или 0
	/// </summary>
	[JsonPropertyName("group_officers_edit")]
	public bool GroupOfficersEdit { get; set; }

	/// <summary>
	/// Уведомления об внесении пользователя в чёрный список (0 — выключить, 1 — включить). флаг, может принимать значения 1 или 0
	/// </summary>
	[JsonPropertyName("user_block")]
	public bool UserBlock { get; set; }

	/// <summary>
	/// Уведомления об исключении пользователя из чёрного списка (0 — выключить, 1 — включить). флаг, может принимать значения 1 или 0
	/// </summary>
	[JsonPropertyName("user_unblock")]
	public bool UserUnblock { get; set; }
}