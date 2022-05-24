namespace CattleBase
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.menubutton = new System.Windows.Forms.Button();
            this.animalbutton = new System.Windows.Forms.Button();
            this.doctorbutton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.addbutton = new System.Windows.Forms.Button();
            this.changebutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ucDoctors11 = new CattleBase.UC.UCDoctors1();
            this.ucAnimals11 = new CattleBase.UC.UCAnimals1();
            this.SuspendLayout();
            // 
            // menubutton
            // 
            this.menubutton.Location = new System.Drawing.Point(12, 12);
            this.menubutton.Name = "menubutton";
            this.menubutton.Size = new System.Drawing.Size(130, 60);
            this.menubutton.TabIndex = 0;
            this.menubutton.Text = "Главное меню";
            this.menubutton.UseVisualStyleBackColor = true;
            this.menubutton.Click += new System.EventHandler(this.menubutton_Click);
            // 
            // animalbutton
            // 
            this.animalbutton.Location = new System.Drawing.Point(12, 78);
            this.animalbutton.Name = "animalbutton";
            this.animalbutton.Size = new System.Drawing.Size(130, 60);
            this.animalbutton.TabIndex = 1;
            this.animalbutton.Text = "Животные";
            this.animalbutton.UseVisualStyleBackColor = true;
            this.animalbutton.Click += new System.EventHandler(this.animalbutton_Click);
            // 
            // doctorbutton
            // 
            this.doctorbutton.Location = new System.Drawing.Point(12, 144);
            this.doctorbutton.Name = "doctorbutton";
            this.doctorbutton.Size = new System.Drawing.Size(130, 60);
            this.doctorbutton.TabIndex = 2;
            this.doctorbutton.Text = "Ветеринары";
            this.doctorbutton.UseVisualStyleBackColor = true;
            this.doctorbutton.Click += new System.EventHandler(this.doctorbutton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 395);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(130, 43);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(12, 221);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(130, 43);
            this.addbutton.TabIndex = 5;
            this.addbutton.Text = "Добавить запись";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Visible = false;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // changebutton
            // 
            this.changebutton.Location = new System.Drawing.Point(12, 270);
            this.changebutton.Name = "changebutton";
            this.changebutton.Size = new System.Drawing.Size(130, 43);
            this.changebutton.TabIndex = 6;
            this.changebutton.Text = "Изменить выбранную";
            this.changebutton.UseVisualStyleBackColor = true;
            this.changebutton.Visible = false;
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(12, 319);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(130, 43);
            this.deletebutton.TabIndex = 7;
            this.deletebutton.Text = "Удалить запись";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(148, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(640, 60);
            this.label1.TabIndex = 8;
            this.label1.Text = "Здравствуйте";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(149, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(639, 290);
            this.label2.TabIndex = 9;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // ucDoctors11
            // 
            this.ucDoctors11.Location = new System.Drawing.Point(148, 12);
            this.ucDoctors11.Name = "ucDoctors11";
            this.ucDoctors11.Size = new System.Drawing.Size(640, 426);
            this.ucDoctors11.TabIndex = 11;
            this.ucDoctors11.Visible = false;
            // 
            // ucAnimals11
            // 
            this.ucAnimals11.Location = new System.Drawing.Point(148, 12);
            this.ucAnimals11.Name = "ucAnimals11";
            this.ucAnimals11.Size = new System.Drawing.Size(640, 426);
            this.ucAnimals11.TabIndex = 10;
            this.ucAnimals11.Visible = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ucDoctors11);
            this.Controls.Add(this.ucAnimals11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.changebutton);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.doctorbutton);
            this.Controls.Add(this.animalbutton);
            this.Controls.Add(this.menubutton);
            this.Name = "MainMenu";
            this.Text = "CattleBase";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button menubutton;
        private System.Windows.Forms.Button animalbutton;
        private System.Windows.Forms.Button doctorbutton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button changebutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private UC.UCAnimals1 ucAnimals11;
        private UC.UCDoctors1 ucDoctors11;
    }
}

