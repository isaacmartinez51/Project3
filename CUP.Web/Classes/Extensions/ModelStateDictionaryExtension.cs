using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Continental.CUP.Web.Classes.Extensions
{
    public static class ModelStateDictionaryExtension
    {
        /// <summary>
        /// Excludes the list of model properties from model validation.
        /// </summary>
        /// <param name="ModelState">The model state dictionary which holds the state of model data being interpreted.</param>
        /// <param name="modelProperties">A string array of delimited string property names of the model to be excluded from the model state validation.</param>
        public static void CleanUp(this ModelStateDictionary ModelState, params string[] modelProperties)
        {
            foreach (var prop in modelProperties)
                ModelState.Remove(prop);
        }
    }
}
