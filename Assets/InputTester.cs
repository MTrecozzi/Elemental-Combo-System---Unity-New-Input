using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputTester : MonoBehaviour
{
    [SerializeField] private TestInput input;

    public PhraseInput r1;
    public PhraseInput r2;
    public PhraseInput l1;
    public PhraseInput l2;

 
    public Aang theLastAirBender = new Aang();

    // hold a button to start a phrase, and then tap another button to continue the phrase, let go of first button to finish.

    // R1 // 1 = Grab  // Fire
    // R2 1 = Push      // Water
    // L1 1 = Swing     // Earth    
    // L2 1 = Gather    //Air



    // Start is called before the first frame update
    void Start()
    {

        r1 = new PhraseInput("R1: Grab", "R1: Fire");
        r2 = new PhraseInput("R2: Push", "R2: Water");
        l1 = new PhraseInput("L1: Swing", "L1: Earth");
        l2 = new PhraseInput("L2: Gather", "L2: Air");


        input = new TestInput();

        input.Combo.R1.Enable();
        input.Combo.R2.Enable();

        input.Combo.L2.Enable();
        input.Combo.L1.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        // Was I triggered this Frame
        if (input.Combo.R1.triggered)
        {
            theLastAirBender.SayPhrase(r1);
        }

        if (input.Combo.R2.triggered)
        {
            theLastAirBender.SayPhrase(r2);
        }

        if (input.Combo.L2.triggered)
        {
            theLastAirBender.SayPhrase(l2);
        }

        if (input.Combo.L1.triggered)
        {
            theLastAirBender.SayPhrase(l1);
        }
    }
}

[System.Serializable]
public class Aang
{
    public Phases currentPhase;

    public void SayPhrase(PhraseInput input)
    {
        if (currentPhase == Phases.PHASE1)
        {
            Debug.Log(input.phase1);
        } else if (currentPhase == Phases.PHASE2)
        {
            Debug.Log(input.phase2);
        }

        NextPhase();

    }

    public void NextPhase()
    {
        if (currentPhase == Phases.PHASE1)
        {
            currentPhase = Phases.PHASE2;
        } else if (currentPhase == Phases.PHASE2)
        {
            currentPhase = Phases.PHASE1;
        }
    }

    public enum Phases { PHASE1, PHASE2};


}

public class PhraseInput {

    public string phase1;
    public string phase2;

    public PhraseInput(string _phase1, string _phase2)
    {
        phase1 = _phase1;
        phase2 = _phase2;
    }

    

 }
