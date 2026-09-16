namespace PizzaProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.radioButtonLarge = new System.Windows.Forms.RadioButton();
            this.radioButtonMeduim = new System.Windows.Forms.RadioButton();
            this.radioButtonSmall = new System.Windows.Forms.RadioButton();
            this.gbCrustType = new System.Windows.Forms.GroupBox();
            this.radioButtonThinkCrust = new System.Windows.Forms.RadioButton();
            this.radioButtonThinCrust = new System.Windows.Forms.RadioButton();
            this.gbEat = new System.Windows.Forms.GroupBox();
            this.radioButtonTakeOut = new System.Windows.Forms.RadioButton();
            this.radioButtonEatIn = new System.Windows.Forms.RadioButton();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.chcGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chcOlives = new System.Windows.Forms.CheckBox();
            this.chcOnion = new System.Windows.Forms.CheckBox();
            this.chcTomatoes = new System.Windows.Forms.CheckBox();
            this.chcMushrooms = new System.Windows.Forms.CheckBox();
            this.chcExtraChees = new System.Windows.Forms.CheckBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.lblSummary = new System.Windows.Forms.Label();
            this.lblTitleSize = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lblTitleToppings = new System.Windows.Forms.Label();
            this.lblCrustType = new System.Windows.Forms.Label();
            this.lblTitleCrustType = new System.Windows.Forms.Label();
            this.lblEat = new System.Windows.Forms.Label();
            this.lblTitleEat = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTitleTotalPrice = new System.Windows.Forms.Label();
            this.gbSize.SuspendLayout();
            this.gbCrustType.SuspendLayout();
            this.gbEat.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(182, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(487, 64);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "MAKE YOUR PIZZA";
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.radioButtonLarge);
            this.gbSize.Controls.Add(this.radioButtonMeduim);
            this.gbSize.Controls.Add(this.radioButtonSmall);
            this.gbSize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSize.Location = new System.Drawing.Point(24, 92);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(188, 167);
            this.gbSize.TabIndex = 1;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // radioButtonLarge
            // 
            this.radioButtonLarge.AutoSize = true;
            this.radioButtonLarge.Location = new System.Drawing.Point(36, 117);
            this.radioButtonLarge.Name = "radioButtonLarge";
            this.radioButtonLarge.Size = new System.Drawing.Size(67, 25);
            this.radioButtonLarge.TabIndex = 2;
            this.radioButtonLarge.Tag = "40";
            this.radioButtonLarge.Text = "Large";
            this.radioButtonLarge.UseVisualStyleBackColor = true;
            this.radioButtonLarge.CheckedChanged += new System.EventHandler(this.radioButtonLarge_CheckedChanged);
            // 
            // radioButtonMeduim
            // 
            this.radioButtonMeduim.AutoSize = true;
            this.radioButtonMeduim.Checked = true;
            this.radioButtonMeduim.Location = new System.Drawing.Point(36, 74);
            this.radioButtonMeduim.Name = "radioButtonMeduim";
            this.radioButtonMeduim.Size = new System.Drawing.Size(86, 25);
            this.radioButtonMeduim.TabIndex = 1;
            this.radioButtonMeduim.TabStop = true;
            this.radioButtonMeduim.Tag = "30";
            this.radioButtonMeduim.Text = "Meduim";
            this.radioButtonMeduim.UseVisualStyleBackColor = true;
            this.radioButtonMeduim.CheckedChanged += new System.EventHandler(this.radioButtonMeduim_CheckedChanged);
            // 
            // radioButtonSmall
            // 
            this.radioButtonSmall.AutoSize = true;
            this.radioButtonSmall.Location = new System.Drawing.Point(36, 28);
            this.radioButtonSmall.Name = "radioButtonSmall";
            this.radioButtonSmall.Size = new System.Drawing.Size(67, 25);
            this.radioButtonSmall.TabIndex = 0;
            this.radioButtonSmall.Tag = "20";
            this.radioButtonSmall.Text = "Small";
            this.radioButtonSmall.UseVisualStyleBackColor = true;
            this.radioButtonSmall.CheckedChanged += new System.EventHandler(this.radioButtonSmall_CheckedChanged);
            // 
            // gbCrustType
            // 
            this.gbCrustType.Controls.Add(this.radioButtonThinkCrust);
            this.gbCrustType.Controls.Add(this.radioButtonThinCrust);
            this.gbCrustType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCrustType.Location = new System.Drawing.Point(24, 291);
            this.gbCrustType.Name = "gbCrustType";
            this.gbCrustType.Size = new System.Drawing.Size(188, 151);
            this.gbCrustType.TabIndex = 2;
            this.gbCrustType.TabStop = false;
            this.gbCrustType.Text = "Crust Type";
            // 
            // radioButtonThinkCrust
            // 
            this.radioButtonThinkCrust.AutoSize = true;
            this.radioButtonThinkCrust.Location = new System.Drawing.Point(36, 90);
            this.radioButtonThinkCrust.Name = "radioButtonThinkCrust";
            this.radioButtonThinkCrust.Size = new System.Drawing.Size(107, 25);
            this.radioButtonThinkCrust.TabIndex = 3;
            this.radioButtonThinkCrust.Tag = "10";
            this.radioButtonThinkCrust.Text = "Think Crust";
            this.radioButtonThinkCrust.UseVisualStyleBackColor = true;
            this.radioButtonThinkCrust.CheckedChanged += new System.EventHandler(this.radioButtonThinkCrust_CheckedChanged);
            // 
            // radioButtonThinCrust
            // 
            this.radioButtonThinCrust.AutoSize = true;
            this.radioButtonThinCrust.Checked = true;
            this.radioButtonThinCrust.Location = new System.Drawing.Point(36, 44);
            this.radioButtonThinCrust.Name = "radioButtonThinCrust";
            this.radioButtonThinCrust.Size = new System.Drawing.Size(99, 25);
            this.radioButtonThinCrust.TabIndex = 2;
            this.radioButtonThinCrust.TabStop = true;
            this.radioButtonThinCrust.Tag = "0";
            this.radioButtonThinCrust.Text = "Thin Crust";
            this.radioButtonThinCrust.UseVisualStyleBackColor = true;
            this.radioButtonThinCrust.CheckedChanged += new System.EventHandler(this.radioButtonThinCrust_CheckedChanged);
            // 
            // gbEat
            // 
            this.gbEat.Controls.Add(this.radioButtonTakeOut);
            this.gbEat.Controls.Add(this.radioButtonEatIn);
            this.gbEat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEat.Location = new System.Drawing.Point(243, 291);
            this.gbEat.Name = "gbEat";
            this.gbEat.Size = new System.Drawing.Size(234, 86);
            this.gbEat.TabIndex = 3;
            this.gbEat.TabStop = false;
            this.gbEat.Text = "Where To Eat";
            // 
            // radioButtonTakeOut
            // 
            this.radioButtonTakeOut.AutoSize = true;
            this.radioButtonTakeOut.Location = new System.Drawing.Point(122, 44);
            this.radioButtonTakeOut.Name = "radioButtonTakeOut";
            this.radioButtonTakeOut.Size = new System.Drawing.Size(88, 25);
            this.radioButtonTakeOut.TabIndex = 4;
            this.radioButtonTakeOut.Text = "Take Out";
            this.radioButtonTakeOut.UseVisualStyleBackColor = true;
            this.radioButtonTakeOut.CheckedChanged += new System.EventHandler(this.radioButtonTakeOut_CheckedChanged);
            // 
            // radioButtonEatIn
            // 
            this.radioButtonEatIn.AutoSize = true;
            this.radioButtonEatIn.Checked = true;
            this.radioButtonEatIn.Location = new System.Drawing.Point(24, 44);
            this.radioButtonEatIn.Name = "radioButtonEatIn";
            this.radioButtonEatIn.Size = new System.Drawing.Size(66, 25);
            this.radioButtonEatIn.TabIndex = 3;
            this.radioButtonEatIn.TabStop = true;
            this.radioButtonEatIn.Text = "Eat In";
            this.radioButtonEatIn.UseVisualStyleBackColor = true;
            this.radioButtonEatIn.CheckedChanged += new System.EventHandler(this.radioButtonEatIn_CheckedChanged);
            // 
            // gbToppings
            // 
            this.gbToppings.Controls.Add(this.chcGreenPeppers);
            this.gbToppings.Controls.Add(this.chcOlives);
            this.gbToppings.Controls.Add(this.chcOnion);
            this.gbToppings.Controls.Add(this.chcTomatoes);
            this.gbToppings.Controls.Add(this.chcMushrooms);
            this.gbToppings.Controls.Add(this.chcExtraChees);
            this.gbToppings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbToppings.Location = new System.Drawing.Point(243, 92);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(278, 167);
            this.gbToppings.TabIndex = 4;
            this.gbToppings.TabStop = false;
            this.gbToppings.Tag = "5";
            this.gbToppings.Text = "Toppings";
            // 
            // chcGreenPeppers
            // 
            this.chcGreenPeppers.AutoSize = true;
            this.chcGreenPeppers.Location = new System.Drawing.Point(143, 114);
            this.chcGreenPeppers.Name = "chcGreenPeppers";
            this.chcGreenPeppers.Size = new System.Drawing.Size(130, 25);
            this.chcGreenPeppers.TabIndex = 5;
            this.chcGreenPeppers.Tag = "5";
            this.chcGreenPeppers.Text = "Green Peppers";
            this.chcGreenPeppers.UseVisualStyleBackColor = true;
            this.chcGreenPeppers.CheckedChanged += new System.EventHandler(this.chcGreenPeppers_CheckedChanged);
            // 
            // chcOlives
            // 
            this.chcOlives.AutoSize = true;
            this.chcOlives.Location = new System.Drawing.Point(143, 75);
            this.chcOlives.Name = "chcOlives";
            this.chcOlives.Size = new System.Drawing.Size(72, 25);
            this.chcOlives.TabIndex = 4;
            this.chcOlives.Tag = "5";
            this.chcOlives.Text = "Olives";
            this.chcOlives.UseVisualStyleBackColor = true;
            this.chcOlives.CheckedChanged += new System.EventHandler(this.chcOlives_CheckedChanged);
            // 
            // chcOnion
            // 
            this.chcOnion.AutoSize = true;
            this.chcOnion.Location = new System.Drawing.Point(143, 38);
            this.chcOnion.Name = "chcOnion";
            this.chcOnion.Size = new System.Drawing.Size(72, 25);
            this.chcOnion.TabIndex = 3;
            this.chcOnion.Tag = "5";
            this.chcOnion.Text = "Onion";
            this.chcOnion.UseVisualStyleBackColor = true;
            this.chcOnion.CheckedChanged += new System.EventHandler(this.chcOnion_CheckedChanged);
            // 
            // chcTomatoes
            // 
            this.chcTomatoes.AutoSize = true;
            this.chcTomatoes.Location = new System.Drawing.Point(12, 117);
            this.chcTomatoes.Name = "chcTomatoes";
            this.chcTomatoes.Size = new System.Drawing.Size(95, 25);
            this.chcTomatoes.TabIndex = 2;
            this.chcTomatoes.Tag = "5";
            this.chcTomatoes.Text = "Tomatoes";
            this.chcTomatoes.UseVisualStyleBackColor = true;
            this.chcTomatoes.CheckedChanged += new System.EventHandler(this.chcTomatoes_CheckedChanged);
            // 
            // chcMushrooms
            // 
            this.chcMushrooms.AutoSize = true;
            this.chcMushrooms.Location = new System.Drawing.Point(12, 75);
            this.chcMushrooms.Name = "chcMushrooms";
            this.chcMushrooms.Size = new System.Drawing.Size(113, 25);
            this.chcMushrooms.TabIndex = 1;
            this.chcMushrooms.Tag = "5";
            this.chcMushrooms.Text = "Mushrooms";
            this.chcMushrooms.UseVisualStyleBackColor = true;
            this.chcMushrooms.CheckedChanged += new System.EventHandler(this.chcMushrooms_CheckedChanged);
            // 
            // chcExtraChees
            // 
            this.chcExtraChees.AutoSize = true;
            this.chcExtraChees.Location = new System.Drawing.Point(12, 38);
            this.chcExtraChees.Name = "chcExtraChees";
            this.chcExtraChees.Size = new System.Drawing.Size(109, 25);
            this.chcExtraChees.TabIndex = 0;
            this.chcExtraChees.Tag = "5";
            this.chcExtraChees.Text = "Extra Chees";
            this.chcExtraChees.UseVisualStyleBackColor = true;
            this.chcExtraChees.CheckedChanged += new System.EventHandler(this.chcExtraChees_CheckedChanged);
            // 
            // btnOrder
            // 
            this.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(243, 413);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(121, 42);
            this.btnOrder.TabIndex = 5;
            this.btnOrder.Text = "Order Pizza";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetForm.Location = new System.Drawing.Point(400, 413);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(121, 42);
            this.btnResetForm.TabIndex = 6;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummary.Location = new System.Drawing.Point(586, 102);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(114, 18);
            this.lblSummary.TabIndex = 7;
            this.lblSummary.Text = "Order Summary";
            // 
            // lblTitleSize
            // 
            this.lblTitleSize.AutoSize = true;
            this.lblTitleSize.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleSize.Location = new System.Drawing.Point(600, 135);
            this.lblTitleSize.Name = "lblTitleSize";
            this.lblTitleSize.Size = new System.Drawing.Size(54, 20);
            this.lblTitleSize.TabIndex = 8;
            this.lblTitleSize.Text = "Size :";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.BackColor = System.Drawing.Color.Transparent;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(655, 138);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(55, 16);
            this.lblSize.TabIndex = 9;
            this.lblSize.Text = "Medium";
            // 
            // lblToppings
            // 
            this.lblToppings.BackColor = System.Drawing.Color.Transparent;
            this.lblToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings.Location = new System.Drawing.Point(638, 189);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(191, 70);
            this.lblToppings.TabIndex = 11;
            this.lblToppings.Text = "No Toppings";
            // 
            // lblTitleToppings
            // 
            this.lblTitleToppings.AutoSize = true;
            this.lblTitleToppings.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleToppings.Location = new System.Drawing.Point(600, 167);
            this.lblTitleToppings.Name = "lblTitleToppings";
            this.lblTitleToppings.Size = new System.Drawing.Size(92, 20);
            this.lblTitleToppings.TabIndex = 10;
            this.lblTitleToppings.Text = "Toppings :";
            // 
            // lblCrustType
            // 
            this.lblCrustType.AutoSize = true;
            this.lblCrustType.BackColor = System.Drawing.Color.Transparent;
            this.lblCrustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrustType.Location = new System.Drawing.Point(703, 268);
            this.lblCrustType.Name = "lblCrustType";
            this.lblCrustType.Size = new System.Drawing.Size(73, 16);
            this.lblCrustType.TabIndex = 13;
            this.lblCrustType.Text = "Think Crust";
            // 
            // lblTitleCrustType
            // 
            this.lblTitleCrustType.AutoSize = true;
            this.lblTitleCrustType.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleCrustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleCrustType.Location = new System.Drawing.Point(600, 264);
            this.lblTitleCrustType.Name = "lblTitleCrustType";
            this.lblTitleCrustType.Size = new System.Drawing.Size(105, 20);
            this.lblTitleCrustType.TabIndex = 12;
            this.lblTitleCrustType.Text = "Crust Type :";
            // 
            // lblEat
            // 
            this.lblEat.AutoSize = true;
            this.lblEat.BackColor = System.Drawing.Color.Transparent;
            this.lblEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEat.Location = new System.Drawing.Point(728, 309);
            this.lblEat.Name = "lblEat";
            this.lblEat.Size = new System.Drawing.Size(40, 16);
            this.lblEat.TabIndex = 15;
            this.lblEat.Text = "Eat In";
            // 
            // lblTitleEat
            // 
            this.lblTitleEat.AutoSize = true;
            this.lblTitleEat.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleEat.Location = new System.Drawing.Point(600, 305);
            this.lblTitleEat.Name = "lblTitleEat";
            this.lblTitleEat.Size = new System.Drawing.Size(130, 20);
            this.lblTitleEat.TabIndex = 14;
            this.lblTitleEat.Text = "Where to Eat  :";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Green;
            this.lblPrice.Location = new System.Drawing.Point(676, 378);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 60);
            this.lblPrice.TabIndex = 17;
            // 
            // lblTitleTotalPrice
            // 
            this.lblTitleTotalPrice.AutoSize = true;
            this.lblTitleTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleTotalPrice.Location = new System.Drawing.Point(600, 349);
            this.lblTitleTotalPrice.Name = "lblTitleTotalPrice";
            this.lblTitleTotalPrice.Size = new System.Drawing.Size(104, 20);
            this.lblTitleTotalPrice.TabIndex = 16;
            this.lblTitleTotalPrice.Text = "Total Price :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 473);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblTitleTotalPrice);
            this.Controls.Add(this.lblEat);
            this.Controls.Add(this.lblTitleEat);
            this.Controls.Add(this.lblCrustType);
            this.Controls.Add(this.lblTitleCrustType);
            this.Controls.Add(this.lblToppings);
            this.Controls.Add(this.lblTitleToppings);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblTitleSize);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbEat);
            this.Controls.Add(this.gbCrustType);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Pizza Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbCrustType.ResumeLayout(false);
            this.gbCrustType.PerformLayout();
            this.gbEat.ResumeLayout(false);
            this.gbEat.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.GroupBox gbCrustType;
        private System.Windows.Forms.GroupBox gbEat;
        private System.Windows.Forms.RadioButton radioButtonLarge;
        private System.Windows.Forms.RadioButton radioButtonMeduim;
        private System.Windows.Forms.RadioButton radioButtonSmall;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.CheckBox chcGreenPeppers;
        private System.Windows.Forms.CheckBox chcOlives;
        private System.Windows.Forms.CheckBox chcOnion;
        private System.Windows.Forms.CheckBox chcTomatoes;
        private System.Windows.Forms.CheckBox chcMushrooms;
        private System.Windows.Forms.CheckBox chcExtraChees;
        private System.Windows.Forms.RadioButton radioButtonThinkCrust;
        private System.Windows.Forms.RadioButton radioButtonThinCrust;
        private System.Windows.Forms.RadioButton radioButtonTakeOut;
        private System.Windows.Forms.RadioButton radioButtonEatIn;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.Label lblTitleSize;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label lblTitleToppings;
        private System.Windows.Forms.Label lblCrustType;
        private System.Windows.Forms.Label lblTitleCrustType;
        private System.Windows.Forms.Label lblEat;
        private System.Windows.Forms.Label lblTitleEat;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTitleTotalPrice;
    }
}

