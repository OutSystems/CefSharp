﻿// Copyright © 2010-2017 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.

using System;

namespace CefSharp.ModelBinding
{
    /// <summary>
    /// Binds incoming request data to a model type
    /// </summary>
    public interface IBinder
    {
        /// <summary>
        /// Bind to the given model type
        /// </summary>
        /// <param name="obj">object to be converted into a model</param>
        /// <param name="modelType">Model type to bind to</param>
        /// <param name="camelCaseJavascriptNames">Specifies whether the object fields names should be converted to Pascal Case</param>
        /// <returns>Bound model</returns>
        object Bind(object obj, Type modelType, bool camelCaseJavascriptNames = false);
    }
}