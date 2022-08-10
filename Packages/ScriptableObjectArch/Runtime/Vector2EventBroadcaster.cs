namespace ScriptableObjectArch
{
	using Core;
	using UnityEngine;

	[CreateAssetMenu(fileName = "Vector2Event", menuName = "Reactive/Event/Vector2", order = 0)]
	public class Vector2EventBroadcaster : EventBroadcaster<Vector2> { }
}
