using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishRotate : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(0,1,0,Space.World);
         StartCoroutine (ToEnd ());
    }

    IEnumerator ToEnd ()
    {
        yield return new WaitForSeconds (4);
        SceneManager.LoadScene (3);
    }
}
