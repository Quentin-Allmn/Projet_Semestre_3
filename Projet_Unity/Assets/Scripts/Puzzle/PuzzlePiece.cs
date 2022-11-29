using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzlePiece : MonoBehaviour
{

    private bool isDragging = false;
    private float saveY;

    private Vector3 offSet;

    private Vector3 originalPosition;

    private void Start()
    {
        saveY = transform.position.y + 2;
        originalPosition = transform.position;
    }



    private void Update()
    {
        if (!isDragging) return;

        if (isDragging == true)
        {

        var mousePosistion = GetMousPos();
      //  mousePosistion.y = saveY;

        transform.position = mousePosistion - offSet;
        }
    }

    private void OnMouseDown()
    {
        isDragging = true;
        Debug.Log(isDragging);

        offSet = GetMousPos() - (Vector3)transform.position;

    }

    private void OnMouseUp()
    {
        transform.position = originalPosition;
        isDragging = false;
        Debug.Log(isDragging);
    }

    Vector3 GetMousPos()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }


    //https://www.youtube.com/watch?v=o_qEXZhQR-M

}
