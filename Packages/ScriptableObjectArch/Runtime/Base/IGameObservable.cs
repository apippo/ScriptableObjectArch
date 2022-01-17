namespace ScriptableObjectArch.Core
{
	using System;
	using UniRx;
	using UnityEngine;

	public abstract class IGameObservable<T> : ScriptableObject
	{
		protected abstract IObservable<T> Observable { get; }

		public IDisposable Subscribe(Action<T> onNext) => Observable.Subscribe(onNext);
	}
}
