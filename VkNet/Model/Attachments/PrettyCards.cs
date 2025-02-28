using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <inheritdoc />
[Serializable]
public class PrettyCards : MediaAttachment
{
	/// <inheritdoc />
	protected override string Alias => "pretty_cards";

	/// <summary>
	/// Cards
	/// </summary>
	[JsonPropertyName("cards")]
	public ReadOnlyCollection<PrettyCard> Cards { get; set; }
}