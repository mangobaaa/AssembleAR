using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Furniture : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI furnitureName;
    [SerializeField] TextMeshProUGUI furnitureIntroduction;
    [SerializeField] TextMeshProUGUI furnitureMatter;
    [SerializeField] TextMeshProUGUI furnitureManagement;
    [SerializeField] FurniturSO furnitur;
    

    void Start(){
        furnitureName.text = furnitur.GetFurnitureName();
        
    }

    public void OnClick()
    {
        furnitureIntroduction.text = furnitur.GetFurnitureIntroduction();
        furnitureMatter.text = furnitur.GetFurnitureMatter();
        furnitureManagement.text = furnitur.GetFurnitureManagement();
    }
}
   
