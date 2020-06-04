using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMore : MonoBehaviour
{

    public GameObject Showing;
    public GameObject notShowing;
    private Transform ShowingTransform;
    private Transform notShowingTransform;
    // Start is called before the first frame update
    void Start()
    {
        ShowingTransform = Showing.GetComponent<Transform>();
        notShowingTransform = notShowing.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowMorePanel()
    {
        SetActiveAllChildren(notShowingTransform, false);
        Showing.SetActive(true);
    }

    private void SetActiveAllChildren(Transform transform, bool value)
    {
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(value);

            //SetActiveAllChildren(child, value);
        }
    }

}
