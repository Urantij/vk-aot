using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Улица
/// </summary>
[Serializable]
public class Street
{
	/// <summary>
	/// Идентификатор улицы
	/// </summary>
	[JsonPropertyName("id")]
	public long Id { get; set; }

	/// <summary>
	/// Название улицы
	/// </summary>
	[JsonPropertyName("title")]
	public string Title { get; set; }


	[JsonPropertyName("name")]
	private string Name
	{
		get => Title;
		set => Title = value;
	}

	[JsonPropertyName("sid")]
	private long Sid
	{
		get => Id;
		set => Id = value;
	}
}