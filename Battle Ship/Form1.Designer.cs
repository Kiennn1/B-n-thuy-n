﻿namespace Battle_Ship
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
            this.components = new System.ComponentModel.Container();
            this.txtPlayer = new System.Windows.Forms.Label();
            this.txtEnemy = new System.Windows.Forms.Label();
            this.txtRound = new System.Windows.Forms.Label();
            this.txtHelp = new System.Windows.Forms.Label();
            this.enemyMove = new System.Windows.Forms.Label();
            this.EnemyLocationListBox = new System.Windows.Forms.ComboBox();
            this.w1 = new System.Windows.Forms.Button();
            this.w2 = new System.Windows.Forms.Button();
            this.w3 = new System.Windows.Forms.Button();
            this.w4 = new System.Windows.Forms.Button();
            this.x1 = new System.Windows.Forms.Button();
            this.x2 = new System.Windows.Forms.Button();
            this.x3 = new System.Windows.Forms.Button();
            this.x4 = new System.Windows.Forms.Button();
            this.y1 = new System.Windows.Forms.Button();
            this.y2 = new System.Windows.Forms.Button();
            this.y3 = new System.Windows.Forms.Button();
            this.y4 = new System.Windows.Forms.Button();
            this.z1 = new System.Windows.Forms.Button();
            this.z2 = new System.Windows.Forms.Button();
            this.z3 = new System.Windows.Forms.Button();
            this.z4 = new System.Windows.Forms.Button();
            this.a1 = new System.Windows.Forms.Button();
            this.a2 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.c1 = new System.Windows.Forms.Button();
            this.d1 = new System.Windows.Forms.Button();
            this.a3 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.c2 = new System.Windows.Forms.Button();
            this.d2 = new System.Windows.Forms.Button();
            this.a4 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.c3 = new System.Windows.Forms.Button();
            this.d3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.c4 = new System.Windows.Forms.Button();
            this.d4 = new System.Windows.Forms.Button();
            this.btnAttack = new System.Windows.Forms.Button();
            this.EnenmyPlayTime = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtPlayer
            // 
            this.txtPlayer.AutoSize = true;
            this.txtPlayer.BackColor = System.Drawing.Color.Transparent;
            this.txtPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayer.ForeColor = System.Drawing.Color.White;
            this.txtPlayer.Location = new System.Drawing.Point(346, 105);
            this.txtPlayer.Name = "txtPlayer";
            this.txtPlayer.Size = new System.Drawing.Size(38, 25);
            this.txtPlayer.TabIndex = 0;
            this.txtPlayer.Text = "00";
            // 
            // txtEnemy
            // 
            this.txtEnemy.AutoSize = true;
            this.txtEnemy.BackColor = System.Drawing.Color.Transparent;
            this.txtEnemy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnemy.ForeColor = System.Drawing.Color.White;
            this.txtEnemy.Location = new System.Drawing.Point(890, 105);
            this.txtEnemy.Name = "txtEnemy";
            this.txtEnemy.Size = new System.Drawing.Size(38, 25);
            this.txtEnemy.TabIndex = 0;
            this.txtEnemy.Text = "00";
            // 
            // txtRound
            // 
            this.txtRound.AutoSize = true;
            this.txtRound.BackColor = System.Drawing.Color.Transparent;
            this.txtRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRound.ForeColor = System.Drawing.Color.White;
            this.txtRound.Location = new System.Drawing.Point(471, 172);
            this.txtRound.Name = "txtRound";
            this.txtRound.Size = new System.Drawing.Size(127, 25);
            this.txtRound.TabIndex = 0;
            this.txtRound.Text = "Round : 10";
            // 
            // txtHelp
            // 
            this.txtHelp.AutoSize = true;
            this.txtHelp.BackColor = System.Drawing.Color.Transparent;
            this.txtHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtHelp.Location = new System.Drawing.Point(99, 536);
            this.txtHelp.Name = "txtHelp";
            this.txtHelp.Size = new System.Drawing.Size(203, 20);
            this.txtHelp.TabIndex = 0;
            this.txtHelp.Text = "an vao day de duoc giup";
            this.txtHelp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // enemyMove
            // 
            this.enemyMove.AutoSize = true;
            this.enemyMove.BackColor = System.Drawing.Color.Transparent;
            this.enemyMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyMove.ForeColor = System.Drawing.Color.White;
            this.enemyMove.Location = new System.Drawing.Point(898, 33);
            this.enemyMove.Name = "enemyMove";
            this.enemyMove.Size = new System.Drawing.Size(49, 31);
            this.enemyMove.TabIndex = 0;
            this.enemyMove.Text = "A1";
            // 
            // EnemyLocationListBox
            // 
            this.EnemyLocationListBox.BackColor = System.Drawing.Color.PaleGreen;
            this.EnemyLocationListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EnemyLocationListBox.DropDownWidth = 95;
            this.EnemyLocationListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnemyLocationListBox.FormattingEnabled = true;
            this.EnemyLocationListBox.Location = new System.Drawing.Point(175, 31);
            this.EnemyLocationListBox.Name = "EnemyLocationListBox";
            this.EnemyLocationListBox.Size = new System.Drawing.Size(107, 33);
            this.EnemyLocationListBox.TabIndex = 1;
            // 
            // w1
            // 
            this.w1.BackColor = System.Drawing.Color.White;
            this.w1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.w1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.w1.Location = new System.Drawing.Point(101, 224);
            this.w1.Name = "w1";
            this.w1.Size = new System.Drawing.Size(83, 68);
            this.w1.TabIndex = 2;
            this.w1.Text = "w1";
            this.w1.UseVisualStyleBackColor = false;
            this.w1.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // w2
            // 
            this.w2.BackColor = System.Drawing.Color.White;
            this.w2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.w2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.w2.Location = new System.Drawing.Point(194, 224);
            this.w2.Name = "w2";
            this.w2.Size = new System.Drawing.Size(83, 69);
            this.w2.TabIndex = 2;
            this.w2.Text = "w2";
            this.w2.UseVisualStyleBackColor = false;
            this.w2.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // w3
            // 
            this.w3.BackColor = System.Drawing.Color.White;
            this.w3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.w3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.w3.Location = new System.Drawing.Point(286, 224);
            this.w3.Name = "w3";
            this.w3.Size = new System.Drawing.Size(83, 69);
            this.w3.TabIndex = 2;
            this.w3.Text = "w3";
            this.w3.UseVisualStyleBackColor = false;
            this.w3.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // w4
            // 
            this.w4.BackColor = System.Drawing.Color.White;
            this.w4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.w4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.w4.Location = new System.Drawing.Point(378, 224);
            this.w4.Name = "w4";
            this.w4.Size = new System.Drawing.Size(83, 69);
            this.w4.TabIndex = 2;
            this.w4.Text = "w4";
            this.w4.UseVisualStyleBackColor = false;
            this.w4.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // x1
            // 
            this.x1.BackColor = System.Drawing.Color.White;
            this.x1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.x1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x1.Location = new System.Drawing.Point(101, 299);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(83, 68);
            this.x1.TabIndex = 2;
            this.x1.Text = "x1";
            this.x1.UseVisualStyleBackColor = false;
            this.x1.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // x2
            // 
            this.x2.BackColor = System.Drawing.Color.White;
            this.x2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.x2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x2.Location = new System.Drawing.Point(194, 299);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(83, 69);
            this.x2.TabIndex = 2;
            this.x2.Text = "x2";
            this.x2.UseVisualStyleBackColor = false;
            this.x2.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // x3
            // 
            this.x3.BackColor = System.Drawing.Color.White;
            this.x3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.x3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x3.Location = new System.Drawing.Point(286, 299);
            this.x3.Name = "x3";
            this.x3.Size = new System.Drawing.Size(83, 69);
            this.x3.TabIndex = 2;
            this.x3.Text = "x3";
            this.x3.UseVisualStyleBackColor = false;
            this.x3.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // x4
            // 
            this.x4.BackColor = System.Drawing.Color.White;
            this.x4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.x4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x4.Location = new System.Drawing.Point(378, 299);
            this.x4.Name = "x4";
            this.x4.Size = new System.Drawing.Size(83, 69);
            this.x4.TabIndex = 2;
            this.x4.Text = "x4";
            this.x4.UseVisualStyleBackColor = false;
            this.x4.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // y1
            // 
            this.y1.BackColor = System.Drawing.Color.White;
            this.y1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.y1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.y1.Location = new System.Drawing.Point(102, 378);
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(83, 68);
            this.y1.TabIndex = 2;
            this.y1.Text = "y1";
            this.y1.UseVisualStyleBackColor = false;
            this.y1.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // y2
            // 
            this.y2.BackColor = System.Drawing.Color.White;
            this.y2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.y2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.y2.Location = new System.Drawing.Point(195, 378);
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(83, 69);
            this.y2.TabIndex = 2;
            this.y2.Text = "y2";
            this.y2.UseVisualStyleBackColor = false;
            this.y2.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // y3
            // 
            this.y3.BackColor = System.Drawing.Color.White;
            this.y3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.y3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.y3.Location = new System.Drawing.Point(287, 378);
            this.y3.Name = "y3";
            this.y3.Size = new System.Drawing.Size(83, 69);
            this.y3.TabIndex = 2;
            this.y3.Text = "y3";
            this.y3.UseVisualStyleBackColor = false;
            this.y3.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // y4
            // 
            this.y4.BackColor = System.Drawing.Color.White;
            this.y4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.y4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.y4.Location = new System.Drawing.Point(379, 378);
            this.y4.Name = "y4";
            this.y4.Size = new System.Drawing.Size(83, 69);
            this.y4.TabIndex = 2;
            this.y4.Text = "y4";
            this.y4.UseVisualStyleBackColor = false;
            this.y4.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // z1
            // 
            this.z1.BackColor = System.Drawing.Color.White;
            this.z1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.z1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.z1.Location = new System.Drawing.Point(101, 455);
            this.z1.Name = "z1";
            this.z1.Size = new System.Drawing.Size(83, 68);
            this.z1.TabIndex = 2;
            this.z1.Text = "z1";
            this.z1.UseVisualStyleBackColor = false;
            this.z1.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // z2
            // 
            this.z2.BackColor = System.Drawing.Color.White;
            this.z2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.z2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.z2.Location = new System.Drawing.Point(194, 455);
            this.z2.Name = "z2";
            this.z2.Size = new System.Drawing.Size(83, 69);
            this.z2.TabIndex = 2;
            this.z2.Text = "z2";
            this.z2.UseVisualStyleBackColor = false;
            this.z2.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // z3
            // 
            this.z3.BackColor = System.Drawing.Color.White;
            this.z3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.z3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.z3.Location = new System.Drawing.Point(286, 455);
            this.z3.Name = "z3";
            this.z3.Size = new System.Drawing.Size(83, 69);
            this.z3.TabIndex = 2;
            this.z3.Text = "z3";
            this.z3.UseVisualStyleBackColor = false;
            this.z3.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // z4
            // 
            this.z4.BackColor = System.Drawing.Color.White;
            this.z4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.z4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.z4.Location = new System.Drawing.Point(378, 455);
            this.z4.Name = "z4";
            this.z4.Size = new System.Drawing.Size(83, 69);
            this.z4.TabIndex = 2;
            this.z4.Text = "z4";
            this.z4.UseVisualStyleBackColor = false;
            this.z4.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // a1
            // 
            this.a1.BackColor = System.Drawing.Color.White;
            this.a1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.a1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a1.Location = new System.Drawing.Point(599, 224);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(83, 68);
            this.a1.TabIndex = 2;
            this.a1.Text = "a1";
            this.a1.UseVisualStyleBackColor = false;
            // 
            // a2
            // 
            this.a2.BackColor = System.Drawing.Color.White;
            this.a2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.a2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a2.Location = new System.Drawing.Point(692, 224);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(83, 69);
            this.a2.TabIndex = 2;
            this.a2.Text = "a2";
            this.a2.UseVisualStyleBackColor = false;
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.Color.White;
            this.b1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(599, 299);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(83, 68);
            this.b1.TabIndex = 2;
            this.b1.Text = "b1";
            this.b1.UseVisualStyleBackColor = false;
            // 
            // c1
            // 
            this.c1.BackColor = System.Drawing.Color.White;
            this.c1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.c1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1.Location = new System.Drawing.Point(600, 378);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(83, 68);
            this.c1.TabIndex = 2;
            this.c1.Text = "c1";
            this.c1.UseVisualStyleBackColor = false;
            // 
            // d1
            // 
            this.d1.BackColor = System.Drawing.Color.White;
            this.d1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.d1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d1.Location = new System.Drawing.Point(599, 455);
            this.d1.Name = "d1";
            this.d1.Size = new System.Drawing.Size(83, 68);
            this.d1.TabIndex = 2;
            this.d1.Text = "d1";
            this.d1.UseVisualStyleBackColor = false;
            // 
            // a3
            // 
            this.a3.BackColor = System.Drawing.Color.White;
            this.a3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.a3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a3.Location = new System.Drawing.Point(784, 224);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(83, 69);
            this.a3.TabIndex = 2;
            this.a3.Text = "a3";
            this.a3.UseVisualStyleBackColor = false;
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.Color.White;
            this.b2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.Location = new System.Drawing.Point(692, 299);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(83, 69);
            this.b2.TabIndex = 2;
            this.b2.Text = "b2";
            this.b2.UseVisualStyleBackColor = false;
            // 
            // c2
            // 
            this.c2.BackColor = System.Drawing.Color.White;
            this.c2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.c2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c2.Location = new System.Drawing.Point(693, 378);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(83, 69);
            this.c2.TabIndex = 2;
            this.c2.Text = "c2";
            this.c2.UseVisualStyleBackColor = false;
            // 
            // d2
            // 
            this.d2.BackColor = System.Drawing.Color.White;
            this.d2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.d2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d2.Location = new System.Drawing.Point(692, 455);
            this.d2.Name = "d2";
            this.d2.Size = new System.Drawing.Size(83, 69);
            this.d2.TabIndex = 2;
            this.d2.Text = "d2";
            this.d2.UseVisualStyleBackColor = false;
            // 
            // a4
            // 
            this.a4.BackColor = System.Drawing.Color.White;
            this.a4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.a4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a4.Location = new System.Drawing.Point(876, 224);
            this.a4.Name = "a4";
            this.a4.Size = new System.Drawing.Size(83, 69);
            this.a4.TabIndex = 2;
            this.a4.Text = "a4";
            this.a4.UseVisualStyleBackColor = false;
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.Color.White;
            this.b3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.Location = new System.Drawing.Point(784, 299);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(83, 69);
            this.b3.TabIndex = 2;
            this.b3.Text = "b3";
            this.b3.UseVisualStyleBackColor = false;
            // 
            // c3
            // 
            this.c3.BackColor = System.Drawing.Color.White;
            this.c3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.c3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c3.Location = new System.Drawing.Point(785, 378);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(83, 69);
            this.c3.TabIndex = 2;
            this.c3.Text = "c3";
            this.c3.UseVisualStyleBackColor = false;
            // 
            // d3
            // 
            this.d3.BackColor = System.Drawing.Color.White;
            this.d3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.d3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d3.Location = new System.Drawing.Point(784, 455);
            this.d3.Name = "d3";
            this.d3.Size = new System.Drawing.Size(83, 69);
            this.d3.TabIndex = 2;
            this.d3.Text = "d3";
            this.d3.UseVisualStyleBackColor = false;
            // 
            // b4
            // 
            this.b4.BackColor = System.Drawing.Color.White;
            this.b4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b4.Location = new System.Drawing.Point(876, 299);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(83, 69);
            this.b4.TabIndex = 2;
            this.b4.Text = "b4";
            this.b4.UseVisualStyleBackColor = false;
            // 
            // c4
            // 
            this.c4.BackColor = System.Drawing.Color.White;
            this.c4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.c4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c4.Location = new System.Drawing.Point(877, 378);
            this.c4.Name = "c4";
            this.c4.Size = new System.Drawing.Size(83, 69);
            this.c4.TabIndex = 2;
            this.c4.Text = "c4";
            this.c4.UseVisualStyleBackColor = false;
            // 
            // d4
            // 
            this.d4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d4.Location = new System.Drawing.Point(876, 455);
            this.d4.Name = "d4";
            this.d4.Size = new System.Drawing.Size(83, 69);
            this.d4.TabIndex = 2;
            this.d4.Text = "d4";
            this.d4.UseVisualStyleBackColor = true;
            // 
            // btnAttack
            // 
            this.btnAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttack.Location = new System.Drawing.Point(301, 22);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(83, 52);
            this.btnAttack.TabIndex = 2;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.AttackButtonEvent);
            // 
            // EnenmyPlayTime
            // 
            this.EnenmyPlayTime.Interval = 1000;
            this.EnenmyPlayTime.Tick += new System.EventHandler(this.EnemyTimeEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Battle_Ship.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 586);
            this.Controls.Add(this.d4);
            this.Controls.Add(this.z4);
            this.Controls.Add(this.c4);
            this.Controls.Add(this.y4);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.x4);
            this.Controls.Add(this.d3);
            this.Controls.Add(this.z3);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.y3);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.x3);
            this.Controls.Add(this.a4);
            this.Controls.Add(this.d2);
            this.Controls.Add(this.w4);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.z2);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.y2);
            this.Controls.Add(this.a3);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.d1);
            this.Controls.Add(this.w3);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.z1);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.y1);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.w2);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.w1);
            this.Controls.Add(this.EnemyLocationListBox);
            this.Controls.Add(this.txtHelp);
            this.Controls.Add(this.txtRound);
            this.Controls.Add(this.enemyMove);
            this.Controls.Add(this.txtEnemy);
            this.Controls.Add(this.txtPlayer);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtPlayer;
        private System.Windows.Forms.Label txtEnemy;
        private System.Windows.Forms.Label txtRound;
        private System.Windows.Forms.Label txtHelp;
        private System.Windows.Forms.Label enemyMove;
        private System.Windows.Forms.ComboBox EnemyLocationListBox;
        private System.Windows.Forms.Button w1;
        private System.Windows.Forms.Button w2;
        private System.Windows.Forms.Button w3;
        private System.Windows.Forms.Button w4;
        private System.Windows.Forms.Button x1;
        private System.Windows.Forms.Button x2;
        private System.Windows.Forms.Button x3;
        private System.Windows.Forms.Button x4;
        private System.Windows.Forms.Button y1;
        private System.Windows.Forms.Button y2;
        private System.Windows.Forms.Button y3;
        private System.Windows.Forms.Button y4;
        private System.Windows.Forms.Button z1;
        private System.Windows.Forms.Button z2;
        private System.Windows.Forms.Button z3;
        private System.Windows.Forms.Button z4;
        private System.Windows.Forms.Button a1;
        private System.Windows.Forms.Button a2;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button c1;
        private System.Windows.Forms.Button d1;
        private System.Windows.Forms.Button a3;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button c2;
        private System.Windows.Forms.Button d2;
        private System.Windows.Forms.Button a4;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button c3;
        private System.Windows.Forms.Button d3;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button c4;
        private System.Windows.Forms.Button d4;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Timer EnenmyPlayTime;
    }
}

