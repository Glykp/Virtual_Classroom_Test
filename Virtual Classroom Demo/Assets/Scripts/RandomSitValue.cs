using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSitValue : MonoBehaviour
{

    public Animator Anim;
    private float Rand;
    public float RandTime;
    private bool CoroutineEnd = true;

    // Start is called before the first frame update
    void Start()
    {
        Anim = GetComponent<Animator>();
        //Rand = Random.Range(0.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if(CoroutineEnd == true)
        StartCoroutine(SittingCoroutine());
    }

    IEnumerator SittingCoroutine()
    {
        CoroutineEnd = false;

        Rand = Random.Range(0.0f, 1.0f);
        RandTime = Random.Range(4.0f, 12.0f);

        if (Rand <= 0.2f)
            Anim.SetFloat("SitVar_3", 1.0f);

        else if (Rand > 0.2f && Rand <= 0.4f)
            Anim.SetFloat("SitVar_1", 1.0f);

        else if (Rand > 0.4f && Rand <= 0.6f)
            Anim.SetFloat("SitVar_2", 1.0f);

        else if (Rand > 0.6f && Rand <= 0.8f)
            Anim.SetFloat("SitTalk_1", 1.0f);

        else if (Rand > 0.8f && Rand <= 1.0f)
            Anim.SetFloat("SitTalk_2", 1.0f);

        yield return new WaitForSeconds(RandTime);
        Anim.SetFloat("SitVar_3", 0.8f);
        Anim.SetFloat("SitVar_1", 0.8f);
        Anim.SetFloat("SitVar_2", 0.8f);
        Anim.SetFloat("SitTalk_1", 0.8f);
        Anim.SetFloat("SitTalk_2", 0.8f);
        //yield return new WaitForSeconds(1.0f);

        CoroutineEnd = true;


    }
}
