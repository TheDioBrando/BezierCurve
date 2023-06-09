using BezierCurve.ViewModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BezierCurve
{
    public class BezierViewModel : INotifyPropertyChanged
    {
        //значения всех координат увеличены в пять раз для увеличения размера кривой
        static EllipseViewModel ellipse1 = new()
        {
            X = 0,
            Y = 125
        };

        Point point1 = new(ellipse1.X, ellipse1.Y);

        static EllipseViewModel ellipse2 = new()
        {
            X = 140,
            Y = 85
        };

        static EllipseViewModel ellipse3 = new()
        {
            X = 220,
            Y = 195
        };

        static EllipseViewModel ellipse4 = new()
        {
            X = 275,
            Y = 70
        };

        static EllipseViewModel ellipse5 = new()
        {
            X = 315,
            Y = 195
        };

        static EllipseViewModel ellipse6 = new()
        {
            X = 450,
            Y = 125
        };

        static EllipseViewModel ellipse7 = new()
        {
            X = 500,
            Y = 125
        };

        LineViewModel line = new()
        {
            LineOffset = 5
        };

        public EllipseViewModel Ellipse1
        {
            get => ellipse1;
            set
            {
                ellipse1 = value;
                OnPropertyChanged();
            }
        }

        public Point Point1
        {
            get => point1;
            set
            {
                point1 = value;
                OnPropertyChanged();
            }
        }

        public EllipseViewModel Ellipse2
        {
            get => ellipse2;
            set
            {
                ellipse2 = value;
                OnPropertyChanged();
            }
        }

        public EllipseViewModel Ellipse3
        {
            get => ellipse3;
            set
            {
                ellipse3 = value;
                OnPropertyChanged();
            }
        }

        public EllipseViewModel Ellipse4
        {
            get => ellipse4;
            set
            {
                ellipse4 = value;
                OnPropertyChanged();
            }
        }

        public EllipseViewModel Ellipse5
        {
            get => ellipse5;
            set
            {
                ellipse5 = value;
                OnPropertyChanged();
            }
        }

        public EllipseViewModel Ellipse6
        {
            get => ellipse6;
            set
            {
                ellipse6 = value;
                OnPropertyChanged();
            }
        }

        public EllipseViewModel Ellipse7
        {
            get => ellipse7;
            set
            {
                ellipse7 = value;
                OnPropertyChanged();
            }
        }

        public LineViewModel Line
        {
            get => line;
            set
            {
                line = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
