using System;
using System.Runtime.Serialization;

class NonIntResult : Exception
{
	public NonIntResult() : base() { }
	public NonIntResult(string message) : base(message) { }
	public NonIntResult(string message, Exception inner) : base(message, inner) { }
	protected NonIntResult(
	      SerializationInfo info,
	      StreamingContext context) : base(info, context) { }
	public override string ToString()
	{
		return Message; 
	}
}
