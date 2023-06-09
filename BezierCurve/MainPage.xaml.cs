using Microsoft.Maui.Controls.Shapes;
using System.Collections.ObjectModel;

namespace BezierCurve;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

        Figure.BindingContext = new BezierViewModel();
        Figure.SetBinding(PathFigure.StartPointProperty, new MultiBinding
        {
            Bindings = new Collection<BindingBase>
            {
                new Binding("Ellipse1.X"),
                new Binding("Ellipse1.Y")
            },
            Converter = new CoordsConcatMultiConverter()
        });

        BS1.BindingContext = Figure.BindingContext;
        BS1.SetBinding(BezierSegment.Point1Property, new MultiBinding
        {
            Bindings = new Collection<BindingBase>
            {
                new Binding("Ellipse2.X"),
                new Binding("Ellipse2.Y")
            },
            Converter = new CoordsConcatMultiConverter()
        });
        BS1.SetBinding(BezierSegment.Point2Property, new MultiBinding
        {
            Bindings = new Collection<BindingBase>
            {
                new Binding("Ellipse3.X"),
                new Binding("Ellipse3.Y")
            },
            Converter = new CoordsConcatMultiConverter()
        });
        BS1.SetBinding(BezierSegment.Point3Property, new MultiBinding
        {
            Bindings = new Collection<BindingBase>
            {
                new Binding("Ellipse4.X"),
                new Binding("Ellipse4.Y")
            },
            Converter = new CoordsConcatMultiConverter()
        });

        BS2.BindingContext = Figure.BindingContext;
        BS2.SetBinding(BezierSegment.Point1Property, new MultiBinding
        {
            Bindings = new Collection<BindingBase>
            {
                new Binding("Ellipse5.X"),
                new Binding("Ellipse5.Y")
            },
            Converter = new CoordsConcatMultiConverter()
        });
        BS2.SetBinding(BezierSegment.Point2Property, new MultiBinding
        {
            Bindings = new Collection<BindingBase>
            {
                new Binding("Ellipse6.X"),
                new Binding("Ellipse6.Y")
            },
            Converter = new CoordsConcatMultiConverter()
        });
        BS2.SetBinding(BezierSegment.Point3Property, new MultiBinding
        {
            Bindings = new Collection<BindingBase>
            {
                new Binding("Ellipse7.X"),
                new Binding("Ellipse7.Y")
            },
            Converter = new CoordsConcatMultiConverter()
        });
    }
}

