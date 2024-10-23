using gamedev;


public abstract class AppState 
{
    protected Session _sessionCtx;
    protected AppState(Session session) 
    {
         _sessionCtx = session;
    }
}