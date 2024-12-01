using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DetailCanvas : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI furnitureName;
    [SerializeField] TextMeshProUGUI furnitureIntroduction;

    void Start()
    {
        FurniturSO selectedFurniture = FurnitureManager.Instance.GetSelectedFurniture();

        if (selectedFurniture != null)
        {
            furnitureName.text = selectedFurniture.GetFurnitureName();
            furnitureIntroduction.text = selectedFurniture.GetFurnitureIntroduction();
        }
    }
}
