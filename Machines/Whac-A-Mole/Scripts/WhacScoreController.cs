using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WhacScoreController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textScore;
    [SerializeField] float score;

    private void Start()
    {
        MachineEventsManager.BeatenHamster += BeatenHamster;
        MachineEventsManager.StartWhacParty += StartParty;
    }

    private void OnDisable()
    {
        MachineEventsManager.BeatenHamster -= BeatenHamster;  
        MachineEventsManager.StartWhacParty -= StartParty;
    }

    void StartParty()
    {
        score = 0;
        textScore.text = "Score: " + score;
    }

    public void BeatenHamster(int points)
    {
        score += points;
        textScore.text = "Score: " + score;
    }

}
