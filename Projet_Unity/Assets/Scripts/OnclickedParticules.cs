using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnclickedParticules : MonoBehaviour
{

    [SerializeField] GameObject onClickedEvent;

    public void CreateParticle()
    {
        var particle = Instantiate(onClickedEvent, transform.position, Quaternion.identity);
        Destroy(particle, 0.5f);
    }

}
