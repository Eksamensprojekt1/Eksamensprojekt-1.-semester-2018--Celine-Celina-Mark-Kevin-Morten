using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using FV3.Helpers;
using HelpList.Annotations;
using HelpList.Model;

namespace HelpList.ViewModel
{
    public class ForumSite : INotifyPropertyChanged
    {
        #region PropertyChangeSupport

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region InstanceFields

        public ObservableCollection<Forum> _forums;
        private string _name;
        private string _topic;
        private string _description;
        private string _answer;
        private DateTime _date;
        private Forum _selectedForum;
        #endregion

        #region Constructor

        public ForumSite()
        {
            _forums = new ObservableCollection<Forum>();
            _selectedForum = null;

            _forums.Add(new Forum("Morten", "Matematik", "Jeg kan ikke finde ud af noget som helst :(","Så find ud af det"));

            AddCommand = new RelayCommand(Add);
            RemoveCommand = new RelayCommand(Remove);
            UpdateCommand = new RelayCommand(Update);
        }
        #endregion

        #region Properties
        public ObservableCollection<Forum> Forums
        {
            get { return _forums; } 
            set => _forums = value;
        }

        public string Name
        {
            get { return _name;}
            set => _name = value;
        }

        public string Topic
        {
            get { return _topic;} 
            set => _topic = value;
        }

        public string Description
        {
            get { return _description; }
            set => _description = value;
        }

        public string Answer
        {
            get { return _answer; }
            set => _answer = value;
        }

        public DateTime Date
        {
            get{ return _date;}
            set => _date = value;
        }

        public Forum SelectedForum
        {
            get { return _selectedForum; }
            set
            {
                _selectedForum = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand AddCommand { get; set; }
        public RelayCommand RemoveCommand { get; set; }
        public RelayCommand UpdateCommand { get; set; }

        #endregion

        #region Methods

        public void Add()
        {
            _forums.Add(new Forum(Name, Topic, Description, Answer));

        }

        public void Update()
        {
            OnPropertyChanged();
        }
  

        public void Remove()
        {
            if ( SelectedForum != null)
            {
                _forums.Remove(_selectedForum);
                OnPropertyChanged();
            }
        }

        #endregion

    }
}