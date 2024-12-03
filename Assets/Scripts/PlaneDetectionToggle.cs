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
        string toggleButtonMessage = "�ٴ� ����";

        if(planeManager.enabled ) {
            toggleButtonMessage = "���� �ߴ�";
            SetAllPlanesActive(false);
        } else {
            toggleButtonMessage = "�ٴ� ����";
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
