using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class phone : MonoBehaviour
{

public GameObject telefoon;
public bool gepakt = false;

    public void oppakken() {
        telefoon.SetActive(false);
        gepakt = true;
    }
}
