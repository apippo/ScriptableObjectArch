namespace ScriptableObjectArch
{
	using Core;
	using UnityEngine;

	[CreateAssetMenu(fileName = "FloatValue", menuName = "Reactive/Values/Float", order = 0)]
	public class FloatValue : ReactiveValue<float> { }
}
