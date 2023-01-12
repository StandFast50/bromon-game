using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseBromon : MonoBehaviour {

    public string Name;
    public Sprite image;
    public BromonType type;
    public Stat HPstat;
    public Stat AttackStat;
    public Stat DeffenseStat;
    public float speed;
    public int bromonNumber; //This is going to be on the card and will tell you which bromon this was out of how many total their are.

    public BromonStats bromonStats;

    private int level;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }
}

public enum Rarity {
    VeryCommon,
    Common,
    SmiRare,
    Rare,
    VeryRare
}

public enum BromonType {
    Fire,
    Water,
    Magic,
    Tech,
    Flying,
    Undead,
    Plant,
    Electric,
    Food
}


[System.Serializable] 
public class BromonStats {
    public int AttackStat;
    public int DeffenseStat;
    public int SpeedStat;
    public int DefenseStat;
    public int SpAttackStat;
    public int SpDeffenseStat;
    public int EvasionStat;
}