namespace ScriptableObjectArch.Core
{
	using UnityEngine;

	public abstract partial class EventBroadcaster<T> : GameEvent<T>
	{
#if UNITY_EDITOR
		[SerializeField]
		private T testValue = default(T);

		private void TestRaise() => subject.OnNext(testValue);
#endif


		public void Raise(T value) => subject.OnNext(value);
	}
}
