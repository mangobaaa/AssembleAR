using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasOpen : MonoBehaviour
{
    [SerializeField] private GameObject activeCanvas;

    public void ChangeCanvasTo(GameObject canvasToActivate)
    {
        CanvasManager.Instance.OpenCanvas(canvasToActivate);
    }

}
