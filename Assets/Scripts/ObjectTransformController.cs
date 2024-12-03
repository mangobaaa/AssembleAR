using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTransformController : MonoBehaviour
{
    [SerializeField]
    private GameObject objectToMove;
    private SpawnObjectOnPlane spawnObjectOnPlane;

    private void Awake() {
        spawnObjectOnPlane = GetComponent<SpawnObjectOnPlane>();
    }

    // Update is called once per frame
    void Update()
    {
        if(objectToMove == null) {
            objectToMove = spawnObjectOnPlane.getObject();
        }

        // objectToMove.transform.position += new Vector3(0, 0, 1);
    }
}
