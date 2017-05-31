﻿// Copyright © 2010-2017 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.

using System;

namespace CefSharp.ModelBinding
{
    /// <summary>
    /// Provides the capability to supply an interceptor of
    /// .net method calls from js. Can be used to log method calls.
    public interface IMethodInterceptor
    {
        /// <summary>
        /// Intercept the given method name
        /// </summary>
        /// <param name="originalMethod">method to be called</param>
        /// <param name="methodName">Name of the method to be called</param>
        /// <returns>The method result</returns>
        object Intercept(Func<object> originalMethod, string methodName);
    }
}