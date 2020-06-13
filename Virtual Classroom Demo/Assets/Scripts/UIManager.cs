using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Cinemachine;
using DG.Tweening;

namespace Invector.vCharacterController
{
    public class UIManager : MonoBehaviour
    {

        public Texture2D CursorArrow;

        public CinemachineFreeLook CVcam;
        public Animator anim;


        public GameObject MenuPanel;
        public GameObject BarPanel;

        public GameObject ActionPanel;





        public vThirdPersonInput moveInput;
        public bool isInMenu;
        public bool isInBar = false;


        // Start is called before the first frame update
        void Start()
        {
            Cursor.SetCursor(CursorArrow, Vector2.zero, CursorMode.ForceSoftware);

            ActionPanel.SetActive(false);
            MenuPanel.SetActive(false);
            BarPanel.SetActive(false);
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }

        // Update is called once per frame
        void Update()
        {
            PaueGame();
            PauseBar();

        }

        public void onExitApplication()
        {

            Application.Quit();

        }

        public void PaueGame()
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                if(isInMenu == false)
                { 
                    showMenu();
                    isInMenu = true;
                    //source.clip = TagSFX;
                    //source.Play();
                }
                else if (isInMenu == true)
                {
                    if(isInBar)
                    {
                        hideBar();
                    }
                     hideMenu();
                    isInMenu = false;
                     // source.clip = TagSFX;
                     // source.Play();
                
                }
            }
        }

        public void PauseBar()
        {
            if (Input.GetKeyDown(KeyCode.L))
            {
                if(isInMenu == true)
                {
                    if (isInBar == false)
                    {
                        showBar();
                        isInBar = true;
                        //source.clip = TagSFX;
                        //source.Play();
                    }
                    else if (isInBar == true)
                    {

                        hideBar();
                        isInBar = false;
                        // source.clip = TagSFX;
                        // source.Play();

                    }
                }
            }
        
        }

        public void showBar()
        {
            BarPanel.SetActive(true);
        }
            
        public void hideBar()
        {
            BarPanel.SetActive(false);
        }

        public void showMenu()
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            MenuPanel.SetActive(true);
            CVcam.enabled = false;
            moveInput.enabled = false;
            anim.SetBool("isMenuing", true);
            //ResetAnimator();

        }

        public void hideMenu()
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            MenuPanel.SetActive(false);
            CVcam.enabled = true;
            moveInput.enabled = true;
            anim.SetBool("isMenuing", false);
        }

        private void ResetAnimator()
        {
            anim.ResetTrigger("InputHorizontal");
            anim.ResetTrigger("InputVertical");
            anim.ResetTrigger("InputMagnitude");
            anim.ResetTrigger("IsGrounded");
            anim.ResetTrigger("IsStrafing");
            anim.ResetTrigger("IsSprinting");
            anim.ResetTrigger("GroundDistance");
        }

        public void onOpenActionPnl()
        {
            if (ActionPanel.activeInHierarchy)
            {
                ActionPanel.SetActive(false);
                //StartCoroutine(ActionPnlSlideCoroutine());

            }
            else
            {
                ActionPanel.SetActive(true);
               // iTween.MoveBy(ActionPanel, iTween.Hash("x", -237, "time", .3f, "easeType", "easeInOutSine", "loopType", "none"));

            }

        }

        IEnumerator ActionPnlSlideCoroutine()
        {
            //iTween.MoveBy(ActionPanel, iTween.Hash("x", 237, "time", .3f, "easeType", "easeInOutSine", "loopType", "none"));
            yield return new WaitForSeconds(.5f);
            ActionPanel.SetActive(false);
        }


        public void CloseTab()
        {
            this.transform.parent.gameObject.SetActive(false);
        }



    }
}
