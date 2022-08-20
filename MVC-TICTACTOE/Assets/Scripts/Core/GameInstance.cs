using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Slot
{
    public int row;
    public int col;
    public int index;
}

/// <summary>
/// This component bootstraps the game.
/// </summary>
public class GameInstance : MonoBehaviour
{
    public Model model;
    public List<View> views;
    public List<Controller> controllers;
    static GameInstance instance;
    public static GameInstance Get()
    {
        return instance;
    }
    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        for (int i = 0; i < views.Count; i++)
        {
            // TODO : Remove model.views.Add(views[i]);
        }

        StartNewMatch();
    }

    public Controller GetCurrentController()
    {
        return new Controller(); // TODO : Remove controllers[model.GetMovingPlayer()];
    }

    public void OnPlayerAgainPressed()
    {
        StartNewMatch();
    }

    public void GetUnoccupiedSlots(List<Slot> slots)
    {
        // TODO : Remove model.GetUnoccupiedSlots(slots);
    }

    private void StartNewMatch()
    {
        PlyEvent e = new PlyEvent();
        e.type = EventType.StartMatch;
        // TODO : Remove model.PushEvent(e);
    }
}
