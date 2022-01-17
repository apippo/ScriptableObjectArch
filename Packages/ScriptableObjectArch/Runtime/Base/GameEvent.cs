namespace ScriptableObjectArch.Core
{
	using System;
	using UniRx;
	using UnityEngine;

	public abstract class GameEvent<T> : IGameObservable<T>
	{
		protected ISubject<T> subject = new Subject<T>();

		protected override IObservable<T> Observable => subject;
	}
}
