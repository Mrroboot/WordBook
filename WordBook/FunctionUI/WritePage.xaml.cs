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

namespace WordBook.FunctionUI
{
    /// <summary>
    /// Interaction logic for WritePage.xaml
    /// </summary>
    public partial class WritePage : Page
    {
        public WritePage()
        {
            InitializeComponent();
            for (int i = 0; i <= Constant.SourceFile.listF.Count - 1;i++ )
            {
                cboxSource.Items.Add(Constant.SourceFile.listF[i].xmlName);
            }
            if( Constant.SourceFile.CurrentID >= 0 )
            {
                cboxSource.SelectedItem = Constant.SourceFile.listF[Constant.SourceFile.CurrentID].xmlName;
            }            
        }
        
    }
}
