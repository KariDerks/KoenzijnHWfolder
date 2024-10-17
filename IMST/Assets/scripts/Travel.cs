using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Travel : MonoBehaviour
{
    public GameObject travelUI;
    public GameObject koen;
    public GameObject crosshair;
    public PlayerMove playermove;
    public PlayerLook playerlook;
    public CameraLookDetector cameralookdetector;

    public void travelinteract() {
        travelUI.SetActive(true);
        Cursor.visible = true;
        crosshair.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
        playermove.enabled = false;
        playerlook.enabled = false;
        cameralookdetector.enabled = false;
    }

    public void closetravel(){ 
        travelUI.SetActive(false);
        Cursor.visible = false;
        crosshair.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        playermove.enabled = true;
        playerlook.enabled = true;
        cameralookdetector.enabled = true;

    }

    public void travelwoman() {
        SceneManager.LoadScene("oldlady", LoadSceneMode.Single);
         travelUI.SetActive(false);
        koen.SetActive(true);
        Cursor.visible = false;
        crosshair.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void travelmain() {
        SceneManager.LoadScene("main", LoadSceneMode.Single);
         travelUI.SetActive(false);
        koen.SetActive(true);
        Cursor.visible = false;
        crosshair.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void travelsupermarkt() {
        SceneManager.LoadScene("supermarkt", LoadSceneMode.Single);
         travelUI.SetActive(false);
        koen.SetActive(true);
        Cursor.visible = false;
        crosshair.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void travelhome() {
        SceneManager.LoadScene("outside", LoadSceneMode.Single);
         travelUI.SetActive(false);
        koen.SetActive(true);
        Cursor.visible = false;
        crosshair.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
    }

}
