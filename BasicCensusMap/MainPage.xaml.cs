using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using ESRI.ArcGIS.Client;

namespace BasicCensusMap
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();

            ESRI.ArcGIS.Client.Geometry.Envelope initialExtent =
             new ESRI.ArcGIS.Client.Geometry.Envelope(-13205480.536, 4077189.785, -13176602.592, 4090421.641);

            MyMap.Extent = initialExtent;
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            

            ArcGISTiledMapServiceLayer arcgisLayer = MyMap.Layers["CensusLayer"] as ArcGISTiledMapServiceLayer;
            arcgisLayer.Url = ((RadioButton)sender).Tag as string;
            //arcgisLayer.Opacity = 0.5;
        }

        private void BaseMapRadioButton_Click(object sender, RoutedEventArgs e)
        {
            ArcGISTiledMapServiceLayer arcgisLayer = MyMap.Layers["BaseLayer"] as ArcGISTiledMapServiceLayer;
            arcgisLayer.Url = ((RadioButton)sender).Tag as string;

        }

    }
}
