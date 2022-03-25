using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandboxCellChange : MonoBehaviour
{
    public Sprite emptySprite;
    public Sprite positiveSprite;
    public Sprite negativeSprite;

    private SpriteRenderer cellRenderer;

    private void Start()
    {
        cellRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    public void EmptyCell()
    {
        cellRenderer.sprite = emptySprite;
    }

    public void PositiveCell()
    {
        cellRenderer.sprite = positiveSprite;
    }

    public void NegativeCell()
    {
        cellRenderer.sprite = negativeSprite;
    }
}
