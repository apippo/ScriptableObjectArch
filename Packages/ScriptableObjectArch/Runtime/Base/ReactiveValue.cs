namespace ScriptableObjectArch.Core
{
	public abstract partial class ReactiveValue<T> : IReadonlyReactiveValue<T>
	{
		public new T Value
		{
			get => reactiveProperty.Value;
			set => reactiveProperty.Value = value;
		}

		public void SetValueAndForceNotify(T value) => reactiveProperty.SetValueAndForceNotify(value);

#if UNITY_EDITOR
		private void EditorSetValueAndForceNotify() => reactiveProperty.SetValueAndForceNotify(Value);
#endif
	}
}
