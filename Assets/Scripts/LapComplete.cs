using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour
{
    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;

    public GameObject LapCounter;
    public int LapsDone;

    public float RawTime;

    public GameObject RaceFinish;

    void Update () {
        if (LapsDone == 2) {
            RaceFinish.SetActive (true);
        }
    }

    void OnTriggerEnter (Collider collider) {
        if (collider.gameObject.tag == "Player") {
            LapsDone += 1;
            RawTime = PlayerPrefs.GetFloat ("RawTime");   
            // PlayerPrefs.SetFloat ("RawTime", LapTimeManager.RawTime);

            // LapTimeManager.RawTime = 0;

            LapCounter.GetComponent<Text>().text = "" + (LapsDone + 1);

            HalfLapTrig.SetActive (true);
            LapCompleteTrig.SetActive (false);    
        }
    }
}
