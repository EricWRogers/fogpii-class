public enum EventType
{
    EndMatchStalemate,
    EndMatchWin,
    Ply,
    StartMatch,
    StartTurn
}

public class PlyEvent
{
    public EventType type;
    public int playerId;
    public int row;
    public int col;
    public int ringIndex;
}
