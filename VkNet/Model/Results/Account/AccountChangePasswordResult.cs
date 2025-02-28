using System;
using System.Text.Json.Serialization;
using VkNet.Utils;

namespace VkNet.Model;

/// <summary>
/// Результат метода account.changePassword
/// </summary>
[Serializable]
public class AccountChangePasswordResult
{
	/// <summary>
	/// Токен.
	/// </summary>
	[JsonPropertyName("token")]
	public string Token { get; set; }

	/// <summary>
	/// secret в случае, если токен был nohttps.
	/// </summary>
	[Obsolete(ObsoleteText.Obsolete)]
	[JsonPropertyName("secret")]
	public string Secret { get; set; }
}