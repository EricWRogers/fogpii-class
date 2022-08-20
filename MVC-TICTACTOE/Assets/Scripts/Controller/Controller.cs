using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public virtual void HandleEvent(PlyEvent e) {}
    public virtual void OnStartTurn() {}

	public int playerId;
	private List<PlyEvent> events = new List<PlyEvent>();

	public void PushEvent(PlyEvent e)
	{
		events.Add(e);
	}

	void FixedUpdate()
	{
		if (events.Count > 0)
		{
			PlyEvent e = events[0];
			events.RemoveAt(0);

			HandleEvent(e);
		}
	}
}
