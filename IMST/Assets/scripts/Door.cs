using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

public Phone phone;
public Text text;
public Bord bord;

public void open() {
    if(phone.gepakt == true && bord.ingeschreven == true) {
    animator.SetTrigger("dooropen");
    }
    else {
        text.text = "I can't leave yet\nI still have to grab something";
    }
}




}
