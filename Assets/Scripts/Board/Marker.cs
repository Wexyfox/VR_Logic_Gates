using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Marker : MonoBehaviour
{
    [SerializeField] private Transform tipTransform;
    [SerializeField] private int tipSize;

    private Renderer markerRenderer;
    private Board boardObject;
    private Color[] colourArray;
    private float tipHeight;

    private RaycastHit touchedObject;
    private Vector2 touchPosition;
    private Vector2 lastTouchPosition;
    private Quaternion lastTouchRotation;
    private bool touchedLastFrame;
    


    void Start()
    {
        markerRenderer = tipTransform.GetComponent<Renderer>();
        colourArray = Enumerable.Repeat(markerRenderer.material.color, tipSize * tipSize).ToArray();
        tipHeight = tipTransform.localScale.z -0.005f;
    }

   
    void Update()
    {
        Draw();
    }

    private void Draw()
    {
        if (Physics.Raycast(tipTransform.position, transform.forward, out touchedObject, tipHeight))
        {
            if (touchedObject.transform.CompareTag("Board"))
            {
                if (boardObject == null)
                {
                    boardObject = touchedObject.transform.GetComponent<Board>();
                }

                touchPosition = new Vector2(touchedObject.textureCoord.x, touchedObject.textureCoord.y);

                var xPosition = (int)(touchPosition.x * boardObject.textureSize.x - (tipSize / 2));
                var yPosition = (int)(touchPosition.y * boardObject.textureSize.y - (tipSize / 2));

                if (yPosition < 0 || yPosition > boardObject.textureSize.y || xPosition < 0 || xPosition > boardObject.textureSize.x) 
                {
                    return;
                }

                if (touchedLastFrame)
                {
                    boardObject.texture.SetPixels(xPosition, yPosition, tipSize, tipSize, colourArray);

                    for (float percent = 0.01f; percent < 1.00f; percent += 0.02f)
                    {
                        var lerpX = (int)Mathf.Lerp(lastTouchPosition.x, xPosition, percent);
                        var lerpY = (int)Mathf.Lerp(lastTouchPosition.y, yPosition, percent);

                        boardObject.texture.SetPixels(lerpX, lerpY, tipSize, tipSize, colourArray);
                    }

                    transform.rotation = lastTouchRotation;

                    boardObject.texture.Apply();
                }

                lastTouchPosition = new Vector2(xPosition, yPosition);
                lastTouchRotation = transform.rotation;
                touchedLastFrame = true;
                return;
            }
        }

        boardObject = null;
        touchedLastFrame = false;
    }
}
