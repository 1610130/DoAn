namespace DGRLSV
{
	partial class ThongKe
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
			this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
			this.dashboardBarAndDockingController1 = new DevExpress.DashboardWin.Native.DashboardBarAndDockingController(this.components);
			this.dashboardBarController1 = new DevExpress.DashboardWin.Bars.DashboardBarController(this.components);
			this.pnChart = new DevExpress.XtraEditors.PanelControl();
			this.pnStack = new DevExpress.Utils.Layout.StackPanel();
			this.cbChoice = new DevExpress.XtraEditors.ComboBoxEdit();
			this.cbCustom = new DevExpress.XtraEditors.ComboBoxEdit();
			this.ketQuaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dashboardBarAndDockingController1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dashboardBarController1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pnChart)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pnStack)).BeginInit();
			this.pnStack.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cbChoice.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbCustom.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ketQuaBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// pnChart
			// 
			this.pnChart.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnChart.Location = new System.Drawing.Point(0, 0);
			this.pnChart.Name = "pnChart";
			this.pnChart.Size = new System.Drawing.Size(668, 390);
			this.pnChart.TabIndex = 2;
			// 
			// pnStack
			// 
			this.pnStack.Controls.Add(this.cbChoice);
			this.pnStack.Controls.Add(this.cbCustom);
			this.pnStack.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnStack.Location = new System.Drawing.Point(0, 0);
			this.pnStack.Name = "pnStack";
			this.pnStack.Size = new System.Drawing.Size(668, 22);
			this.pnStack.TabIndex = 3;
			// 
			// cbChoice
			// 
			this.cbChoice.EditValue = "";
			this.cbChoice.Location = new System.Drawing.Point(30, 1);
			this.cbChoice.Margin = new System.Windows.Forms.Padding(30, 0, 0, 0);
			this.cbChoice.Name = "cbChoice";
			this.cbChoice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cbChoice.Properties.Items.AddRange(new object[] {
            "Khoa",
            "Lớp",
            "Xếp loại"});
			this.cbChoice.Properties.Sorted = true;
			this.cbChoice.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			this.cbChoice.Size = new System.Drawing.Size(167, 20);
			this.cbChoice.TabIndex = 1;
			this.cbChoice.SelectedIndexChanged += new System.EventHandler(this.cbChoice_SelectedIndexChanged);
			// 
			// cbCustom
			// 
			this.cbCustom.Location = new System.Drawing.Point(200, 1);
			this.cbCustom.Name = "cbCustom";
			this.cbCustom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cbCustom.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			this.cbCustom.Size = new System.Drawing.Size(100, 20);
			this.cbCustom.TabIndex = 2;
			this.cbCustom.SelectedIndexChanged += new System.EventHandler(this.cbCustom_SelectedIndexChanged);
			// 
			// ketQuaBindingSource
			// 
			this.ketQuaBindingSource.DataSource = typeof(DGRLSV.ketQua);
			// 
			// ThongKe
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(668, 390);
			this.Controls.Add(this.pnStack);
			this.Controls.Add(this.pnChart);
			this.Name = "ThongKe";
			this.Text = "Thống Kê";
			((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dashboardBarAndDockingController1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dashboardBarController1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pnChart)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pnStack)).EndInit();
			this.pnStack.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cbChoice.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbCustom.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ketQuaBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
		private System.Windows.Forms.BindingSource ketQuaBindingSource;
		private DevExpress.DashboardWin.Native.DashboardBarAndDockingController dashboardBarAndDockingController1;
		private DevExpress.DashboardWin.Bars.DashboardBarController dashboardBarController1;
		private DevExpress.XtraEditors.PanelControl pnChart;
		private DevExpress.Utils.Layout.StackPanel pnStack;
		public DevExpress.XtraEditors.ComboBoxEdit cbCustom;
		public DevExpress.XtraEditors.ComboBoxEdit cbChoice;
	}
}