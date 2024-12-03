using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manual : MonoBehaviour
{
    [SerializeField]
    private Sprite[] m_Sprites;

    [SerializeField]
    private GameObject sliderObject;

    private SpriteRenderer spriteRenderer;
    private int index = 0;
    
    public void Awake() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void Update() {
        spriteRenderer.sprite = m_Sprites[index];
        Slider slider = sliderObject.GetComponent<Slider>();
        slider.value = index;
    }

    public void NextPage() {
        if(index >= 7) {
            index = 7;
            return;
        }
        index++;
    }

    public void PreviousPage() {
        if (index <= 0) {
            index = 0;
            return;
        }
        index--;
    }

}
