using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Права токена
/// </summary>
[Serializable]
public class TokenPermissionsResult
{
	/// <summary>
	/// Битовая масска
	/// </summary>
	[JsonPropertyName("mask")]
	public long Mask { get; set; }

	/// <summary>
	/// Права доступа
	/// </summary>
	[JsonPropertyName("permissions")]
	public ReadOnlyCollection<TokenPermission> Permissions { get; set; }
}