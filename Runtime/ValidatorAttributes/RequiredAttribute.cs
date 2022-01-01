using System;

namespace AarquieSolutions.InspectorAttributes
{
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	public class RequiredAttribute : ValidatorAttribute
	{
		public string Message { get; protected set; }

		public RequiredAttribute(string message = null)
		{
			Message = message;
		}
	}
}
