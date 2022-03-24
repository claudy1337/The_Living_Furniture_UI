using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;


namespace The_Living_Furniture_UI.Assets.items
{
    /// <summary>
    /// Логика взаимодействия для FurnitureItem.xaml
    /// </summary>
    public partial class FurnitureItem : UserControl
    {
        public FurnitureItem()
        {
            InitializeComponent();
        }
        public ImageSource Source
        {
            get { return (ImageSource)GetValue(SourceProperty); }
            set { SetValue(SourceProperty, value); }
        }

        public static readonly DependencyProperty SourceProperty = DependencyProperty.Register("Source", typeof(ImageSource), typeof(FurnitureItem));


        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register("Title", typeof(string), typeof(FurnitureItem));


        public string Ref
        {
            get { return (string)GetValue(RefProperty); }
            set { SetValue(RefProperty, value); }
        }

        public static readonly DependencyProperty RefProperty = DependencyProperty.Register("Ref", typeof(string), typeof(FurnitureItem));
    }
}
