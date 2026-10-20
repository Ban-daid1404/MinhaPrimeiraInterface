namespace MinhaPrimeiraInterface;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        lblinstrução = new System.Windows.Forms.Label();
        txtIdade = new System.Windows.Forms.TextBox();
        btnCalcular = new System.Windows.Forms.Button();
        lblResultado = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // lblinstrução
        // 
        lblinstrução.AutoSize = true;
        lblinstrução.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
        lblinstrução.Location = new System.Drawing.Point(35, 35);
        lblinstrução.Name = "lblinstrução";
        lblinstrução.Size = new System.Drawing.Size(222, 21);
        lblinstrução.TabIndex = 0;
        lblinstrução.Text = "Digite a idade do seu cachorro";
        // 
        // txtIdade
        // 
        txtIdade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
        txtIdade.Location = new System.Drawing.Point(40, 75);
        txtIdade.Name = "txtIdade";
        txtIdade.Size = new System.Drawing.Size(254, 29);
        txtIdade.TabIndex = 1;
        // 
        // btnCalcular
        // 
        btnCalcular.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btnCalcular.Location = new System.Drawing.Point(40, 127);
        btnCalcular.Name = "btnCalcular";
        btnCalcular.Size = new System.Drawing.Size(254, 56);
        btnCalcular.TabIndex = 2;
        btnCalcular.Text = "Calcular idade canina";
        btnCalcular.UseVisualStyleBackColor = true;
        btnCalcular.Click += btnCalcular_Click;
        // 
        // lblResultado
        // 
        lblResultado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
        lblResultado.ForeColor = System.Drawing.SystemColors.Desktop;
        lblResultado.Location = new System.Drawing.Point(35, 202);
        lblResultado.MaximumSize = new System.Drawing.Size(234, 50);
        lblResultado.Name = "lblResultado";
        lblResultado.Size = new System.Drawing.Size(234, 50);
        lblResultado.TabIndex = 3;
        lblResultado.Text = "Resultado:";
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.Info;
        ClientSize = new System.Drawing.Size(343, 267);
        ControlBox = false;
        Controls.Add(lblResultado);
        Controls.Add(btnCalcular);
        Controls.Add(txtIdade);
        Controls.Add(lblinstrução);
        Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Calculadora de Idade Canina";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label lblResultado;

    private System.Windows.Forms.Button btnCalcular;

    private System.Windows.Forms.TextBox txtIdade;

    private System.Windows.Forms.Label lblinstrução;

    #endregion
}

