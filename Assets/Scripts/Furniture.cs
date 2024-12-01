using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Furniture : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI furnitureName;
    [SerializeField] TextMeshProUGUI furnitureIntroduction;
    [SerializeField] FurniturSO furnitur;

    void Start(){
        furnitureName.text = furnitur.GetFurnitureName();
        furnitureIntroduction.text = furnitur.GetFurnitureIntroduction();
    }
}
   
