using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dynamic_vehicles
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Button btn = new Button();
			Point btnkonum = new Point(10,20);
			btn.Location = btnkonum;
			btn.Name = "Button1";
			btn.Text = "Tıkla";
			btn.Height = 50;
			btn.Width = 75;
			btn.BackColor = Color.Green;

			Label lbl = new Label();
			Point lblkonum = new Point(200, 25);
			lbl.Location = lblkonum;
			lbl.Name = "Label1";
			lbl.Text = "Merhaba";
			lbl.BackColor = Color.Yellow;
			lbl.AutoSize = true;
			this.Controls.Add(lbl);

			
             for(int i = 1; i <= 5; i++)
			{

				TextBox txt = new TextBox();
				Point txtkonum = new Point(350, i * 30);
				txt.Location = txtkonum;
				txt.Name = "Textbox" + i;
				txt.Text = i.ToString();
				this.Controls.Add(txt);

			}

			this.Controls.Add(btn); // buton, formda görsel olarak eklenir ve kullanıcı tarafından etkileşimli hale gelir.
									//Eğer bu satır olmasaydı, buton oluşturulurdu fakat formun üzerinde görünmezdi,
									//çünkü kontrol koleksiyonuna eklenmemiş olurdu.
		}
	}
}
