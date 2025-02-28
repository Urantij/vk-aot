using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Ошибка при вызове метода exeсute
/// </summary>
[Serializable]
public class VkError
{
	/// <summary>
	/// Метод в котором произошла ошибка
	/// </summary>
	[JsonPropertyName("method")]
	public string Method { get; set; }

	/// <summary>
	/// Код ошибки
	/// </summary>
	[JsonPropertyName("error_code")]
	public int ErrorCode { get; set; }

	/// <summary>
	/// Сообщение об ошибке
	/// </summary>
	[JsonPropertyName("error_msg")]
	public string ErrorMessage { get; set; }

	/// <summary>
	/// Параметры запроса
	/// </summary>
	[JsonPropertyName("request_params")]
	public ReadOnlyCollection<RequestParam> RequestParams { get; set; }

	/// <summary>
	/// Идентификатор капчи
	/// </summary>
	[JsonPropertyName("captcha_sid")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public ulong CaptchaSid { get; set; }

	/// <summary>
	/// Ссылка на изображение капчи
	/// </summary>
	[JsonPropertyName("captcha_img")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public Uri CaptchaImg { get; set; }

	/// <summary>
	/// Адрес который необходимо открыть в браузере для подтверждения валидации.
	/// </summary>
	[JsonPropertyName("redirect_uri")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public Uri RedirectUri { get; set; }
}