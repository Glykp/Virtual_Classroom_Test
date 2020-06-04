using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseButton : MonoBehaviour
{

    public GameObject ThisPanel;

    public void CloseTab()
    {
        this.gameObject.SetActive(false);
    }
}
