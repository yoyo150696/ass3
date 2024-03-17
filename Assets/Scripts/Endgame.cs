using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Endgame : MonoBehaviour
{
    public GameObject go;
    public GameObject startgo;
    public Body downp;
    public Body upp;
    public TextMeshProUGUI textplayer;

    public void Winner(String s){
        if(downp.name != s)
            textplayer.text = downp.name;
        else
            textplayer.text = upp.name;    
        go.SetActive(true);
    }
    public void Newgame(){
        downp.Reset();
        upp.Reset();
        go.SetActive(false);

    }
    public void Startgame(){
        startgo.SetActive(false);
    }
}
