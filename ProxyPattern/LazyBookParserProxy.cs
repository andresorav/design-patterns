using System;

namespace ProxyPattern
{
    public class LazyBookParserProxy : IBookParser
    {
        private readonly string _book;
        private IBookParser _bookParser;
        
        public LazyBookParserProxy(string book)
        {
            _book = book;
        }
        
        public int GetNumberOfWords()
        {
            if (_bookParser == null)
            {
                InitializeBookParser();
            }

            return _bookParser.GetNumberOfWords();
        }

        private void InitializeBookParser()
        {
            _bookParser = new BookParser(_book);
        }
    }
}