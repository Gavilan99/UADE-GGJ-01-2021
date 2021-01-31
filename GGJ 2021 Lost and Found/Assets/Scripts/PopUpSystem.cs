using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PopUpSystem : MonoBehaviour
{
    public GameObject popUpBox;
    public Animator animator;
    public Text dialogText;

    public void PopUp(string text)
    {
        Debug.Log("Estoy funcionando");
        popUpBox.SetActive(true);
        dialogText.text = text; 
        if (animator.GetBool("isOpen"))
        {
            animator.SetTrigger("close");
            animator.SetBool("isOpen", false);
            animator.ResetTrigger("pop");

        }
        else
        {
            animator.SetTrigger("pop");
            animator.SetBool("isOpen", true);
            animator.ResetTrigger("close");
            

        }
        
        

    }
}
