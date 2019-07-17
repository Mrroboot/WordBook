using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace WordBook.UserContrl
{
    /// <summary>
    /// Interaction logic for DataGridPage.xaml
    /// </summary>
    public partial class DataGridPage : UserControl
    {
        public DataGridPage()
        {
            InitializeComponent();            
        }

        private DataTable _dt = new DataTable();
        private int pageNum = 100;//minimum records for page
        private int pIndex = 1; //current page
        private DataGrid grdList; // object
        private int MaxIndex = 1;// max index
        private int allNum = 0; // all count

        #region initialization data
        ///<summary>
        ///init data
        ///</summary>
        ///<param name="grd"></param>
        ///<param name="dtt"></param>
        ///<param name="Num"></param>
        public void ShowPages(DataGrid grd, DataTable ds, int Num)
        {
            if (ds == null || ds.Rows.Count == 0)
                return;
            if (ds.Rows.Count == 0)
                return;
            DataTable dt = ds;
            this._dt = dt.Clone();
            this.grdList = grd;
            this.pageNum = Num;
            this.pIndex = 1;
            foreach(DataRow r in dt.Rows)
            {
                this._dt.ImportRow(r);
            }

            SetMaxIndex();
            ReadDataTable();
            if(this.MaxIndex > 1)
            {
                this.pageGo.IsReadOnly = false;
                this.btnGo.IsEnabled = true;
            }
        }
        #endregion

        #region Draw data
        private void ReadDataTable()
        {
            try
            {
                DataTable tmpTable = new DataTable();
                tmpTable = this._dt.Clone();
                int first = this.pageNum * (this.pIndex - 1);
                first = (first > 0) ? first : 0;  // judge the total > page max 
                if( this._dt.Rows.Count >= this.pageNum * this.pIndex )
                {
                    for( int i = first ; i < pageNum * this.pIndex ; i++ )
                    {
                        tmpTable.ImportRow(this._dt.Rows[i]);
                    }
                }
                else
                {
                    for( int i = first ; i < this._dt.Rows.Count ; i++ )
                    {
                        tmpTable.ImportRow(this._dt.Rows[i]);
                    }
                }
                this.grdList.ItemsSource = tmpTable.DefaultView;
                tmpTable.Dispose();
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
            finally
            {
                DisplayPagingInfo();
            }
        }
        #endregion

        #region draw page
        private void DisplayPagingInfo()
        {
            if(this.pIndex == 1)
            {
                this.btnPrev.IsEnabled = false;
                this.btnFirst.IsEnabled = false;
            }
            else
            {
                this.btnPrev.IsEnabled = true;
                this.btnFirst.IsEnabled = true;
            }

            if(this.pIndex == this.MaxIndex)
            {
                this.btnNext.IsEnabled = false;
                this.btnLast.IsEnabled = false;
            }
            else
            {
                this.btnNext.IsEnabled = true;
                this.btnLast.IsEnabled = true;
            }
            this.tbkRecords.Text = string.Format("Total : {1}", this.pageNum, this.allNum);
            int first = (this.pIndex - 4) > 0 ? (this.pIndex - 4) : 1;
            int last = (first + 9) > this.MaxIndex ? this.MaxIndex : (first + 9);
            this.grid.Children.Clear();
            for(int i = first; i<= last; i++)
            {
                ColumnDefinition cdf = new ColumnDefinition();
                this.grid.ColumnDefinitions.Add(cdf);
                TextBlock tbl = new TextBlock();
                tbl.Text = i.ToString();
                tbl.Style = FindResource("PageTextBlock3") as Style;
                tbl.MouseLeftButtonUp += new MouseButtonEventHandler(tbl_MouseLeftButtonUp);
                tbl.MouseLeftButtonDown += new MouseButtonEventHandler(tbl_MouseLeftButtonDown);
                if( i == this.pIndex)
                {
                    tbl.IsEnabled = false;
                }
                Grid.SetColumn(tbl, this.grid.ColumnDefinitions.Count - 1);
                Grid.SetRow(tbl, 0);
                this.grid.Children.Add(tbl);
            }
        }
        #endregion                                                 

        #region setup max page count
        private void SetMaxIndex()
        {
            int Pages = this._dt.Rows.Count / pageNum;
            if(this._dt.Rows.Count != (Pages*pageNum))
            {
                if(_dt.Rows.Count < (Pages*pageNum))
                {
                    Pages--;
                }
                else
                {
                    Pages++;
                }

            }
            this.MaxIndex = Pages;
            this.allNum = this._dt.Rows.Count;
        }
        #endregion     

        #region paging number trigger
        private void tbl_MouseLeftButtonUp(object sender, RoutedEventArgs e)
        {
            e.Handled = true;
        }
        void tbl_MouseLeftButtonDown(object sender, RoutedEventArgs e)
        {
            TextBlock tbl = sender as TextBlock;
            if (tbl == null)
            {
                return;
            }
            int index = int.Parse(tbl.Text.ToString());
            this.pIndex = index;
            if (index > this.MaxIndex)
                this.pIndex = this.MaxIndex;
            if (index < 1)
                this.pIndex = 1;
            ReadDataTable();
           
        }
        #endregion

        private static Regex RegNumber = new Regex("^[0-9]+$");
        public static bool IsNumber(string valString)
        {
            Match m = RegNumber.Match(valString);
            return m.Success;
        }

        #region First Page
        private void btnFirst_Click_1(object sender, RoutedEventArgs e)
        {
            this.pIndex = 1;
            ReadDataTable();
        }

        private void btnFirst_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            e.Handled = true;
        }
        #endregion

        #region Prev Page
        private void btnPrev_Click_1(object sender, RoutedEventArgs e)
        {
            if (this.pIndex <= 1)
                return;
            this.pIndex--;
            ReadDataTable();
        }
       
        private void btnPrev_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            e.Handled = true;
        }
        #endregion

        #region Next page
        private void btnNext_Click_1(object sender, RoutedEventArgs e)
        {
            if (this.pIndex >= this.MaxHeight)
                return;
            this.pIndex++;
            ReadDataTable();
        }    

        private void btnNext_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            e.Handled = true;
        }
        #endregion

        #region End Page
        private void btnLast_Click_1(object sender, RoutedEventArgs e)
        {
            this.pIndex = this.MaxIndex;
            ReadDataTable();
        }

        private void btnLast_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            e.Handled = true;
        }
        #endregion

        #region Jump page
        private void btnGo_Click_1(object sender, RoutedEventArgs e)
        {
            if (IsNumber(this.pageGo.Text))
            {
                int pageNum = int.Parse(this.pageGo.Text);
                if (pageNum > 0 && pageNum <= this.MaxIndex)
                {
                    this.pIndex = pageNum;
                    ReadDataTable();
                }
                else if (pageNum > this.MaxIndex)
                {
                    this.pIndex = this.MaxIndex;
                    ReadDataTable();
                }
            }
            this.pageGo.Text = "";
        }
        #endregion
    }
}
