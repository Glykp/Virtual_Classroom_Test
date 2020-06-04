using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowSubPanel : MonoBehaviour
{

    public Transform MySubPanel;
    public Transform MainSubPanel;
    public GameObject MySubPanelObject;
    public GameObject MainSubPanelObject;

    private bool isShowing;

    // Start is called before the first frame update
    void Start()
    {
        isShowing = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowMyPanel()
    {
        if(isShowing == false)
        {
            isShowing = true;
            MainSubPanelObject.SetActive(true);
            SetActiveAllChildren(MainSubPanel, false);
            MySubPanelObject.SetActive(true);
            SetActiveAllChildren(MySubPanel, true);
        }
        else
        {
            isShowing = false;
            SetActiveAllChildren(MainSubPanel, false);
        }

    }

    private void SetActiveAllChildren(Transform transform, bool value)
    {
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(value);

            SetActiveAllChildren(child, value);
        }
    }


}
