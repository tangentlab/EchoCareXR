using UnityEngine;
using DG.Tweening;

namespace ECHO
{
	public class DoTweenIn : MonoBehaviour
	{
		private bool hasTweenedIn = false;

		private void OnEnable()
		{
			//transform.localScale = Vector3.zero;
			if (hasTweenedIn) return;

			transform.DOScale(Vector3.one, 0.5f).From(Vector3.zero).SetEase(Ease.OutBack);
			hasTweenedIn = true;
		}
	}
}