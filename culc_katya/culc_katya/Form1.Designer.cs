using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
namespace culc_katya
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
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 600);
            this.Text = "Form1";

            Label name_label = new Label();
            name_label.Text = "Калькулятор по расходу топлива";
            name_label.Location = new Point(100, 10);
            name_label.AutoSize = true;
            this.Controls.Add(name_label);

            Label km_label = new Label();
            km_label.Text = "Сколько хотите проехать(км)";
            km_label.Location = new Point(20, 50);
            km_label.AutoSize = true;
            this.Controls.Add(km_label);

            TextBox km_textbox = new TextBox();
            km_textbox.Location = new Point(km_label.Location.X + 250, km_label.Location.Y);
            km_textbox.AutoSize = true;
            this.Controls.Add(km_textbox);

            Label l_km_label = new Label();
            l_km_label.Text = "Средний расход топлива(л/100км)";
            l_km_label.Location = new Point(km_label.Location.X, km_label.Location.Y + 50);
            l_km_label.AutoSize = true;
            this.Controls.Add(l_km_label);

            TextBox l_km_textbox = new TextBox();
            l_km_textbox.Location = new Point(l_km_label.Location.X + 250, l_km_label.Location.Y);
            km_textbox.AutoSize = true;
            this.Controls.Add(l_km_textbox);

            Label cost_label = new Label();
            cost_label.Text = "Стоимость 1 л. топлива(грн)";
            cost_label.Location = new Point(l_km_label.Location.X, l_km_label.Location.Y + 50);
            cost_label.AutoSize = true;
            this.Controls.Add (cost_label);

            TextBox cost_textbox = new TextBox();
            cost_textbox.Location = new Point (cost_label.Location.X + 250, cost_label.Location.Y);
            cost_textbox.AutoSize = true;
            this.Controls.Add (cost_textbox);

            this.res_btn = new Button();
            res_btn.Location = new Point(cost_label.Location.X + 30, cost_label.Location.Y + 50);
            res_btn.Size = new Size(300, 50);
            res_btn.Text = "Рассчитать";
            this.Controls.Add(res_btn);

            Label need_label = new Label();
            need_label.Text = "Потребуется топлива";
            need_label.Location = new Point(cost_label.Location.X, cost_label.Location.Y + 150);
            need_label.AutoSize = true;
            this.Controls.Add(need_label);

            TextBox need_textbox = new TextBox();
            need_textbox.Location = new Point(need_label.Location.X + 250, need_label.Location.Y);
            need_textbox.AutoSize = true;
            this.Controls.Add(need_textbox);

            Label price_label = new Label();
            price_label.Text = "Стоимость топлива(грн)";
            price_label.Location = new Point(need_label.Location.X, need_label.Location.Y + 50);
            price_label.AutoSize = true;
            this.Controls.Add(price_label);

            TextBox price_textbox = new TextBox();
            price_textbox.Location = new Point(price_label.Location.X + 250, price_label.Location.Y);
            price_textbox.AutoSize = true;
            this.Controls.Add(price_textbox);
        }

        Button res_btn;

        Label name_label;
        Label km_label;
        Label l_km_label;
        Label cost_label;
        Label need_label;
        Label price_label;

        TextBox km_textbox;
        TextBox l_km_textbox;
        TextBox cost_textbox;
        TextBox need_textbox;
        TextBox price_textbox;

        #endregion
    }
}

