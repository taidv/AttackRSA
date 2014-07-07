namespace Wiener
{
    partial class WienerMainForm
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
            this.btnProcess = new System.Windows.Forms.Button();
            this.lbPQ = new System.Windows.Forms.Label();
            this.txtPQ = new System.Windows.Forms.TextBox();
            this.txtE = new System.Windows.Forms.TextBox();
            this.lbE = new System.Windows.Forms.Label();
            this.lstResult = new System.Windows.Forms.ListBox();
            this.cbShowLog = new System.Windows.Forms.CheckBox();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.btnLoadJson = new System.Windows.Forms.Button();
            this.openJsonFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(43, 58);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(787, 40);
            this.btnProcess.TabIndex = 0;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // lbPQ
            // 
            this.lbPQ.AutoSize = true;
            this.lbPQ.Location = new System.Drawing.Point(38, 24);
            this.lbPQ.Name = "lbPQ";
            this.lbPQ.Size = new System.Drawing.Size(36, 25);
            this.lbPQ.TabIndex = 1;
            this.lbPQ.Text = "pq";
            // 
            // txtPQ
            // 
            this.txtPQ.Location = new System.Drawing.Point(80, 21);
            this.txtPQ.Name = "txtPQ";
            this.txtPQ.Size = new System.Drawing.Size(352, 31);
            this.txtPQ.TabIndex = 2;
            this.txtPQ.Text = "8927";
            // 
            // txtE
            // 
            this.txtE.Location = new System.Drawing.Point(478, 21);
            this.txtE.Name = "txtE";
            this.txtE.Size = new System.Drawing.Size(352, 31);
            this.txtE.TabIndex = 4;
            this.txtE.Text = "2621";
            // 
            // lbE
            // 
            this.lbE.AutoSize = true;
            this.lbE.Location = new System.Drawing.Point(448, 24);
            this.lbE.Name = "lbE";
            this.lbE.Size = new System.Drawing.Size(24, 25);
            this.lbE.TabIndex = 3;
            this.lbE.Text = "e";
            // 
            // lstResult
            // 
            this.lstResult.FormattingEnabled = true;
            this.lstResult.ItemHeight = 25;
            this.lstResult.Location = new System.Drawing.Point(43, 149);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(787, 254);
            this.lstResult.TabIndex = 5;
            // 
            // cbShowLog
            // 
            this.cbShowLog.AutoSize = true;
            this.cbShowLog.Checked = true;
            this.cbShowLog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowLog.Location = new System.Drawing.Point(422, 414);
            this.cbShowLog.Name = "cbShowLog";
            this.cbShowLog.Size = new System.Drawing.Size(214, 29);
            this.cbShowLog.TabIndex = 6;
            this.cbShowLog.Text = "Show process log";
            this.cbShowLog.UseVisualStyleBackColor = true;
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(642, 409);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(188, 37);
            this.btnClearLog.TabIndex = 7;
            this.btnClearLog.Text = "Clear Logs";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // btnLoadJson
            // 
            this.btnLoadJson.Location = new System.Drawing.Point(43, 104);
            this.btnLoadJson.Name = "btnLoadJson";
            this.btnLoadJson.Size = new System.Drawing.Size(787, 39);
            this.btnLoadJson.TabIndex = 8;
            this.btnLoadJson.Text = "Load Json File";
            this.btnLoadJson.UseVisualStyleBackColor = true;
            this.btnLoadJson.Click += new System.EventHandler(this.btnLoadJson_Click);
            // 
            // openJsonFileDialog
            // 
            this.openJsonFileDialog.FileName = "Open Json File";
            // 
            // WienerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1681, 926);
            this.Controls.Add(this.btnLoadJson);
            this.Controls.Add(this.btnClearLog);
            this.Controls.Add(this.cbShowLog);
            this.Controls.Add(this.lstResult);
            this.Controls.Add(this.txtE);
            this.Controls.Add(this.lbE);
            this.Controls.Add(this.txtPQ);
            this.Controls.Add(this.lbPQ);
            this.Controls.Add(this.btnProcess);
            this.Name = "WienerMainForm";
            this.Text = "Continued Fraction Attack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Label lbPQ;
        private System.Windows.Forms.TextBox txtPQ;
        private System.Windows.Forms.TextBox txtE;
        private System.Windows.Forms.Label lbE;
        private System.Windows.Forms.ListBox lstResult;
        private System.Windows.Forms.CheckBox cbShowLog;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.Button btnLoadJson;
        private System.Windows.Forms.OpenFileDialog openJsonFileDialog;
    }
}

