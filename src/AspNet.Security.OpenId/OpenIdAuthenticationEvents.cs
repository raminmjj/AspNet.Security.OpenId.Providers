﻿/*
 * Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
 * See https://github.com/aspnet-contrib/AspNet.Security.OpenId.Providers
 * for more information concerning the license and the contributors participating to this project.
 */

using System;
using System.Threading.Tasks;
using Microsoft.AspNet.Authentication;

namespace AspNet.Security.OpenId {
    /// <summary>
    /// Specifies callback methods that the <see cref="OpenIdAuthenticationMiddleware{TOptions}"/>
    /// invokes to enable developer control over the OpenID2 authentication process.
    /// </summary>
    public class OpenIdAuthenticationEvents : RemoteAuthenticationEvents, IOpenIdAuthenticationEvents {
        /// <summary>
        /// Defines a notification invoked when the user is authenticated by the identity provider.
        /// </summary>
        public Func<OpenIdAuthenticatedContext, Task> OnAuthenticated { get; set; } = context => Task.FromResult<object>(null);

        /// <summary>
        /// Defines a notification invoked when the user is authenticated by the identity provider.
        /// </summary>
        /// <param name="context">The context of the event carries information in and results out.</param>
        /// <returns>Task to enable asynchronous execution</returns>
        public virtual Task Authenticated(OpenIdAuthenticatedContext context) => OnAuthenticated(context);
    }
}
