using UnityEngine;
using UnityEngine.Events;

public class BackButton : MonoBehaviour
{
	public UnityEvent BackPressedEvent;

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape) && BackPressedEvent != null)
		{
			BackPressedEvent.Invoke();
		}
	}
}
