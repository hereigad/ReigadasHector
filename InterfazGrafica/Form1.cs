using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazGrafica
{
    public class Form1 : Form {
        private ListBox _dInicial;
        private ListBox _dFinal;
        private TextBox _cantidad;
        private TextBox _resultado;
        private Button _calc;

        public Form1() {
            InitializeComponent();
        }

        private void InitializeComponent() {
            Dictionary<string, Conversor.Divisa>.KeyCollection codigos = Conversor.Conversor.getKeys();
            this._dInicial = new System.Windows.Forms.ListBox();
            this._dFinal = new System.Windows.Forms.ListBox();
            this._cantidad = new System.Windows.Forms.TextBox();
            this._resultado = new System.Windows.Forms.TextBox();
            this._calc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _dInicial
            // 
            this._dInicial.Location = new System.Drawing.Point(120, 10);
            this._dInicial.Name = "_dInicial";
            this._dInicial.Size = new System.Drawing.Size(100, 147);
            this._dInicial.TabIndex = 0;
            this._dInicial.BeginUpdate();
            foreach(string c in codigos) {
                _dInicial.Items.Add(c);
            }
            this._dInicial.EndUpdate();
            // 
            // _dFinal
            // 
            this._dFinal.Location = new System.Drawing.Point(250, 10);
            this._dFinal.Name = "_dFinal";
            this._dFinal.Size = new System.Drawing.Size(100, 147);
            this._dFinal.TabIndex = 1;
            // 
            // _cantidad
            // 
            this._cantidad.Location = new System.Drawing.Point(40, 75);
            this._cantidad.Name = "_cantidad";
            this._cantidad.Size = new System.Drawing.Size(40, 20);
            this._cantidad.TabIndex = 2;
            // 
            // _resultado
            // 
            this._resultado.Location = new System.Drawing.Point(300, 200);
            this._resultado.Name = "_resultado";
            this._resultado.Size = new System.Drawing.Size(40, 20);
            this._resultado.TabIndex = 3;
            // 
            // _calc
            // 
            this._calc.Location = new System.Drawing.Point(300, 120);
            this._calc.Name = "_calc";
            this._calc.Size = new System.Drawing.Size(40, 20);
            this._calc.TabIndex = 4;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(466, 296);
            this.Controls.Add(this._dInicial);
            this.Controls.Add(this._dFinal);
            this.Controls.Add(this._cantidad);
            this.Controls.Add(this._resultado);
            this.Controls.Add(this._calc);
            this.Name = "Form1";
            this.Text = "Conversor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
