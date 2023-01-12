using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public List<BaseBromon> allBromon = new List<BaseBromon>();
    public List<BromonMoves> BromonMoves= new List<BromonMoves>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


[System.Serializable]

public class BromonMoves {
    string Name;
    public MoveType catargory;
    public Stat moveStat;
    public BromonType moveType;
    public int PP;
    public float power;
    public float accuracy;
}

[System.Serializable]
public class Stat {
    public float mininum;
    public float maxinum;
}

public enum MoveType {
    Physical,
    Special,
    Status
}