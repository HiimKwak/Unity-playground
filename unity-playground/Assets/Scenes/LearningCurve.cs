using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
  void Start()
  {
    Character heroine = new Character("Agatha");
    Debug.LogFormat("Hero: {0} - {1} EXP", heroine.name, heroine.exp);
    FindPartyMember();
  }

  // Update is called once per frame
  public void dd()
  {

  }
  public void FindPartyMember()
  {
    List<string> QuestPartyMembers = new List<string>() {
        "Grim the Barbarian",
        "Merlin the Wise",
        "Sterling the Knight",
    };

    QuestPartyMembers.Add("Craven the Necromancer");
    QuestPartyMembers.Insert(1, "Tanis the Thief");
    QuestPartyMembers.RemoveAt(0);

    int listLength = QuestPartyMembers.Count;
    Debug.LogFormat("Party Members: {0}", listLength);

    for (int i = 0; i < listLength; i++)
    {
      Debug.LogFormat("Index: {0} - {1}", i, QuestPartyMembers[i]);
      if (QuestPartyMembers[i] == "Merlin the Wise")
      {
        Debug.Log("Glad you're here Merlin!");
      }
    }
  }
}
