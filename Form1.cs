namespace Helix_Item_Maker
{
    using System;
    using System.IO;
    using System.Security.Cryptography;

    public partial class HelixItemMaker : Form
    {
        string itemName = "My Item";
        string itemDesc = "Default item description";
        string itemMdl = "models/props/example.mdl";
        string itemCat = "Misc";
        int itemWidth = 1;
        int itemHeight = 1;
        int itemCost = 1;
        bool itemBusiness = false;
        bool itemexRender = false;
        bool itemUsesPac = false;
        string itemPacData = "";
        bool itemIsAWeapon = false;
        string itemWeapCat = "";
        string itemWeapClass = "";
        bool itemUseIconCam = false;
        string itemIconCam = "";


        public string itemBusinessLowercase
        {
            get { return itemBusiness ? "true" : "false"; }
        }

        public string itemexRenderLowercase
        {
            get { return itemexRender ? "true" : "false"; }
        }

        public HelixItemMaker()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            inputItemName.Text = itemName;
            inputItemModel.Text = itemMdl;
            inputItemDesc.Text = itemDesc;
            inputItemCat.Text = itemCat;
            inputItemCost.Text = itemCost.ToString();
            inputItemWidth.Text = itemWidth.ToString();
            inputItemHeight.Text = itemHeight.ToString();
            inputItemBusiness.Checked = itemBusiness;
            inputexRender.Checked = itemexRender;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void inputItemName_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputItemModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputItemCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputItemCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void inputItemWidth_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputItemWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void inputItemHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void inputItemName_Enter(object sender, EventArgs e)
        {

        }

        private void inputItemName_Click(object sender, EventArgs e)
        {
            inputItemName.SelectAll();
        }

        private void inputItemModel_Click(object sender, EventArgs e)
        {
            inputItemModel.SelectAll();
        }

        private void inputItemDesc_Click(object sender, EventArgs e)
        {
            inputItemDesc.SelectAll();
        }

        private void inputItemCat_Click(object sender, EventArgs e)
        {
            inputItemCat.SelectAll();
        }

        private void inputItemCost_Click(object sender, EventArgs e)
        {
            inputItemCost.SelectAll();
        }

        private void inputItemWidth_Click(object sender, EventArgs e)
        {
            inputItemWidth.SelectAll();
        }

        private void inputItemHeight_Click(object sender, EventArgs e)
        {
            inputItemHeight.SelectAll();
        }

        private void inputItemBusiness_CheckedChanged(object sender, EventArgs e)
        {
            if (this.inputItemBusiness.Checked == true)
            {
                itemBusiness = true;
              //  debugtxt.Text = itemBusinessLowercase;
            }
            else
            {
                itemBusiness = false;
             //   debugtxt.Text = itemBusinessLowercase;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void inputexRender_CheckedChanged(object sender, EventArgs e)
        {
            if (this.inputexRender.Checked == true)
            {
                itemexRender = true;
             //   debugtxt2.Text = itemexRenderLowercase;
            }
            else
            {
                itemexRender = false;
             //   debugtxt2.Text = itemexRenderLowercase;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void outputItemCode_Click(object sender, EventArgs e)
        {
            outputItemCode.SelectAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonSaveItem.Enabled = true;
            outputItemCode.Text = "";

            outputItemCode.AppendText("ITEM.name = " + "\"" + inputItemName.Text + "\"");
            outputItemCode.AppendText("\n" + "ITEM.model = " + "\"" + inputItemModel.Text + "\"");
            outputItemCode.AppendText("\n" + "ITEM.description = " + "\"" + inputItemDesc.Text + "\"");
            outputItemCode.AppendText("\n" + "ITEM.category = " + "\"" + inputItemCat.Text + "\"");
            outputItemCode.AppendText("\n" + "ITEM.price = " + inputItemCost.Text.ToString());
            outputItemCode.AppendText("\n" + "ITEM.width = " + inputItemWidth.Text.ToString());
            outputItemCode.AppendText("\n" + "ITEM.height = " + inputItemHeight.Text.ToString());
            outputItemCode.AppendText("\n" + "ITEM.noBusiness = " + itemBusinessLowercase);
            outputItemCode.AppendText("\n" + "ITEM.exRender = " + itemexRenderLowercase);

            if (itemIsAWeapon == true)
            {
                outputItemCode.AppendText("\n" + "ITEM.class = " + "\"" + inputWeaponClass.Text + "\"");
                outputItemCode.AppendText("\n" + "ITEM.weaponCategory = " + "\"" + inputWeapCat.Text + "\"");
            }

            if (itemUseIconCam == true)
            {
                outputItemCode.AppendText("\n" + "ITEM.iconCam = {\n" + inputIconCamData.Text + "\n}");
            }

            if (itemUsesPac == true)
            {
                outputItemCode.AppendText("\n" + "ITEM.pacData = {\n" + inputPACData.Text + "\n}");
            }
            else
            {
                inputPACData.Text = "";
            }

        }

        private void debugtxt2_Click(object sender, EventArgs e)
        {
        }

        private void buttonSaveItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "*.lua|*.lua";
            dlg.RestoreDirectory = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dlg.FileName, outputItemCode.Text);
            }
        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void itemHasPacData_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void inputIconCamData_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputIconCamData_Click(object sender, EventArgs e)
        {
            inputIconCamData.SelectAll();
        }

        private void inputUseIconCam_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void inputUseIconCam_CheckStateChanged(object sender, EventArgs e)
        {
            inputIconCamData.Enabled = (inputUseIconCam.CheckState == CheckState.Checked);
            if (inputUseIconCam.CheckState == CheckState.Checked)
            {
                itemUseIconCam = true;
              //  debugtxt4.Text = itemUseIconCam.ToString();
            }
            else if (inputUseIconCam.CheckState == CheckState.Unchecked)
            {
                itemUseIconCam = false;
                //debugtxt4.Text = itemUseIconCam.ToString();
            }
        }

        private void debugtxt4_Click(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void inputIsWeapon_CheckStateChanged(object sender, EventArgs e)
        {
            inputWeaponClass.Enabled = (inputIsWeapon.CheckState == CheckState.Checked);
            inputWeapCat.Enabled = (inputIsWeapon.CheckState == CheckState.Checked);
            if (inputIsWeapon.CheckState == CheckState.Checked)
            {
                itemIsAWeapon = true;
               // debugtxt5.Text = itemIsAWeapon.ToString();
            }
            else if (inputIsWeapon.CheckState == CheckState.Unchecked)
            {
                itemIsAWeapon = false;
               // debugtxt5.Text = itemIsAWeapon.ToString();
            }
        }

        private void inputWeaponClass_Click(object sender, EventArgs e)
        {
            inputWeaponClass.SelectAll();
        }

        private void InputHasPacData_CheckStateChanged(object sender, EventArgs e)
        {
            inputPACData.Enabled = (InputHasPacData.CheckState == CheckState.Checked);
            if (InputHasPacData.CheckState == CheckState.Checked)
            {
                itemUsesPac = true;
              //  debugtxt3.Text = itemUsesPac.ToString();
            }
            else if (InputHasPacData.CheckState == CheckState.Unchecked)
            {
                itemUsesPac = false;
              //  debugtxt3.Text = itemUsesPac.ToString();
            }
        }

        private void inputPACData_Click(object sender, EventArgs e)
        {
            inputPACData.SelectAll();
        }

        private void buttonSaveItem_MouseHover(object sender, EventArgs e)
        {

        }
    }
}


