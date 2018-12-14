using FV3.Helpers;
using HelpList.Model;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace HelpList.ViewModel
{
    class ProblemCollector : INotifyPropertyChanged
    {
        #region PropertyChangeSupport
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region Instance Field
        private ObservableCollection<Problem> _problems;
        private DateTime _date;
        #endregion

        #region Constructor
        //blabla
        public ProblemCollector()
        {

            MyHelpList = SingletonHelpList.Instance;

            AddCommand = new RelayCommand(MyHelpList.Add);
            RemoveCommand = new RelayCommand(MyHelpList.Remove);
            RemoveAllCommand = new RelayCommand(MyHelpList.RemoveAll);
        }
        #endregion

        #region Property
        public SingletonHelpList MyHelpList { get; set; }
        public Problem SelectedProblem { get; set; } = null;

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public RelayCommand AddCommand { get; set; }
        public RelayCommand RemoveCommand { get; set; }
        public RelayCommand RemoveAllCommand { get; set; }
        #endregion

        #region Methods not used

        //public void Add()
        //{
        //    _problems.Add(new Problem(Name, Topic, Location, Description));
        //    OnPropertyChanged();
        //}

        //public void Remove()
        //{
        //    if (SelectedProblem != null)
        //    {
        //        _problems.Remove(_selectedProblem);
        //        OnPropertyChanged();
        //    }
        //}
        //public void RemoveAll()
        //{
        //    _problems.Clear();
        //    OnPropertyChanged();
        //}

        //public void RemoveJustOne()
        //{
        //    if (SelectedProblem != null)
        //    {
        //        if (Name==Name)
        //        {
        //            _problems.Remove(_selectedProblem);
        //        OnPropertyChanged();
        //        }

        //    }
        //}

        #endregion

    }
}
