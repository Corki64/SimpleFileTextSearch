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
               
          List<String> dataList = new List<String>();
          private void simpleTextSearch_Load(object sender, EventArgs e)
          {

          }

          private void browseButton_Click(object sender, EventArgs e)
          {
               if (browseFileDBox.ShowDialog() == DialogResult.OK)
               {
                    dataReader = File.OpenText(browseFileDBox.FileName);

                    while (!dataReader.EndOfStream)
                    {
                         dataList.Add(dataReader.ReadLine());
                    }

                    dataReader.Close();
               }
               else if (browseFileDBox.ShowDialog() == DialogResult.Cancel)
               {
                    
               }
          }

          private void searchButton_Click(object sender, EventArgs e)
          {
               if (dataList == null || dataList.Count == 0) 
               {
                    return;
               }
               else
               {
                    var line = dataList.Count;
                    resultListBox.Items.Clear();

                    while (line < dataList.Count)
                    {
                         if (dataList[line].Contains())
                         {
                              
                         }
                    }
               }
          }
     }
}
