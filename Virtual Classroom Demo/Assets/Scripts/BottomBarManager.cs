using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomBarManager : MonoBehaviour
{

    public GameObject MicPnl;
    public GameObject CanPnl;
    public GameObject ViewPnl;

    // Start is called before the first frame update
    void Start()
    {
        MicPnl.SetActive(false);
        CanPnl.SetActive(false);
        ViewPnl.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onOpenMic()
    {
        MicPnl.SetActive(false);
        CanPnl.SetActive(false);
        ViewPnl.SetActive(false);
        if (MicPnl.activeInHierarchy)
        {
            MicPnl.SetActive(false);
        }
        else
        {
            MicPnl.SetActive(true);

        }
    }

    public void onOpenCan()
    {
        MicPnl.SetActive(false);
        CanPnl.SetActive(false);
        ViewPnl.SetActive(false);
        if (CanPnl.activeInHierarchy)
        {
            CanPnl.SetActive(false);
        }
        else
        {
            CanPnl.SetActive(true);

        }
    }

    public void onOpenView()
    {
        MicPnl.SetActive(false);
        CanPnl.SetActive(false);
        ViewPnl.SetActive(false);
        if (ViewPnl.activeInHierarchy)
        {
            ViewPnl.SetActive(false);
        }
        else
        {
            ViewPnl.SetActive(true);

        }
    }
}
