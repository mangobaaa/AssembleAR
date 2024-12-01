using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "FurniturData", menuName = "FurniturSO")]
public class FurniturSO : ScriptableObject {
    
    [SerializeField] string furniturName ="가구 이름";
    [TextArea(2,6)]
    [SerializeField] string introduction ="가구 소개";
    [SerializeField]  GameObject furnitureImage;
    [SerializeField] bool isUnlocked;

    public string GetFurnitureName(){
        return furniturName;
    }

    public GameObject GetFurnitureImage(){
        return furnitureImage;
    }

    public string GetFurnitureIntroduction(){
        return introduction;
    }
}
