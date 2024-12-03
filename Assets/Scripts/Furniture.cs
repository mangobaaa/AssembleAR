using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Furniture : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI furnitureName;
    [SerializeField] TextMeshProUGUI furnitureIntroduction;
    [SerializeField] TextMeshProUGUI furnitureMatter;
    [SerializeField] TextMeshProUGUI furnitureManagement;
    [SerializeField] Image furnitureImage;
    [SerializeField] Image detailFurnitureImage;
    [SerializeField] FurniturSO furnitur;

    

    void Start(){
        furnitureName.text = furnitur.GetFurnitureName();
        furnitureImage.sprite = furnitur.GetFurnitureImage();
        
    }

    public void OnClick()
    {
        furnitureIntroduction.text = furnitur.GetFurnitureIntroduction();
        furnitureMatter.text = furnitur.GetFurnitureMatter();
        furnitureManagement.text = furnitur.GetFurnitureManagement();
        detailFurnitureImage.sprite = furnitur.GetDetailFurnitureImage();
    }
}
   
