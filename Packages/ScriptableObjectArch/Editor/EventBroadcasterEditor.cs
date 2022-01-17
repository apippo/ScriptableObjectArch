namespace ScriptableObjectArch.Editor
{
	using System;
	using System.Reflection;
	using Core;
	using UnityEditor;
	using UnityEngine;
	using Object = UnityEngine.Object;

	[CustomEditor(typeof(EventBroadcaster<>), true)]
	public class EventBroadcasterEditor : Editor
	{
		private Type parameterType;

		public override void OnInspectorGUI()
		{
			var serializedProperty = serializedObject.FindProperty("testValue");

			if (serializedProperty == null)
			{
				if (parameterType == null)
				{
					var baseType = target.GetType().BaseType;
					if (baseType != null &&
					    baseType.GetGenericTypeDefinition() == typeof(EventBroadcaster<>))
					{
						parameterType = baseType.GetGenericArguments()[0];
					}
				}

				EditorGUILayout.LabelField($"{parameterType.Name} is not serializable");

				return;
			}

			EditorGUI.BeginDisabledGroup(!EditorApplication.isPlaying);

			if (serializedProperty.type != "Unit")
			{
				EditorGUILayout.PropertyField(serializedProperty, true);
			}

			if (GUILayout.Button("Raise"))
			{
				var baseType = target.GetType().BaseType;
				if (baseType != null &&
				    baseType.GetGenericTypeDefinition() == typeof(EventBroadcaster<>))
				{
					serializedObject.ApplyModifiedProperties();
					var methodInfo = baseType.GetMethod("TestRaise", BindingFlags.IgnoreCase | BindingFlags.InvokeMethod | BindingFlags.Instance | BindingFlags.NonPublic);
					if (methodInfo != null)
					{
						methodInfo.Invoke(serializedProperty.serializedObject.targetObject, null);
					}
				}
			}

			EditorGUI.EndDisabledGroup();
		}
	}
}
