using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Доступность рекламной акции пользователю.
/// </summary>
[Serializable]
public class Checked
{
	/// <summary>
	/// Information whether user can start the lead
	/// </summary>
	[JsonPropertyName("result")]
	public string Result { get; set; }

	/// <summary>
	/// URL user should open to start the lead
	/// </summary>
	[JsonPropertyName("start_link")]
	public string StartLink { get; set; }

	/// <summary>
	/// Session ID
	/// </summary>
	[JsonPropertyName("sid")]
	public string Sid { get; set; }

	/// <summary>
	/// Reason why user can't start the lead
	/// </summary>
	[JsonPropertyName("reason")]
	public string Reason { get; set; }
}