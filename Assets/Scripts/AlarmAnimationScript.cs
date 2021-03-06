﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AlarmAnimationScript : MonoBehaviour
{
    public float speed = 1f;
    public float distance = 1f;
    private Vector3 initialPosition;

    void Start()
    {
        initialPosition = this.transform.position;
        this.transform.position += new Vector3(distance, 0, 0);
        StartCoroutine(Timer());
    }

    // Update is called once per frame
    void Update()
    {
        if (initialPosition.x < this.transform.position.x)
        {
            this.transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
        }
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(3.5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
