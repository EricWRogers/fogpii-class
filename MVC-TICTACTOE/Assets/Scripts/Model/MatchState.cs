using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    public int piecesOnBoard;
    public int pieceCount;

    public void Reset()
    {
        pieceCount = 9;
        piecesOnBoard = 0;
    }

    public bool HasPiece()
    {
        return (pieceCount > 0);
    }
}
public class MatchState
{
    public static readonly int playerCount = 2;
    public Player[] players = null;

    public static readonly int[] winMasks = {
        
    };

    public void Reset()
    {
        players = new Player[playerCount];

        for (int i = 0; i < playerCount; ++i)
        {
            if (players[i] == null)
            {
                players[i] = new Player();
            }

            players[i].Reset();
        }
    }

    public int GetNumPlayers()
    {
        return playerCount;
    }

}
