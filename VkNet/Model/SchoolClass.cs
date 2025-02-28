using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// ����� � �����
/// </summary>
[Serializable]
public class SchoolClass
{
	/// <summary>
	/// ����� �������������, ������� ����������� ������.
	/// </summary>
	[JsonPropertyName("class")]
	public long Class { get; set; }

	/// <summary>
	/// ������� ����������� �� ������ �������� ������������.
	/// </summary>
	[JsonPropertyName("text")]
	public string Text { get; set; }
}