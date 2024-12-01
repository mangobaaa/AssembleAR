using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackButton : MonoBehaviour
{
    public void GoBackToPreviousCanvas(){
        CanvasManager.Instance.CloseCurrentCanvas();
    }
}
