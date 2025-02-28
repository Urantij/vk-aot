using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// ����������� � ������
/// </summary>
[Serializable]
public class MarketComment
{
	/// <summary>
	/// ������ ������������.
	/// </summary>
	[JsonPropertyName("items")]
	public ReadOnlyCollection<Comment> Comments { get; set; }

	/// <summary>
	/// ���������� ������������.
	/// </summary>
	[JsonPropertyName("count")]
	public long Count { get; set; }

	/// <summary>
	/// ������ �������������.
	/// </summary>
	[JsonPropertyName("profiles")]
	public ReadOnlyCollection<User> Profiles { get; set; }

	/// <summary>
	/// ������ ���������.
	/// </summary>
	[JsonPropertyName("groups")]
	public ReadOnlyCollection<Group> Groups { get; set; }
}