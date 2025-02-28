using System;
using System.Diagnostics;
using System.Text.Json.Serialization;
using VkNet.Enums;

namespace VkNet.Model;

/// <summary>
/// Определяет тип объекта
/// </summary>
[DebuggerDisplay(value: "Id = {Id}, Type = {Type}")]
[Serializable]
public class VkObject
{
	/// <summary>
	/// Идентификатор объекта
	/// </summary>
	[JsonPropertyName("object_id")]
	public long? Id { get; set; }

	/// <summary>
	/// Тип объекта
	/// </summary>
	[JsonPropertyName("type")]
	[JsonConverter(typeof(JsonStringEnumConverter<VkObjectType>))]
	public VkObjectType Type { get; set; }
}