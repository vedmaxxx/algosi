namespace RGR
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.sheet = new System.Windows.Forms.PictureBox();
            this.Btn_drawVert = new System.Windows.Forms.Button();
            this.Btn_drawEdge = new System.Windows.Forms.Button();
            this.Btn_delete = new System.Windows.Forms.Button();
            this.btn_Select = new System.Windows.Forms.Button();
            this.listBox_Matrix = new System.Windows.Forms.ListBox();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.btn_BFS = new System.Windows.Forms.Button();
            this.startVert = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_DFS = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Floyd = new System.Windows.Forms.Button();
            this.vertFrom = new System.Windows.Forms.TextBox();
            this.vertTo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox_Floyd = new System.Windows.Forms.ListBox();
            this.task = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_FloydPaths = new System.Windows.Forms.Button();
            this.listBox_Matrix_lbl = new System.Windows.Forms.Label();
            this.listBox_MatrixFloyd_lbl = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sheet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // sheet
            // 
            this.sheet.Location = new System.Drawing.Point(9, 12);
            this.sheet.Name = "sheet";
            this.sheet.Size = new System.Drawing.Size(403, 267);
            this.sheet.TabIndex = 0;
            this.sheet.TabStop = false;
            this.sheet.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sheet_MouseClick);
            // 
            // Btn_drawVert
            // 
            this.Btn_drawVert.Location = new System.Drawing.Point(100, 288);
            this.Btn_drawVert.Name = "Btn_drawVert";
            this.Btn_drawVert.Size = new System.Drawing.Size(100, 39);
            this.Btn_drawVert.TabIndex = 1;
            this.Btn_drawVert.Text = "Нарисовать вершины";
            this.Btn_drawVert.UseVisualStyleBackColor = true;
            this.Btn_drawVert.Click += new System.EventHandler(this.Btn_drawVert_Click);
            // 
            // Btn_drawEdge
            // 
            this.Btn_drawEdge.Location = new System.Drawing.Point(206, 288);
            this.Btn_drawEdge.Name = "Btn_drawEdge";
            this.Btn_drawEdge.Size = new System.Drawing.Size(100, 39);
            this.Btn_drawEdge.TabIndex = 2;
            this.Btn_drawEdge.Text = "Нарисовать ребра";
            this.Btn_drawEdge.UseVisualStyleBackColor = true;
            this.Btn_drawEdge.Click += new System.EventHandler(this.Btn_drawEdge_Click);
            // 
            // Btn_delete
            // 
            this.Btn_delete.Location = new System.Drawing.Point(312, 288);
            this.Btn_delete.Name = "Btn_delete";
            this.Btn_delete.Size = new System.Drawing.Size(100, 39);
            this.Btn_delete.TabIndex = 3;
            this.Btn_delete.Text = "Удалить объект";
            this.Btn_delete.UseVisualStyleBackColor = true;
            this.Btn_delete.Click += new System.EventHandler(this.Btn_delete_Click);
            // 
            // btn_Select
            // 
            this.btn_Select.Location = new System.Drawing.Point(12, 288);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(82, 39);
            this.btn_Select.TabIndex = 4;
            this.btn_Select.Text = "Отмена";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // listBox_Matrix
            // 
            this.listBox_Matrix.FormattingEnabled = true;
            this.listBox_Matrix.HorizontalScrollbar = true;
            this.listBox_Matrix.Location = new System.Drawing.Point(445, 25);
            this.listBox_Matrix.Name = "listBox_Matrix";
            this.listBox_Matrix.Size = new System.Drawing.Size(271, 173);
            this.listBox_Matrix.TabIndex = 5;
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(440, 415);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(248, 20);
            this.resultBox.TabIndex = 6;
            // 
            // btn_BFS
            // 
            this.btn_BFS.Location = new System.Drawing.Point(19, 390);
            this.btn_BFS.Name = "btn_BFS";
            this.btn_BFS.Size = new System.Drawing.Size(62, 39);
            this.btn_BFS.TabIndex = 7;
            this.btn_BFS.Text = "Поиск в ширину";
            this.btn_BFS.UseVisualStyleBackColor = true;
            this.btn_BFS.Visible = false;
            this.btn_BFS.Click += new System.EventHandler(this.BFS);
            // 
            // startVert
            // 
            this.startVert.Location = new System.Drawing.Point(327, 416);
            this.startVert.Name = "startVert";
            this.startVert.Size = new System.Drawing.Size(31, 20);
            this.startVert.TabIndex = 8;
            this.startVert.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Введите начальную вершину:";
            this.label1.Visible = false;
            // 
            // btn_DFS
            // 
            this.btn_DFS.Location = new System.Drawing.Point(87, 390);
            this.btn_DFS.Name = "btn_DFS";
            this.btn_DFS.Size = new System.Drawing.Size(61, 39);
            this.btn_DFS.TabIndex = 10;
            this.btn_DFS.Text = "Поиск в глубину";
            this.btn_DFS.UseVisualStyleBackColor = true;
            this.btn_DFS.Visible = false;
            this.btn_DFS.Click += new System.EventHandler(this.DFS_print);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(437, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Результат:";
            // 
            // btn_Floyd
            // 
            this.btn_Floyd.Location = new System.Drawing.Point(440, 328);
            this.btn_Floyd.Name = "btn_Floyd";
            this.btn_Floyd.Size = new System.Drawing.Size(122, 55);
            this.btn_Floyd.TabIndex = 12;
            this.btn_Floyd.Text = "Найти матрицу кратчайших путей";
            this.btn_Floyd.UseVisualStyleBackColor = true;
            this.btn_Floyd.Click += new System.EventHandler(this.btn_Floyd_Click);
            // 
            // vertFrom
            // 
            this.vertFrom.Location = new System.Drawing.Point(516, 244);
            this.vertFrom.Name = "vertFrom";
            this.vertFrom.Size = new System.Drawing.Size(100, 20);
            this.vertFrom.TabIndex = 13;
            this.vertFrom.TextChanged += new System.EventHandler(this.vertFrom_TextChanged);
            // 
            // vertTo
            // 
            this.vertTo.Location = new System.Drawing.Point(516, 272);
            this.vertTo.Name = "vertTo";
            this.vertTo.Size = new System.Drawing.Size(100, 20);
            this.vertTo.TabIndex = 14;
            this.vertTo.TextChanged += new System.EventHandler(this.vertTo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Из вершины";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(450, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "В вершину";
            // 
            // listBox_Floyd
            // 
            this.listBox_Floyd.FormattingEnabled = true;
            this.listBox_Floyd.HorizontalScrollbar = true;
            this.listBox_Floyd.Location = new System.Drawing.Point(754, 25);
            this.listBox_Floyd.Name = "listBox_Floyd";
            this.listBox_Floyd.Size = new System.Drawing.Size(271, 173);
            this.listBox_Floyd.TabIndex = 17;
            // 
            // task
            // 
            this.task.AutoSize = true;
            this.task.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.task.Location = new System.Drawing.Point(751, 216);
            this.task.Name = "task";
            this.task.Size = new System.Drawing.Size(57, 15);
            this.task.TabIndex = 18;
            this.task.Text = "Задание";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(437, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Найти кратчайших путь";
            // 
            // btn_FloydPaths
            // 
            this.btn_FloydPaths.Enabled = false;
            this.btn_FloydPaths.Location = new System.Drawing.Point(568, 326);
            this.btn_FloydPaths.Name = "btn_FloydPaths";
            this.btn_FloydPaths.Size = new System.Drawing.Size(122, 55);
            this.btn_FloydPaths.TabIndex = 20;
            this.btn_FloydPaths.Text = "Найти кратчайший путь между двумя вершинами";
            this.btn_FloydPaths.UseVisualStyleBackColor = true;
            this.btn_FloydPaths.Click += new System.EventHandler(this.btn_FloydPaths_Click);
            // 
            // listBox_Matrix_lbl
            // 
            this.listBox_Matrix_lbl.AutoSize = true;
            this.listBox_Matrix_lbl.Location = new System.Drawing.Point(442, 9);
            this.listBox_Matrix_lbl.Name = "listBox_Matrix_lbl";
            this.listBox_Matrix_lbl.Size = new System.Drawing.Size(111, 13);
            this.listBox_Matrix_lbl.TabIndex = 21;
            this.listBox_Matrix_lbl.Text = "Матрица смежности";
            // 
            // listBox_MatrixFloyd_lbl
            // 
            this.listBox_MatrixFloyd_lbl.AutoSize = true;
            this.listBox_MatrixFloyd_lbl.Location = new System.Drawing.Point(751, 9);
            this.listBox_MatrixFloyd_lbl.Name = "listBox_MatrixFloyd_lbl";
            this.listBox_MatrixFloyd_lbl.Size = new System.Drawing.Size(144, 13);
            this.listBox_MatrixFloyd_lbl.TabIndex = 22;
            this.listBox_MatrixFloyd_lbl.Text = "Матрица кратчайших путей";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(206, 347);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown1.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Задать вес ребра:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.listBox_MatrixFloyd_lbl);
            this.Controls.Add(this.listBox_Matrix_lbl);
            this.Controls.Add(this.btn_FloydPaths);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.task);
            this.Controls.Add(this.listBox_Floyd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vertTo);
            this.Controls.Add(this.vertFrom);
            this.Controls.Add(this.btn_Floyd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_DFS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startVert);
            this.Controls.Add(this.btn_BFS);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.listBox_Matrix);
            this.Controls.Add(this.btn_Select);
            this.Controls.Add(this.Btn_delete);
            this.Controls.Add(this.Btn_drawEdge);
            this.Controls.Add(this.Btn_drawVert);
            this.Controls.Add(this.sheet);
            this.Name = "Form1";
            this.Text = "РГР Вариант 1 Орашанов Максим ПРО-230Б";
            ((System.ComponentModel.ISupportInitialize)(this.sheet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox sheet;
        private System.Windows.Forms.Button Btn_drawVert;
        private System.Windows.Forms.Button Btn_drawEdge;
        private System.Windows.Forms.Button Btn_delete;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.ListBox listBox_Matrix;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button btn_BFS;
        private System.Windows.Forms.TextBox startVert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_DFS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Floyd;
        private System.Windows.Forms.TextBox vertFrom;
        private System.Windows.Forms.TextBox vertTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox_Floyd;
        private System.Windows.Forms.Label task;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_FloydPaths;
        private System.Windows.Forms.Label listBox_Matrix_lbl;
        private System.Windows.Forms.Label listBox_MatrixFloyd_lbl;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label6;
    }
}

