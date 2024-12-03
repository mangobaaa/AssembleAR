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
    private SpawnObjectOnPlane spawnObjectOnPlane;
    [SerializeField]
    private TextMeshProUGUI toggleButtonText;
    
    private void Awake() {
        planeManager = GetComponent<ARPlaneManager>();
        spawnObjectOnPlane = GetComponent<SpawnObjectOnPlane>();
    }

    public void TogglePlaneDetection() {
        planeManager.enabled = !planeManager.enabled;
        spawnObjectOnPlane.CanChangePosition = planeManager.enabled;

        string toggleButtonMessage = "��ġ ���";

        if (planeManager.enabled ) {
            toggleButtonMessage = "���� ���";
            SetAllPlanesActive(false);
        } else {
            toggleButtonMessage = "��ġ ���";
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
