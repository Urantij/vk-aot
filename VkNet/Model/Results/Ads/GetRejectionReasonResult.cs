using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Результат получения информации о причинах отказа
/// </summary>
[Serializable]
public class GetRejectionReasonResult
{
	/// <summary>
	/// Количество оставшихся методов;
	/// </summary>
	[JsonPropertyName("comment")]
	public string Comment { get; set; }

	/// <summary>
	/// Время до следующего обновления в секундах.
	/// </summary>
	[JsonPropertyName("rules")]
	public ReadOnlyCollection<RejectionRules> Rules { get; set; }
}