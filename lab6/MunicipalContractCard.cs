using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    public partial class MunicipalContractCard : Form
    {
        public bool canUpdate = Session.GetCurrentPM().CanUpdate(new MunicipalContract());
        MunicipalContractController MunicipalContractController = new MunicipalContractController();
        public MunicipalContractCard(int idmunisipalContract)
        {
            InitializeComponent();
            MunicipalContract munnicipalContract = MunicipalContractController.ViewMunicipalContractCard(idmunisipalContract);
            if (!canUpdate)
            {
                AddNomerContract.ReadOnly = true;
                AddDateConContract.ReadOnly = true;
                AddDateExeContract.ReadOnly = true;
                AddCustomerContract.ReadOnly = true;
                AddExecutinContract.ReadOnly = true;
                AddLocalityContract.Enabled = true;
                ButtonCreateMunicipalContract.Enabled = false;
            }
            textBox1.ReadOnly = true;
            AddNomerContract.Text = munnicipalContract.number.ToString();
            AddDateConContract.Text = munnicipalContract.dateOfConclusion.ToString();
            AddDateExeContract.Text = munnicipalContract.dateOfExecotion.ToString();
            AddCustomerContract.Text = munnicipalContract.customer.ToString();
            AddExecutinContract.Text = munnicipalContract.executor.ToString();
            AddLocalityContract.DataSource = munnicipalContract.tableLocalyty;
            AddLocalityContract.DisplayMember = "Name";
            textBox1.Text = munnicipalContract.price.ToString();
        }

        private void ButtonCreateMunicipalContract_Click(object sender, EventArgs e)
        {

            
        }
    }
}
