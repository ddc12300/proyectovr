using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineEventsManager : MonoBehaviour
{
    public delegate void Party();
    public static Party StartWhacParty;
    public static Party FinishWhacParty;    
    public static Party StartClownParty;
    public static Party FinishClownParty;
    public delegate void Score(int points);
    public static Score BeatenHamster;
    public static Score BeatenClown;
}
