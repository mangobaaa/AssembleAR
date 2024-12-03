using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "FurniturData", menuName = "FurniturSO")]
public class FurniturSO : ScriptableObject {
    
    [SerializeField] string furniturName ="가구 이름";
    [TextArea(2,6)]
    [SerializeField] string introduction ="제품 소개";
    [TextArea(2,6)]
    [SerializeField] string matter ="제품 소재";
    [TextArea(2,6)]
    [SerializeField] string management ="제품 관리";
    [SerializeField] Sprite furnitureImage;
    [SerializeField] Sprite detailfurnitureImage;


    public string GetFurnitureName(){
        return furniturName;
    }

    public Sprite GetFurnitureImage(){
        return furnitureImage;
    }

    public Sprite GetDetailFurnitureImage(){
        return detailfurnitureImage;
    }

    public string GetFurnitureIntroduction(){
        return introduction;
    }
    public string GetFurnitureMatter(){
        return matter;
    }
    public string GetFurnitureManagement(){
        return management;
    }
}
