using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TODOLIST
{
	public partial class AddToDo : Form
	{
		private string username;
		public AddToDo()
		{
			InitializeComponent();
		}
		public AddToDo(string _username)
		{
			this.username = _username;
		}

		private void butAdd_Click(object sender, EventArgs e)
		{
			if(textTodo.Text=="")
			{
				MessageBox.Show("Things to do mustn't be blank");
				return;
			}
			else
			{

			}				
		}
	}
}
