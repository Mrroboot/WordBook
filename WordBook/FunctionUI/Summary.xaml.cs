using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;
using System.IO;
using System.Data;
using WordBook.UserContrl;
using System.ComponentModel;

namespace WordBook.FunctionUI
{
    /// <summary>
    /// Interaction logic for Summary.xaml
    /// </summary>
    public partial class Summary : Page
    {
                          
        public Summary()
        {
            InitializeComponent();
            relView();           
        }
        private MainWindow _parentWin;
        public MainWindow ParentWin
        {
            get { return _parentWin; }
            set { _parentWin = value; }
        }
        private void relView()
        {
            if (File.Exists(ConfigurationManager.AppSettings["ObjectCfg"].ToString()))
            {
                DataSet Dst = new DataSet();
                Dst = Helper.xmlLoadFactory.GetXml(ConfigurationManager.AppSettings["ObjectCfg"].ToString());
                for (int i = 0; i <= Dst.Tables[0].Rows.Count - 1; i++)
                {
                    Constant.SourceFile.GetSampleSource(new Constant.SourceFile(i, Dst.Tables[0].Rows[i][0].ToString(), Dst.Tables[0].Rows[i][3].ToString(), int.Parse(Dst.Tables[0].Rows[i][2].ToString()), Dst.Tables[0].Rows[i][1].ToString()));
                }
                InitialzationMainView();
            }

        }
        private void InitialzationMainView()
        {
            for (int i = 0; i <= Constant.SourceFile.listF.Count - 1; i++)
            {
                switch (i)
                {
                    case 0:
                        Img0.Source = new BitmapImage(new Uri(Constant.SourceFile.listF[0].ImgPath));
                        txtSName0.Visibility = Visibility.Visible;
                        txtHeartBlk0.Visibility = Visibility.Visible;
                        HeartIcon0.Visibility = Visibility.Visible;
                        txtSName0.Text = Constant.SourceFile.listF[0].xmlName;
                        txtHeartBlk0.Text = Constant.SourceFile.listF[0].heartCount.ToString();
                        break;
                    case 1:
                        Img1.Source = new BitmapImage(new Uri(Constant.SourceFile.listF[1].ImgPath));
                        txtSName1.Visibility = Visibility.Visible;
                        txtHeartBlk1.Visibility = Visibility.Visible;
                        HeartIcon1.Visibility = Visibility.Visible;
                        txtSName1.Text = Constant.SourceFile.listF[1].xmlName;
                        txtHeartBlk1.Text = Constant.SourceFile.listF[1].heartCount.ToString();
                        break;
                    case 2:
                        Img2.Source = new BitmapImage(new Uri(Constant.SourceFile.listF[2].ImgPath));
                        txtSName2.Visibility = Visibility.Visible;
                        txtHeartBlk2.Visibility = Visibility.Visible;
                        HeartIcon2.Visibility = Visibility.Visible;
                        txtSName2.Text = Constant.SourceFile.listF[2].xmlName;
                        txtHeartBlk2.Text = Constant.SourceFile.listF[2].heartCount.ToString();
                        break;
                    case 3:
                        Img3.Source = new BitmapImage(new Uri(Constant.SourceFile.listF[3].ImgPath));
                        txtSName3.Visibility = Visibility.Visible;
                        txtHeartBlk3.Visibility = Visibility.Visible;
                        HeartIcon3.Visibility = Visibility.Visible;
                        txtSName3.Text = Constant.SourceFile.listF[3].xmlName;
                        txtHeartBlk3.Text = Constant.SourceFile.listF[3].heartCount.ToString();
                        break;
                    case 4:
                        Img4.Source = new BitmapImage(new Uri(Constant.SourceFile.listF[4].ImgPath));
                        txtSName4.Visibility = Visibility.Visible;
                        txtHeartBlk4.Visibility = Visibility.Visible;
                        HeartIcon4.Visibility = Visibility.Visible;
                        txtSName4.Text = Constant.SourceFile.listF[4].xmlName;
                        txtHeartBlk4.Text = Constant.SourceFile.listF[4].heartCount.ToString();
                        break;
                    case 5:
                        Img5.Source = new BitmapImage(new Uri(Constant.SourceFile.listF[5].ImgPath));
                        txtSName5.Visibility = Visibility.Visible;
                        txtHeartBlk5.Visibility = Visibility.Visible;
                        HeartIcon5.Visibility = Visibility.Visible;
                        txtSName5.Text = Constant.SourceFile.listF[5].xmlName;
                        txtHeartBlk5.Text = Constant.SourceFile.listF[5].heartCount.ToString();
                        break;

                }
            }
        }

        private void block_click(object sender, RoutedEventArgs e)
        {
            TextBlock txtItem = sender as TextBlock;
            Constant.SourceFile.CurrentID = Constant.SourceFile.listF.FindIndex(item => item.xmlName.Equals(txtItem.Text));
            var MW = Window.GetWindow(this) as MainWindow;
            MW.NavigateFun("ViewPage");
        }
             
        private void element_MouseEnter(object sender, MouseEventArgs e)
        {
            ((TextBlock)sender).Background = new SolidColorBrush(Color.FromArgb(129, 115, 120, 120));
        }

        private void element_MouseLeave(object sender, MouseEventArgs e)
        {
            ((TextBlock)sender).Background = null;
        }

    }


}
