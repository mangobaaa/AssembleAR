using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnitureManager : MonoBehaviour
{
     public static FurnitureManager Instance; // Singleton Instance

    private FurniturSO selectedFurniture; // 선택된 가구 데이터 저장

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // 씬 전환 시 파괴되지 않도록 설정
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetSelectedFurniture(FurniturSO furniture)
    {
        selectedFurniture = furniture;
    }

    public FurniturSO GetSelectedFurniture()
    {
        return selectedFurniture;
    }
}
