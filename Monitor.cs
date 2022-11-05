using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monitor
{
    public partial class Monitor : Form
    {
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public Monitor()
        {
            InitializeComponent();
            ChangeAttributesGridView();
            FillCmbSites();
        }

        /// <summary>
        /// Llena el combobox de los sitios
        /// </summary>
        void FillCmbSites()
        {
            //Carga los sitios del combobox
            cmbSites.Items.Add("Chaturbate");
            cmbSites.Items.Add("Stripchat");
            cmbSites.Items.Add("Camsoda");
            cmbSites.Items.Add("Cam4");
            cmbSites.Items.Add("MyFreeCams");

            //Selecciona la opción por defecto
            cmbSites.SelectedItem = "Chaturbate";
        }

        /// <summary>
        /// Agrega una nueva sala
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            ///valida si el campo de la sala esta vacio
            if (string.IsNullOrEmpty(txtAddRoom.Text))
            {
                MessageBox.Show("Enter a valid room or username");
            }
            else
            {
                //Agrega la sala a la tabla
                AddRoom();
            }
        }

        /// <summary>
        /// Agrega las salas
        /// </summary>
        void AddRoom()
        {
            GrdRooms.Columns[0].Name = "Usename";
            GrdRooms.Columns[1].Name = "Site";

            string[] row1 = new string[] { txtAddRoom.Text, Convert.ToString(cmbSites.SelectedItem) };
            GrdRooms.Rows.Add(row1);

            //Se limpia el textbox de la sala
            txtAddRoom.Text = string.Empty;
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (true)
            {
                DialogResult dialogResult = MessageBox.Show("Confirm", "Remove Model?", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    GrdRooms.Rows.RemoveAt(GrdRooms.CurrentRow.Index);
                    MessageBox.Show("Enter a valid room or username");
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Close();
                }
            }
        }

        /// <summary>
        /// Metodo que cambia los atributos del gridview
        /// </summary>
        void ChangeAttributesGridView()
        {
            GrdRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            GrdRooms.AllowUserToResizeColumns = false;
            GrdRooms.AllowUserToResizeRows = false;
        }
    }
}
