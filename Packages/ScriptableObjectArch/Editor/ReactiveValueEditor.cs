namespace ScriptableObjectArch.Editor
{
	using System.Reflection;
	using Core;
	using UnityEditor;
	using UnityEngine;


	[CustomEditor(typeof(ReactiveValue<>), true)]
	public class ReactiveValueEditor : Editor
	{
		public override void OnInspectorGUI()
		{
			serializedObject.Update();

			EditorGUI.BeginDisabledGroup(EditorApplication.isPlayingOrWillChangePlaymode);
			{
				EditorGUILayout.PropertyField(serializedObject.FindProperty("initialValue"), true);
			}
			EditorGUI.EndDisabledGroup();

			EditorGUI.BeginDisabledGroup(!EditorApplication.isPlaying);
			{
				EditorGUI.BeginChangeCheck();
				EditorGUILayout.PropertyField(serializedObject.FindProperty("reactiveProperty"), new GUIContent("Value"), true);
				if (EditorGUI.EndChangeCheck())
				{

					var targetType = target.GetType()?.BaseType;
					if (targetType != null &&
					    targetType.GetGenericTypeDefinition() == typeof(ReactiveValue<>))
					{
						serializedObject.ApplyModifiedProperties();
						var methodInfo = targetType.GetMethod("EditorSetValueAndForceNotify", BindingFlags.IgnoreCase | BindingFlags.InvokeMethod | BindingFlags.Instance | BindingFlags.NonPublic);
						if (methodInfo != null)
						{
							methodInfo.Invoke(serializedObject.targetObject, null);
						}
					}
				}
			}
			EditorGUI.EndDisabledGroup();

			serializedObject.ApplyModifiedProperties();
		}
	}
}
