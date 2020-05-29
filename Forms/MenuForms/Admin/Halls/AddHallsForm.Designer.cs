namespace DesktopApp.Forms.MenuForms.Admin.Halls
{
    partial class AddHallsForm
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
            this.components = new System.ComponentModel.Container();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.sendButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.nameField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.numberField = new System.Windows.Forms.NumericUpDown();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberField)).BeginInit();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.materialLabel1);
            this.contentPanel.Controls.Add(this.numberField);
            this.contentPanel.Controls.Add(this.materialLabel4);
            this.contentPanel.Controls.Add(this.sendButton);
            this.contentPanel.Controls.Add(this.materialLabel2);
            this.contentPanel.Controls.Add(this.nameField);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(786, 455);
            this.contentPanel.TabIndex = 1;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(123, 127);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(185, 19);
            this.materialLabel4.TabIndex = 6;
            this.materialLabel4.Text = "Min 2, maks 50 characters";
            // 
            // sendButton
            // 
            this.sendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendButton.Depth = 0;
            this.sendButton.Location = new System.Drawing.Point(317, 324);
            this.sendButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.sendButton.Name = "sendButton";
            this.sendButton.Primary = true;
            this.sendButton.Size = new System.Drawing.Size(146, 44);
            this.sendButton.TabIndex = 4;
            this.sendButton.Text = "Wyślij";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(100, 79);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(58, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Nazwa:";
            // 
            // nameField
            // 
            this.nameField.Depth = 0;
            this.nameField.Hint = "";
            this.nameField.Location = new System.Drawing.Point(104, 101);
            this.nameField.MouseState = MaterialSkin.MouseState.HOVER;
            this.nameField.Name = "nameField";
            this.nameField.PasswordChar = '\0';
            this.nameField.SelectedText = "";
            this.nameField.SelectionLength = 0;
            this.nameField.SelectionStart = 0;
            this.nameField.Size = new System.Drawing.Size(596, 23);
            this.nameField.TabIndex = 1;
            this.nameField.UseSystemPasswordChar = false;
            // 
            // numberField
            // 
            this.numberField.Location = new System.Drawing.Point(317, 229);
            this.numberField.Name = "numberField";
            this.numberField.Size = new System.Drawing.Size(146, 20);
            this.numberField.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(213, 227);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(95, 19);
            this.materialLabel1.TabIndex = 8;
            this.materialLabel1.Text = "Ilość miejsc:";
            // 
            // AddHallsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 455);
            this.Controls.Add(this.contentPanel);
            this.Name = "AddHallsForm";
            this.Text = "AddHallsForm";
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberField)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contentPanel;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialRaisedButton sendButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField nameField;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.NumericUpDown numberField;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}