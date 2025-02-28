using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Обобщенная модель ответа vk
/// </summary>
/// <typeparam name="TModel">Тип ответа</typeparam>
[Serializable]
public class VkResponseObject<TModel>
{
	/// <summary>
	/// Response
	/// </summary>
	[JsonPropertyName("response")]
	public TModel Response { get; set; }
}