using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Медиа вложение.
/// </summary>
[Serializable]
public abstract class MediaAttachment
{
	/// <summary>
	/// Наименование типа которое приходит от vk.com
	/// </summary>
	protected abstract string Alias { get; }

	/// <summary>
	/// Идентификатор вложенеия.
	/// </summary>
	[JsonPropertyName("id")]
	public long? Id { get; set; }

	/// <summary>
	/// Идентификатор владельца вложения.
	/// </summary>
	[JsonPropertyName("owner_id")]
	public long? OwnerId { get; set; }

	/// <summary>
	/// Ключ доступа
	/// </summary>
	[JsonPropertyName("access_key")]
	public string AccessKey { get; set; }

	/// <summary>
	/// Преобразовать вложение в строку.
	/// </summary>
	/// <returns>
	/// Строковое представление
	/// </returns>
	public override string ToString()
	{
		var result = $"{Alias}{OwnerId}_{Id}";

		return string.IsNullOrWhiteSpace(AccessKey)
			? result
			: $"{result}_{AccessKey}";
	}
}