using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Questboard : MonoBehaviour
{
public GameObject questboard;
public GameObject koen;

public void klikquests() {
    questboard.SetActive(true);
    Cursor.visible = true;
    koen.SetActive(false);
    Cursor.lockState = CursorLockMode.None;
}

}
