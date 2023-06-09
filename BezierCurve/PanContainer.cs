using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BezierCurve
{
    class PanContainer : ContentView
    {
        const int MAX_WIDTH = 500;
        const int MAX_HEIGHT = 250;

        public double Xcoord { get; set; }
        public double Ycoord { get; set; }
        public int MaxWidth { get => MAX_WIDTH; }
        public int MaxHeight { get => MAX_HEIGHT; }

        public PanContainer()
        {
            PanGestureRecognizer panGesture = new PanGestureRecognizer();
            panGesture.PanUpdated += OnPanUpdated;
            GestureRecognizers.Add(panGesture);
        }

        void OnPanUpdated(object sender, PanUpdatedEventArgs e)
        {
            if (e.StatusType == GestureStatus.Running)
            {
                Content.TranslationX = Math.Min(Math.Max(0, Xcoord + e.TotalX), MAX_WIDTH);
                Content.TranslationY = Math.Min(Math.Max(0, Ycoord + e.TotalY), MAX_HEIGHT);
            }
            else if (e.StatusType == GestureStatus.Completed)
            {
                Xcoord = Content.TranslationX;
                Ycoord = Content.TranslationY;
            }
        }
    }
}
