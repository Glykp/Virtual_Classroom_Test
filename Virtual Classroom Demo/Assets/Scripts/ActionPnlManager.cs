using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionPnlManager : MonoBehaviour
{
    public Image SubPnl_1_Img;
    public Image SubPnl_2_Img;
    public Image SubPnl_3_Img;
    public GameObject SubPnl_1;
    public GameObject SubPnl_2;
    public GameObject SubPnl_3;
    public GameObject HL_1;
    public GameObject HL_2;
    public GameObject HL_3;

    // Start is called before the first frame update
    void Start()
    {
        SubPnl_1_Img = HL_1.GetComponent<Image>();
        SubPnl_2_Img = HL_2.GetComponent<Image>();
        SubPnl_3_Img = HL_3.GetComponent<Image>();
        //SubPnl_1_Img.enabled = false;
        SubPnl_2_Img.enabled = false;
        SubPnl_3_Img.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onOpenSubPnl_1()
    {
        SubPnl_1_Img.enabled = true;
        SubPnl_2_Img.enabled = false;
        SubPnl_3_Img.enabled = false;
        SubPnl_1.SetActive(true);
        SubPnl_2.SetActive(false);
        SubPnl_3.SetActive(false);
    }

    public void onOpenSubPnl_2()
    {
        SubPnl_1_Img.enabled = false;
        SubPnl_2_Img.enabled = true;
        SubPnl_3_Img.enabled = false;
        SubPnl_1.SetActive(false);
        SubPnl_2.SetActive(true);
        SubPnl_3.SetActive(false);
    }

    public void onOpenSubPnl_3()
    {
        SubPnl_1_Img.enabled = false;
        SubPnl_2_Img.enabled = false;
        SubPnl_3_Img.enabled = true;
        SubPnl_1.SetActive(false);
        SubPnl_2.SetActive(false);
        SubPnl_3.SetActive(true);
    }

}
