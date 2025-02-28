using System;
using System.Text.Json.Serialization;
using VkNet.Enums.StringEnums;

namespace VkNet.Model;

/// <summary>
/// Информация о текущем роде занятия пользователя.
/// </summary>
[Serializable]
public class Occupation
{
	/// <summary>
	/// Название школы, вуза или места работы
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; }

	/// <summary>
	/// Идентификатор школы, вуза, группы компании (в которой пользователь работает).
	/// </summary>
	[JsonPropertyName("id")]
	public long? Id { get; set; }

	/// <summary>
	/// Информация о текущем роде занятия пользователя.
	/// </summary>
	[JsonPropertyName("type")]
	public OccupationType? Type { get; set; }
}