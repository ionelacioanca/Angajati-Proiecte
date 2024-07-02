namespace Angajati
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.firmaDataSet = new Angajati.FirmaDataSet();
            this.angajatiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.angajatiTableAdapter = new Angajati.FirmaDataSetTableAdapters.AngajatiTableAdapter();
            this.tableAdapterManager = new Angajati.FirmaDataSetTableAdapters.TableAdapterManager();
            this.proiecteTableAdapter = new Angajati.FirmaDataSetTableAdapters.ProiecteTableAdapter();
            this.angajatiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.angajatiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.angajatiDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proiecteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proiecteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.textBoxAngajatId = new System.Windows.Forms.TextBox();
            this.textBoxNumeComplet = new System.Windows.Forms.TextBox();
            this.textBoxCNP = new System.Windows.Forms.TextBox();
            this.textBoxFunctie = new System.Windows.Forms.TextBox();
            this.buttonAdaugareAngajat = new System.Windows.Forms.Button();
            this.textBoxNrOreAlocate = new System.Windows.Forms.TextBox();
            this.textBoxFunctiePeProiect = new System.Windows.Forms.TextBox();
            this.textBoxAngajatIdProiect = new System.Windows.Forms.TextBox();
            this.textBoxProiectId = new System.Windows.Forms.TextBox();
            this.textBoxPlataPeOra = new System.Windows.Forms.TextBox();
            this.buttonAdaugareProiect = new System.Windows.Forms.Button();
            this.textBoxCautare = new System.Windows.Forms.TextBox();
            this.buttonCautare = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.firmaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiBindingNavigator)).BeginInit();
            this.angajatiBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proiecteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proiecteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // firmaDataSet
            // 
            this.firmaDataSet.DataSetName = "FirmaDataSet";
            this.firmaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // angajatiBindingSource
            // 
            this.angajatiBindingSource.DataMember = "Angajati";
            this.angajatiBindingSource.DataSource = this.firmaDataSet;
            // 
            // angajatiTableAdapter
            // 
            this.angajatiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AngajatiTableAdapter = this.angajatiTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProiecteTableAdapter = this.proiecteTableAdapter;
            this.tableAdapterManager.UpdateOrder = Angajati.FirmaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // proiecteTableAdapter
            // 
            this.proiecteTableAdapter.ClearBeforeFill = true;
            // 
            // angajatiBindingNavigator
            // 
            this.angajatiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.angajatiBindingNavigator.BindingSource = this.angajatiBindingSource;
            this.angajatiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.angajatiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.angajatiBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.angajatiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.angajatiBindingNavigatorSaveItem});
            this.angajatiBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.angajatiBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.angajatiBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.angajatiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.angajatiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.angajatiBindingNavigator.Name = "angajatiBindingNavigator";
            this.angajatiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.angajatiBindingNavigator.Size = new System.Drawing.Size(546, 27);
            this.angajatiBindingNavigator.TabIndex = 0;
            this.angajatiBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // angajatiBindingNavigatorSaveItem
            // 
            this.angajatiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.angajatiBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("angajatiBindingNavigatorSaveItem.Image")));
            this.angajatiBindingNavigatorSaveItem.Name = "angajatiBindingNavigatorSaveItem";
            this.angajatiBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.angajatiBindingNavigatorSaveItem.Text = "Save Data";
            this.angajatiBindingNavigatorSaveItem.Click += new System.EventHandler(this.angajatiBindingNavigatorSaveItem_Click);
            // 
            // angajatiDataGridView
            // 
            this.angajatiDataGridView.AutoGenerateColumns = false;
            this.angajatiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.angajatiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.angajatiDataGridView.DataSource = this.angajatiBindingSource;
            this.angajatiDataGridView.Location = new System.Drawing.Point(12, 30);
            this.angajatiDataGridView.Name = "angajatiDataGridView";
            this.angajatiDataGridView.RowHeadersWidth = 51;
            this.angajatiDataGridView.RowTemplate.Height = 24;
            this.angajatiDataGridView.Size = new System.Drawing.Size(300, 220);
            this.angajatiDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AngajatId";
            this.dataGridViewTextBoxColumn1.HeaderText = "AngajatId";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nume_complet";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nume_complet";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CNP";
            this.dataGridViewTextBoxColumn3.HeaderText = "CNP";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Functie";
            this.dataGridViewTextBoxColumn4.HeaderText = "Functie";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // proiecteBindingSource
            // 
            this.proiecteBindingSource.DataMember = "FK__Proiecte__Angaja__38996AB5";
            this.proiecteBindingSource.DataSource = this.angajatiBindingSource;
            // 
            // proiecteDataGridView
            // 
            this.proiecteDataGridView.AutoGenerateColumns = false;
            this.proiecteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proiecteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.proiecteDataGridView.DataSource = this.proiecteBindingSource;
            this.proiecteDataGridView.Location = new System.Drawing.Point(12, 256);
            this.proiecteDataGridView.Name = "proiecteDataGridView";
            this.proiecteDataGridView.RowHeadersWidth = 51;
            this.proiecteDataGridView.Size = new System.Drawing.Size(300, 220);
            this.proiecteDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ProiectId";
            this.dataGridViewTextBoxColumn5.HeaderText = "ProiectId";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "AngajatId";
            this.dataGridViewTextBoxColumn6.HeaderText = "AngajatId";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Functie_pe_proiect";
            this.dataGridViewTextBoxColumn7.HeaderText = "Functie_pe_proiect";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Nr_ore_alocate";
            this.dataGridViewTextBoxColumn8.HeaderText = "Nr_ore_alocate";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Plata_pe_ora";
            this.dataGridViewTextBoxColumn9.HeaderText = "Plata_pe_ora";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Adaugare angajat";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(318, 258);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(111, 16);
            this.label.TabIndex = 4;
            this.label.Text = "Adaugare proiect";
            // 
            // textBoxAngajatId
            // 
            this.textBoxAngajatId.Location = new System.Drawing.Point(322, 50);
            this.textBoxAngajatId.Name = "textBoxAngajatId";
            this.textBoxAngajatId.Size = new System.Drawing.Size(185, 22);
            this.textBoxAngajatId.TabIndex = 5;
            // 
            // textBoxNumeComplet
            // 
            this.textBoxNumeComplet.Location = new System.Drawing.Point(322, 78);
            this.textBoxNumeComplet.Name = "textBoxNumeComplet";
            this.textBoxNumeComplet.Size = new System.Drawing.Size(185, 22);
            this.textBoxNumeComplet.TabIndex = 6;
            // 
            // textBoxCNP
            // 
            this.textBoxCNP.Location = new System.Drawing.Point(322, 106);
            this.textBoxCNP.Name = "textBoxCNP";
            this.textBoxCNP.Size = new System.Drawing.Size(185, 22);
            this.textBoxCNP.TabIndex = 7;
            // 
            // textBoxFunctie
            // 
            this.textBoxFunctie.Location = new System.Drawing.Point(322, 135);
            this.textBoxFunctie.Name = "textBoxFunctie";
            this.textBoxFunctie.Size = new System.Drawing.Size(185, 22);
            this.textBoxFunctie.TabIndex = 8;
            // 
            // buttonAdaugareAngajat
            // 
            this.buttonAdaugareAngajat.Location = new System.Drawing.Point(322, 164);
            this.buttonAdaugareAngajat.Name = "buttonAdaugareAngajat";
            this.buttonAdaugareAngajat.Size = new System.Drawing.Size(185, 30);
            this.buttonAdaugareAngajat.TabIndex = 9;
            this.buttonAdaugareAngajat.Text = "Adaugare";
            this.buttonAdaugareAngajat.UseVisualStyleBackColor = true;
            this.buttonAdaugareAngajat.Click += new System.EventHandler(this.buttonAdaugareAngajat_Click);
            // 
            // textBoxNrOreAlocate
            // 
            this.textBoxNrOreAlocate.Location = new System.Drawing.Point(322, 362);
            this.textBoxNrOreAlocate.Name = "textBoxNrOreAlocate";
            this.textBoxNrOreAlocate.Size = new System.Drawing.Size(185, 22);
            this.textBoxNrOreAlocate.TabIndex = 13;
            // 
            // textBoxFunctiePeProiect
            // 
            this.textBoxFunctiePeProiect.Location = new System.Drawing.Point(322, 333);
            this.textBoxFunctiePeProiect.Name = "textBoxFunctiePeProiect";
            this.textBoxFunctiePeProiect.Size = new System.Drawing.Size(185, 22);
            this.textBoxFunctiePeProiect.TabIndex = 12;
            // 
            // textBoxAngajatIdProiect
            // 
            this.textBoxAngajatIdProiect.Location = new System.Drawing.Point(322, 305);
            this.textBoxAngajatIdProiect.Name = "textBoxAngajatIdProiect";
            this.textBoxAngajatIdProiect.ReadOnly = true;
            this.textBoxAngajatIdProiect.Size = new System.Drawing.Size(185, 22);
            this.textBoxAngajatIdProiect.TabIndex = 11;
            // 
            // textBoxProiectId
            // 
            this.textBoxProiectId.Location = new System.Drawing.Point(322, 277);
            this.textBoxProiectId.Name = "textBoxProiectId";
            this.textBoxProiectId.Size = new System.Drawing.Size(185, 22);
            this.textBoxProiectId.TabIndex = 10;
            // 
            // textBoxPlataPeOra
            // 
            this.textBoxPlataPeOra.Location = new System.Drawing.Point(322, 391);
            this.textBoxPlataPeOra.Name = "textBoxPlataPeOra";
            this.textBoxPlataPeOra.Size = new System.Drawing.Size(185, 22);
            this.textBoxPlataPeOra.TabIndex = 14;
            // 
            // buttonAdaugareProiect
            // 
            this.buttonAdaugareProiect.Location = new System.Drawing.Point(322, 419);
            this.buttonAdaugareProiect.Name = "buttonAdaugareProiect";
            this.buttonAdaugareProiect.Size = new System.Drawing.Size(185, 30);
            this.buttonAdaugareProiect.TabIndex = 15;
            this.buttonAdaugareProiect.Text = "Adaugare";
            this.buttonAdaugareProiect.UseVisualStyleBackColor = true;
            this.buttonAdaugareProiect.Click += new System.EventHandler(this.buttonAdaugareProiect_Click);
            // 
            // textBoxCautare
            // 
            this.textBoxCautare.Location = new System.Drawing.Point(12, 483);
            this.textBoxCautare.Name = "textBoxCautare";
            this.textBoxCautare.Size = new System.Drawing.Size(148, 22);
            this.textBoxCautare.TabIndex = 16;
            // 
            // buttonCautare
            // 
            this.buttonCautare.Location = new System.Drawing.Point(166, 479);
            this.buttonCautare.Name = "buttonCautare";
            this.buttonCautare.Size = new System.Drawing.Size(146, 30);
            this.buttonCautare.TabIndex = 17;
            this.buttonCautare.Text = "Cauta angajat";
            this.buttonCautare.UseVisualStyleBackColor = true;
            this.buttonCautare.Click += new System.EventHandler(this.buttonCautare_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 515);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(300, 30);
            this.button4.TabIndex = 18;
            this.button4.Text = "Salveaza in fisier + calcul salar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 585);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonCautare);
            this.Controls.Add(this.textBoxCautare);
            this.Controls.Add(this.buttonAdaugareProiect);
            this.Controls.Add(this.textBoxPlataPeOra);
            this.Controls.Add(this.textBoxNrOreAlocate);
            this.Controls.Add(this.textBoxFunctiePeProiect);
            this.Controls.Add(this.textBoxAngajatIdProiect);
            this.Controls.Add(this.textBoxProiectId);
            this.Controls.Add(this.buttonAdaugareAngajat);
            this.Controls.Add(this.textBoxFunctie);
            this.Controls.Add(this.textBoxCNP);
            this.Controls.Add(this.textBoxNumeComplet);
            this.Controls.Add(this.textBoxAngajatId);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.proiecteDataGridView);
            this.Controls.Add(this.angajatiDataGridView);
            this.Controls.Add(this.angajatiBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.firmaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiBindingNavigator)).EndInit();
            this.angajatiBindingNavigator.ResumeLayout(false);
            this.angajatiBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proiecteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proiecteDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FirmaDataSet firmaDataSet;
        private System.Windows.Forms.BindingSource angajatiBindingSource;
        private FirmaDataSetTableAdapters.AngajatiTableAdapter angajatiTableAdapter;
        private FirmaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator angajatiBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton angajatiBindingNavigatorSaveItem;
        private FirmaDataSetTableAdapters.ProiecteTableAdapter proiecteTableAdapter;
        private System.Windows.Forms.DataGridView angajatiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource proiecteBindingSource;
        private System.Windows.Forms.DataGridView proiecteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBoxAngajatId;
        private System.Windows.Forms.TextBox textBoxNumeComplet;
        private System.Windows.Forms.TextBox textBoxCNP;
        private System.Windows.Forms.TextBox textBoxFunctie;
        private System.Windows.Forms.Button buttonAdaugareAngajat;
        private System.Windows.Forms.TextBox textBoxNrOreAlocate;
        private System.Windows.Forms.TextBox textBoxFunctiePeProiect;
        private System.Windows.Forms.TextBox textBoxAngajatIdProiect;
        private System.Windows.Forms.TextBox textBoxProiectId;
        private System.Windows.Forms.TextBox textBoxPlataPeOra;
        private System.Windows.Forms.Button buttonAdaugareProiect;
        private System.Windows.Forms.TextBox textBoxCautare;
        private System.Windows.Forms.Button buttonCautare;
        private System.Windows.Forms.Button button4;
    }
}

