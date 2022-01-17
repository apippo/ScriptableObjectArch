namespace ScriptableObjectArch.Editor
{
	using System;
	using System.Reflection;
	using System.Text.RegularExpressions;
	using UniRx;
	using UnityEditor;
	using UnityEngine;

	[CustomPropertyDrawer(typeof(ReactiveProperty<>))]
	public class ReactivePropertyDrawer : PropertyDrawer
	{
		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
		{
			UnityEditor.EditorGUI.PropertyField(position, property.FindPropertyRelative("value"), label, includeChildren: true);
		}

		public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
		{
			return base.GetPropertyHeight(property, label);
		}
	}
}
