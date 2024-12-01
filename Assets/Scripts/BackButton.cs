using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackButton : MonoBehaviour
{
    public GameObject previousCanvas;
    public GameObject currentCanvas;

    public void GoBackToPreviousCanvas()
    {
       if(previousCanvas != null)
       {
        previousCanvas.SetActive(true);
        currentCanvas.SetActive(false);
       }

    }
}
