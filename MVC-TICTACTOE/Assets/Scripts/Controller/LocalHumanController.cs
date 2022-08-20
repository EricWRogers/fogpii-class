public class LocalHumanController : Controller
{
    public override void HandleEvent(PlyEvent e)
    {
        switch(e.type)
        {
            case EventType.Ply:
                e.playerId = playerId;
                // TODO : Remove GameInstance.Get().model.PushEvent(e);
                break;
        }
    }
}
