namespace ScriptableObjectArch
{
	using Core;
	using UnityEngine;

	[CreateAssetMenu(fileName = "Vector3Event", menuName = "Reactive/Event/Vector3", order = 0)]
	public class Vector3EventBroadcaster : EventBroadcaster<Vector3> { }
}
