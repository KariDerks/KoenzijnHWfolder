using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Questclose : MonoBehaviour
{

    public GameObject koen;
    public GameObject questboard;


    public void close(){ 
        questboard.SetActive(false);
        koen.SetActive(true);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

    }

    public void clickadd() {
    GetComponent<Image>().color = Color.green;
    }

}
