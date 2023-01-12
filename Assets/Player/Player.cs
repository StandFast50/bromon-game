using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Player : MonoBehaviour {

    public List<OwnnedBromon> ownedBromon = new List<OwnnedBromon>();

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }
}

[System.Serializable]
public class OwnnedBromon {
    public string Nickname;
    public BaseBromon bromon;
    private int level;
    public List<BromonMoves> moves = new List<BromonMoves>();

}