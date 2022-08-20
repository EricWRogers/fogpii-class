using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAIController : Controller
{
    private List<Slot> slots = new List<Slot>();

    public override void OnStartTurn()
    {
        GameInstance.Get().GetUnoccupiedSlots(slots);

        for (int i = slots.Count - 1; i >= 0; --i)
        {
            Slot slot = slots[i];

            /*
            if (!GameInstance.Get().model.HasAvailableRing(playerId, slot.ringIndex))
            {
                slots.RemoveAt(i);
            }
            */
        }

        // pick a remaining slot at random
        int randomIndex = Random.Range(0, slots.Count);

        Slot pick = slots[randomIndex];

        PlyEvent ply = new PlyEvent();
        ply.type = EventType.Ply;
        ply.playerId = playerId;
        ply.row = pick.row;
        ply.col = pick.col;
        ply.ringIndex = pick.index;

        // TODO : Remove GameInstance.Get().model.PushEvent(ply);
    }
}
