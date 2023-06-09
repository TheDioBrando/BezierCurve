using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BezierCurve.ViewModel
{
    public class LineViewModel : INotifyPropertyChanged
    {
        double lineOffset;
        public double LineOffset 
        {
            get => lineOffset; 
            set
            {
                if(lineOffset!= value)
                {
                    lineOffset = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
