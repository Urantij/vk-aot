using System;
using System.Linq;
using System.Text.Json;

namespace VkNet.Utils.JsonConverter;

/// <summary>
/// Стратегия наменования сущностей в camelCase
/// </summary>
public class LowerCaseWithDigitNamingStrategy : JsonNamingPolicy
{
	/// <inheritdoc />
	public override string ConvertName(string name)
	{
		return string.Concat(name.Select((x, i) => i > 0 && char.IsDigit(x) ? "_" + x : x.ToString())).ToLower();
	}
}