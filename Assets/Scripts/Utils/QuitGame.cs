using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class QuitGame : MonoBehaviour
{
   public void Quit()
    {

#if UNITY_EDITOR
#else
#endif

        /*
        Application.Quit();
        Debug.Log("Application closed.");
        */
    }
}
