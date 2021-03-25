// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Threading;
using System.Web.Compatibility.Features;
using System.Web.SessionState;
using CoreHttpContext = Microsoft.AspNetCore.Http.HttpContext;

namespace System.Web
{
    [Obsolete("This HttpContext should not be used and should be replaced with the ASP.NET Core context", DiagnosticId = "SYSWEB_HTTPCONTEXT")]
    public partial class HttpContext
    {
        private static readonly AsyncLocal<HttpContext> _current = new AsyncLocal<HttpContext>();

        private readonly CoreHttpContext _context;

        public HttpContext(CoreHttpContext context)
        {
            _context = context;
        }

        [Obsolete("HttpContext.Current should not be used and code using it should be refactored to request the services they need", DiagnosticId = "SYSWEB_HTTPCONTEXT_CURRENT")]
        public static HttpContext Current
        {
            get => _current.Value;
            set => _current.Value = value;
        }

        [Obsolete("Should use the ASP.NET Core HttpContext.Items instead", DiagnosticId = "SYSWEB_HTTPCONTEXT_ITEMS")]
        public IDictionary Items
        {
            get => _context.Features.Get<IHttpContextItemsFeature>()?.GetDictionary(_context);
        }

        [Obsolete("Should use ASP.NET Core Session instead", DiagnosticId = "SYSWEB_HTTPCONTEXT_SESSION")]
        public HttpSessionState Session
        {
            get => _context.Features.Get<ISessionFeature>()?.GetSessionState(_context);
        }

        [Obsolete("This constructor does not do anything", error: true, DiagnosticId = "SYSWEB_HTTPCONTEXT")]
        public IPrincipal User
        {
            get => _context.User;
            [Obsolete]
            set => throw new PlatformNotSupportedException(SR.PlatformNotSupportedSystemWeb);
        }

        [Obsolete("This constructor does not do anything", error: true, DiagnosticId = "SYSWEB_HTTPCONTEXT")]
        public HttpContext(HttpRequest request, HttpResponse response)
        {
        }

        public static implicit operator CoreHttpContext(HttpContext context) => context._context;
    }
}
