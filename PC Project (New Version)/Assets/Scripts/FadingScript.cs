using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadingScript : MonoBehaviour
{

    private IEnumerator Fade()
    {
        while (true)
        {
            for (float i = 1; i > 0; i -= .9f)
            {
                Color newColor = new Color(1, 1, 1, i);
                this.gameObject.GetComponent<Renderer>().material.color = newColor;
                yield return new WaitForSeconds(1f);
            }

        }
    }
    /*
    private IEnumerator BackFade()
    {
        while (true) { 
        Debug.Log("It should be working!");
        for (float i = 1; i > 0; i += 0.1f)
        {
            Color newColor = new Color(1, 1, 1, i);
            this.gameObject.GetComponent<Renderer>().material.color = newColor;
            yield return new WaitForSeconds(0.1f);
        }

    }
}
    */

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Fade");
        //StartCoroutine("BackFade");

    }

    // Update is called once per frame
    void Update()
    {

    }
}
