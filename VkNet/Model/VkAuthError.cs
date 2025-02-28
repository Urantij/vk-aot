using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Authorization error.
/// </summary>
[Serializable]
public class VkAuthError
{
	/// <summary>
	/// Error.
	/// </summary>
	[JsonPropertyName("error")]
	public string Error { get; set; }

	/// <summary>
	/// Error type.
	/// </summary>
	[JsonPropertyName("error_type")]
	public string ErrorType { get; set; }

	/// <summary>
	/// Error description.
	/// </summary>
	[JsonPropertyName("error_description")]
	public string ErrorDescription { get; set; }

	/// <summary>
	/// Captcha id.
	/// </summary>
	[JsonPropertyName("captcha_sid")]
	public ulong? CaptchaSid { get; set; }

	/// <summary>
	/// Captcha image Uri.
	/// </summary>
	[JsonPropertyName("captcha_img")]
	public Uri CaptchaImg { get; set; }
}