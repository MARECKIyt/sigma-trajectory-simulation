namespace asgsimulations
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(-1D, -1D);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.diameter = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.energy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mass = new System.Windows.Forms.TextBox();
            this.hop = new System.Windows.Forms.TextBox();
            this.angle = new System.Windows.Forms.TextBox();
            this.height = new System.Windows.Forms.TextBox();
            this.gravity = new System.Windows.Forms.TextBox();
            this.density = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.rotatedeacy = new System.Windows.Forms.TextBox();
            this.plot = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.delete = new System.Windows.Forms.Button();
            this.newseries = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.setname = new System.Windows.Forms.Button();
            this.index = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.yaxis = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.xaxis = new System.Windows.Forms.ComboBox();
            this.setautohu = new System.Windows.Forms.Button();
            this.autohu = new System.Windows.Forms.TextBox();
            this.watch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.BackColor = System.Drawing.Color.DarkGray;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Dock = System.Windows.Forms.DockStyle.Top;
            legend1.BackColor = System.Drawing.Color.DarkGray;
            legend1.Name = "Legend1";
            legend1.TitleBackColor = System.Drawing.Color.DarkGray;
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Name = "chart";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Legend1";
            series1.Name = "series 1";
            series1.Points.Add(dataPoint1);
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(1182, 300);
            this.chart.TabIndex = 0;
            this.chart.Text = "+";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.64315F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.6873F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.64748F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.6873F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.64748F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.6873F));
            this.tableLayoutPanel1.Controls.Add(this.diameter, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.energy, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.mass, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.hop, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.angle, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.height, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.gravity, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.density, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rotatedeacy, 5, 2);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 306);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(693, 84);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // diameter
            // 
            this.diameter.BackColor = System.Drawing.Color.LightGray;
            this.diameter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.diameter.Location = new System.Drawing.Point(152, 59);
            this.diameter.Name = "diameter";
            this.diameter.Size = new System.Drawing.Size(69, 23);
            this.diameter.TabIndex = 12;
            this.diameter.Text = "5,95";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Right;
            this.label7.Location = new System.Drawing.Point(8, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 28);
            this.label7.TabIndex = 8;
            this.label7.Text = "diameter (mm)";
            // 
            // energy
            // 
            this.energy.BackColor = System.Drawing.Color.LightGray;
            this.energy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.energy.Location = new System.Drawing.Point(152, 3);
            this.energy.Name = "energy";
            this.energy.Size = new System.Drawing.Size(69, 23);
            this.energy.TabIndex = 1;
            this.energy.Text = "1,69";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(57, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "mass (g)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(256, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "hop-up (rps)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(264, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "angle (deg)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Location = new System.Drawing.Point(276, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "height (m)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Right;
            this.label6.Location = new System.Drawing.Point(468, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 28);
            this.label6.TabIndex = 7;
            this.label6.Text = "gravity (m/s^2)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Right;
            this.label5.Location = new System.Drawing.Point(501, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "density air (kg/m^3)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Right;
            this.label8.Location = new System.Drawing.Point(496, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 28);
            this.label8.TabIndex = 9;
            this.label8.Text = "C_r (10^-7)";
            // 
            // mass
            // 
            this.mass.BackColor = System.Drawing.Color.LightGray;
            this.mass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mass.Location = new System.Drawing.Point(152, 31);
            this.mass.Name = "mass";
            this.mass.Size = new System.Drawing.Size(69, 23);
            this.mass.TabIndex = 10;
            this.mass.Text = "0,32";
            // 
            // hop
            // 
            this.hop.BackColor = System.Drawing.Color.LightGray;
            this.hop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hop.Location = new System.Drawing.Point(382, 3);
            this.hop.Name = "hop";
            this.hop.Size = new System.Drawing.Size(69, 23);
            this.hop.TabIndex = 11;
            this.hop.Text = "2137";
            // 
            // angle
            // 
            this.angle.BackColor = System.Drawing.Color.LightGray;
            this.angle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.angle.Location = new System.Drawing.Point(382, 31);
            this.angle.Name = "angle";
            this.angle.Size = new System.Drawing.Size(69, 23);
            this.angle.TabIndex = 13;
            this.angle.Text = "0";
            // 
            // height
            // 
            this.height.BackColor = System.Drawing.Color.LightGray;
            this.height.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.height.Location = new System.Drawing.Point(382, 59);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(69, 23);
            this.height.TabIndex = 14;
            this.height.Text = "1,5";
            // 
            // gravity
            // 
            this.gravity.BackColor = System.Drawing.Color.LightGray;
            this.gravity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gravity.Location = new System.Drawing.Point(612, 3);
            this.gravity.Name = "gravity";
            this.gravity.Size = new System.Drawing.Size(69, 23);
            this.gravity.TabIndex = 15;
            this.gravity.Text = "9,81";
            // 
            // density
            // 
            this.density.BackColor = System.Drawing.Color.LightGray;
            this.density.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.density.Location = new System.Drawing.Point(612, 31);
            this.density.Name = "density";
            this.density.Size = new System.Drawing.Size(69, 23);
            this.density.TabIndex = 16;
            this.density.Text = "1,225";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Dock = System.Windows.Forms.DockStyle.Right;
            this.label.Location = new System.Drawing.Point(44, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(102, 28);
            this.label.TabIndex = 0;
            this.label.Text = "energy (J)";
            // 
            // rotatedeacy
            // 
            this.rotatedeacy.BackColor = System.Drawing.Color.LightGray;
            this.rotatedeacy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rotatedeacy.Location = new System.Drawing.Point(612, 59);
            this.rotatedeacy.Name = "rotatedeacy";
            this.rotatedeacy.Size = new System.Drawing.Size(69, 23);
            this.rotatedeacy.TabIndex = 17;
            this.rotatedeacy.Text = "115";
            // 
            // plot
            // 
            this.plot.Dock = System.Windows.Forms.DockStyle.Left;
            this.plot.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.plot.Location = new System.Drawing.Point(3, 3);
            this.plot.Name = "plot";
            this.plot.Size = new System.Drawing.Size(289, 58);
            this.plot.TabIndex = 2;
            this.plot.Text = "draw plot";
            this.plot.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.99812F));
            this.tableLayoutPanel2.Controls.Add(this.plot, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.delete, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.newseries, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.name, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.setname, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.index, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.label12, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.save, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 524);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1182, 128);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // delete
            // 
            this.delete.Dock = System.Windows.Forms.DockStyle.Left;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.delete.Location = new System.Drawing.Point(298, 67);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(289, 58);
            this.delete.TabIndex = 4;
            this.delete.Text = "delete series";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // newseries
            // 
            this.newseries.Dock = System.Windows.Forms.DockStyle.Left;
            this.newseries.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.newseries.Location = new System.Drawing.Point(3, 67);
            this.newseries.Name = "newseries";
            this.newseries.Size = new System.Drawing.Size(289, 58);
            this.newseries.TabIndex = 5;
            this.newseries.Text = "new series";
            this.newseries.UseVisualStyleBackColor = true;
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.LightGray;
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name.Dock = System.Windows.Forms.DockStyle.Left;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.name.Location = new System.Drawing.Point(593, 67);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(289, 31);
            this.name.TabIndex = 6;
            this.name.Text = "sus";
            // 
            // setname
            // 
            this.setname.Dock = System.Windows.Forms.DockStyle.Left;
            this.setname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.setname.Location = new System.Drawing.Point(593, 3);
            this.setname.Name = "setname";
            this.setname.Size = new System.Drawing.Size(289, 58);
            this.setname.TabIndex = 7;
            this.setname.Text = "rename to: ↓";
            this.setname.UseVisualStyleBackColor = true;
            // 
            // index
            // 
            this.index.BackColor = System.Drawing.Color.LightGray;
            this.index.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.index.Dock = System.Windows.Forms.DockStyle.Left;
            this.index.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.index.Location = new System.Drawing.Point(888, 67);
            this.index.Name = "index";
            this.index.Size = new System.Drawing.Size(289, 31);
            this.index.TabIndex = 9;
            this.index.Text = "1";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Dock = System.Windows.Forms.DockStyle.Left;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label12.Location = new System.Drawing.Point(888, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(289, 64);
            this.label12.TabIndex = 8;
            this.label12.Text = "editing series index: ↓";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // save
            // 
            this.save.Dock = System.Windows.Forms.DockStyle.Left;
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.save.Location = new System.Drawing.Point(298, 3);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(289, 58);
            this.save.TabIndex = 3;
            this.save.Text = "save chart";
            this.save.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.yaxis, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label11, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.xaxis, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(941, 306);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(229, 69);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // yaxis
            // 
            this.yaxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.yaxis.FormattingEnabled = true;
            this.yaxis.Items.AddRange(new object[] {
            "position.x",
            "position.y",
            "energy",
            "speed",
            "rotate speed",
            "time"});
            this.yaxis.Location = new System.Drawing.Point(117, 37);
            this.yaxis.Name = "yaxis";
            this.yaxis.Size = new System.Drawing.Size(109, 33);
            this.yaxis.TabIndex = 3;
            this.yaxis.Text = "position.y";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.DarkGray;
            this.label11.Dock = System.Windows.Forms.DockStyle.Right;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(46, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 35);
            this.label11.TabIndex = 2;
            this.label11.Text = "Y axis";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DarkGray;
            this.label10.Dock = System.Windows.Forms.DockStyle.Right;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(45, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 34);
            this.label10.TabIndex = 1;
            this.label10.Text = "X axis";
            // 
            // xaxis
            // 
            this.xaxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.xaxis.FormattingEnabled = true;
            this.xaxis.ItemHeight = 25;
            this.xaxis.Items.AddRange(new object[] {
            "position.x",
            "position.y",
            "energy",
            "speed",
            "rotate speed",
            "time"});
            this.xaxis.Location = new System.Drawing.Point(117, 3);
            this.xaxis.Name = "xaxis";
            this.xaxis.Size = new System.Drawing.Size(109, 33);
            this.xaxis.TabIndex = 0;
            this.xaxis.Text = "position.x";
            // 
            // setautohu
            // 
            this.setautohu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.setautohu.Location = new System.Drawing.Point(3, 436);
            this.setautohu.Name = "setautohu";
            this.setautohu.Size = new System.Drawing.Size(346, 58);
            this.setautohu.TabIndex = 8;
            this.setautohu.Text = "auto set hu (cm)";
            this.setautohu.UseVisualStyleBackColor = true;
            // 
            // autohu
            // 
            this.autohu.BackColor = System.Drawing.Color.LightGray;
            this.autohu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.autohu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.autohu.Location = new System.Drawing.Point(355, 456);
            this.autohu.Name = "autohu";
            this.autohu.Size = new System.Drawing.Size(69, 23);
            this.autohu.TabIndex = 18;
            this.autohu.Text = "1";
            // 
            // watch
            // 
            this.watch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.watch.Location = new System.Drawing.Point(486, 444);
            this.watch.Name = "watch";
            this.watch.Size = new System.Drawing.Size(207, 43);
            this.watch.TabIndex = 19;
            this.watch.Text = "watch video";
            this.watch.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1182, 652);
            this.Controls.Add(this.watch);
            this.Controls.Add(this.autohu);
            this.Controls.Add(this.setautohu);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.chart);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1200, 699);
            this.MinimumSize = new System.Drawing.Size(1200, 699);
            this.Name = "Form1";
            this.Text = "sigma trajectory simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox energy;
        private System.Windows.Forms.TextBox diameter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox mass;
        private System.Windows.Forms.TextBox hop;
        private System.Windows.Forms.TextBox angle;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.TextBox gravity;
        private System.Windows.Forms.TextBox density;
        private System.Windows.Forms.TextBox rotatedeacy;
        private System.Windows.Forms.Button plot;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button newseries;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox xaxis;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox yaxis;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button setname;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox index;
        private System.Windows.Forms.Button setautohu;
        private System.Windows.Forms.TextBox autohu;
        private System.Windows.Forms.Button watch;
    }
}

