using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Создаёт новую сессию для прохождения рекламной акции для пользователя.
/// </summary>
[Serializable]
public class StartParams
{
	/// <summary>
	/// идентификатор рекламной акции, доступный в интерфейсе тестирования рекламных
	/// акций.
	/// </summary>
	[JsonPropertyName("lead_id")]
	public ulong LeadId { get; set; }

	/// <summary>
	/// секретный ключ, доступный в интерфейсе редактирования рекламных акций.
	/// </summary>
	[JsonPropertyName("secret")]
	public string Secret { get; set; }

	/// <summary>
	/// идентификатор пользователя, для которого необходимо получить сессию рекламной
	/// акции.
	/// </summary>
	[JsonPropertyName("uid")]
	public ulong Uid { get; set; }

	/// <summary>
	/// идентификатор приложения, на счет которого будут зачислены голоса.
	/// Если 0, при завершении рекламной акции голоса будут зачислены на счет
	/// пользователя.
	/// </summary>
	[JsonPropertyName("aid")]
	public ulong Aid { get; set; }

	/// <summary>
	/// 1 - запустить рекламную акцию в тестовом режиме;
	/// 0 - запустить рекламную акцию в боевом режиме (рекламная акция должна быть
	/// одобрена).
	/// </summary>
	[JsonPropertyName("test_mode")]
	public bool TestMode { get; set; }

	/// <summary>
	/// 1 - запустить рекламную акцию без проверок пользователя на фрод.
	/// Рекомендуется использовать только при выполнении оффлайн-офферов.
	/// </summary>
	[JsonPropertyName("force")]
	public bool Force { get; set; }
}