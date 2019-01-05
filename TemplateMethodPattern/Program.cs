using System;
using System.Collections.Generic;

namespace TemplateMethodPattern
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var user = new User(new Dictionary<string, string> {
                {"username", "SomeUserName"}, 
                {"password", "SomeAwesomePassword"}
            });
            
            user.Save();
            
            Console.WriteLine();
            
            var userWithInvalidData = new User(new Dictionary<string, string>());
            userWithInvalidData.Save();
            
            Console.WriteLine();
            
            var note = new Note("Some random note content");
            note.Save();
            
            Console.WriteLine();
            
            var noteWithInvalidData = new Note("");
            noteWithInvalidData.Save();
        }
    }
}