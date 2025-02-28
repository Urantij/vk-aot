using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Nodes;

namespace VkNet.Exception;

/// <summary>
/// Исключение, которое выбрасывается при нахождении ошибок в ответе метода execute.
/// </summary>
[Serializable]
public sealed class ExecuteException : AggregateException
{
	/// <summary>
	/// Поле response из ответа метода execute.
	/// </summary>
	public JsonNode Response { get; }

	/// <inheritdoc />
	public ExecuteException(IEnumerable<System.Exception> innerExceptions, JsonNode response) : base(innerExceptions) => Response = response;

	/// <inheritdoc />
	private ExecuteException(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{

	}
}