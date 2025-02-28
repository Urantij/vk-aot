using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Политика конфиденциальности приложения.
/// </summary>
[Serializable]
public class MiniAppPolicies
{
	/// <summary>
	/// Идентификатор приложения.
	/// </summary>
	[JsonPropertyName("privacy_policy")]
	public string PrivacyPolicy { get; set; }

	/// <summary>
	/// Название приложения.
	/// </summary>
	[JsonPropertyName("terms")]
	public string Terms { get; set; }
}