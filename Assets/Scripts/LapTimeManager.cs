using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTimeManager : MonoBehaviour
{
    public static float RawTime;


    void Update()
    {
        RawTime += Time.deltaTime;
    }
}
