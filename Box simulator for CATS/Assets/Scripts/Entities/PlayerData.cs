﻿using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Player Data", menuName = "Player Data")]
class PlayerData : ScriptableObject
{
    [SerializeField] private List<PlayerGameResource> _playerGameResources;
    public List<PlayerGameResource> PlayerGameResources => _playerGameResources;
}