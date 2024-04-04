
namespace Menuk_12B
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
            this.szoveg = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fájlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újDokumentumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.megnyitásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mentésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szerkesztésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visszavonásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.kivágásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.másolásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beillesztésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.törlésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.azÖsszesKijelölésaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.időDátumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.névjegyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.másolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beillesztToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.kilepesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.súgóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // szoveg
            // 
            this.szoveg.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.szoveg.ContextMenuStrip = this.contextMenuStrip2;
            this.szoveg.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szoveg.Location = new System.Drawing.Point(2, 32);
            this.szoveg.Name = "szoveg";
            this.szoveg.Size = new System.Drawing.Size(786, 403);
            this.szoveg.TabIndex = 0;
            this.szoveg.Text = "";
            this.szoveg.TextChanged += new System.EventHandler(this.szoveg_TextChanged);
            this.szoveg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.szoveg_MouseMove);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fájlToolStripMenuItem,
            this.szerkesztésToolStripMenuItem,
            this.névjegyToolStripMenuItem,
            this.informacioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(792, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fájlToolStripMenuItem
            // 
            this.fájlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újDokumentumToolStripMenuItem,
            this.toolStripSeparator1,
            this.megnyitásToolStripMenuItem,
            this.mentésToolStripMenuItem,
            this.toolStripSeparator2,
            this.kilépésToolStripMenuItem});
            this.fájlToolStripMenuItem.Name = "fájlToolStripMenuItem";
            this.fájlToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fájlToolStripMenuItem.Text = "Fájl";
            // 
            // újDokumentumToolStripMenuItem
            // 
            this.újDokumentumToolStripMenuItem.Name = "újDokumentumToolStripMenuItem";
            this.újDokumentumToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.újDokumentumToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.újDokumentumToolStripMenuItem.Text = "Új dokumentum";
            this.újDokumentumToolStripMenuItem.Click += new System.EventHandler(this.újDokumentumToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(201, 6);
            // 
            // megnyitásToolStripMenuItem
            // 
            this.megnyitásToolStripMenuItem.Name = "megnyitásToolStripMenuItem";
            this.megnyitásToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.megnyitásToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.megnyitásToolStripMenuItem.Text = "Megnyitás";
            this.megnyitásToolStripMenuItem.Click += new System.EventHandler(this.megnyitásToolStripMenuItem_Click);
            // 
            // mentésToolStripMenuItem
            // 
            this.mentésToolStripMenuItem.Name = "mentésToolStripMenuItem";
            this.mentésToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mentésToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.mentésToolStripMenuItem.Text = "Mentés";
            this.mentésToolStripMenuItem.Click += new System.EventHandler(this.mentésToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(201, 6);
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.kilépésToolStripMenuItem_Click);
            // 
            // szerkesztésToolStripMenuItem
            // 
            this.szerkesztésToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visszavonásToolStripMenuItem,
            this.toolStripSeparator3,
            this.kivágásToolStripMenuItem,
            this.másolásToolStripMenuItem,
            this.beillesztésToolStripMenuItem,
            this.törlésToolStripMenuItem,
            this.toolStripSeparator4,
            this.azÖsszesKijelölésaToolStripMenuItem,
            this.időDátumToolStripMenuItem});
            this.szerkesztésToolStripMenuItem.Name = "szerkesztésToolStripMenuItem";
            this.szerkesztésToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.szerkesztésToolStripMenuItem.Text = "Szerkesztés";
            // 
            // visszavonásToolStripMenuItem
            // 
            this.visszavonásToolStripMenuItem.Name = "visszavonásToolStripMenuItem";
            this.visszavonásToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.visszavonásToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.visszavonásToolStripMenuItem.Text = "Visszavonás";
            this.visszavonásToolStripMenuItem.Click += new System.EventHandler(this.visszavonásToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(197, 6);
            // 
            // kivágásToolStripMenuItem
            // 
            this.kivágásToolStripMenuItem.Name = "kivágásToolStripMenuItem";
            this.kivágásToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.kivágásToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.kivágásToolStripMenuItem.Text = "Kivágás";
            this.kivágásToolStripMenuItem.Click += new System.EventHandler(this.kivágásToolStripMenuItem_Click);
            // 
            // másolásToolStripMenuItem
            // 
            this.másolásToolStripMenuItem.Name = "másolásToolStripMenuItem";
            this.másolásToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.másolásToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.másolásToolStripMenuItem.Text = "Másolás";
            this.másolásToolStripMenuItem.Click += new System.EventHandler(this.másolásToolStripMenuItem_Click);
            // 
            // beillesztésToolStripMenuItem
            // 
            this.beillesztésToolStripMenuItem.Name = "beillesztésToolStripMenuItem";
            this.beillesztésToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.beillesztésToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.beillesztésToolStripMenuItem.Text = "Beillesztés";
            this.beillesztésToolStripMenuItem.Click += new System.EventHandler(this.beillesztésToolStripMenuItem_Click);
            // 
            // törlésToolStripMenuItem
            // 
            this.törlésToolStripMenuItem.Name = "törlésToolStripMenuItem";
            this.törlésToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.törlésToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.törlésToolStripMenuItem.Text = "Törlés";
            this.törlésToolStripMenuItem.Click += new System.EventHandler(this.törlésToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(197, 6);
            // 
            // azÖsszesKijelölésaToolStripMenuItem
            // 
            this.azÖsszesKijelölésaToolStripMenuItem.Name = "azÖsszesKijelölésaToolStripMenuItem";
            this.azÖsszesKijelölésaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.azÖsszesKijelölésaToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.azÖsszesKijelölésaToolStripMenuItem.Text = "összes kijelölése";
            this.azÖsszesKijelölésaToolStripMenuItem.Click += new System.EventHandler(this.azÖsszesKijelölésaToolStripMenuItem_Click);
            // 
            // időDátumToolStripMenuItem
            // 
            this.időDátumToolStripMenuItem.Name = "időDátumToolStripMenuItem";
            this.időDátumToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.időDátumToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.időDátumToolStripMenuItem.Text = "Idő / dátum";
            this.időDátumToolStripMenuItem.Click += new System.EventHandler(this.időDátumToolStripMenuItem_Click);
            // 
            // névjegyToolStripMenuItem
            // 
            this.névjegyToolStripMenuItem.Name = "névjegyToolStripMenuItem";
            this.névjegyToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.névjegyToolStripMenuItem.Text = "Névjegy";
            this.névjegyToolStripMenuItem.Click += new System.EventHandler(this.névjegyToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 442);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "karakterek száma:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(509, 442);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.másolToolStripMenuItem,
            this.beillesztToolStripMenuItem,
            this.toolStripSeparator5,
            this.kilepesToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(117, 76);
            // 
            // másolToolStripMenuItem
            // 
            this.másolToolStripMenuItem.Name = "másolToolStripMenuItem";
            this.másolToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.másolToolStripMenuItem.Text = "Másol";
            this.másolToolStripMenuItem.Click += new System.EventHandler(this.másolToolStripMenuItem_Click);
            // 
            // beillesztToolStripMenuItem
            // 
            this.beillesztToolStripMenuItem.Name = "beillesztToolStripMenuItem";
            this.beillesztToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.beillesztToolStripMenuItem.Text = "Beilleszt";
            this.beillesztToolStripMenuItem.Click += new System.EventHandler(this.beillesztToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(177, 6);
            // 
            // kilepesToolStripMenuItem
            // 
            this.kilepesToolStripMenuItem.Name = "kilepesToolStripMenuItem";
            this.kilepesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kilepesToolStripMenuItem.Text = "Kilepes";
            this.kilepesToolStripMenuItem.Click += new System.EventHandler(this.kilepesToolStripMenuItem_Click);
            // 
            // informacioToolStripMenuItem
            // 
            this.informacioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.súgóToolStripMenuItem});
            this.informacioToolStripMenuItem.Name = "informacioToolStripMenuItem";
            this.informacioToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.informacioToolStripMenuItem.Text = "Informacio";
            // 
            // súgóToolStripMenuItem
            // 
            this.súgóToolStripMenuItem.Name = "súgóToolStripMenuItem";
            this.súgóToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.súgóToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.súgóToolStripMenuItem.Text = "súgó";
            this.súgóToolStripMenuItem.Click += new System.EventHandler(this.súgóToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(792, 483);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.szoveg);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notesz ++";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox szoveg;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fájlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újDokumentumToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem megnyitásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mentésToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szerkesztésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visszavonásToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem kivágásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem másolásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beillesztésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem törlésToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem azÖsszesKijelölésaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem időDátumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem névjegyToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem másolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beillesztToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem kilepesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem súgóToolStripMenuItem;
    }
}

