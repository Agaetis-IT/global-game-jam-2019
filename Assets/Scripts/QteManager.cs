﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QteManager : MonoBehaviour
{
    public int qteNumber = 10;
    public Image key1;
    public Image key2;
    public Image key3;
    public Image key4;
    public Image key5;
    public Image key6;

    private List<XboxKeyEnum> keys;
    private Sprite aSprite;
    private Sprite bSprite;
    private Sprite xSprite;
    private Sprite ySprite;

    void Start()
    {
        aSprite = Resources.Load<Sprite>("xbox_a");
        bSprite = Resources.Load<Sprite>("xbox_b");
        xSprite = Resources.Load<Sprite>("xbox_x");
        ySprite = Resources.Load<Sprite>("xbox_y");

        keys = new List<XboxKeyEnum>();
        for (int i = 0; i < qteNumber; i++)
        {
            keys.Add(GetRandomKey());
        }

        ShowKeys();
    }

    // Update is called once per frame
    void Update()
    {
        if (keys.Count == 0)
        {
            return;
        }

        XboxKeyEnum currentKey = keys[0];
        if (Input.GetButtonDown("XboxA") && currentKey == XboxKeyEnum.XBOX_A
        || Input.GetButtonDown("XboxB") && currentKey == XboxKeyEnum.XBOX_B
        || Input.GetButtonDown("XboxX") && currentKey == XboxKeyEnum.XBOX_X
        || Input.GetButtonDown("XboxY") && currentKey == XboxKeyEnum.XBOX_Y)
        {
            keys.RemoveAt(0);
            ShowKeys();
        }
    }

    static private XboxKeyEnum GetRandomKey()
    {
        var v = Enum.GetValues(typeof(XboxKeyEnum));
        return (XboxKeyEnum)v.GetValue(UnityEngine.Random.Range(0, v.Length));
    }

    private Sprite GetSpriteForKey(XboxKeyEnum key)
    {
        switch (key)
        {
            case XboxKeyEnum.XBOX_A:
                return aSprite;
            case XboxKeyEnum.XBOX_B:
                return bSprite;
            case XboxKeyEnum.XBOX_X:
                return xSprite;
            case XboxKeyEnum.XBOX_Y:
                return ySprite;
        }
        return null;
    }

    private void ShowKeys()
    {
        try
        {
            key1.sprite = GetSpriteForKey(keys[0]);
        }
        catch (ArgumentOutOfRangeException)
        {
            key1.enabled = false;
        }
        try
        {
            key2.sprite = GetSpriteForKey(keys[1]);
        }
        catch (ArgumentOutOfRangeException)
        {
            key2.enabled = false;
        }
        try
        {
            key3.sprite = GetSpriteForKey(keys[2]);
        }
        catch (ArgumentOutOfRangeException)
        {
            key3.enabled = false;
        }
        try
        {
            key4.sprite = GetSpriteForKey(keys[3]);
        }
        catch (ArgumentOutOfRangeException)
        {
            key4.enabled = false;
        }
        try
        {
            key5.sprite = GetSpriteForKey(keys[4]);
        }
        catch (ArgumentOutOfRangeException)
        {
            key5.enabled = false;
        }
        try
        {
            key6.sprite = GetSpriteForKey(keys[5]);
        }
        catch (ArgumentOutOfRangeException)
        {
            key6.enabled = false;
        }
    }
}
