﻿using TMPro;
using UnityEngine;
using UnityEngine.UI;

class PlayerGameResourceDisplay : MonoBehaviour
{
    public PlayerGameResource playerGameResource;

    public TextMeshProUGUI value;
    public Image image;

    public void UpdateUI()
    {
        value.text = playerGameResource.Value.ToString();
        image.sprite = playerGameResource.GameResource.Sprite;
    }
}
