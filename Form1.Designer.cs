namespace Helix_Item_Maker
{
    partial class HelixItemMaker
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelixItemMaker));
            label1 = new Label();
            inputItemName = new TextBox();
            label2 = new Label();
            inputItemModel = new TextBox();
            label3 = new Label();
            inputItemDesc = new RichTextBox();
            inputItemCat = new TextBox();
            label4 = new Label();
            inputItemCost = new TextBox();
            label5 = new Label();
            inputItemWidth = new TextBox();
            label6 = new Label();
            inputItemHeight = new TextBox();
            label7 = new Label();
            inputItemBusiness = new CheckBox();
            inputexRender = new CheckBox();
            outputItemCode = new RichTextBox();
            label8 = new Label();
            button1 = new Button();
            buttonSaveItem = new Button();
            InputHasPacData = new CheckBox();
            inputUseIconCam = new CheckBox();
            inputIconCamData = new RichTextBox();
            inputIsWeapon = new CheckBox();
            inputWeaponClass = new TextBox();
            label9 = new Label();
            label10 = new Label();
            inputWeapCat = new ComboBox();
            inputPACData = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 17);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 0;
            label1.Text = "Item Name:";
            // 
            // inputItemName
            // 
            inputItemName.Location = new Point(17, 35);
            inputItemName.Name = "inputItemName";
            inputItemName.Size = new Size(233, 23);
            inputItemName.TabIndex = 1;
            inputItemName.Click += inputItemName_Click;
            inputItemName.TextChanged += inputItemName_TextChanged;
            inputItemName.Enter += inputItemName_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 73);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 2;
            label2.Text = "Item Model:";
            // 
            // inputItemModel
            // 
            inputItemModel.Location = new Point(17, 91);
            inputItemModel.Name = "inputItemModel";
            inputItemModel.Size = new Size(233, 23);
            inputItemModel.TabIndex = 3;
            inputItemModel.Click += inputItemModel_Click;
            inputItemModel.TextChanged += inputItemModel_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 132);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 4;
            label3.Text = "Item Description:";
            // 
            // inputItemDesc
            // 
            inputItemDesc.BorderStyle = BorderStyle.FixedSingle;
            inputItemDesc.Location = new Point(17, 150);
            inputItemDesc.Name = "inputItemDesc";
            inputItemDesc.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            inputItemDesc.Size = new Size(233, 94);
            inputItemDesc.TabIndex = 6;
            inputItemDesc.Text = "";
            inputItemDesc.Click += inputItemDesc_Click;
            // 
            // inputItemCat
            // 
            inputItemCat.Location = new Point(17, 279);
            inputItemCat.Name = "inputItemCat";
            inputItemCat.Size = new Size(233, 23);
            inputItemCat.TabIndex = 8;
            inputItemCat.Click += inputItemCat_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 261);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 7;
            label4.Text = "Item Catergory:";
            label4.Click += label4_Click;
            // 
            // inputItemCost
            // 
            inputItemCost.Location = new Point(17, 337);
            inputItemCost.Name = "inputItemCost";
            inputItemCost.Size = new Size(73, 23);
            inputItemCost.TabIndex = 10;
            inputItemCost.Click += inputItemCost_Click;
            inputItemCost.TextChanged += inputItemCost_TextChanged;
            inputItemCost.KeyPress += inputItemCost_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(17, 319);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 9;
            label5.Text = "Item Price:";
            // 
            // inputItemWidth
            // 
            inputItemWidth.Location = new Point(99, 337);
            inputItemWidth.Name = "inputItemWidth";
            inputItemWidth.Size = new Size(73, 23);
            inputItemWidth.TabIndex = 12;
            inputItemWidth.Click += inputItemWidth_Click;
            inputItemWidth.TextChanged += inputItemWidth_TextChanged;
            inputItemWidth.KeyPress += inputItemWidth_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(98, 319);
            label6.Name = "label6";
            label6.Size = new Size(74, 15);
            label6.TabIndex = 11;
            label6.Text = "Item Width:";
            // 
            // inputItemHeight
            // 
            inputItemHeight.Location = new Point(182, 337);
            inputItemHeight.Name = "inputItemHeight";
            inputItemHeight.Size = new Size(73, 23);
            inputItemHeight.TabIndex = 14;
            inputItemHeight.Click += inputItemHeight_Click;
            inputItemHeight.KeyPress += inputItemHeight_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(182, 319);
            label7.Name = "label7";
            label7.Size = new Size(78, 15);
            label7.TabIndex = 13;
            label7.Text = "Item Height:";
            // 
            // inputItemBusiness
            // 
            inputItemBusiness.AutoSize = true;
            inputItemBusiness.BackColor = SystemColors.Control;
            inputItemBusiness.FlatStyle = FlatStyle.Flat;
            inputItemBusiness.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inputItemBusiness.Location = new Point(17, 370);
            inputItemBusiness.Name = "inputItemBusiness";
            inputItemBusiness.Size = new Size(194, 19);
            inputItemBusiness.TabIndex = 16;
            inputItemBusiness.Text = "Don't show in Bussiness menu?";
            inputItemBusiness.UseVisualStyleBackColor = false;
            inputItemBusiness.CheckedChanged += inputItemBusiness_CheckedChanged;
            // 
            // inputexRender
            // 
            inputexRender.AutoSize = true;
            inputexRender.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inputexRender.Location = new Point(17, 528);
            inputexRender.Name = "inputexRender";
            inputexRender.Size = new Size(153, 19);
            inputexRender.TabIndex = 17;
            inputexRender.Text = "Use \"ITEM.exRender\"?";
            inputexRender.UseVisualStyleBackColor = true;
            inputexRender.CheckedChanged += inputexRender_CheckedChanged;
            // 
            // outputItemCode
            // 
            outputItemCode.BorderStyle = BorderStyle.FixedSingle;
            outputItemCode.Location = new Point(288, 35);
            outputItemCode.Name = "outputItemCode";
            outputItemCode.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            outputItemCode.Size = new Size(433, 683);
            outputItemCode.TabIndex = 20;
            outputItemCode.Text = "";
            outputItemCode.Click += outputItemCode_Click;
            outputItemCode.TextChanged += richTextBox1_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(288, 17);
            label8.Name = "label8";
            label8.Size = new Size(117, 15);
            label8.TabIndex = 21;
            label8.Text = "Item Code Preview:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(288, 761);
            button1.Name = "button1";
            button1.Size = new Size(189, 65);
            button1.TabIndex = 22;
            button1.Text = "GENERATE ITEM CODE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // buttonSaveItem
            // 
            buttonSaveItem.BackColor = SystemColors.Control;
            buttonSaveItem.Enabled = false;
            buttonSaveItem.FlatStyle = FlatStyle.Flat;
            buttonSaveItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSaveItem.ForeColor = SystemColors.ControlText;
            buttonSaveItem.Location = new Point(532, 761);
            buttonSaveItem.Name = "buttonSaveItem";
            buttonSaveItem.Size = new Size(189, 65);
            buttonSaveItem.TabIndex = 23;
            buttonSaveItem.Text = "SAVE ITEM";
            buttonSaveItem.UseVisualStyleBackColor = false;
            buttonSaveItem.Click += buttonSaveItem_Click;
            buttonSaveItem.MouseHover += buttonSaveItem_MouseHover;
            // 
            // InputHasPacData
            // 
            InputHasPacData.AutoSize = true;
            InputHasPacData.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InputHasPacData.Location = new Point(17, 684);
            InputHasPacData.Name = "InputHasPacData";
            InputHasPacData.Size = new Size(139, 19);
            InputHasPacData.TabIndex = 24;
            InputHasPacData.Text = "Item has PAC3 Data?";
            InputHasPacData.UseVisualStyleBackColor = true;
            InputHasPacData.CheckedChanged += itemHasPacData_CheckedChanged;
            InputHasPacData.CheckStateChanged += InputHasPacData_CheckStateChanged;
            // 
            // inputUseIconCam
            // 
            inputUseIconCam.AutoSize = true;
            inputUseIconCam.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inputUseIconCam.Location = new Point(17, 553);
            inputUseIconCam.Name = "inputUseIconCam";
            inputUseIconCam.Size = new Size(103, 19);
            inputUseIconCam.TabIndex = 26;
            inputUseIconCam.Text = "Use IconCam?";
            inputUseIconCam.UseVisualStyleBackColor = true;
            inputUseIconCam.CheckedChanged += inputUseIconCam_CheckedChanged;
            inputUseIconCam.CheckStateChanged += inputUseIconCam_CheckStateChanged;
            // 
            // inputIconCamData
            // 
            inputIconCamData.BorderStyle = BorderStyle.FixedSingle;
            inputIconCamData.Enabled = false;
            inputIconCamData.Location = new Point(17, 578);
            inputIconCamData.Name = "inputIconCamData";
            inputIconCamData.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            inputIconCamData.Size = new Size(233, 94);
            inputIconCamData.TabIndex = 27;
            inputIconCamData.Text = "Place IconCam Data here";
            inputIconCamData.Click += inputIconCamData_Click;
            inputIconCamData.TextChanged += inputIconCamData_TextChanged;
            // 
            // inputIsWeapon
            // 
            inputIsWeapon.AutoSize = true;
            inputIsWeapon.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inputIsWeapon.Location = new Point(17, 403);
            inputIsWeapon.Name = "inputIsWeapon";
            inputIsWeapon.Size = new Size(125, 19);
            inputIsWeapon.TabIndex = 29;
            inputIsWeapon.Text = "Is item a weapon?";
            inputIsWeapon.UseVisualStyleBackColor = true;
            inputIsWeapon.CheckedChanged += checkBox1_CheckedChanged;
            inputIsWeapon.CheckStateChanged += inputIsWeapon_CheckStateChanged;
            // 
            // inputWeaponClass
            // 
            inputWeaponClass.Enabled = false;
            inputWeaponClass.Location = new Point(17, 447);
            inputWeaponClass.Name = "inputWeaponClass";
            inputWeaponClass.Size = new Size(233, 23);
            inputWeaponClass.TabIndex = 32;
            inputWeaponClass.Text = "weapon_physgun";
            inputWeaponClass.Click += inputWeaponClass_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(17, 429);
            label9.Name = "label9";
            label9.Size = new Size(115, 15);
            label9.TabIndex = 31;
            label9.Text = "Item Weapon Class:";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(17, 476);
            label10.Name = "label10";
            label10.Size = new Size(139, 15);
            label10.TabIndex = 33;
            label10.Text = "Item Weapon Category:";
            // 
            // inputWeapCat
            // 
            inputWeapCat.Enabled = false;
            inputWeapCat.FormattingEnabled = true;
            inputWeapCat.Items.AddRange(new object[] { "primary", "sidearm", "melee", "grenade" });
            inputWeapCat.Location = new Point(17, 494);
            inputWeapCat.Name = "inputWeapCat";
            inputWeapCat.Size = new Size(233, 23);
            inputWeapCat.TabIndex = 34;
            inputWeapCat.Text = "Select Category";
            // 
            // inputPACData
            // 
            inputPACData.BorderStyle = BorderStyle.FixedSingle;
            inputPACData.Enabled = false;
            inputPACData.Location = new Point(17, 709);
            inputPACData.Name = "inputPACData";
            inputPACData.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            inputPACData.Size = new Size(233, 156);
            inputPACData.TabIndex = 35;
            inputPACData.Text = "Place PAC3 Data here";
            inputPACData.Click += inputPACData_Click;
            // 
            // HelixItemMaker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 896);
            Controls.Add(inputPACData);
            Controls.Add(inputWeapCat);
            Controls.Add(label10);
            Controls.Add(inputWeaponClass);
            Controls.Add(label9);
            Controls.Add(inputIsWeapon);
            Controls.Add(inputIconCamData);
            Controls.Add(inputUseIconCam);
            Controls.Add(InputHasPacData);
            Controls.Add(buttonSaveItem);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(outputItemCode);
            Controls.Add(inputexRender);
            Controls.Add(inputItemBusiness);
            Controls.Add(inputItemHeight);
            Controls.Add(label7);
            Controls.Add(inputItemWidth);
            Controls.Add(label6);
            Controls.Add(inputItemCost);
            Controls.Add(label5);
            Controls.Add(inputItemCat);
            Controls.Add(label4);
            Controls.Add(inputItemDesc);
            Controls.Add(label3);
            Controls.Add(inputItemModel);
            Controls.Add(label2);
            Controls.Add(inputItemName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "HelixItemMaker";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Helix Item Maker";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox inputItemName;
        private Label label2;
        private TextBox inputItemModel;
        private Label label3;
        private RichTextBox inputItemDesc;
        private TextBox inputItemCat;
        private Label label4;
        private TextBox inputItemCost;
        private Label label5;
        private TextBox inputItemWidth;
        private Label label6;
        private TextBox inputItemHeight;
        private Label label7;
        private CheckBox inputItemBusiness;
        private CheckBox inputexRender;
        private RichTextBox outputItemCode;
        private Label label8;
        private Button button1;
        private Button buttonSaveItem;
        private CheckBox InputHasPacData;
        private CheckBox inputUseIconCam;
        private RichTextBox inputIconCamData;
        private CheckBox inputIsWeapon;
        private TextBox inputWeaponClass;
        private Label label9;
        private Label label10;
        private ComboBox inputWeapCat;
        private RichTextBox inputPACData;
    }
}
