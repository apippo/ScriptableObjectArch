namespace ScriptableObjectArch
{
	using Core;
	using UnityEngine;

	[CreateAssetMenu(fileName = "IntValue", menuName = "Reactive/Values/Int", order = 0)]
	public class IntValue : ReactiveValue<int> { }
}
