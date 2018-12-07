using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation.Diagnostics;
using HelpList.ViewModel;

namespace HelpList.Model
{
    class ProblemMappe
    {

        public class Singleton
        {
            private static Singleton _mappe;

            private Singleton() { }



            public static Singleton problemMappe
            {
                get
                {
                    if (_mappe == null)
                    {
                        _mappe = new Singleton();
                    }

                    return _mappe;
                }

                
            }
            private ObservableCollection<ProblemCollector> _savedProblems = new ObservableCollection<ProblemCollector>();

            public ObservableCollection<Problem> savedProblems
            {
                get
                {
                    if (_savedProblems == null)
                    {
                        _savedProblems = new ObservableCollection<ProblemCollector>();
                    }

                    return _savedProblems;
                }
            }

            public void AddString(string source, string message)
            {
                ProblemCollector problems = new ProblemCollector();
                problems.time = DateTime.Now;
                problems.source = source;
                problems.message = message;
                
            
            }

            public sealed class ProblemCollector
            {
                public DateTime time { get; set; }
                public string source { get; set; }
                public string message { get; set; }
            }
        }
    }
}
