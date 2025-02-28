using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Город.
/// </summary>
/// <remarks>
/// Страница документации ВКонтакте http://vk.com/dev/database.getCities
/// </remarks>
[Serializable]
public class City
{
	/// <summary>
	/// Идентификатор города.
	/// </summary>
	[JsonPropertyName("id")]
	public long? Id { get; set; }

	/// <summary>
	/// Название города.
	/// </summary>
	[JsonPropertyName("title")]
	public string Title { get; set; }

	/// <summary>
	/// Район.
	/// </summary>
	[JsonPropertyName("area")]
	public string Area { get; set; }

	/// <summary>
	/// Область.
	/// </summary>
	[JsonPropertyName("region")]
	public string Region { get; set; }

	/// <summary>
	/// Является ли город основным.
	/// </summary>
	[JsonPropertyName("important")]
	public bool Important { get; set; }

	[JsonPropertyName("comment_id")]
	private long? CommentId
	{
		get => Id;
		set => Id = value;
	}

	[JsonPropertyName("cid")]
	private long? Cid
	{
		get => Id;
		set => Id = value;
	}

	[JsonPropertyName("name")]
	private string Name
	{
		get => Title;
		set => Title = value;
	}
}