using System;
using System.Collections.Generic;

namespace TemplateMethodPattern
{
    public abstract class AbstractRecord
    {
        protected readonly IDictionary<string, string> Fields;

        protected AbstractRecord(IDictionary<string, string> fields = null)
        {
            Fields = fields;
        }
        
        public void Save()
        {
            try
            {
                Validate();
                BeforeSave();
                SaveRecord();
                AfterSave();
            }
            catch (FieldValidationException exception)
            {
                FailedSave(exception);
            }
        }

        protected virtual void Validate()
        {
        }

        protected virtual void FailedSave(FieldValidationException exception)
        {
            Console.WriteLine("Failed to save {0}, got an exception: {1}", this.GetType().Name, exception.Message);
        }
        
        protected virtual void BeforeSave()
        {
        }

        protected virtual void AfterSave()
        {
            Console.WriteLine("{0} successfully saved", this.GetType().Name);
        }
        
        private void SaveRecord()
        {
            Console.WriteLine("Saving {0} record", this.GetType().Name);
        }
    }
    
    public class FieldValidationException : Exception
    {
        public FieldValidationException(string message) : base(message)
        {
        }
    }
}