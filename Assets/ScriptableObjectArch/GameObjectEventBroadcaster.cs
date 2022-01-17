namespace ScriptableObjectArch
{
	using Core;
	using UniRx;
	using UnityEngine;

	[CreateAssetMenu(fileName = "GameObjectEvent", menuName = "Reactive/Event/GameObject", order = 0)]
	public class GameObjectEventBroadcaster : EventBroadcaster<GameObject> { }
}
