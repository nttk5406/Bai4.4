namespace FormDatHang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lstMenu.Items.Add("Hamburger: 50k");
            lstMenu.Items.Add("Pizza: 120k");
            lstMenu.Items.Add("Gà Rán: 35k");
            lstMenu.Items.Add("Pepsi: 15k");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lstMenu.SelectedItem != null)
            {
                lstSelected.Items.Add(lstMenu.SelectedItem);
                lstMenu.Items.Remove(lstMenu.SelectedItem);
                TinhTongTien();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstSelected.SelectedItem != null)
            {
                lstMenu.Items.Add(lstSelected.SelectedItem);
                lstSelected.Items.Remove(lstSelected.SelectedItem);
                TinhTongTien();
            }
        }
        private void TinhTongTien()
        {
            int tong = 0;

            for (int i = 0; i < lstSelected.Items.Count; i++)
            {
                string mon = lstSelected.Items[i].ToString();

                if (mon.Contains("50k"))
                {
                    tong += 50;
                }
                else if (mon.Contains("120k"))
                {
                    tong += 120;
                }
                else if (mon.Contains("35k"))
                {
                    tong += 35;
                }
                else if (mon.Contains("15k"))
                {
                    tong += 15;
                }
            }

            lblTotal.Text = "Tổng tiền: " + tong + "k";
        }
    }
}
