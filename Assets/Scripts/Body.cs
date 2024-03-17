using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Body : MonoBehaviour
{
    int injury;
    public Endgame end;
    // Start is called before the first frame update
    void Start()
    {
        injury = 0;
        
    }
    public void Reset(){
        injury = 0;
    }

    public void AddDamage(){
        injury++;
        if (injury > 2){
            Debug.Log("Game over");
            end.Winner(name);
        }
    }

}
