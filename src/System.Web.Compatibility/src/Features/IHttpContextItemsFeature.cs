using System.Collections;

namespace System.Web.Compatibility.Features
{
    public interface IHttpContextItemsFeature
    {
        IDictionary GetDictionary(Microsoft.AspNetCore.Http.HttpContext context);
    }
}
