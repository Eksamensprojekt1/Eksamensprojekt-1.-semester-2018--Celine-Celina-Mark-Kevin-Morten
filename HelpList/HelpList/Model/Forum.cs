using System;

namespace HelpList.Model
{
    public class Forum
    {
        #region Instance Fields
        private string _name;
        private string _topic;
        private string _description;
        private string _answer;
        private DateTime _date;
        #endregion

        #region Constructor
        public Forum(string name, string topic, string description, string answer)
        {
            _name = name;
            _topic = topic;
            _description = description;
            _answer = answer;
            _date = DateTime.Now;
        }
        #endregion

        #region Properties

        public string Name
        {
            get { return _name; }
        }

        public string Topic
        {
            get { return _topic; }
        }

        public string Description
        {
            get { return _description; }
        }
        public string Answer
        {
            get { return _answer; }
        }

        public DateTime Date
        {
            get { return _date; }
        }

        #endregion
    }
}