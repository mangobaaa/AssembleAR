using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    public static CanvasManager Instance; // 싱글톤 인스턴스

    private Stack<GameObject> canvasStack = new Stack<GameObject>(); // 캔버스 스택

    void Start()
    {
        GameObject mainCanvas = GameObject.Find("MainCanvas"); 
        if (mainCanvas != null)
        {
            canvasStack.Push(mainCanvas); // 스택에 추가
        }
    }
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void OpenCanvas(GameObject newCanvas)
    {
        if (canvasStack.Count > 0)
        {
            // 현재 활성화된 캔버스를 비활성화
            canvasStack.Peek().SetActive(false);
        }

        // 새 캔버스를 활성화하고 스택에 추가
        newCanvas.SetActive(true);
        canvasStack.Push(newCanvas);
    }

    public void CloseCurrentCanvas()
    {
        if (canvasStack.Count > 0)
        {
            // 현재 캔버스를 비활성화 및 스택에서 제거
            GameObject currentCanvas = canvasStack.Pop();
            currentCanvas.SetActive(false);

            // 스택에 남아 있는 캔버스를 다시 활성화
            if (canvasStack.Count > 0)
            {
                canvasStack.Peek().SetActive(true);
            }
        }
    }
}
