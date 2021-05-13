﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPointTrigger : MonoBehaviour
{
    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;

    void OnTriggerEnter (Collider collider) {
        if (collider.gameObject.tag == "Player") {
            LapCompleteTrig.SetActive (true);
            HalfLapTrig.SetActive (false);
        }
    }
}
