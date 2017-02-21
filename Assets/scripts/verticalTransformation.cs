﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class verticalTransformation : MonoBehaviour
{
    Vector3 _startPosition;
    public float domain;
    public float scalar;


    //use this for initialization
    private void Start()
    {
        _startPosition = transform.position;
        domain = Random.Range(10f, 50f);
        scalar = Random.Range(10f, 50f);
    }

    private void Update()
    {
		transform.position = _startPosition + new Vector3((Mathf.Sin(Time.unscaledTime * 5.0f) * scalar), (Mathf.Sin(Time.unscaledTime * 5.0f) * scalar), (Mathf.Sin(Time.unscaledTime * 5.0f) * scalar));

    }
}