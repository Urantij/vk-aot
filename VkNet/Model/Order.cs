using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// API Order object.
/// </summary>
[Serializable]
public class Order
{
	/// <summary>
	/// Amount
	/// </summary>
	[JsonPropertyName("amount")]
	public int? Amount { get; set; }

	/// <summary>
	/// Receiver ID
	/// </summary>
	[JsonPropertyName("receiver_id")]
	public int? ReceiverId { get; set; }

	/// <summary>
	/// Order ID
	/// </summary>
	[JsonPropertyName("id")]
	public int? Id { get; set; }

	/// <summary>
	/// Order item
	/// </summary>
	[JsonPropertyName("item")]
	public string Item { get; set; }

	/// <summary>
	/// App order ID
	/// </summary>
	[JsonPropertyName("app_order_id")]
	public int? AppOrderId { get; set; }

	/// <summary>
	/// Cancel transaction ID
	/// </summary>
	[JsonPropertyName("cancel_transaction_id")]
	public int? CancelTransactionId { get; set; }

	/// <summary>
	/// Order status
	/// </summary>
	[JsonPropertyName("status")]
	public string Status { get; set; }

	/// <summary>
	/// User ID
	/// </summary>
	[JsonPropertyName("user_id")]
	public int? UserId { get; set; }

	/// <summary>
	/// Transaction ID
	/// </summary>
	[JsonPropertyName("transaction_id")]
	public int? TransactionId { get; set; }

	/// <summary>
	/// Date of creation in Unixtime
	/// </summary>
	[JsonPropertyName("date")]
	public int? Date { get; set; }
}