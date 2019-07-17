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

namespace WordBook.UserContrl
{
    /// <summary>
    /// Interaction logic for SessionCyclic.xaml
    /// </summary>
    public partial class SessionCyclic : UserControl
    {
        private List<Constant.Session> _sessionList;
        private RichTextBox _sessionBox;
        private int pIndex;
        public SessionCyclic()
        {
            InitializeComponent();
        }

        #region initialization session box
        public void showSessionBox(RichTextBox sessionBox, List<Constant.Session> sessionList)
        {
            if (sessionList == null || sessionList.Count == 0)
                return;
            this._sessionList = sessionList;
            this._sessionBox = sessionBox;
            
        }
        #endregion

        #region Draw data
        private void ReadDataBox()
        {
            try
            {
                if(this._sessionList.Count >= this.pIndex)
                {
                    //this._sessionBox = _sessionList[pIndex].Session.Length;
                }
            }
            catch
            {

            }
            finally
            {

            }
        }
        #endregion
        private void btnGo_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
