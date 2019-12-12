using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloattextDele : MonoBehaviour
{
    public float DestroyTime = .1f;
    void Start()
    {
        Destroy(gameObject, DestroyTime);
    }
}
