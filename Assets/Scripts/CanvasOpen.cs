using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasOpen : MonoBehaviour
{
    private GameObject activeCanvas;
    public GameObject previousCanvas;

    public void ChangeCanvasTo(GameObject canvas)
    {
        if(activeCanvas != null)
        {
            activeCanvas.SetActive(false);
        }

        activeCanvas = canvas;
        activeCanvas.SetActive(true);
    }
}
