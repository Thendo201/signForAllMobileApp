using signForAllMobileApp.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Text;

namespace signForAllMobileApp.ViewModel
{
    public class CardViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<Areas> Areas;
        public ObservableCollection<Areas> areas
        {
            get { return Areas; }
            set
            {
                Areas = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("areas"));
            }
        }
        public CardViewModel()
        {
            areas = new ObservableCollection<Areas>();
            addData();
        }

        private void addData()
        {
            areas.Add(new Areas
            {
                id = 0,
                name = "Sign Alphabets",
                imgSource = "https://i.pinimg.com/564x/bf/7a/86/bf7a865e3cb94ea25fc48c2f7b186944.jpg"
            });
            areas.Add(new Areas
            {
                id = 1,
                name = "Finger Spelling",
                imgSource = "https://i.pinimg.com/564x/7f/a4/c8/7fa4c8a41520b337394637e3eae51bfb.jpg"
            });
            areas.Add(new Areas
            {
                id = 2,
                name = "Sign Words",
                imgSource = "https://i.pinimg.com/236x/17/68/1e/17681e4966d31fbbcf5ce7d76c7ed5bc.jpg"
            });
            areas.Add(new Areas
            {
                id = 3,
                name = "Sign Sentences",
                imgSource = "https://i.pinimg.com/564x/fe/97/89/fe97898ac7d974684f8c69b753164537.jpg"
            });
        }
    }
}
