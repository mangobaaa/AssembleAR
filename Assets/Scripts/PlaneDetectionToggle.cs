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
        // spawnObjectOnPlane.CanChangePosition = planeManager.enabled;

        string toggleButtonMessage = "";

        if (planeManager.enabled ) {
            toggleButtonMessage = "조립 모드";
            spawnObjectOnPlane.CanChangePosition = false;
        } else {
            toggleButtonMessage = "배치 모드";
            spawnObjectOnPlane.CanChangePosition = true;
        }
        toggleButtonText.text = toggleButtonMessage;
    }

    private void Update() {
        if(spawnObjectOnPlane.CanChangePosition) {
            SetAllPlanesActive(true);
        } else {
            SetAllPlanesActive(false);
        }
    }

    private void SetAllPlanesActive(bool value) {
        foreach (var plane in planeManager.trackables) {
            plane.gameObject.SetActive(value);
        }
    }

}
