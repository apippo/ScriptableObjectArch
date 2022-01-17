namespace ScriptableObjectArch
{
	using Core;
	using UniRx;
	using UnityEngine;
	using UnityEngine.Events;

	public class VoidEventSubscriber : MonoBehaviour
	{
		[SerializeField]
		private GameEvent<Unit> voidEvent;

		public UnityEvent unityEvent;

		private void Awake()
		{
			voidEvent.Subscribe(_ => unityEvent.Invoke()).AddTo(this);
		}
	}
}
