namespace ScriptableObjectArch.Core
{
	using System;
	using UniRx;
	using UnityEngine;
	using UnityEngine.Events;

	public abstract class EventSubscriber<T> : MonoBehaviour
	{
		[SerializeField]
		private IGameObservable<T> eventSource;

		public UnityEvent<T> unityEvent;

		private IDisposable subscription;

		private void OnEnable()
		{
			subscription = eventSource.Subscribe(unityEvent.Invoke);
		}

		private void OnDisable()
		{
			subscription?.Dispose();
		}

		private void OnDestroy()
		{
			subscription?.Dispose();
		}
	}
}
