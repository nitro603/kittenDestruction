using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete : MonoBehaviour
{
    public float time = .5F;
    // Start is called before the first frame update
    void Awake()
    {
        Destroy(this.gameObject, time);
    }

}
