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

/**
 * This application will allow the user to search for a file.
 * The user can then indicate a key or phrase to search in the file.
 * It will then display the lines which had the results of the search
 * indicated on a listBox.
 *
 * @author Luis Cortez(lac0084@auburn.edu)
 * @version 041420191608
 */
namespace SimpleTextSearch
{
     public partial class simpleTextSearch : Form
     {
          public simpleTextSearch()
          {
               InitializeComponent();
          }

          private StreamReader dataReader;

          private List<String> dataList = new List<String>();
          private void simpleTextSearch_Load(object sender, EventArgs e)
          {

          }

          private void browseButton_Click(object sender, EventArgs e)
          {
               if (browseFileDBox.ShowDialog() == DialogResult.OK)
               {
                    dataReader = File.OpenText(browseFileDBox.FileName);

                    fileLocation.Text = browseFileDBox.FileName;

                    while (!dataReader.EndOfStream)
                    {
                         dataList.Add(dataReader.ReadLine());
                    }

                    dataReader.Close();
               }
               else if (browseFileDBox.ShowDialog() == DialogResult.Cancel)
               {
                    
               }
               else
               {
                    
               }
          }

          private void searchButton_Click(object sender, EventArgs e)
          {

               var line = 0;

               if (dataList == null || dataList.Count == 0) 
               {
                    return;
               }
               else
               {
                    resultListBox.Items.Clear();

                    while (line < dataList.Count)
                    {
                         if (dataList[line].Contains(searchTextBox.Text))
                         {
                              resultListBox.Items.Insert(resultListBox.Items.Count, dataList[line]);
                         }
                         line++;
                    }
               }
          }
     }
}
