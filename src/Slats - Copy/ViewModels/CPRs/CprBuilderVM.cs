using System;
using System.Collections.ObjectModel;
using System.Windows;
using Slats.Contracts.ViewModels;
using Slats.Core.Contracts.Services;
using Slats.Core.Models;
using Slats.Helpers;
using Slats.DAL;
using Slats.Models;

namespace Slats.ViewModels
{
    public partial class CprBuilderVM : Observable, INavigationAware, INotifyUpdate
    {
        public ObservableCollection<CprQuestion> Questions 
        {
            get { return questions; }
            set { questions = value; }
        }

        public ObservableCollection<CprQuestion> questions = new ObservableCollection<CprQuestion>();

        public ICprPoolsRepository cprPoolRepository;

        public ObservableCollection<CprPool> Source { get; set; } = new ObservableCollection<CprPool>();

        public CprBuilderVM(ICprPoolsRepository cprPoolsRepository)
        {
            cprPoolRepository = cprPoolsRepository;
        }
        public async void OnNavigatedTo(object parameter)
        {
            // TODO WTS: Replace this with your actual data
            var data = await cprPoolRepository.GetAll();  //.GetSalesPeople();

            foreach (var item in data)
            {
                Source.Add(item);
            }

            LoadQuestions();

            MessageBox.Show(Questions.Count.ToString());
            
        }

        private void LoadQuestions()
        {
            CprQuestion qu;
            
            qu = new CprQuestion(); qu.Id = 1; qu.Question = "Who is the lone ranger"; qu.reportID = "Bam!"; qu.Type = QuestionType.OpenQuestion; Questions.Add(qu);
            qu = new CprQuestion(); qu.Id = 2;qu.Question = "Who is the Cookie Monster"; qu.reportID = "Bam!"; qu.Type = QuestionType.OpenQuestion; Questions.Add(qu);
            qu = new CprQuestion(); qu.Id = 3;qu.Question = "Who is the Shirlie Temple"; qu.reportID = "Bam!"; qu.Type = QuestionType.OpenQuestion; Questions.Add(qu);
            qu = new CprQuestion(); qu.Id = 4;qu.Question = "Where is Waldo"; qu.reportID = "Bam!"; qu.Type = QuestionType.OpenQuestion; Questions.Add(qu);
            qu = new CprQuestion(); qu.Id = 5; qu.Question = "Who is the Shirlie Temple"; qu.reportID = "Bam!"; qu.Type = QuestionType.OpenQuestion; Questions.Add(qu);
        }

        public void OnNavigatedFrom()
        {
        }

        private System.Windows.Data.BindingBase effective;

        public System.Windows.Data.BindingBase Effective { get => effective; set => Set(ref effective, value); }

    }

    internal interface INotifyUpdate
    {
    }
}
