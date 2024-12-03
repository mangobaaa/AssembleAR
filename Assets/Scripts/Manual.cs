using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manual : MonoBehaviour
{
    [SerializeField]
    private Sprite[] m_Sprites;
    private SpriteRenderer spriteRenderer;
    private int index = 4;

    public void Awake() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void Update() {
        spriteRenderer.sprite = m_Sprites[index];
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
