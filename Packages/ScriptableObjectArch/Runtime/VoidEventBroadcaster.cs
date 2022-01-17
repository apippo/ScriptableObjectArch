namespace ScriptableObjectArch
{
	using Core;
	using UniRx;
	using UnityEngine;

	[CreateAssetMenu(fileName = "VoidEvent", menuName = "Reactive/Event/Void", order = 0)]
	public class VoidEventBroadcaster : EventBroadcaster<Unit>
	{
		public void Raise() => Raise(Unit.Default);
	}
}
