namespace Studee_Main.Views.UserControlsForms
{
    partial class toDoListUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openAddTaskWindow = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // openAddTaskWindow
            // 
            this.openAddTaskWindow.BorderRadius = 8;
            this.openAddTaskWindow.CheckedState.Parent = this.openAddTaskWindow;
            this.openAddTaskWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openAddTaskWindow.CustomImages.Parent = this.openAddTaskWindow;
            this.openAddTaskWindow.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(156)))), ((int)(((byte)(116)))));
            this.openAddTaskWindow.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openAddTaskWindow.ForeColor = System.Drawing.Color.White;
            this.openAddTaskWindow.HoverState.Parent = this.openAddTaskWindow;
            this.openAddTaskWindow.Location = new System.Drawing.Point(697, 17);
            this.openAddTaskWindow.Name = "openAddTaskWindow";
            this.openAddTaskWindow.ShadowDecoration.Parent = this.openAddTaskWindow;
            this.openAddTaskWindow.Size = new System.Drawing.Size(180, 45);
            this.openAddTaskWindow.TabIndex = 0;
            this.openAddTaskWindow.Text = "Add Task";
            this.openAddTaskWindow.Click += new System.EventHandler(this.openAddTaskWindow_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 77);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(861, 584);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // toDoListUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.openAddTaskWindow);
            this.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "toDoListUC";
            this.Size = new System.Drawing.Size(902, 681);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button openAddTaskWindow;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
