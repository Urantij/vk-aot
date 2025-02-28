using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Регион
/// </summary>
[Serializable]
public class Region
{
	/// <summary>
	/// Идентификатор региона
	/// </summary>
	[JsonPropertyName("id")]
	public int Id { get; set; }

	/// <summary>
	/// Идентификатор региона
	/// </summary>
	[JsonPropertyName("region_id")]
	public int RegionId
	{
		get => Id;
		set => Id = value;
	}


	/// <summary>
	/// Название региона
	/// </summary>
	[JsonPropertyName("title")]
	public string Title { get; set; }
}