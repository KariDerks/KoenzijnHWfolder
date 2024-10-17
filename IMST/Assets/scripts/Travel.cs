using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Travel : MonoBehaviour
{
    public GameObject travelUI;
    public GameObject koen;

    public void travelinteract() {
        travelUI.SetActive(true);
        Cursor.visible = true;
        koen.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
    }

    public void closetravel(){ 
        travelUI.SetActive(false);
        koen.SetActive(true);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

    }

    public void travelwoman() {
        SceneManager.LoadScene("oldlady", LoadSceneMode.Single);
    }

}
