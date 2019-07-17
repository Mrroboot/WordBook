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
using WordBook.Helper;
using System.Data;
using System.Windows.Controls.Primitives;
using System.ComponentModel;

namespace WordBook.FunctionUI
{
    /// <summary>
    /// Interaction logic for ViewPage.xaml
    /// </summary>
    public partial class ViewPage : Page
    {
        private DataSet ds = new DataSet();
        BackgroundWorker pagWork = null;
        private MainWindow _parentWin;
        public MainWindow ParentWin
        {
            get { return _parentWin; }
            set { _parentWin = value; }
        }
        public ViewPage()
        {
            InitializeComponent();
            pagWork = new BackgroundWorker();
            pagWork.WorkerReportsProgress = true;
            if (Constant.SourceFile.CurrentID >= 0)
            {
                pagWork.DoWork += pagWork_DoWork;
                //pagWork.ProgressChanged += pagWork_ProgressChanged;
                pagWork.RunWorkerCompleted += pagWork_RunWorkerCompleted;
                pagWork.RunWorkerAsync(); 
            }
            else
            {
                MessageBox.Show("Please select source file first!", "Reminder", MessageBoxButton.OK, MessageBoxImage.Warning);
                //var MW = Window.GetWindow(this) as MainWindow;
                //MW.NavigateFun("WritePage");

            }
            
                      
            
        }

        void pagWork_DoWork(object sender, DoWorkEventArgs e)
        {
            this.Dispatcher.BeginInvoke(new Action(() =>
            {
                Gload.Visibility = Visibility.Visible;
                _loading.Visibility = Visibility.Visible;
            }));
            loadData();   
            
        }
        void pagWork_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
        }
        void pagWork_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //Action<DataGrid, DataTable> updateAction = new Action<DataGrid, DataTable>(UpdateDG);
            //WordView.Dispatcher.BeginInvoke(updateAction, WordView, ds.Tables[0]);
            this.Dispatcher.Invoke(new Action(() =>
            {
                this.WordView.DataContext = ds.Tables[0].DefaultView;
                this.DGpage.ShowPages(this.WordView, ds.Tables[0], 100);
            }));   
            Gload.Visibility = Visibility.Hidden;
            this._loading.Visibility = Visibility.Hidden;
        }
        
        private void loadData()
        {
            ds = xmlLoadFactory.GetXml((string)Constant.SourceFile.listF[Constant.SourceFile.CurrentID].xmlPath);
            DataColumn wordWrite = new DataColumn();
            DataColumn wordID = new DataColumn();
            wordWrite.ColumnName = "WRITE";
            wordID.ColumnName = "ID";
            ds.Tables[0].Columns.Add(wordID);
            ds.Tables[0].Columns.Add(wordWrite);
            for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
            {
               ds.Tables[0].Rows[i][4] = (i + 1).ToString();
            }                      
        }

        private void UpdateDG(DataGrid wv, DataTable tb)
        {
            wv.ItemsSource = tb.DefaultView;
        }

        private void btnEng_Click(object sender, RoutedEventArgs e)
        {
            if(WordView.Columns[3].Visibility != Visibility.Collapsed)
            {
                WordView.Columns[2].Visibility = Visibility.Collapsed;
            }           
        }

        private void btnAllShow_Click(object sender, RoutedEventArgs e)
        {
            WordView.Columns[2].Visibility = Visibility.Visible;
            WordView.Columns[3].Visibility = Visibility.Visible;
        }

        private void btnChn_Click(object sender, RoutedEventArgs e)
        {
            if (WordView.Columns[2].Visibility != Visibility.Collapsed)
            {
                WordView.Columns[3].Visibility = Visibility.Collapsed;
            }
        }

        private void btnRstore_Click(object sender, RoutedEventArgs e)
        {                       
            DataColumn dc = ds.Tables[0].Columns[5];
            ds.Tables[0].Columns.Remove("WRITE");
            ds.Tables[0].Columns.Add(dc);
            //WordView.ItemsSource = ds.Tables[0].DefaultView;
            pagWork.RunWorkerAsync();  
            txtErrBlk.Text = "0";
            txtCrrBlk.Text = "0";
        }             

        private void WordView_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void WordView_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            string inValue = (e.EditingElement as TextBox).Text;
            string wordValue = ds.Tables[0].Rows[int.Parse((WordView.Columns[0].GetCellContent(WordView.SelectedItem) as TextBlock).Text)-1][1].ToString();
            int Crr = int.Parse(txtCrrBlk.Text);
            int Err = int.Parse(txtErrBlk.Text);
            DataRowView drv = WordView.SelectedItem as DataRowView;
            DataGridRow row = (DataGridRow)this.WordView.ItemContainerGenerator.ContainerFromIndex(WordView.SelectedIndex);
            DataGridCellsPresenter presenter = GetVisualChild<DataGridCellsPresenter>(row);
            DataGridCell cell = (DataGridCell)presenter.ItemContainerGenerator.ContainerFromIndex(4);
            DataGridTemplateColumn tempColum = this.WordView.Columns[1] as DataGridTemplateColumn;
            FrameworkElement element = this.WordView.Columns[1].GetCellContent(this.WordView.SelectedItem);
            if (inValue.ToUpper() == wordValue.ToUpper())
            {
                if((Crr+Err) > WordView.SelectedIndex)
                {
                    Crr++;
                    Err--;
                }
                else
                {
                    Crr++;
                }
                cell.Foreground = new SolidColorBrush(Colors.Black);            
                if(element !=null)
                {
                    TextBlock txtBlock = tempColum.CellTemplate.FindName("txtBlk", element) as TextBlock;
                    MaterialDesignThemes.Wpf.PackIcon pIcon= tempColum.CellTemplate.FindName("PICON",element) as MaterialDesignThemes.Wpf.PackIcon;
                    pIcon.Foreground = new SolidColorBrush(Colors.Gray);                    
                }
            }
            else
            {
                if ((Crr + Err) > WordView.SelectedIndex)
                {
                    Crr--;
                    Err++;
                }
                else
                {
                    Err++;
                }
                cell.Foreground = new SolidColorBrush(Colors.Red);
                if (element != null)
                {
                    TextBlock txtBlock = tempColum.CellTemplate.FindName("txtBlk", element) as TextBlock;
                    MaterialDesignThemes.Wpf.PackIcon pIcon = tempColum.CellTemplate.FindName("PICON", element) as MaterialDesignThemes.Wpf.PackIcon;
                    pIcon.Foreground = new SolidColorBrush(Colors.Red);
                    txtBlock.Text = (int.Parse(txtBlock.Text) + 1).ToString();
                }

            }
            //for(int i=0;i<=WordView.Items.Count-1;i++)
            //{
            //    if(i==WordView.SelectedIndex)
            //    {
            //        inValue = (e.EditingElement as TextBox).Text;
            //    }
            //    else
            //    {
            //        inValue = ds.Tables[0].Rows[i][5].ToString(); //   (WordView.Columns[3].GetCellContent(WordView.Items[i]) as TextBlock).Text;
            //    }
            //    wordValue = ds.Tables[0].Rows[i][1].ToString();               
            //    if (inValue != "")
            //    {
            //        if (inValue == wordValue)
            //        {
            //            Crr += 1;                        
            //        }
            //        else
            //        {                                             
            //            Err += 1;
            //        }
            //    }
            //}
            txtCrrBlk.Text = Crr.ToString();
            txtErrBlk.Text = Err.ToString();
            
        }
        public static T GetVisualChild<T>(Visual parent) where T : Visual
        {
            T childContent = default(T);
            int numVisuals = VisualTreeHelper.GetChildrenCount(parent);
            for (int i = 0; i < numVisuals; i++)
            {
                Visual v = (Visual)VisualTreeHelper.GetChild(parent, i);
                childContent = v as T;
                if (childContent == null)
                {
                    childContent = GetVisualChild<T>(v);
                }
                if (childContent != null)
                {
                    break;
                }
            }

            return childContent;
        }
        
       

        private void ViewMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Back)
            {
                e.Handled = true;
            }
        }
        
        //private void WordView_LoadingRow(object sender, DataGridRowEventArgs e)
        //{  
        //    e.Row.Header = e.Row.GetIndex() + 1;
        //    //WordView.Columns[0]..Items[e.Row.GetIndex()]
        //}
    }
}
