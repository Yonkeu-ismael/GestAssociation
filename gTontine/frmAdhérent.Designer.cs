namespace gTontine
{
    partial class frmAdhérent
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdhérent));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.code_adherent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compte_adherent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_naiss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_adh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sit_mat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numCNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtNoCNI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboPays = new System.Windows.Forms.ComboBox();
            this.cboSexe = new System.Windows.Forms.ComboBox();
            this.cboSituMat = new System.Windows.Forms.ComboBox();
            this.btnPhoto = new System.Windows.Forms.Button();
            this.ptbPhoto = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpDateAdhesion = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDateNaiss = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbpAppartenir = new System.Windows.Forms.TabPage();
            this.btnSupprimer1 = new System.Windows.Forms.Button();
            this.btnEnregistrer1 = new System.Windows.Forms.Button();
            this.cboTontine = new System.Windows.Forms.ComboBox();
            this.txtNbrePart = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cboCycle = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.opbl = new System.Windows.Forms.OpenFileDialog();
            this.btnImp = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.code_appartenir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lib_cycle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbre_part = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPhoto)).BeginInit();
            this.tbpAppartenir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code_adherent,
            this.compte_adherent,
            this.nom,
            this.prenom,
            this.date_naiss,
            this.tel,
            this.pays,
            this.email,
            this.date_adh,
            this.adresse,
            this.sexe,
            this.sit_mat,
            this.numCNI});
            this.dataGridView1.Location = new System.Drawing.Point(1, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(822, 192);
            this.dataGridView1.TabIndex = 104;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGriview1_CellDoubleClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.select);
            // 
            // code_adherent
            // 
            this.code_adherent.DataPropertyName = "code_adherent";
            this.code_adherent.HeaderText = "code_adherent";
            this.code_adherent.Name = "code_adherent";
            this.code_adherent.Visible = false;
            // 
            // compte_adherent
            // 
            this.compte_adherent.DataPropertyName = "compte_adherent";
            this.compte_adherent.HeaderText = "Numéro du compte";
            this.compte_adherent.Name = "compte_adherent";
            this.compte_adherent.Visible = false;
            // 
            // nom
            // 
            this.nom.DataPropertyName = "nom";
            this.nom.HeaderText = "Nom";
            this.nom.Name = "nom";
            // 
            // prenom
            // 
            this.prenom.DataPropertyName = "prenom";
            this.prenom.HeaderText = "Prénom";
            this.prenom.Name = "prenom";
            // 
            // date_naiss
            // 
            this.date_naiss.DataPropertyName = "date_naiss";
            this.date_naiss.HeaderText = "Date de naissance";
            this.date_naiss.Name = "date_naiss";
            // 
            // tel
            // 
            this.tel.DataPropertyName = "tel";
            this.tel.HeaderText = "Téléphone";
            this.tel.Name = "tel";
            // 
            // pays
            // 
            this.pays.DataPropertyName = "pays";
            this.pays.HeaderText = "Pays";
            this.pays.Name = "pays";
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Adresse mail";
            this.email.Name = "email";
            // 
            // date_adh
            // 
            this.date_adh.DataPropertyName = "date_adh";
            this.date_adh.HeaderText = "Date d\'adhésion";
            this.date_adh.Name = "date_adh";
            // 
            // adresse
            // 
            this.adresse.DataPropertyName = "adresse";
            this.adresse.HeaderText = "Adresse";
            this.adresse.Name = "adresse";
            // 
            // sexe
            // 
            this.sexe.DataPropertyName = "sexe";
            this.sexe.HeaderText = "Sexe";
            this.sexe.Name = "sexe";
            // 
            // sit_mat
            // 
            this.sit_mat.DataPropertyName = "sit_mat";
            this.sit_mat.HeaderText = "Situation matrimoniale";
            this.sit_mat.Name = "sit_mat";
            // 
            // numCNI
            // 
            this.numCNI.DataPropertyName = "numCNI";
            this.numCNI.HeaderText = "Numéro CNI";
            this.numCNI.Name = "numCNI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 101;
            this.label1.Text = "Nombre :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(90, 201);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(61, 22);
            this.txtNombre.TabIndex = 108;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tbpAppartenir);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(2, 227);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(821, 225);
            this.tabControl1.TabIndex = 115;
            this.tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.txtNoCNI);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cboPays);
            this.tabPage1.Controls.Add(this.cboSexe);
            this.tabPage1.Controls.Add(this.cboSituMat);
            this.tabPage1.Controls.Add(this.btnPhoto);
            this.tabPage1.Controls.Add(this.ptbPhoto);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.dtpDateAdhesion);
            this.tabPage1.Controls.Add(this.txtEmail);
            this.tabPage1.Controls.Add(this.txtAdresse);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtTel);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.dtpDateNaiss);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txtPrenom);
            this.tabPage1.Controls.Add(this.txtNom);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(813, 199);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Enregistrement";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // txtNoCNI
            // 
            this.txtNoCNI.Location = new System.Drawing.Point(119, 153);
            this.txtNoCNI.Name = "txtNoCNI";
            this.txtNoCNI.Size = new System.Drawing.Size(174, 21);
            this.txtNoCNI.TabIndex = 140;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 139;
            this.label2.Text = "Numéro CNI :";
            // 
            // cboPays
            // 
            this.cboPays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPays.FormattingEnabled = true;
            this.cboPays.Items.AddRange(new object[] {
            "    ",
            "    Afghanistan",
            "    Afrique du Sud",
            "    Akrotiri",
            "    Albanie",
            "    Algérie",
            "    Allemagne",
            "    Andorre",
            "    Angola",
            "    Anguilla",
            "    Antarctique",
            "    Antigua-et-Barbuda",
            "    Antilles néerlandaises",
            "    Arabie saoudite",
            "    Arctic Ocean",
            "    Argentine",
            "    Arménie",
            "    Aruba",
            "    Ashmore and Cartier Islands",
            "    Atlantic Ocean",
            "    Australie",
            "    Autriche",
            "    Azerbaïdjan",
            "    Bahamas",
            "    Bahreïn",
            "    Bangladesh",
            "    Barbade",
            "    Belau",
            "    Belgique",
            "    Belize",
            "    Bénin",
            "    Bermudes",
            "    Bhoutan",
            "    Biélorussie",
            "    Birmanie",
            "    Bolivie",
            "    Bosnie-Herzégovine",
            "    Botswana",
            "    Brésil",
            "    Brunei",
            "    Bulgarie",
            "    Burkina Faso",
            "    Burundi",
            "    Cambodge",
            "    Cameroun",
            "    Canada",
            "    Cap-Vert",
            "    Chili",
            "    Chine",
            "    Chypre",
            "    Clipperton Island",
            "    Colombie",
            "    Comores",
            "    Congo",
            "    Coral Sea Islands",
            "    Corée du Nord",
            "    Corée du Sud",
            "    Costa Rica",
            "    Côte d\'Ivoire",
            "    Croatie",
            "    Cuba",
            "    Danemark",
            "    Dhekelia",
            "    Djibouti",
            "    Dominique",
            "    Égypte",
            "    Émirats arabes unis",
            "    Équateur",
            "    Érythrée",
            "    Espagne",
            "    Estonie",
            "    États-Unis",
            "    Éthiopie",
            "    ex-République yougoslave de Macédoine",
            "    Finlande",
            "    France",
            "    Gabon",
            "    Gambie",
            "    Gaza Strip",
            "    Géorgie",
            "    Ghana",
            "    Gibraltar",
            "    Grèce",
            "    Grenade",
            "    Groenland",
            "    Guam",
            "    Guatemala",
            "    Guernsey",
            "    Guinée",
            "    Guinée équatoriale",
            "    Guinée-Bissao",
            "    Guyana",
            "    Haïti",
            "    Honduras",
            "    Hong Kong",
            "    Hongrie",
            "    Ile Bouvet",
            "    Ile Christmas",
            "    Ile Norfolk",
            "    Iles Cayman",
            "    Iles Cook",
            "    Iles des Cocos (Keeling)",
            "    Iles Falkland",
            "    Iles Féroé",
            "    Iles Fidji",
            "    Iles Géorgie du Sud et Sandwich du Sud",
            "    Iles Heard et McDonald",
            "    Iles Marshall",
            "    Iles Pitcairn",
            "    Iles Salomon",
            "    Iles Svalbard et Jan Mayen",
            "    Iles Turks-et-Caicos",
            "    Iles Vierges américaines",
            "    Iles Vierges britanniques",
            "    Inde",
            "    Indian Ocean",
            "    Indonésie",
            "    Iran",
            "    Iraq",
            "    Irlande",
            "    Islande",
            "    Israël",
            "    Italie",
            "    Jamaïque",
            "    Jan Mayen",
            "    Japon",
            "    Jersey",
            "    Jordanie",
            "    Kazakhstan",
            "    Kenya",
            "    Kirghizistan",
            "    Kiribati",
            "    Koweït",
            "    Laos",
            "    Lesotho",
            "    Lettonie",
            "    Liban",
            "    Liberia",
            "    Libye",
            "    Liechtenstein",
            "    Lituanie",
            "    Luxembourg",
            "    Macao",
            "    Madagascar",
            "    Malaisie",
            "    Malawi",
            "    Maldives",
            "    Mali",
            "    Malte",
            "    Man, Isle of",
            "    Mariannes du Nord",
            "    Maroc",
            "    Maurice",
            "    Mauritanie",
            "    Mayotte",
            "    Mexique",
            "    Micronésie",
            "    Moldavie",
            "    Monaco",
            "    Monde",
            "    Mongolie",
            "    Monténégro",
            "    Montserrat",
            "    Mozambique",
            "    Namibie",
            "    Nauru",
            "    Navassa Island",
            "    Népal",
            "    Nicaragua",
            "    Niger",
            "    Nigeria",
            "    Nioué",
            "    Norvège",
            "    Nouvelle-Calédonie",
            "    Nouvelle-Zélande",
            "    Oman",
            "    Ouganda",
            "    Ouzbékistan",
            "    Pacific Ocean",
            "    Pakistan",
            "    Panama",
            "    Papouasie-Nouvelle-Guinée",
            "    Paracel Islands",
            "    Paraguay",
            "    Pays-Bas",
            "    Pérou",
            "    Philippines",
            "    Pologne",
            "    Polynésie française",
            "    Porto Rico",
            "    Portugal",
            "    Qatar",
            "    République centrafricaine",
            "    République démocratique du Congo",
            "    République dominicaine",
            "    République tchèque",
            "    Roumanie",
            "    Royaume-Uni",
            "    Russie",
            "    Rwanda",
            "    Sahara occidental",
            "    Saint-Christophe-et-Niévès",
            "    Sainte-Hélène",
            "    Sainte-Lucie",
            "    Saint-Marin",
            "    Saint-Pierre-et-Miquelon",
            "    Saint-Siège",
            "    Saint-Vincent-et-les-Grenadines",
            "    Salvador",
            "    Samoa",
            "    Samoa américaines",
            "    Sao Tomé-et-Principe",
            "    Sénégal",
            "    Serbie",
            "    Seychelles",
            "    Sierra Leone",
            "    Singapour",
            "    Slovaquie",
            "    Slovénie",
            "    Somalie",
            "    Soudan",
            "    Southern Ocean",
            "    Spratly Islands",
            "    Sri Lanka",
            "    Suède",
            "    Suisse",
            "    Suriname",
            "    Swaziland",
            "    Syrie",
            "    Tadjikistan",
            "    Taïwan",
            "    Tanzanie",
            "    Tchad",
            "    Terres australes françaises",
            "    Territoire britannique de l\'Océan Indien",
            "    Thaïlande",
            "    Timor Oriental",
            "    Togo",
            "    Tokélaou",
            "    Tonga",
            "    Trinité-et-Tobago",
            "    Tunisie",
            "    Turkménistan",
            "    Turquie",
            "    Tuvalu",
            "    Ukraine",
            "    Union européenne",
            "    Uruguay",
            "    Vanuatu",
            "    Venezuela",
            "    Viêt Nam",
            "    Wake Island",
            "    Wallis-et-Futuna",
            "    West Bank",
            "    Yémen",
            "    Zambie",
            "    Zimbabwe"});
            this.cboPays.Location = new System.Drawing.Point(119, 124);
            this.cboPays.Name = "cboPays";
            this.cboPays.Size = new System.Drawing.Size(174, 23);
            this.cboPays.TabIndex = 138;
            // 
            // cboSexe
            // 
            this.cboSexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexe.FormattingEnabled = true;
            this.cboSexe.Items.AddRange(new object[] {
            "",
            "Masculin",
            "Feminin"});
            this.cboSexe.Location = new System.Drawing.Point(425, 131);
            this.cboSexe.Name = "cboSexe";
            this.cboSexe.Size = new System.Drawing.Size(193, 23);
            this.cboSexe.TabIndex = 137;
            // 
            // cboSituMat
            // 
            this.cboSituMat.BackColor = System.Drawing.SystemColors.Window;
            this.cboSituMat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSituMat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboSituMat.FormattingEnabled = true;
            this.cboSituMat.Items.AddRange(new object[] {
            "",
            "Marié(e)",
            "Célibataire",
            "Veuve",
            "Veuf"});
            this.cboSituMat.Location = new System.Drawing.Point(425, 95);
            this.cboSituMat.Name = "cboSituMat";
            this.cboSituMat.Size = new System.Drawing.Size(193, 23);
            this.cboSituMat.TabIndex = 136;
            // 
            // btnPhoto
            // 
            this.btnPhoto.BackColor = System.Drawing.SystemColors.Control;
            this.btnPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhoto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPhoto.Location = new System.Drawing.Point(687, 162);
            this.btnPhoto.Name = "btnPhoto";
            this.btnPhoto.Size = new System.Drawing.Size(92, 30);
            this.btnPhoto.TabIndex = 135;
            this.btnPhoto.Text = "  Photo...";
            this.btnPhoto.UseVisualStyleBackColor = false;
            this.btnPhoto.Click += new System.EventHandler(this.btnPhoto_Click);
            // 
            // ptbPhoto
            // 
            this.ptbPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptbPhoto.Image = ((System.Drawing.Image)(resources.GetObject("ptbPhoto.Image")));
            this.ptbPhoto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ptbPhoto.Location = new System.Drawing.Point(640, 10);
            this.ptbPhoto.Name = "ptbPhoto";
            this.ptbPhoto.Size = new System.Drawing.Size(169, 146);
            this.ptbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPhoto.TabIndex = 134;
            this.ptbPhoto.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(321, 93);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 30);
            this.label12.TabIndex = 133;
            this.label12.Text = "Situation \r\nmatrimoniale :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(321, 133);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 15);
            this.label11.TabIndex = 132;
            this.label11.Text = "Sexe :";
            // 
            // dtpDateAdhesion
            // 
            this.dtpDateAdhesion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateAdhesion.Location = new System.Drawing.Point(425, 39);
            this.dtpDateAdhesion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpDateAdhesion.Name = "dtpDateAdhesion";
            this.dtpDateAdhesion.Size = new System.Drawing.Size(193, 21);
            this.dtpDateAdhesion.TabIndex = 131;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(425, 11);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(193, 21);
            this.txtEmail.TabIndex = 130;
            // 
            // txtAdresse
            // 
            this.txtAdresse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdresse.Location = new System.Drawing.Point(425, 67);
            this.txtAdresse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(193, 21);
            this.txtAdresse.TabIndex = 129;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(321, 40);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 15);
            this.label13.TabIndex = 128;
            this.label13.Text = "Date d\'adhésion :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(321, 11);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 15);
            this.label10.TabIndex = 127;
            this.label10.Text = "Adresse mail :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(6, 125);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 126;
            this.label8.Text = "Pays :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(321, 69);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 125;
            this.label7.Text = "Adresse :";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(119, 96);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(174, 21);
            this.txtTel.TabIndex = 124;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(6, 97);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 123;
            this.label6.Text = "Téléphone :";
            // 
            // dtpDateNaiss
            // 
            this.dtpDateNaiss.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateNaiss.Location = new System.Drawing.Point(119, 68);
            this.dtpDateNaiss.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpDateNaiss.Name = "dtpDateNaiss";
            this.dtpDateNaiss.Size = new System.Drawing.Size(174, 21);
            this.dtpDateNaiss.TabIndex = 122;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(6, 69);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 15);
            this.label9.TabIndex = 121;
            this.label9.Text = "Date de naissance :";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(119, 40);
            this.txtPrenom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(174, 21);
            this.txtPrenom.TabIndex = 120;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(119, 12);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(174, 21);
            this.txtNom.TabIndex = 119;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(6, 41);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 118;
            this.label5.Text = "Prénom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(6, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 117;
            this.label4.Text = "Nom :";
            // 
            // tbpAppartenir
            // 
            this.tbpAppartenir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbpAppartenir.Controls.Add(this.btnSupprimer1);
            this.tbpAppartenir.Controls.Add(this.btnEnregistrer1);
            this.tbpAppartenir.Controls.Add(this.cboTontine);
            this.tbpAppartenir.Controls.Add(this.txtNbrePart);
            this.tbpAppartenir.Controls.Add(this.label15);
            this.tbpAppartenir.Controls.Add(this.cboCycle);
            this.tbpAppartenir.Controls.Add(this.label14);
            this.tbpAppartenir.Controls.Add(this.label3);
            this.tbpAppartenir.Controls.Add(this.dataGridView2);
            this.tbpAppartenir.Location = new System.Drawing.Point(4, 22);
            this.tbpAppartenir.Name = "tbpAppartenir";
            this.tbpAppartenir.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAppartenir.Size = new System.Drawing.Size(813, 199);
            this.tbpAppartenir.TabIndex = 4;
            this.tbpAppartenir.Text = "Appartenir";
            this.tbpAppartenir.Click += new System.EventHandler(this.tbpAppartenir_Click);
            // 
            // btnSupprimer1
            // 
            this.btnSupprimer1.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSupprimer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer1.Image = global::gTontine.Properties.Resources.delete;
            this.btnSupprimer1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupprimer1.Location = new System.Drawing.Point(685, 155);
            this.btnSupprimer1.Name = "btnSupprimer1";
            this.btnSupprimer1.Size = new System.Drawing.Size(106, 36);
            this.btnSupprimer1.TabIndex = 122;
            this.btnSupprimer1.Text = "Supprimer";
            this.btnSupprimer1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSupprimer1.UseVisualStyleBackColor = false;
            this.btnSupprimer1.Click += new System.EventHandler(this.btnSupprimer1_Click_1);
            // 
            // btnEnregistrer1
            // 
            this.btnEnregistrer1.BackColor = System.Drawing.Color.DarkCyan;
            this.btnEnregistrer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer1.Image = global::gTontine.Properties.Resources._new;
            this.btnEnregistrer1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnregistrer1.Location = new System.Drawing.Point(563, 155);
            this.btnEnregistrer1.Name = "btnEnregistrer1";
            this.btnEnregistrer1.Size = new System.Drawing.Size(106, 36);
            this.btnEnregistrer1.TabIndex = 122;
            this.btnEnregistrer1.Text = "Enregistrer";
            this.btnEnregistrer1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnregistrer1.UseVisualStyleBackColor = false;
            this.btnEnregistrer1.Click += new System.EventHandler(this.btnEnregistrer1_Click_1);
            // 
            // cboTontine
            // 
            this.cboTontine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTontine.FormattingEnabled = true;
            this.cboTontine.Location = new System.Drawing.Point(512, 23);
            this.cboTontine.Name = "cboTontine";
            this.cboTontine.Size = new System.Drawing.Size(242, 21);
            this.cboTontine.TabIndex = 15;
            // 
            // txtNbrePart
            // 
            this.txtNbrePart.Location = new System.Drawing.Point(512, 87);
            this.txtNbrePart.Name = "txtNbrePart";
            this.txtNbrePart.Size = new System.Drawing.Size(75, 20);
            this.txtNbrePart.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(427, 85);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 30);
            this.label15.TabIndex = 10;
            this.label15.Text = "Nombres de\r\n part(s) :";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // cboCycle
            // 
            this.cboCycle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCycle.FormattingEnabled = true;
            this.cboCycle.Location = new System.Drawing.Point(512, 54);
            this.cboCycle.Name = "cboCycle";
            this.cboCycle.Size = new System.Drawing.Size(242, 21);
            this.cboCycle.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(427, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 15);
            this.label14.TabIndex = 6;
            this.label14.Text = "Cycle :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(427, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tontine :";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code_appartenir,
            this.libelle,
            this.lib_cycle,
            this.nbre_part});
            this.dataGridView2.Location = new System.Drawing.Point(3, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(404, 196);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGriview2_CellDoubleClick);
            this.dataGridView2.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.select);
            // 
            // opbl
            // 
            this.opbl.FileName = "openFileDialog1";
            // 
            // btnImp
            // 
            this.btnImp.BackColor = System.Drawing.Color.DarkCyan;
            this.btnImp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImp.Image = global::gTontine.Properties.Resources.printer;
            this.btnImp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImp.Location = new System.Drawing.Point(701, 458);
            this.btnImp.Name = "btnImp";
            this.btnImp.Size = new System.Drawing.Size(106, 36);
            this.btnImp.TabIndex = 121;
            this.btnImp.Text = "Imprimer";
            this.btnImp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImp.UseVisualStyleBackColor = false;
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.Color.DarkCyan;
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Image = ((System.Drawing.Image)(resources.GetObject("btnFermer.Image")));
            this.btnFermer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFermer.Location = new System.Drawing.Point(589, 458);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(106, 36);
            this.btnFermer.TabIndex = 120;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.Image = global::gTontine.Properties.Resources.delete;
            this.btnSupprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupprimer.Location = new System.Drawing.Point(477, 458);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(106, 36);
            this.btnSupprimer.TabIndex = 119;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click_1);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.DarkCyan;
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Image = global::gTontine.Properties.Resources.ecrire;
            this.btnModifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifier.Location = new System.Drawing.Point(365, 458);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(106, 36);
            this.btnModifier.TabIndex = 118;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click_1);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.DarkCyan;
            this.btnEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.Image = global::gTontine.Properties.Resources._new;
            this.btnEnregistrer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnregistrer.Location = new System.Drawing.Point(253, 458);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(106, 36);
            this.btnEnregistrer.TabIndex = 117;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click_1);
            // 
            // code_appartenir
            // 
            this.code_appartenir.DataPropertyName = "code_appartenir";
            this.code_appartenir.HeaderText = "code_appartenir";
            this.code_appartenir.Name = "code_appartenir";
            this.code_appartenir.Visible = false;
            this.code_appartenir.Width = 60;
            // 
            // libelle
            // 
            this.libelle.DataPropertyName = "libelle";
            this.libelle.FillWeight = 200F;
            this.libelle.HeaderText = "Tontine";
            this.libelle.Name = "libelle";
            this.libelle.Width = 150;
            // 
            // lib_cycle
            // 
            this.lib_cycle.DataPropertyName = "lib_cycle";
            this.lib_cycle.FillWeight = 200F;
            this.lib_cycle.HeaderText = "Cycle";
            this.lib_cycle.Name = "lib_cycle";
            // 
            // nbre_part
            // 
            this.nbre_part.DataPropertyName = "nbre_part";
            this.nbre_part.FillWeight = 200F;
            this.nbre_part.HeaderText = "Nombres de part(s)";
            this.nbre_part.Name = "nbre_part";
            this.nbre_part.Width = 60;
            // 
            // frmAdhérent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(823, 506);
            this.Controls.Add(this.btnImp);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAdhérent";
            this.Text = " Adhérents                                                                       " +
    "                         ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPhoto)).EndInit();
            this.tbpAppartenir.ResumeLayout(false);
            this.tbpAppartenir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtNoCNI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboPays;
        private System.Windows.Forms.ComboBox cboSexe;
        private System.Windows.Forms.ComboBox cboSituMat;
        private System.Windows.Forms.Button btnPhoto;
        private System.Windows.Forms.PictureBox ptbPhoto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpDateAdhesion;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDateNaiss;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tbpAppartenir;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cboCycle;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtNbrePart;
        private System.Windows.Forms.ComboBox cboTontine;
        private System.Windows.Forms.OpenFileDialog opbl;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnImp;
        private System.Windows.Forms.Button btnSupprimer1;
        private System.Windows.Forms.Button btnEnregistrer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn code_adherent;
        private System.Windows.Forms.DataGridViewTextBoxColumn compte_adherent;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_naiss;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn pays;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_adh;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexe;
        private System.Windows.Forms.DataGridViewTextBoxColumn sit_mat;
        private System.Windows.Forms.DataGridViewTextBoxColumn numCNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn code_appartenir;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn lib_cycle;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbre_part;
    }
}

