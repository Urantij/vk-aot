using System;
using System.Diagnostics;
using System.Text.Json.Serialization;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// ������� � �����������.
/// </summary>
[DebuggerDisplay(value: "Id = {Id}, TaggedName = {TaggedName}")]
[Serializable]
public class Tag
{
	/// <summary>
	/// ������������� �������.
	/// </summary>
	[JsonPropertyName("tag_id")]
	public long? Id { get; set; }

	/// <summary>
	/// �������� �������.
	/// </summary>
	[JsonPropertyName("tagged_name")]
	public string TaggedName { get; set; }

	/// <summary>
	/// ������������� ������������, �������� ������������� �������.
	/// </summary>
	[JsonPropertyName("user_id")]
	public long? UserId { get; set; }

	/// <summary>
	/// ������������� ������������, ���������� �������.
	/// </summary>
	[JsonPropertyName("placer_id")]
	public long? PlacerId { get; set; }

	/// <summary>
	/// ���� ���������� �������.
	/// </summary>
	[JsonPropertyName("date")]
	[JsonConverter(converterType: typeof(UnixDateTimeConverter))]
	public DateTime? Date { get; set; }

	/// <summary>
	/// ������ �������: true - ��������������, false - �� ��������������.
	/// </summary>
	[JsonPropertyName("viewed")]
	public bool? IsViewed { get; set; }

	/// <summary>
	/// ���������� ������������� �������, �� ������� ������� ������� (������� �����
	/// ���� � ������ ������ ����) � ���������.
	/// </summary>
	[JsonPropertyName("x")]
	public decimal? X { get; set; }

	/// <summary>
	/// ���������� ������������� �������, �� ������� ������� ������� (������� �����
	/// ���� � ������ ������ ����) � ���������.
	/// </summary>
	[JsonPropertyName("y")]
	public decimal? Y { get; set; }

	/// <summary>
	/// ���������� ������������� �������, �� ������� ������� ������� (������� �����
	/// ���� � ������ ������ ����) � ���������.
	/// </summary>
	[JsonPropertyName("x2")]
	public decimal? X2 { get; set; }

	/// <summary>
	/// ���������� ������������� �������, �� ������� ������� ������� (������� �����
	/// ���� � ������ ������ ����) � ���������.
	/// </summary>
	[JsonPropertyName("v2")]
	public decimal? Y2 { get; set; }

	[JsonPropertyName("uid")]
	private long? Uid
	{
		get => Id;
		set => Id = value;
	}

	[JsonPropertyName("tag_created")]
	private DateTime? TagCreated
	{
		get => Date;
		set => Date = value;
	}
}