using System;

namespace NostalgiaOrbitDLL
{
    [Serializable]
    public class Login
    {
        public DateTime Date { get; set; }
        public string Header { get; set; }
        public bool IsCorrect { get; set; }

        public Login(DateTime date, string header, bool isCorrect)
        {
            Date = date;
            Header = header;
            IsCorrect = isCorrect;
        }
    }
}