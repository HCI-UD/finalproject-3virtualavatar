using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RogoDigital.Lipsync;

public class VHSpeech : MonoBehaviour
{
    private LipSync ls;
    public LipSyncData[] lsAudio;
    void Start()
    {
        ls = GameObject.Find("remy").GetComponent<LipSync>();
     
    }

    void Update()
    {
        if(!ls){
            ls = GameObject.Find("remy").GetComponent<LipSync>(); 
        }
    }

    //First option in senario one
    public void iWasBornHere() {
        ls.Play(lsAudio[0]);
    }

    public void getOut() {
        ls.Play(lsAudio[1]);
    }
    public void notPolite() {
        ls.Play(lsAudio[2]);
    }
    public void noOffense() {
        ls.Play(lsAudio[3]);
    }
    public void showsBias() {
        ls.Play(lsAudio[3]);
    }

    //Second option in senerio one
    public void noProblem() {
        ls.Play(lsAudio[4]);
    }

    public void suitYourself() {
        ls.Play(lsAudio[5]);
    }
    public void seeYouNextTime() {
        ls.Play(lsAudio[6]);
    }
    public void justLeave() {
        ls.Play(lsAudio[7]);
    }

    //Option 3&4
    public void haveANiceDay() {
        ls.Play(lsAudio[8]);
    }

    //Intro
    public void hereIsYourOrder() {
        
        ls.Play(lsAudio[9]);
    }
}
