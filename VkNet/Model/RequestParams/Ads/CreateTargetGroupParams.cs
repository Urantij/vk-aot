using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Параметры запроса ads.createTargetGroup
/// </summary>
[Serializable]
public class CreateTargetGroupParams
{
	/// <summary>
	/// Идентификатор рекламного кабинета. обязательный параметр, целое число
	/// </summary>
	[JsonPropertyName("account_id")]
	public long AccountId { get; set; }

	/// <summary>
	/// Название аудитории ретаргетинга — строка до 64 символов. обязательный параметр, строка
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; }

	/// <summary>
	/// Только для рекламных агентств.
	/// id клиента, в рекламном кабинете которого будет создаваться аудитория. целое число
	/// </summary>
	[JsonPropertyName("client_id")]
	public long? ClientId { get; set; }

	/// <summary>
	/// Количество дней, через которое пользователи, добавляемые в аудиторию, будут автоматически исключены из нее.
	/// Положительное число от 1 до 720
	/// </summary>
	[JsonPropertyName("lifetime")]
	public ulong Lifetime { get; set; }

	/// <summary>
	/// Идентификатор пикселя, если требуется собирать аудиторию с веб-сайта. целое число
	/// </summary>
	[JsonPropertyName("target_pixel_id")]
	public long? TargetPixelId { get; set; }

	/// <summary>
	/// Массив правил для пополнения аудитории из пикселя. Имеет вид:
	/// [
	/// {"type": args},
	/// {"type": args},
	/// ...
	/// {"type": args}
	/// ] данные в формате JSON
	/// </summary>
	[JsonPropertyName("target_pixel_rules")]
	public IDictionary<string, string> TargetPixelRules { get; set; }
}