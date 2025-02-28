using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Результат метода Ads.CreateTargetPixel
/// </summary>
[Serializable]
public class CreateTargetPixelResult
{
	/// <summary>
	/// Идентификатор пикселя
	/// </summary>
	[JsonPropertyName("id")]
	public long Id { get; set; }

	/// <summary>
	/// Код для размещения на сайте рекламодателя
	/// </summary>
	[JsonPropertyName("pixel")]
	public string Pixel { get; set; }
}