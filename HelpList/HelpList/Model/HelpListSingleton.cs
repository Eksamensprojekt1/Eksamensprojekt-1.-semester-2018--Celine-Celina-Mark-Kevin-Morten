using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Store;
using FV3.Helpers;
using HelpList.ViewModel;

namespace HelpList.Model
{
    class HelpListSingleton
    {
        #region Instance field
        private static HelpListSingleton _instance = null;
        public Problem _problem1 = new Problem("Kevin", "Emne", "Klassen", "hvorfor virker det ikke :(");
        public Problem _problem2 = new Problem("Mark", "Somewhere", "Det er større end os", "PROBLEM");
        #endregion

        #region Constructor
        private HelpListSingleton()
        {
            Problems = new ObservableCollection<Problem>();
            SavedProblemCollection = new ObservableCollection<Problem>();
            CreateLocalList();
            SavedProblemCollection.Add(new Problem("Mark", "Somewhere", "Det er større end os", "PROBLEM"));

        }

        #endregion

        #region Property
        public static HelpListSingleton Instance
        {
            get { return _instance ?? (_instance = new HelpListSingleton()); }
            set { Instance = value; }
        }

        public ObservableCollection<Problem> SavedProblemCollection { get; set; }
        public ObservableCollection<Problem> Problems { get; set; }
        public Problem SelectedProblem { get; set; } = null;
        public string Name { get; set; }
        public string Topic { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }


        #endregion
        #region Methods



        public void Add()
        {
            Problems.Add(new Problem(Name, Topic, Location, Description));
        }

        public void Remove()
        {
            if (SelectedProblem != null)
            {
                Problems.Remove(SelectedProblem);
            }
        }

        public void RemoveAll()
        {
            Problems.Clear();
        }

        //public void Save()
        //{
        //    ProblemFolderCollection.Add(SelectedProblem);
        //}

        public void CreateLocalList()
        {
            // Problems.Add(new Problem(Name, Topic, Location, Description));
            Problems.Add(_problem1);

        }
                
        public void LoadFromFile()
        {
            //Udvikles senere, skal op i Constructor
        }

        public void AddProblemMethod()
        {
            if (SelectedProblem != null)
            {
                SavedProblemCollection.Add(new Problem(Name, Topic, Description));
            }
        }


        #endregion

    }
}
