using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawManager : MonoBehaviour
{

    public GameObject Result;
    public GameObject LightNormal;
    public GameObject SpotLight;

    // Start is called before the first frame update
    void Start()
    {
        Result.SetActive(false);
        SpotLight.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onDraw()
    {

        StartCoroutine(DrawWaiting());
    }

    IEnumerator DrawWaiting()
    {
        yield return new WaitForSeconds(2.0f);
        Result.SetActive(true);
        LightNormal.SetActive(false);
        SpotLight.SetActive(true);
    }

}
