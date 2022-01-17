namespace ScriptableObjectArch
{
	using Core;
	using UnityEngine;

	[CreateAssetMenu(fileName = "BoolValue", menuName = "Reactive/Values/Bool", order = 0)]
	public class BoolValue : ReactiveValue<bool> { }
}
