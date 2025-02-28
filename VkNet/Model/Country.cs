using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Информация о стране.
/// </summary>
[Serializable]
public class Country
{
	/// <summary>
	/// Идентификатор страны.
	/// </summary>
	[JsonPropertyName("id")]
	public long? Id { get; set; }

	[JsonPropertyName("cid")]
	private long? Cid
	{
		get => Id;
		set => Id = value;
	}

	[JsonPropertyName("comment_id")]
	private long? CommentId
	{
		get => Id;
		set => Id = value;
	}

	/// <summary>
	/// Название страны.
	/// </summary>
	[JsonPropertyName("title")]
	public string Title { get; set; }

	[JsonPropertyName("name")]
	private string Name
	{
		get => Title;
		set => Title = value;
	}
}