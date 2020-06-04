using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Invector.vCharacterController
{
    public class SitonChair : MonoBehaviour
    {
        public UIManager UIMan;
        public Rigidbody PlayerRig;
        public vThirdPersonInput moveInput;
        public Transform animationPos;
        public Animator anim;
        public Transform player;

        private GameObject UIObj;

        public void Start()
        {
            UIObj = GameObject.Find("UIManager");
            UIMan = UIObj.GetComponent<UIManager>();
        }

        private void OnTriggerStay(Collider other)
        {
            if (Input.GetMouseButtonDown(0) && !UIMan.isInMenu)
            {
                if (anim.GetBool("isSitting") == false)
                {
                    anim.SetTrigger("isSitting");
                    moveInput.enabled = false;
                    PlayerRig.Sleep();
                }
                else if (anim.GetBool("isSitting") == true)
                {
                    anim.ResetTrigger("isSitting");
                    moveInput.enabled = true;
                    PlayerRig.WakeUp();
                }
                player.position = animationPos.position;
                player.rotation = animationPos.rotation;


            }


        }


    }
}