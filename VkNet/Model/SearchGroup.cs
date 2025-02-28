using System;
using System.Text.Json.Serialization;
using VkNet.Enums;
using VkNet.Enums.StringEnums;

namespace VkNet.Model;

/// <summary>
/// данные о сообществе.
/// </summary>
[Serializable]
public class SearchGroup
{
	/// <summary>
	/// идентификатор сообщества
	/// </summary>
	[JsonPropertyName("id")]
	public long Id { get; set; }

	/// <summary>
	/// название сообщества
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; }

	/// <summary>
	/// короткий адрес
	/// </summary>
	[JsonPropertyName("screen_name")]
	public string ScreenName { get; set; }

	/// <summary>
	/// информация о том, является ли группа/встреча закрытой (0 — открытая, 1 —
	/// закрытая, 2 — частная)
	/// </summary>
	[JsonPropertyName("is_closed")]
	public GroupAccess IsClosed { get; set; }

	/// <summary>
	/// информация о том, является ли текущий пользователь администратором сообщества
	/// (1 — является, 0 — не является);
	/// </summary>
	[JsonPropertyName("is_admin")]
	public bool? IsAdmin { get; set; }

	/// <summary>
	/// информация о том, является ли текущий пользователь участником сообщества (1 —
	/// является, 0 — не является)
	/// </summary>
	[JsonPropertyName("is_member")]
	public bool? IsMember { get; set; }

	/// <summary>
	/// тип сообщества
	/// </summary>
	[JsonPropertyName("type")]
	public GroupType? Type { get; set; }

	/// <summary>
	/// URL квадратной фотографии сообщества с размером 50х50px
	/// </summary>
	[JsonPropertyName("photo")]
	public string Photo { get; set; }

	/// <summary>
	/// URL квадратной фотографии сообщества с размером 50х50px
	/// </summary>
	[JsonPropertyName("photo_50")]
	private string Photo50
	{
		get => Photo;
		set => Photo = value;
	}

	/// <summary>
	/// URL квадратной фотографии сообщества с размером 100х100px
	/// </summary>
	[JsonPropertyName("photo_medium")]
	public string PhotoMedium { get; set; }

	/// <summary>
	/// URL квадратной фотографии сообщества с размером 100х100px
	/// </summary>
	[JsonPropertyName("photo_100")]
	private string Photo100
	{
		get => PhotoMedium;
		set => PhotoMedium = value;
	}

	/// <summary>
	/// URL фотографии сообщества в максимальном доступном размере.
	/// </summary>
	[JsonPropertyName("photo_big")]
	public string PhotoBig { get; set; }

	/// <summary>
	/// URL фотографии сообщества в максимальном доступном размере.
	/// </summary>
	[JsonPropertyName("photo_200")]
	public string Photo200
	{
		get => PhotoBig;
		set => PhotoBig = value;
	}
}