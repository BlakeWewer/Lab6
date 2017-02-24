namespace Lab6
{
    partial class UserInterface
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
            this.uxLabelShares = new System.Windows.Forms.Label();
            this.uxShares = new System.Windows.Forms.TextBox();
            this.uxLabelCost = new System.Windows.Forms.Label();
            this.uxCost = new System.Windows.Forms.TextBox();
            this.uxBuy = new System.Windows.Forms.Button();
            this.uxSell = new System.Windows.Forms.Button();
            this.uxLabelNet = new System.Windows.Forms.Label();
            this.uxNet = new System.Windows.Forms.TextBox();
            this.uxTwoStacksButton = new System.Windows.Forms.RadioButton();
            this.uxGroupBox = new System.Windows.Forms.GroupBox();
            this.uxLinkedButton = new System.Windows.Forms.RadioButton();
            this.uxArrayButton = new System.Windows.Forms.RadioButton();
            this.uxGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxLabelShares
            // 
            this.uxLabelShares.AutoSize = true;
            this.uxLabelShares.Location = new System.Drawing.Point(36, 194);
            this.uxLabelShares.Name = "uxLabelShares";
            this.uxLabelShares.Size = new System.Drawing.Size(165, 24);
            this.uxLabelShares.TabIndex = 0;
            this.uxLabelShares.Text = "Number of shares:";
            // 
            // uxShares
            // 
            this.uxShares.Location = new System.Drawing.Point(207, 194);
            this.uxShares.Name = "uxShares";
            this.uxShares.Size = new System.Drawing.Size(130, 29);
            this.uxShares.TabIndex = 1;
            // 
            // uxLabelCost
            // 
            this.uxLabelCost.AutoSize = true;
            this.uxLabelCost.Location = new System.Drawing.Point(36, 237);
            this.uxLabelCost.Name = "uxLabelCost";
            this.uxLabelCost.Size = new System.Drawing.Size(143, 24);
            this.uxLabelCost.TabIndex = 2;
            this.uxLabelCost.Text = "Price per share:";
            // 
            // uxCost
            // 
            this.uxCost.Location = new System.Drawing.Point(185, 237);
            this.uxCost.Name = "uxCost";
            this.uxCost.Size = new System.Drawing.Size(152, 29);
            this.uxCost.TabIndex = 3;
            // 
            // uxBuy
            // 
            this.uxBuy.Location = new System.Drawing.Point(63, 295);
            this.uxBuy.Name = "uxBuy";
            this.uxBuy.Size = new System.Drawing.Size(101, 38);
            this.uxBuy.TabIndex = 4;
            this.uxBuy.Text = "Buy";
            this.uxBuy.UseVisualStyleBackColor = true;
            this.uxBuy.Click += new System.EventHandler(this.uxBuy_Click);
            // 
            // uxSell
            // 
            this.uxSell.Location = new System.Drawing.Point(207, 295);
            this.uxSell.Name = "uxSell";
            this.uxSell.Size = new System.Drawing.Size(100, 38);
            this.uxSell.TabIndex = 5;
            this.uxSell.Text = "Sell";
            this.uxSell.UseVisualStyleBackColor = true;
            this.uxSell.Click += new System.EventHandler(this.uxSell_Click);
            // 
            // uxLabelNet
            // 
            this.uxLabelNet.AutoSize = true;
            this.uxLabelNet.Location = new System.Drawing.Point(36, 365);
            this.uxLabelNet.Name = "uxLabelNet";
            this.uxLabelNet.Size = new System.Drawing.Size(85, 24);
            this.uxLabelNet.TabIndex = 6;
            this.uxLabelNet.Text = "Net gain:";
            // 
            // uxNet
            // 
            this.uxNet.Location = new System.Drawing.Point(127, 362);
            this.uxNet.Name = "uxNet";
            this.uxNet.ReadOnly = true;
            this.uxNet.Size = new System.Drawing.Size(210, 29);
            this.uxNet.TabIndex = 7;
            this.uxNet.Text = "0";
            // 
            // uxTwoStacksButton
            // 
            this.uxTwoStacksButton.AutoSize = true;
            this.uxTwoStacksButton.Location = new System.Drawing.Point(20, 37);
            this.uxTwoStacksButton.Name = "uxTwoStacksButton";
            this.uxTwoStacksButton.Size = new System.Drawing.Size(124, 28);
            this.uxTwoStacksButton.TabIndex = 8;
            this.uxTwoStacksButton.TabStop = true;
            this.uxTwoStacksButton.Text = "Two Stacks";
            this.uxTwoStacksButton.UseVisualStyleBackColor = true;
            this.uxTwoStacksButton.Click += new System.EventHandler(this.QueueChanged);
            // 
            // uxGroupBox
            // 
            this.uxGroupBox.Controls.Add(this.uxLinkedButton);
            this.uxGroupBox.Controls.Add(this.uxArrayButton);
            this.uxGroupBox.Controls.Add(this.uxTwoStacksButton);
            this.uxGroupBox.Location = new System.Drawing.Point(35, 24);
            this.uxGroupBox.Name = "uxGroupBox";
            this.uxGroupBox.Size = new System.Drawing.Size(301, 150);
            this.uxGroupBox.TabIndex = 9;
            this.uxGroupBox.TabStop = false;
            this.uxGroupBox.Text = "Choose Queue Type";
            // 
            // uxLinkedButton
            // 
            this.uxLinkedButton.AutoSize = true;
            this.uxLinkedButton.Location = new System.Drawing.Point(20, 105);
            this.uxLinkedButton.Name = "uxLinkedButton";
            this.uxLinkedButton.Size = new System.Drawing.Size(84, 28);
            this.uxLinkedButton.TabIndex = 10;
            this.uxLinkedButton.TabStop = true;
            this.uxLinkedButton.Text = "Linked";
            this.uxLinkedButton.UseVisualStyleBackColor = true;
            this.uxLinkedButton.Click += new System.EventHandler(this.QueueChanged);
            // 
            // uxArrayButton
            // 
            this.uxArrayButton.AutoSize = true;
            this.uxArrayButton.Location = new System.Drawing.Point(20, 71);
            this.uxArrayButton.Name = "uxArrayButton";
            this.uxArrayButton.Size = new System.Drawing.Size(72, 28);
            this.uxArrayButton.TabIndex = 9;
            this.uxArrayButton.TabStop = true;
            this.uxArrayButton.Text = "Array";
            this.uxArrayButton.UseVisualStyleBackColor = true;
            this.uxArrayButton.Click += new System.EventHandler(this.QueueChanged);
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 424);
            this.Controls.Add(this.uxGroupBox);
            this.Controls.Add(this.uxNet);
            this.Controls.Add(this.uxLabelNet);
            this.Controls.Add(this.uxSell);
            this.Controls.Add(this.uxBuy);
            this.Controls.Add(this.uxCost);
            this.Controls.Add(this.uxLabelCost);
            this.Controls.Add(this.uxShares);
            this.Controls.Add(this.uxLabelShares);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UserInterface";
            this.Text = "Capital Gain Calculator";
            this.Load += new System.EventHandler(this.UserInterface_Load);
            this.uxGroupBox.ResumeLayout(false);
            this.uxGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxLabelShares;
        private System.Windows.Forms.TextBox uxShares;
        private System.Windows.Forms.Label uxLabelCost;
        private System.Windows.Forms.TextBox uxCost;
        private System.Windows.Forms.Button uxBuy;
        private System.Windows.Forms.Button uxSell;
        private System.Windows.Forms.Label uxLabelNet;
        private System.Windows.Forms.TextBox uxNet;
        private System.Windows.Forms.RadioButton uxTwoStacksButton;
        private System.Windows.Forms.GroupBox uxGroupBox;
        private System.Windows.Forms.RadioButton uxLinkedButton;
        private System.Windows.Forms.RadioButton uxArrayButton;
    }
}

