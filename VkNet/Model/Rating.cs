using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Рейтинг.
/// </summary>
[Serializable]
public class Rating
{
	/// <summary>
	/// Количество звезд у продукта;.
	/// </summary>
	[JsonPropertyName("stars")]
	public long? Stars { get; set; }

	/// <summary>
	/// Количество отзывов о продукте;.
	/// </summary>
	[JsonPropertyName("reviews_count")]
	public long? ReviewsCount { get; set; }
}