using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptsForPersonalTests : MonoBehaviour
{
    public GameObject _object;
    public Renderer _renderer;
    private void Start()
    {
        StartCoroutine(Fade2());
        //Fade();
    }

    private void Update()
    {
        //Fade();
        //StartCoroutine(Fade2());
    }
    public void Fade()
    {
        for (float ft = 1f; ft >= 0; ft -= 0.1f)
        {
            Color c = _object.GetComponent<Renderer>().material.color;
            c.a = ft;
            _object.GetComponent<Renderer>().material.color = c;
        }
    }
    public IEnumerator Fade2()
    {
        Color c = _object.GetComponent<Renderer>().material.color;
        for (float ft = 1f; ft >= 0; ft -= 0.1f)
        {
            //Color c = _renderer.material.color;
            c.a = ft;
            _renderer.material.color = c;
            yield return new WaitForSeconds(1f);
            //yield return null;
        }
    }
}
