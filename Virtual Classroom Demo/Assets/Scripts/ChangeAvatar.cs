using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class ChangeAvatar : MonoBehaviour
{

    public List<GameObject> Avatars;
    public List<Avatar> m_Avatars;
    //public List<Animator> m_Animators;
    public Animator Anim;

    // Start is called before the first frame update
    void Start()
    {
        //m_Avatars[0] = m_Animators.ava
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onChangeAvatar_1()
    {
        foreach(GameObject avatar in Avatars)
        {
            avatar.gameObject.SetActive(false);
        }
        
        
        Anim.avatar = m_Avatars[0];
        Avatars[0].SetActive(true);

    }

    public void onChangeAvatar_2()
    {
        foreach (GameObject avatar in Avatars)
        {
            avatar.gameObject.SetActive(false);
        }

        Anim.avatar = m_Avatars[1];
        Avatars[1].SetActive(true);

    }

    public void onChangeAvatar_3()
    {
        foreach (GameObject avatar in Avatars)
        {
            avatar.gameObject.SetActive(false);
        }

        Anim.avatar = m_Avatars[2];
        Avatars[2].SetActive(true);

    }

}
