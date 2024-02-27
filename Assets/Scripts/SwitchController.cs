using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SwitchController : MonoBehaviour
{
  private enum SwitchState
  {
    Off,
    On,
    Blink
  }
  public Color offColor;
  public Color onColor;
  public float poin = 10;

  private SwitchState state;
  private Renderer switchRenderer;
  ScoreManager scoreManager;

  private void Start()
  {
    switchRenderer = GetComponent<Renderer>();
    scoreManager = GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<ScoreManager>();


    Set(false);

    StartCoroutine(BlinkTimerStart(5));
  }

  private void OnTriggerEnter(Collider other)
  {
    if (other.gameObject.tag == "Ball")
    {
      Toggle();
      scoreManager.AddScore(poin);
    }
  }

  private void Set(bool active)
  {
    if (active == true)
    {
      state = SwitchState.On;
      switchRenderer.material.color = onColor;
      StopAllCoroutines();
    }
    else
    {
      state = SwitchState.Off;
      switchRenderer.material.color = offColor;
      StartCoroutine(BlinkTimerStart(5));
    }
  }

  private void Toggle()
  {
    if (state == SwitchState.On)
    {
      Set(false);
    }
    else
    {
      Set(true);
    }
  }

  private IEnumerator Blink(int times)
  {
    state = SwitchState.Blink;

    for (int i = 0; i < times; i++)
    {
      switchRenderer.material.color = onColor;
      yield return new WaitForSeconds(0.5f);
      switchRenderer.material.color = offColor;
      yield return new WaitForSeconds(0.5f);
    }

    state = SwitchState.Off;

    StartCoroutine(BlinkTimerStart(5));
  }

  private IEnumerator BlinkTimerStart(float time)
  {
    yield return new WaitForSeconds(time);
    StartCoroutine(Blink(2));
  }
}
