using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draw : MonoBehaviour
{

    Coroutine drawing;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartLine();
        }
        if (Input.GetMouseButtonUp(0))
        {
            FinishLine();
        }
    }

    void StartLine()
    {
        if (drawing != null)
        {
            StopCoroutine(drawing);
        }
        drawing = StartCoroutine(DrawLine());
    }

    void FinishLine()
    {
        StopCoroutine(drawing);
    }

    IEnumerator DrawLine()
    {
        GameObject newGameObject = Instantiate(Resources.Load("Line") as GameObject, new Vector3(0, 0, 0), Quaternion.identity);
        LineRenderer line = newGameObject.GetComponent<LineRenderer>();
        line.positionCount = 0;

        while (true)
        {

            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 4;
            Vector3 position = Camera.main.ScreenToWorldPoint(mousePos);
           // Vector3 position = Input.mousePosition;
            Debug.Log("Position :" + position);
            //position.x = +20;
            //position.z = -7;
            line.positionCount++;
            line.SetPosition(line.positionCount - 1, position);
            Debug.Log(line.GetPosition(0));
            yield return null;

             //Debug.Log( Camera.main.ScreenToWorldPoint(Input.mousePosition));
            //Debug.Log("Position :" + position);
        }
    }

}
