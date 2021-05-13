using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMenu : MonoBehaviour
{
    void Start()
    {
        StartCoroutine (ToStart ());
    }

    IEnumerator ToStart ()
    {
        yield return new WaitForSeconds (4);
        SceneManager.LoadScene (0);
    }
}
