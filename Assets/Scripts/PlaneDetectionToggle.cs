using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

[RequireComponent(typeof(ARPlaneManager))]
public class PlaneDetectionToggle : MonoBehaviour
{
    private ARPlaneManager planeManager;
    [SerializeField]
    private TextMeshProUGUI toggleButtonText;
    
    private void Awake() {
        planeManager = GetComponent<ARPlaneManager>();
    }

    public void TogglePlaneDetection() {
        planeManager.enabled = !planeManager.enabled;
        string toggleButtonMessage = "바닥 감지";

        if(planeManager.enabled ) {
            toggleButtonMessage = "감지 중단";
            SetAllPlanesActive(false);
        } else {
            toggleButtonMessage = "바닥 감지";
            SetAllPlanesActive(true);
        }

        toggleButtonText.text = toggleButtonMessage;

    }

    private void SetAllPlanesActive(bool value) {
        foreach (var plane in planeManager.trackables) {
            plane.gameObject.SetActive(value);
        }
    }

}
