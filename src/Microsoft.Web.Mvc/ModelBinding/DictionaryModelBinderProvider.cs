﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Web.Mvc;

namespace Microsoft.Web.Mvc.ModelBinding
{
    public sealed class DictionaryModelBinderProvider : ModelBinderProvider
    {
        public override IExtensibleModelBinder GetBinder(ControllerContext controllerContext, ExtensibleModelBindingContext bindingContext)
        {
            ModelBinderUtil.ValidateBindingContext(bindingContext);

            if (bindingContext.ValueProvider.ContainsPrefix(bindingContext.ModelName))
            {
                return CollectionModelBinderUtil.GetGenericBinder(typeof(IDictionary<,>), typeof(Dictionary<,>), typeof(DictionaryModelBinder<,>), bindingContext.ModelMetadata);
            }
            else
            {
                return null;
            }
        }
    }
}
