using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThinkBubble : MonoBehaviour
{
    public Image Bubble;
    public Sprite A;
    public Sprite B;
    public Sprite Grey;
    public float RandTime;
    public float RandChoosingTime;
    public float Rand;
    private bool isChosed = false;

    // Start is called before the first frame update
    void Start()
    {
        Bubble = GetComponent<Image>();
        Bubble.sprite = null;
        Bubble.CrossFadeAlpha(0, 0.01f, false);
    }

    // Update is called once per frame
    void Update()
    {
        StartChoosing();
    }

    public void StartChoosing()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            if (isChosed == false)
                StartCoroutine(Choosingcoroutine());
        }
    }

    IEnumerator Choosingcoroutine()
    {
        isChosed = true;

        RandChoosingTime = Random.Range(4.0f, 8.0f);
        RandTime = Random.Range(2.0f, 6.0f);
        Rand = Random.Range(0.0f, 1.0f);

        yield return new WaitForSeconds(RandTime);
        Bubble.sprite = Grey;
        Bubble.CrossFadeAlpha(.85f, 2.0f, false);
        yield return new WaitForSeconds(RandChoosingTime);
        Bubble.CrossFadeAlpha(0.0f, 1.0f, false);
        yield return new WaitForSeconds(1f);
        if (Rand > 0.5f)
            Bubble.sprite = A;
        else if (Rand <= 0.5f)
            Bubble.sprite = B;
        Bubble.CrossFadeAlpha(.85f, 2.0f, false);
    }
}
