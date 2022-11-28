using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draw : MonoBehaviour
{

    Coroutine drawing;

    [SerializeField] float posZ = 4;

   // private bool canDraw = false;
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

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        //posZ = hit.transform.position.z + 10;

        // while (true)
       // if (hit.transform.gameObject.CompareTag("King"))
       while(true)
        {

            Vector3 mousePos = Input.mousePosition;
            mousePos.z = posZ;
            Vector3 position = Camera.main.ScreenToWorldPoint(mousePos);
            Debug.Log("Position :" + position);
            line.positionCount++;
            line.SetPosition(line.positionCount - 1, position);
            Debug.Log(line.GetPosition(0));
            yield return null;

             //Debug.Log( Camera.main.ScreenToWorldPoint(Input.mousePosition));
            //Debug.Log("Position :" + position);
        }

        //else
        //{
        //    canDraw = false;
        //}

    }

}
