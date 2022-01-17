namespace ScriptableObjectArch
{
	using Core;
	using UnityEngine;

	[CreateAssetMenu(fileName = "BoolEvent", menuName = "Reactive/Event/Bool", order = 0)]
	public class BoolEventBroadcaster : EventBroadcaster<bool> { }
}
