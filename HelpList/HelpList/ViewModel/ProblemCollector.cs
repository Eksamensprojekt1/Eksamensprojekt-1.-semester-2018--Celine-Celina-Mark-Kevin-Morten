using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using FV3.Helpers;
using HelpList.Model;
using HelpList.ViewModel;


namespace HelpList.ViewModel
{
    class ProblemCollector
    {

        #region Instance Field

        private ObservableCollection<Problem> _problems;
        private DateTime _date;
        #endregion

        #region Constructor

        public ProblemCollector()
        {
            MyHelpList = HelpListSingleton.Instance;
            

            AddCommand = new RelayCommand(MyHelpList.Add);
            RemoveCommand = new RelayCommand(MyHelpList.Remove);
            RemoveAllCommand = new RelayCommand(MyHelpList.RemoveAll);
            SaveProblem = new RelayCommand(MyHelpList.AddProblemMethod);
        }
        #endregion

        #region Property

        public HelpListSingleton MyHelpList { get; set; }

        public Problem SelectedProblem { get; set; } = null;

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }


        public RelayCommand AddCommand { get; set; }
        public RelayCommand RemoveCommand { get; set; }
        public RelayCommand RemoveAllCommand { get; set; }
        public RelayCommand SaveProblem { get; set; }

        #endregion

        #region Methods

        //public void Add()
        //{
        //    _problems.Add(new Problem(Name, Topic, Location, Description));
        //}

        //public void Remove()
        //{
        //    if (SelectedProblem != null)
        //    {
        //        _problems.Remove(SelectedProblem);
        //    }
        //}

        //public void RemoveAll()
        //{
        //    _problems.Clear();
        //}

        #endregion
    }
}
