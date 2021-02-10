using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sage_HW4.Models
{
    public class Data
    {
        private static List<Suggestion> suggestions = new List<Suggestion>();

        public static IEnumerable<Suggestion> Suggestions => suggestions;

        //method to add new suggestion
        public static void AddSuggestion(Suggestion suggestion)
        {
            suggestions.Add(suggestion);
        }
    }
}
