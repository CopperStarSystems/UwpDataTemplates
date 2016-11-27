//  --------------------------------------------------------------------------------------
// UwpDataTemplates.MainViewModel.cs
// 2016/11/27
//  --------------------------------------------------------------------------------------

using System.Collections.Generic;
using GalaSoft.MvvmLight;
using UwpDataTemplates.Model;

namespace UwpDataTemplates.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        Fruit selectedFruit;

        public MainViewModel()
        {
            Fruits = new List<Fruit> {new Apple(), new Orange()};
        }

        public IList<Fruit> Fruits { get; private set; }

        public Fruit SelectedFruit
        {
            get
            {
                return selectedFruit;
            }
            set
            {
                selectedFruit = value;
                RaisePropertyChanged(() => SelectedFruit);
            }
        }
    }
}