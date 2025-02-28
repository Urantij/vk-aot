using System;
using System.Text.Json.Serialization;
using VkNet.Enums;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Элемент подписки
/// </summary>
[Serializable]
public class SubscriptionItem
{
	/// <summary>
	/// Идентификатор подписки
	/// </summary>
	[JsonPropertyName("id")]
	public ulong Id { get; set; }

	/// <summary>
	/// Идентификатор товара в приложении
	/// </summary>
	[JsonPropertyName("item_id")]
	public string ItemId { get; set; }

	/// <summary>
	///  Статус подписки. Возможные значения:
	///  active — подписка активна.
	/// </summary>
	[JsonPropertyName("status")]
	public SubscriptionStatus Status { get; set; }

	/// <summary>
	/// Стоимость подписки
	/// </summary>
	[JsonPropertyName("price")]
	public long Price { get; set; }

	/// <summary>
	/// Период подписки
	/// </summary>
	[JsonPropertyName("period")]
	public int Period { get; set; }

	/// <summary>
	/// Дата создания в Unixtime
	/// </summary>
	[JsonPropertyName("create_time")]
	[JsonConverter(converterType: typeof(UnixDateTimeConverter))]
	public DateTime? CreateTime { get; set; }

	/// <summary>
	/// Дата обновления в Unixtime
	/// </summary>
	[JsonPropertyName("update_time")]
	[JsonConverter(converterType: typeof(UnixDateTimeConverter))]
	public DateTime? UpdateTime { get; set; }

	/// <summary>
	/// Дата начала периода в Unixtime
	/// </summary>
	[JsonPropertyName("period_start_time")]
	[JsonConverter(converterType: typeof(UnixDateTimeConverter))]
	public DateTime? PeriodStartTime { get; set; }

	private DateTime? _nextBillTime;

	/// <summary>
	/// Дата следующего платежа в Unixtime (если status = active)
	/// </summary>
	[JsonPropertyName("next_bill_time")]
	[JsonConverter(converterType: typeof(UnixDateTimeConverter))]
	public DateTime? NextBillTime
	{
		get {
			if (Status.Equals("active"))
			{
				return _nextBillTime;
			}

			return null;
		}

		set {
			if (_nextBillTime == value)
			{
				return;
			}

			if (Status.Equals("active"))
			{
				_nextBillTime = value;
			}
		}
	}

	/// <summary>
	/// Дата истечения триал-периода (если есть)
	/// </summary>
	[JsonPropertyName("trial_expire_time")]
	[JsonConverter(converterType: typeof(UnixDateTimeConverter))]
	public DateTime? TrialExpireTime { get; set; }

	/// <summary>
	/// true, если подписка ожидает отмены.
	/// </summary>
	[JsonPropertyName("pending_cancel")]
	public bool PendingCancel { get; set; }

	/// <summary>
	/// Причина отмены (если есть). Возможные значения:
	/// user_decision — по инициативе пользователя;
	/// app_decision — по инициативе приложения;
	/// payment_fail — из-за проблемы с платежом;
	/// unknown — причина неизвестна.
	/// </summary>
	[JsonPropertyName("cancel_reason")]
	public CancelSubscriptionReason CancelReason { get; set; }

	/// <summary>
	/// true, если используется тестовый режим.
	/// </summary>
	[JsonPropertyName("test_mode")]
	public bool TestMode { get; set; }
}