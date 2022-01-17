namespace ScriptableObjectArch.Core
{
	using System;
	using UniRx;
	using UnityEngine;

	public abstract partial class IReadonlyReactiveValue<T> : IGameObservable<T>
	{
		[SerializeField]
		private T initialValue = default(T);

		[SerializeField]
		protected ReactiveProperty<T> reactiveProperty = new ReactiveProperty<T>();

		public T Value => reactiveProperty.Value;

		protected override IObservable<T> Observable => reactiveProperty;

		private void OnEnable()
		{
			reactiveProperty.Value = initialValue;
#if UNITY_EDITOR
			OnEnableEditor();
#endif
		}

#if UNITY_EDITOR

		private void OnEnableEditor()
		{
			if (UnityEditor.EditorSettings.enterPlayModeOptionsEnabled)
			{
				UnityEditor.EditorApplication.playModeStateChanged -= HandlePlayModeStateChange;
				UnityEditor.EditorApplication.playModeStateChanged += HandlePlayModeStateChange;
			}
		}

		private void HandlePlayModeStateChange(UnityEditor.PlayModeStateChange state)
		{
			if (state == UnityEditor.PlayModeStateChange.ExitingEditMode)
			{
				reactiveProperty.Value = initialValue;
			}
		}
#endif
	}
}
