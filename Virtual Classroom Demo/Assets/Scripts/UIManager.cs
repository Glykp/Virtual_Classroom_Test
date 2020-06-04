using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Cinemachine;

namespace Invector.vCharacterController
{
    public class UIManager : MonoBehaviour
    {
        public CinemachineFreeLook CVcam;
        public Animator anim;
        //Panels: Friends, Chats, Badges, Groups, Play as Teacher, Vote for ...(Yes/No, NewClassroom...), Quest, Change AVATAR, Course Materials, Emote, Typing/Speaking indicator, Environment Interaction
        //Panel Trees: 
        //(ClassRoom)InfoPanel: the class discription, CoursePanel, Play as Teacher
        //SocialPanel: Friends, Chats, Group
        //MyPanel: my info, Badges, AVATAR, Quest, 
        //VotePanel
        //Emote
        //Exit ClassRoom
        //Teacher Mode: Student Statistic, Call Vote, Roll Call, Draw one, Course Slides..., Class Recording,

        //Students only

        public GameObject MenuPanel;
        
        public GameObject PersonalPanel;
        public GameObject SocialPanel;
        /*
        public GameObject FriendsPanel;
        public GameObject ChatsPanel;
        public GameObject BadgesPanel;
        public GameObject AVATARPanel;
        public GameObject GroupPanel;
        public GameObject VotePanel;
        public GameObject QuestPanel;
        public GameObject CoursePanel;
        public GameObject EmotePanel;

        //Teacher only
        public GameObject StudentsPanel;
        public GameObject IntercationPanel;
        public GameObject CoursePanel_Teacher;
        */


        public vThirdPersonInput moveInput;
        public bool isInMenu;


        // Start is called before the first frame update
        void Start()
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }

        // Update is called once per frame
        void Update()
        {
            PaueGame();


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

                     hideMenu();
                    isInMenu = false;
                     // source.clip = TagSFX;
                     // source.Play();
                
                }
            }
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

        public void onOpenSocialWindow()
        {
            if (SocialPanel.activeInHierarchy)
            {
                SocialPanel.SetActive(false);
            }
            else
            {
                SocialPanel.SetActive(true);

            }

        }

        public void onOpenPersonalWindow()
        {
            if (PersonalPanel.activeInHierarchy)
            {
                PersonalPanel.SetActive(false);
            }
            else
            {
                PersonalPanel.SetActive(true);

            }

        }


        public void CloseTab()
        {
            this.transform.parent.gameObject.SetActive(false);
        }



    }
}
