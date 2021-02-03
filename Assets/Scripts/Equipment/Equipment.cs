using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment
{
    string _name = "";
    int _maxDurability = 0;
    int _rarity = 0;
    int _level = 0;
    int _playerLevelRequire = 0;
    StatType _statRequire = StatType.NONE;
    int _statLevelRequire = 0;

    int durability = 0;
}