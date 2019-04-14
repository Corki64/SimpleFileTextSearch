using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleTextSearch
{
     public partial class simpleTextSearch : Form
     {
          public simpleTextSearch()
          {
               InitializeComponent();
          }

          StreamReader dataReader;
               
          List<String> dataList = new List<string>();
          private void simpleTextSearch_Load(object sender, EventArgs e)
          {

          }
     }
}
