using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineAnimator : MonoBehaviour
{
    [SerializeField] private float animationDuration = 5f;

    private LineRenderer lineRenderer;

    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();

        StartCoroutine(AnimateLine());
    }

    private IEnumerator AnimateLine()
    {
        float startTime = Time.time;

        Vector3 startPosition = lineRenderer.GetPosition(0);
        Vector3 endPosition = lineRenderer.GetPosition(1);

        Vector3 pos = startPosition;

        while (pos != endPosition)
        {
            float t = (Time.time - startTime) / animationDuration;
            pos = Vector3.Lerp(startPosition, endPosition, t);
            lineRenderer.SetPosition(1, pos);

            if(t>= 1f)
            {
                lineRenderer.SetPosition(0, pos);
            }

            yield return new WaitForSeconds(0.01f);
        }

    }

    void Update()
    {

    }
}
