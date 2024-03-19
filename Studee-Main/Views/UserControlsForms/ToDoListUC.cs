using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Studee_Main.PopupWindows.ToDo;
using Studee_Main.Views.UserControlsForms;

namespace Studee_Main.Views.UserControlsForms
{
    public partial class toDoListUC : UserControl
    {
        public toDoListUC()
        {
            InitializeComponent();
        }

        private void openAddTaskWindow_Click(object sender, EventArgs e)
        {
            using (var AddTaskPopUpWindow = new AddTaskPopUpWindow())
            {
                
                AddTaskPopUpWindow.ShowDialog();
            }
        }
    }
    }

