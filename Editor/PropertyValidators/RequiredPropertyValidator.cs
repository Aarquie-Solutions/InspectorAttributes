using UnityEditor;

namespace AarquieSolutions.InspectorAttributes.Editor
{
	public class RequiredPropertyValidator : PropertyValidatorBase
	{
		public override void ValidateProperty(SerializedProperty property)
		{
			RequiredAttribute requiredAttribute = PropertyUtility.GetAttribute<RequiredAttribute>(property);

			if (property.propertyType == SerializedPropertyType.ObjectReference)
			{
				if (property.objectReferenceValue == null)
				{
					string errorMessage = property.name + " is required";
					if (!string.IsNullOrEmpty(requiredAttribute.Message))
					{
						errorMessage = requiredAttribute.Message;
					}

					InspectorAttributeEditorGUI.HelpBox_Layout(errorMessage, MessageType.Error, context: property.serializedObject.targetObject);
				}
			}
			else
			{
				string warning = requiredAttribute.GetType().Name + " works only on reference types";
				InspectorAttributeEditorGUI.HelpBox_Layout(warning, MessageType.Warning, context: property.serializedObject.targetObject);
			}
		}
	}
}
