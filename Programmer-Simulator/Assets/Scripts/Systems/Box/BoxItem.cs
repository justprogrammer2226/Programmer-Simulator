﻿using UnityEngine;

[System.Serializable]
public class BoxItem
{
    [SerializeField] private int _id;
    public int GameResourceId => _id;

    [SerializeField] private int _value;
    public int Value
    {
        get => _value;
        set => _value = value;
    }
}
