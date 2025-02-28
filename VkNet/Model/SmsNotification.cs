using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// API SmsNotification object.
/// </summary>
[Serializable]
public class SmsNotification
{
	/// <summary>
	/// User ID
	/// </summary>
	[JsonPropertyName("user_id")]
	public int? UserId { get; set; }

	/// <summary>
	/// Date when message has been sent in Unixtime
	/// </summary>
	[JsonPropertyName("date")]
	public int? Date { get; set; }

	/// <summary>
	/// Application ID
	/// </summary>
	[JsonPropertyName("app_id")]
	public int? AppId { get; set; }

	/// <summary>
	/// Notification ID
	/// </summary>
	[JsonPropertyName("id")]
	public int? Id { get; set; }

	/// <summary>
	/// Messsage text
	/// </summary>
	[JsonPropertyName("message")]
	public string Message { get; set; }
}