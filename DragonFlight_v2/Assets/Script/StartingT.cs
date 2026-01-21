using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class StartingT : MonoBehaviour
{
    Text starttext;

    private Coroutine blinkCoroutine;

    void Start()
    {
        starttext = GetComponent<Text>();

        blinkCoroutine = StartCoroutine(BlinkText(0.5f));

        StartCoroutine(CountdownAndStopBlink(3));
    }

    IEnumerator BlinkText(float interval)
    {
        while (true)
        {
            if (starttext != null)
            {
                starttext.enabled = !starttext.enabled;
            }

            yield return new WaitForSeconds(interval);
        }
    }

    IEnumerator CountdownAndStopBlink(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            starttext.text = "CountDOWN : " + i;

            yield return new WaitForSeconds(1f);
        }

        starttext.text = "Go!";
        yield return new WaitForSeconds(1f);
        StopCoroutine(blinkCoroutine);
        starttext.enabled = false;
    }
}
