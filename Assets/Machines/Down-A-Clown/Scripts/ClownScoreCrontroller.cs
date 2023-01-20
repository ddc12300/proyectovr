using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClownScoreCrontroller : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textScore;
    [SerializeField] float score;

    private void Start()
    {
        MachineEventsManager.BeatenClown += BeatenClown;
        MachineEventsManager.StartWhacParty += StartParty;
    }

    private void OnDisable()
    {
        MachineEventsManager.BeatenClown -= BeatenClown;
        MachineEventsManager.StartClownParty -= StartParty;
    }

    void StartParty()
    {
        score = 0;
        textScore.text = score.ToString();
    }

    public void BeatenClown(int points)
    {
        score += points;
        textScore.text = score.ToString();
    }
}
