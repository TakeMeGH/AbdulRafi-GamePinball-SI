using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauncherController : MonoBehaviour
{
	public KeyCode input;
	public float maxTimeHold;
	public float maxForce;

	public Color onHoldMaximumColor;

	private Color defaultColor;
	private Renderer launcherRenderer;
	private bool isHold;

	private void Start() {
		launcherRenderer = GetComponent<Renderer>();
		defaultColor = launcherRenderer.material.color;
	}
	private void OnCollisionStay(Collision other)
	{
		if (other.gameObject.tag == "Ball")
		{
			ReadInput(other.gameObject);
		}
	}

	// baca input
	private void ReadInput(GameObject other)
	{
		if (Input.GetKey(input) && !isHold)
		{
			StartCoroutine(StartHold(other));
		}
	}

	private IEnumerator StartHold(GameObject other)
	{
		isHold = true;

		float force = 0.0f;
		float timeHold = 0.0f;

		while (Input.GetKey(input))
		{
			force = Mathf.Lerp(0, maxForce, timeHold / maxTimeHold);
			launcherRenderer.material.color = Color.Lerp(defaultColor, onHoldMaximumColor, timeHold / maxTimeHold);
			Debug.Log(launcherRenderer.material.color);
			yield return new WaitForEndOfFrame();
			timeHold += Time.deltaTime;
		}
		launcherRenderer.material.color = defaultColor;
		other.GetComponent<Rigidbody>().AddForce(Vector3.forward * force);
		isHold = false;

	}
}
