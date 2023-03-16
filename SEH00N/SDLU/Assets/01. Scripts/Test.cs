using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake 실행됨");
    }

    private void Start()
    {
        Debug.Log("Start 실행됨");

    }

    private void OnEnable()
    {
        Debug.Log("OnEnable 실행됨");

    }
}
