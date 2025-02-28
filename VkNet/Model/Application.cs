using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Приложение.
/// </summary>
[Serializable]
public class Application
{
	/// <summary>
	/// Магазин.
	/// </summary>
	[JsonPropertyName("store")]
	public Store Store { get; set; }

	/// <summary>
	/// Идентификатор приложения в магазине.
	/// </summary>
	[JsonPropertyName("app_id")]
	public long? AppId { get; set; }
}