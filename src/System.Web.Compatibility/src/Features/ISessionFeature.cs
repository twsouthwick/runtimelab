using System.Web.SessionState;

namespace System.Web.Compatibility.Features
{
    public interface ISessionFeature
    {
        HttpSessionState GetSessionState(Microsoft.AspNetCore.Http.HttpContext context);
    }
}
