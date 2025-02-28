using System;
using System.Text.Json.Serialization;
using VkNet.Enums;

namespace VkNet.Model;

/// <summary>
/// Информация о вики-странице сообщества.
/// См. описание http://vk.com/dev/pages.get
/// </summary>
[Serializable]
public class Page : MediaAttachment
{
	/// <inheritdoc />
	protected override string Alias => "page";

	/// <summary>
	/// Идентификатор сообщества.
	/// </summary>
	[JsonPropertyName("group_id")]
	public long? GroupId { get; set; }

	/// <summary>
	/// Идентификатор создателя страницы.
	/// </summary>
	[JsonPropertyName("creator_id")]
	public long? CreatorId { get; set; }

	/// <summary>
	/// Название страницы.
	/// </summary>
	[JsonPropertyName("title")]
	public string Title { get; set; }

	/// <summary>
	/// Указывает, может ли текущий пользователь редактировать текст страницы.
	/// </summary>
	[JsonPropertyName("current_user_can_edit")]
	public bool CurrentUserCanEdit { get; set; }

	/// <summary>
	/// Указывает, может ли текущий пользователь изменять права доступа на страницу.
	/// </summary>
	[JsonPropertyName("current_user_can_edit_access")]
	public bool CurrentUserCanEditAccess { get; set; }

	/// <summary>
	/// Указывает, кто может просматривать вики-страницу.
	/// </summary>
	[JsonPropertyName("who_can_view")]
	public PageAccessKind? WhoCanView { get; set; }

	/// <summary>
	/// Указывает, кто может редактировать вики-страницу.
	/// </summary>
	[JsonPropertyName("who_can_edit")]
	public PageAccessKind? WhoCanEdit { get; set; }

	/// <summary>
	/// Дата последнего изменения (в виде строки).
	/// </summary>
	[JsonPropertyName("edited")]
	public string Edited { get; set; }

	/// <summary>
	/// Дата создания страницы (в виде строки).
	/// </summary>
	[JsonPropertyName("created")]
	public string Created { get; set; }

	/// <summary>
	/// Идентификатор пользователя, который редактировал страницу последним.
	/// </summary>
	[JsonPropertyName("editor_id")]
	public long? EditorId { get; set; }

	/// <summary>
	/// Количество просмотров вики-страницы.
	/// </summary>
	[JsonPropertyName("views")]
	public long? Views { get; set; }

	/// <summary>
	/// Заголовок родительской страницы для навигации,если есть.
	/// </summary>
	[JsonPropertyName("parent")]
	public string Parent { get; set; }

	/// <summary>
	/// Заголовок второй родительской страницы для навигации, если есть.
	/// </summary>
	[JsonPropertyName("parent2")]
	public string Parent2 { get; set; }

	/// <summary>
	/// Текст страницы в вики-формате.
	/// </summary>
	[JsonPropertyName("source")]
	public string Source { get; set; }

	/// <summary>
	/// Html-текст страницы.
	/// </summary>
	[JsonPropertyName("html")]
	public string Html { get; set; }

	/// <summary>
	/// Адрес страницы для отображения вики-страницы.
	/// </summary>
	[JsonPropertyName("view_url")]
	public string ViewUrl { get; set; }

	#region Поля, установленные экспериментально

	/// <summary>
	/// Gets or sets the version created.
	/// </summary>
	[JsonPropertyName("version_created")]
	public string VersionCreated { get; set; }

	#endregion

	[JsonPropertyName("page_id")]
	private long? PageId
	{
		get => Id;
		set => Id = value;
	}

	[JsonPropertyName("pid")]
	private long? Pid
	{
		get => Id;
		set => Id = value;
	}

	[JsonPropertyName("gid")]
	private long? Gid
	{
		get => GroupId;
		set => GroupId = value;
	}

	/// <inheritdoc />
	public override string ToString() => string.Format("page-{0}_{1}",
		GroupId,
		Id);
}