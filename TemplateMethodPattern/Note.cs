using System;

namespace TemplateMethodPattern
{
    public class Note : AbstractRecord
    {
        private readonly string _content;

        public Note(string content)
        {
            _content = content;
        }
        
        protected override void Validate()
        {
            if (string.IsNullOrEmpty(_content))
            {
                throw new FieldValidationException("Content is not valid");
            }

            Console.WriteLine("Note data is valid");
        }
    }
}