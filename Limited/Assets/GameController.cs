﻿using UnityEngine;

public class GameController : MonoBehaviour
{
    public PlayerInventory playerInventory;
    public int currentTurn = 0;

    private GameObject notificationBig;
    void Awake()
    {
        // load savegame (eventually)

        // ...

        // start next turn (or first turn)
        NextTurn();
    }
    public void NextTurn()
    {
        if (currentTurn == 0)
        {
            FirstTurn();
        }

        // next turn code

        // ...

        // finally, increase turn counter
        currentTurn++;
    }

    private void FirstTurn()
    {
        /* First turn script */

        // activate notification and fade it out
        notificationBig = GameObject.FindWithTag("UI_NotificationBig");

        if (notificationBig != null)
        {
            BigNotificationAPI notificationBig_script = notificationBig.GetComponent<BigNotificationAPI>(); // get the script attached to the notification object

            if (notificationBig_script != null)
            {
                notificationBig_script.SetText("Choose an initial location for your city.");
                notificationBig_script.FadeOut();
            }
        }

        // get TilemapInteractions script
        var tilemapInteractions = GetComponent<TilemapInteraction>();
    }
}
