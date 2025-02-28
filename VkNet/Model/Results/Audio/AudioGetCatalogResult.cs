using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Результат выполнения метода Audio.getCatalog
/// </summary>
[Serializable]
public class AudioGetCatalogResult
{
	/// <summary>
	/// Массив каталогов
	/// </summary>
	[JsonPropertyName("items")]
	public ReadOnlyCollection<AudioCatalog> Items { get; set; }

	/// <summary>
	/// Идентификатор на следующую пачку результатов
	/// </summary>
	[JsonPropertyName("next_from")]
	public string NextFrom { get; set; }

	/// <summary>
	/// Массив профилей
	/// </summary>
	[JsonPropertyName("profiles")]
	public ReadOnlyCollection<User> Profiles { get; set; }

	/// <summary>
	/// Массив групп/сообществ
	/// </summary>
	[JsonPropertyName("groups")]
	public ReadOnlyCollection<Group> Groups { get; set; }
}