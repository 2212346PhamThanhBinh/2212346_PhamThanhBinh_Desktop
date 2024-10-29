namespace lab2Demo_2212346_PhamThanhBInh
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblTienTAB = new System.Windows.Forms.Label();
            this.lblTienTAA = new System.Windows.Forms.Label();
            this.lblTienTHB = new System.Windows.Forms.Label();
            this.lblTienTHA = new System.Windows.Forms.Label();
            this.chkTiengAnhB = new System.Windows.Forms.CheckBox();
            this.chkTiengAnhA = new System.Windows.Forms.CheckBox();
            this.chkTinHocB = new System.Windows.Forms.CheckBox();
            this.chkTinHocA = new System.Windows.Forms.CheckBox();
            this.dtpNgayDangKy = new System.Windows.Forms.DateTimePicker();
            this.lblNgayDangKy = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.cboMaHV = new System.Windows.Forms.ComboBox();
            this.lblMaHocVien = new System.Windows.Forms.Label();
            this.lblTrungTam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Aqua;
            this.btnExit.Location = new System.Drawing.Point(523, 385);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(160, 53);
            this.btnExit.TabIndex = 33;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(312, 384);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(168, 54);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTinhTien.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTinhTien.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhTien.ForeColor = System.Drawing.Color.Cyan;
            this.btnTinhTien.Location = new System.Drawing.Point(89, 384);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(173, 54);
            this.btnTinhTien.TabIndex = 34;
            this.btnTinhTien.Text = "TÃ­nh Tiá»n";
            this.btnTinhTien.UseVisualStyleBackColor = false;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(261, 334);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(374, 20);
            this.txtTongTien.TabIndex = 31;
            this.txtTongTien.TextChanged += new System.EventHandler(this.txtTongTien_TextChanged);
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(123, 327);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(116, 26);
            this.lblTongTien.TabIndex = 16;
            this.lblTongTien.Text = "Tá»•ng Tiá»n";
            this.lblTongTien.Click += new System.EventHandler(this.lblTongTien_Click);
            // 
            // lblTienTAB
            // 
            this.lblTienTAB.AutoSize = true;
            this.lblTienTAB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienTAB.Location = new System.Drawing.Point(406, 286);
            this.lblTienTAB.Name = "lblTienTAB";
            this.lblTienTAB.Size = new System.Drawing.Size(95, 19);
            this.lblTienTAB.TabIndex = 17;
            this.lblTienTAB.Text = "600.000 Ä‘á»“ng";
            this.lblTienTAB.Click += new System.EventHandler(this.lblTienTAB_Click);
            // 
            // lblTienTAA
            // 
            this.lblTienTAA.AutoSize = true;
            this.lblTienTAA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienTAA.Location = new System.Drawing.Point(406, 257);
            this.lblTienTAA.Name = "lblTienTAA";
            this.lblTienTAA.Size = new System.Drawing.Size(95, 19);
            this.lblTienTAA.TabIndex = 18;
            this.lblTienTAA.Text = "400.000 Ä‘á»“ng";
            this.lblTienTAA.Click += new System.EventHandler(this.lblTienTAA_Click);
            // 
            // lblTienTHB
            // 
            this.lblTienTHB.AutoSize = true;
            this.lblTienTHB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienTHB.Location = new System.Drawing.Point(406, 228);
            this.lblTienTHB.Name = "lblTienTHB";
            this.lblTienTHB.Size = new System.Drawing.Size(95, 19);
            this.lblTienTHB.TabIndex = 19;
            this.lblTienTHB.Text = "500.000 Ä‘á»“ng";
            this.lblTienTHB.Click += new System.EventHandler(this.lblTienTHB_Click);
            // 
            // lblTienTHA
            // 
            this.lblTienTHA.AutoSize = true;
            this.lblTienTHA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienTHA.Location = new System.Drawing.Point(406, 199);
            this.lblTienTHA.Name = "lblTienTHA";
            this.lblTienTHA.Size = new System.Drawing.Size(95, 19);
            this.lblTienTHA.TabIndex = 20;
            this.lblTienTHA.Text = "300.000 Ä‘á»“ng";
            this.lblTienTHA.Click += new System.EventHandler(this.lblTienTHA_Click);
            // 
            // chkTiengAnhB
            // 
            this.chkTiengAnhB.AutoSize = true;
            this.chkTiengAnhB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTiengAnhB.Location = new System.Drawing.Point(181, 286);
            this.chkTiengAnhB.Name = "chkTiengAnhB";
            this.chkTiengAnhB.Size = new System.Drawing.Size(102, 23);
            this.chkTiengAnhB.TabIndex = 30;
            this.chkTiengAnhB.Text = "Tiáº¿ng Anh B";
            this.chkTiengAnhB.UseVisualStyleBackColor = true;
            this.chkTiengAnhB.CheckedChanged += new System.EventHandler(this.chkTiengAnhB_CheckedChanged);
            // 
            // chkTiengAnhA
            // 
            this.chkTiengAnhA.AutoSize = true;
            this.chkTiengAnhA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTiengAnhA.Location = new System.Drawing.Point(181, 257);
            this.chkTiengAnhA.Name = "chkTiengAnhA";
            this.chkTiengAnhA.Size = new System.Drawing.Size(102, 23);
            this.chkTiengAnhA.TabIndex = 29;
            this.chkTiengAnhA.Text = "Tiáº¿ng Anh A";
            this.chkTiengAnhA.UseVisualStyleBackColor = true;
            this.chkTiengAnhA.CheckedChanged += new System.EventHandler(this.chkTiengAnhA_CheckedChanged);
            // 
            // chkTinHocB
            // 
            this.chkTinHocB.AutoSize = true;
            this.chkTinHocB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTinHocB.Location = new System.Drawing.Point(181, 228);
            this.chkTinHocB.Name = "chkTinHocB";
            this.chkTinHocB.Size = new System.Drawing.Size(90, 23);
            this.chkTinHocB.TabIndex = 28;
            this.chkTinHocB.Text = "Tin Há»c B";
            this.chkTinHocB.UseVisualStyleBackColor = true;
            this.chkTinHocB.CheckedChanged += new System.EventHandler(this.chkTinHocB_CheckedChanged);
            // 
            // chkTinHocA
            // 
            this.chkTinHocA.AutoSize = true;
            this.chkTinHocA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTinHocA.Location = new System.Drawing.Point(181, 199);
            this.chkTinHocA.Name = "chkTinHocA";
            this.chkTinHocA.Size = new System.Drawing.Size(90, 23);
            this.chkTinHocA.TabIndex = 27;
            this.chkTinHocA.Text = "Tin Há»c A";
            this.chkTinHocA.UseVisualStyleBackColor = true;
            this.chkTinHocA.CheckedChanged += new System.EventHandler(this.chkTinHocA_CheckedChanged);
            // 
            // dtpNgayDangKy
            // 
            this.dtpNgayDangKy.Location = new System.Drawing.Point(241, 170);
            this.dtpNgayDangKy.Name = "dtpNgayDangKy";
            this.dtpNgayDangKy.Size = new System.Drawing.Size(394, 20);
            this.dtpNgayDangKy.TabIndex = 26;
            this.dtpNgayDangKy.ValueChanged += new System.EventHandler(this.dtpNgayDangKy_ValueChanged);
            // 
            // lblNgayDangKy
            // 
            this.lblNgayD,9Nugh{&xÌƒÛ´ñÀíJ—üºÌ‰xvÌÖN÷#zp£š)‹hl~æ*±ÙŒnÒxÁ©vFøm=“1åDôt‘jr ü¶dÆôÚÂ˜|g Cc¾:››Ã»¨SìĞÍ¥>sÑßI€AGôÒ²KrÔÍ½ĞEÃ›Ó°øØ¾ê	xRxM C›õÅ&,u‹/ccv2¤80öYé-o#BÉÅ¦
 D^§eö
t’{m\4A	~ó®¨æ¨]¥‘ŒuE	üê„"æì¦˜L®Ün3õ´/¬IE<ê¿ÊÒ‘«ní¸¥?	Ë—K´\/·„Ü@@;Ø‡»±ÑSıÀqtîÃ°ÆZäKÄuéO	ÀÅû”½.Ù
ˆÑ9›éÇwÕîKş"Éı8]W<:ùôpgz‡JhîşBÙbQÀâº‚¿ö5ÓÜSœIÑs£~ SgÇãõ==¡;_e){Å¹¢†›Ğ8òoj€BOº;òoY—üëwÖ%w)AåÖY:IZDÍv/©óª]6öïW;ÇèÃ˜øØüÔ•†•9®ãyD‹f½²É¹¨V­ü9ê™"ªñM’¬âz{ QÕ¹¬=§ 3œ€xøÔg[ó U¿ø±[?²-1ôV¬Ò[3¦Dô1ìÉƒñÀÄÍq€7Ç„nÍ&HÁ±]Ì}Ş¼µºRŒp½,EçÊ p¥˜²±j6ZóÙîr	)†u>n•Aàw1DoÍuKT ±t¬á·¡ˆ…ğ6<s'æ#áÄ<F/fk^¬1ò¥¹K¥	ù5Üê.F\²FJÖ=—a¾}Q¢Ãı¥İ¾ËB¯i
L|Û[^ÆÀ…ßúƒeE,6ÖTz€gŸH¦¹’P!ä	D08¦@^À¨ë‹„˜#Ò¤ç>2VØ«Å@;…·ÖS´Å<{)¹ßrRÇB³–ıyQXğÈ~¸íøÍµ-‚‡0n¼Z.5¾%GD‹ÏE&ÄÒ ¯C MKŒœs³
.Í‡?ĞZ¾=“¬	ía G´ã†sÀ]Z?öËyÇ[2ş•‘¿˜ÇlÊÒcš’²´İ¶xHıÛOyxeøˆŞ§™¹â2,TDĞú
›ø1ËÊ—Hqµ>ñË½ï+4Û÷i3Ü>Ú›“%¦îkõ¹ŞúYTÙiW@Eç=’ÆÆı‡³¡‰S<ÿœj:N:Õ€ÑúíÜiöR²2ùîµVâ[`
ñÎ¸ß&21X´Ö	¤™<1jî—mpu Cí	Ô5‹#ãÃm¾ Št=·)Ÿ¦WgŸty™ÇDO¾=À_3d‘šö`ô+G¬eÄ|xÔuÇá;yş+;æI1¿¥Ç£ßØcnóNÊ^E&ŸñÁDt+3b1@G…n°IC2 _ & ÔÂ…»æ~èb¦·³`…0˜Ø-”øşZÎy{®©òœ)™¸ ÃÄ–Í‡©&Xd²*ŸSà‹!iü&»aùË)9NU…RP¡ *nåhc’ ¨~|˜Ê9h)¦E
ÜBl¥ê’;t³O•5‰í–4ôd6T¾½î]ÁóØş%G¤—'~µ•»êìáè1ƒ5'ôÆ<¯­#¬Âáä[N=÷E".‰Œû{‹²ÈZ ¼–HiDA8+¼vâ[‘ÈV|m¥»-<5Eí´sàª‡Ù‘ˆ|sğÌà_Ş%-î´Ø~Ü“‡ÊÅxìêXIf…‰Íñ6‡e7ªr¡b…1ğä“[ÇDñ;^GÊZ6Dar·¶†Ï»[c²"ÿZî\º”R’_™Æö,÷8WÆCR?(sO(Ğê™æ–k-Bta‚ö­*·Îõ8Ë£™C‚A)Ûg]É>Ÿ‘]‹ŠjnË.•XèJcMLëF¸ä6rJ³ÒG¦¬	¹çı‘cÊ¯qu{VUyD@‚ƒ§BæöT%.ã9g2 “Q‰Xñ´Ô/¥G&²“Ñ³`ÎÎİ%æË ²Ñ$\Š¦:rdêw²·.e^-l’L¶-‘ÙN¨ª¿`;;˜¤JyË¸¡‚·)š(d~MÌ4)•k¦ÿ†ŞDÆ¦ğœÆğ8ÂÙ-<=Ø7 Dìt#:IŸÚ
•CÚ\´GFŒl<Ñv°'Ğ}_ ^¤BéS_¸w‰Ÿ)a@*U˜LC\à¿˜óòÆæ›F6”ÊP¯Ô˜su›¤)p£È]½Ætç~µ úºŒÌ¤niÅ*1FÇux qäz˜~¿Ø¸,ı[Å*ö1¼é¯\!§¹v±¿rEIeñz"ÖÅm+zAcLÕ²Wö¶úmÀ…ê5JUÁÃóô<ó¼lsÜÉš ˆEĞŸ <D±°,weÇüæq	ÏPN>ÿ¦ßc˜G“§œê.tkÖ¾óN_/xÊuo²x:Z\Ÿ\>FQ8<™?}.ØdôüÙb4ñîî(vò†G“qyfùŞ¶ùç_Ûø²º4´	oÅwqUÑ=h((®I¸ıáÎy›ˆqb¤T@ÓnOzòèD™“nZ`é¡Æ‹e–0S¦Ä»cÿ¯úaÔù°DöQvË!ÆPƒ]—ÆÄ–oùï!îv U`˜e0Å~[ÃÚá/­5ö1Jş:[ÓÍ)‘L‰Y@†y“£ÃqÏšq¸Öş¾ _‹h¼¤*'.yâÇ_0{T+¬–éTzöÁE÷„ÔNâôÉ¿FSv–OSWÕšË6¦ƒ»¿áeH< kOÁ‹x$ŞJM‰-âiü ÑÚ8P^œõ&Äw[z.bÁ¢÷ÀşçËû|¹?-ƒXFÇ®BœKP…çÓÏ¦Éhh”™rˆ!Ã{šIme’ŠxÉE™†¦\e]V#TµğzÜ^lšçq¸¢Ôı†X  >ó_ã‘ûòÓÉéû·’iñÇOİ7¯ÿ||ñç×¯ßsÄŸ<sÿëÓûÓã^kr =ˆÿëÀhò×g‚[=|¢‘FÏ¤ V„‘|ö%¢ÈI@õ%ş@Iíš~@‘…®±}`6ğ5\y"«•ŒØh¯<J^…×5Z[Hñ(é‘x†h^ĞâRôã€%+ØG´¢‘y óÚÖ>ä¦2Ö
pC­ËMÚ¯(Î3 `ú·ş(’º%îPË",´Ûd¾ãİa¸Ãùò4³3G´‡‡¡¥Qj‰±Òğ:¾BsØ-)ôa©wL ¥%¿(ë’¥.¦'¤C
~2+õSJ:Ò|Dvğ)dîg"2éÄiåÜ•Ñõ*˜V˜`øn¼µ1¼¿øIö(ôÛ&™½ˆJÙe.¬<¢Ÿ½
w;°šú»+IGPŸ¯IºˆAØÄÑ'œÀÿ;Ã0<‘9gÃä‚Â=²<@”Ÿ^ŞÀ5Ô—ÀÌrf^»–£†öÇ{èÌ?ß—‘$ô¯t5A&,$±1-1{¡ZÔ\¶®o-ec'6´¤x*Š½MÚ(n[‘şn"…Y´“w‹ğ:£¤ög–ü	lÊ²¬sAÂà'úoğƒ±(ìKğMü‚wòxŞ´@†f!]W‡R‘¯hÉzC6j§qÃÉÖ
ER>tšë!J)F^Ëˆï
™ık”K)\%>“,-3˜ã±V,DÙ%S#)¨VÂ³êœÿíj‰Ñ‰µî$}¨ù”7l²¦)DîC‚zgZÀd¹l³Ì7[äÓ#m“/ô0œ®#?õäÏÍ”×â-ò+•bvBYåÉÅÈ¼ñK4 w¿nHÆc2³½(
@L™Û6"Ñe}&ªÍnÛhj2’hŠÇO&Õ£XØ«%~%È»‰S€ºH5%kÃŸ\wØ_±éè¡‰elê0»¡å2‰0¼/EÙ–(‘5(‘Õ(‘îcâoã¬°)E»È¦m;Ä°…mX–tp>y,ø¥_0Vª†”;eëjÈ™JÀW­Ñ4¤…™¯Œ‘æL«¡ˆı";w”Ó¤ì]ô  ä9“¾uG#]m,¨$ETªåˆ-#N² `(–Ñ“šbivùºV·4·aUfD)ÀšïÈ¸N;†IÁ(r¾À¸yU.å»ÏÜíç%æ‘ö†/(ØŠ.’h8š:7k)òâğF¤˜`–hF¦%…\DXW´œÜ·š)iÍeì±µ¡XŞ-–Ó5{ˆá7éï†‹iL__S÷N.q¼áªx%å²÷™’^m¥Ef,†\QƒŸE’Ò¦¯ÍZ›Ì»»2üÕÙğ$e˜,C!ç-ÌÊ(V,==AÌ–Ô6WÒWK³	#ÿÆ•tf×şáºV§S¦Œr7ö?¾]uÉ`\"$¶o0İø€-cB˜S~õ\?˜…¬ß4òáHXwŞb¢Æ ™«!ùP¸×¼ğÆãúõ•0Œ0”Cí…Ê0¢˜0l>œˆÚ¥'~‰÷"Ê*f–æ¿\µX.	È0x]Ñø’÷ôö­­'¡pı».‹&ˆ,zi*3´öäwK:£N_a?[®	‘ABÌ%Şñ;äßÉÇ á³Eé&?Ëqâè)<qÃş9f7»ÛVHA¿Ù/fõ/¯£µR¶‹o;)qÛ®NvdâÆgÍ ÉÎ­YÖ¢wÃÇjÎà†l½„¼]$—ÉÔ&C3¦4.p7‡SÃ'ñ#…ë¤D«~Ü²§Ùlæª¥lŸİÜ¦{[lóĞÍ@¡-‹Ù®§7fnÂ)Iˆ·»P¡û8È#`wc©D}F)œ€8_Ã+ ¥óagvŠoïÍ°8³,¸õô“Øwú¤0mĞröó™i=ˆQi‹ƒ¹)ï¨xÊm n²Aíâ¨ÑÆñCC‚uáûÊËxßğTfƒWïßxÄØALvdD”…]]W%Í+ºeÄdk;kÓ\üÀ$DA9‹Gï^ÏØë«ƒ)^ºà0¼ó›w=×¡S1+KŸ—n=Gº‚uï±3ã]4«OŒ˜”İ¡ß'¸e–%„ÆòÆRuËT¤Û^:æW/Âãòn&—Î»Í@ŠevƒôNßÄ
š="úÇÌ½Ä†b”úÌ a|Q[ †¥>•ÛèÑ5ùfòZ:H¢»@?zj_ßî·$®ˆ~&éÕ¬’”eÜuÈéªJyZÍ†ZÙ0yC6	 Lƒˆ@¸îÛÊ¼¯Zm„ÿ„yL“5¾öuDÛhíq—2`p=ÒRãç=DétG­t“ëyèI
0üø‹4^Ñî“!Èı½øÊ=Ñ>n-³Ê~y @Ñóİ@(ˆ*Š}uéÙÁş“‘³Q]†ÙLŠ¹&Å Æí~"E.‚XúÌbp„;´åAJc
˜.Ò;wWYÄ„©V¦!ã0êƒ@ha‹B)Rô—8Ò€™ú¥f¸,¥ÔÎT	½›eä^ÁÃ!‹…ğ´ĞBš‹ÅJì’xö®zâ„ñ—HŠ!·úG&Æ<	ª¦ÍßˆY jY™TŞ3¸gqk’…¡¦)0,É¯â!M¦M€¤§÷ÆÚDd·v¬eÆˆ‰öİ"õ™;/¿"¢Ø´ÆC¨õpjf8ÚÕ"PGˆ2xW­.ñt¦Šç,_"LôëSÃ4ŸÏ¸øìœC˜ºC3jâ­÷çè(ÜsŠ‡ÚÍdŸŞœ,µ·ÿÍ„'¢ø$ZgØºÖ¸¶»=”Œ¾#W£²Z`CL-n’ ‰;ÅFú8ª4´ó:
:Wíp¨ ½ùR™ÃK¡n•#mgÊ.!ä´—ŸRhXDŒ\£Ğ^PŸ >=îÕÕB#ÚÔy-y{jÑ¹íV#d×
y!§$eÙ‚@Û"2Éõ¶ú ¥É1qVäçnsØ¸ø¾İÂè8UDÀx¤2)˜¾S€	Fİz¥D ÕjnEÃáÑ6ä“ºM%rwÔ—dÙºÖ‚S“ÁàîqÑÏEOÁ «O€¥ú…o¦vŒáF±Œ‡àG±jùkL•˜CÜS0ÍıÌF#`çµoPO‹§_¢m¡SªºÓQÏ©î®6ˆğÏL?ŞåpŒD¬]w Åíu… VÊ“×´ö"A¥ ufŠ3~ÕÎ»|Pl”¬¾¨Ñ¥ÌrµFQêæ	ÊçÂ†øi;ù·dwÖUYüZ59P°!^ ’yÜŒ¥'
6Û½‡JueËuºXéOäÍ¥7˜²%MAödÛp-¶'EŸpı†£:¸¹ê.ZXSÁo´"JªÎ\ÚÇN›§)—ëu?%Ø–ÍéİÇEy8<rê¸=ª;
Å5êuøCÇ
®Å	¹"äÀÏ¸ºf,R•pmÍ®­9&h»»æÚ›•pë¸&UOÁî•š„¨æ?jQœ!šßÀ5S-²ªØ£Ã·g¯†ÖåŞ6ï³|U¿¾bú1Ğ1dÔœ„¯5>ë8b–Ñç¶Åìu(>I˜¿¤°ÂrqÙcuL–Ë,
¬ïON­ÚÜ!¸^¢—|ÜÂ&<…w<“şÏŠP{Ì<
=Ìë¤©«¡¬Š
˜çÀ-Î1&0¼å5—^+‘[¶¥¬eÛ±l”"§õ:Â åì+ïÉÒ%rér‡À‘t¹—”%Ã‚çNxLúÜcqv”Í5]É¼ß&6nå3“´çÎZ3‘Í…‰ìZ5‘u)éy¤bô©† ¹\ïî^«ÖØÇkt$;†ÎÑõgºÖ-§×-Ëé¤±œ.‚åC–Ó6ºS˜AÚ GlÜĞŠ=DUr„iĞá¤Ùq/l:-¸ˆ\$øSCcï\ ¥”ºñh/n/°6|¯-…±Š®XÌ £¡	Âê`ÿŞÇ“3eöû`2[ÔNüè‚°àQ'˜ºŞ²¹ãö|‰ëXò3ø}D|%%Ö5Ø6i½@Òõr”‚Ğ&fßÛi+r„«¿@í-»N,Jy.W<–FU¾’*ùŸ‰!ÔãIÕã¸˜Õ«îÛ6§º²C !I—xUÈ{,.@ïœ[u½ŠîÂ–&ÙbÆ%%ĞX–L¦ar[ÆóbÀÍ–-}.Çµë.§sœùŞøõ$6wÛÿëÙ_ÿ0;ÿãgÏ¾Ê®ïWqâØşçhèÌì3xïıÑ™ıË~LÙ[[„“¤g(ëĞó±ûø£Fq›äæ¥ó)ONXZ {s¿q–©¨”mŞš­9Ù›>MİàFE-0Õ j&B¸-o£ÃÀ˜ğÙÇLiJc˜+ÂçĞ[Kƒqª•TµQM"Œğ·İoo¤%ô|ş¼•Ğ37»«dªŒHÈ£­Ä’rÜm¹<Akr Q7û4fìA(öÁidM†”&3OÔÅ}”¶´˜Ÿ¾_BÏëóÈ+~+õÆœÏğÜ6ô¯ñv3L†öûıU£®gİ3Ì‡f]ªº—)SÇ¹£ÉGÏrÒ˜Ò2öaî¾ qÍ-!ã´eÂ‹X¥sJhûxëŒCá½şDúÄ™³¼	òÖvZŠ·¾İ-RÕG7Q&7¦P¾­³¦¦	u¹SÏZR®…F«èÁŞ¡k}ƒ,·“	6Ñ|\©ƒÓ’ºpg“º§/`G¿Xê™»¸;
Ê)ÊsÀ ¼Â¥³â"ÿ‡‚÷«„Â–œ°dñ@¾bC¡ˆ'VªpK&ìõĞyT¼"¹Té”G8hË(Â÷óH0Ÿ€BÌ	cÁ'œû<ìçDº8<ãüç‘à?8ÿ)¼FÈh’Áá°½%Œ¼â]ˆf±}‘ÛÀúV™WHÜ\wë¯l4Ü^<Ìr•¨25Q]ÓE—I†Ã­Ñ('Ëüa”6<Y’’´Ô±Ú]A‰õÎ®E û5°„á±ÜÓÀò”ƒ»†ÍdõÆ})©(N:¡¢XpÍ=5‘‡Û¸—Èƒ¤ò,ÚP/d²º’'kÒ²"-¹†-»QUçì±ÁWdÏvfÕ4fuîvÙÜ9şşÂ•l2•Ö43Á?e}¿óêıËÓÿşp<@ï¶¾Yığı>ÿiUxÿPËD­–ÜøWÓ´Î¹}N¾¥gÖÏáuXP8ßr¿«s}‰±XÎô;À¤ù-ìŠPr’¿™
nÏw$P ¦Æİ«m¼2îXßsñ{øå¡E½-kxåÉ ¢ú’:Cî«qNsçşE¬I»	ô;p+ë!îÈ+‚“ús—èÅ°–µ5—fÈÅ”ò6ÎgNË—ª“ÚŠQ¬ÅòkÅÀ•xFhv¼G<ø©¡MÅx¥§ñiAİ×êíc» 2}pLğ@2`’¹‰z²Û[á\ÔqÂ›iİí–üúÀHx1s¢á¡ ŠÅ!×-aZÈ'ÌÍŞÔñˆß0q$(M@öµŸ>náDûòQGBæ¶a,ÛÛ†ÎE³h¦/×CmÌ¶.ª5æ©~¢¤÷Zcl¾Âê"FõÎHÍÖ±$ü½DKR	3€ä‚W­[	&¬ (×¿Êl¦7%ğ€tÛQ¿êj$Ã]¾õÑê¿rà†V”;úäQ0@$çiöc¦_z¦İ–tQt$‡… Õº¸äµkAœß‘L¨=GqôQ˜Km·iäFUamedí–¢y_=Ê[jê¥ĞÄÒ¨¥%Jwtb§™Øv¹NúÂŠEj·ÔDZë?Ÿ¢%i¬,«Øí[áÙ:ä¨XW›7bë Ì
î0Œe Ë×E­.ÛQßWAÑD“ä¥lynÛĞ£ÄõPõ[>HÒóÍl®ª™‘Æ1Ñø±Æiø+ƒ‰§8ºn¬ªÙrê3ê·ûçMªÅ¸ü¶yéaù§€|¤
üf~nSÀ:«áùLª îõ¼ÖP‚º ¶Ğİ‚fî3ïBFæ,	x„Ë‚w›’c+†Ğî•E×şÎDË™Ê	š/7Ñ|·Hé‹(ú}›Š¢á·¦/Ù…O” ó7Î4±$ñh«®m–Æ²Öş~üjèàŒZŠ3%4JÊÌ·J?t":şc¯Å/ı#Pàõ¥ïM8yÑÌÜS‚²ÚN/|Š«& Õ† _uhÓÒ1ƒ—ãÛ	÷Z¦}8ù0ZÍ©L,ÅV—,ğQø9°ĞiM1}5‚ÌË-èË°ŞPüŸ	$¿y´ ‹¦O-4èVê’sYRdd}úHN¿íÀ£Û%Pä)îa^{fÂ+ÂB\æláı^ñW3«Ëß|İ˜c¨öX`õòhyUOwi7'…¤#«ŞÈ‰òA9´Ö_­~£ö›iŒû{ÎQ„;EÎ}üö’*Dh³RÙcÕÓQô®°ñÒª»Å6`.×ö©@Ìaµ„¤JöbäA
![yªt¾f'İª–´…N³äíæíV†ry„[¡Ï“nåq¿+ÅÀIyU{8vå(şníÂI‹Æ^¹¡$<Šš¸B~gC´Ši‚¦)Tš¦è10¨z-7 ûÂ•8drŸ1‚:òíİ>¥Ÿ§´VÜ!ö:Ü¬íğĞà5j!Cö·Oóî“êã×æFEÀ*„k¼İË­m=ĞşrÏUi¼Zó‹îmnîdm‹b
=öñM'’Œ}AN7%WË,‰Ğ€ìb<~>y¾å“wYÍ¿08a7ÏÁÂ"ÂbOÖ°x˜‹º ›¨§è}kE¹àe¬­Z=™ë•ãÑÎô;häò¡ê^ı°±f\|ÀøŠo5YÙ¼bíî
Ópz¾¿ÏDŠ9ğ†'S¦BÊ‹ûûBmIÜŠ|^›ğf*ípâiBT#Nuz¹ ‹¤Åuˆ;StLÓVL•ã®migÉÑÌ)ü¿ÏÄÔ´ÓÚ<>´Í~äb6ğ9rwJ™J·İİîó8Ú+5ZKÌ÷o|s2Z¥ÚÏ†[by‰K2`¸ˆd"•“"Ô„§ƒ²'‡\9ùŒë&ÇR79:ÊÉç\9ùœ+'ÇB;9áÚÉ×N’rri [ÈÊ|C:Ëb™UIôş#û¾Ì²/1¥ôFcI˜ïø®
CMÛñ'ºÔ\·Ù”âîÅì9†¨Áãş¢@W¾µQïpwWFÆÒ^K?……ÂË}*âôj ä@†¢DÃL¯UZTkf'…( A–dƒ%òmÜÚNÃéMËàNŠ<şcÃcÀQÛ¶ÓDøJ28^hUe9?ì1Í¶G¯NDYt ÚtEáf¹C	9ÌeLh-Ğ&…fë&×uÉhšçO¿nEôÃD8"{½¢Ìí‘+_kF‡b ñW h¢ÕU«…İİğ¸ƒh¸t™p´ñå¢D3+“h…hóCÿ6±¬¡³¤^3X™ËàŠ½—î]<i]À“ïÜ‚H¼è«ø©m‘‚¹` ”ùC*(¤6&9	bû®Èç>”eûµ…`<Â@°kDŒ„^‡ËxÒQªú†¦@#Ã\s#uV‡xy/È0‹Ï±ÏRU6€„.2ş^|E)t1Ø(î6ÎÿzÜqªÄWKmÜËz¡åv4+
”ËÍÖ¤-wr¢>Oi[ïŸ)^kSíñÓSô¸éŒƒÿˆ§'ôÏÁsúç2…öÚ,=áØòH~çáèD<™ñÄ±9¾|BøÒ
eTÙ½hµÇ£åZ&«¦†«@úhîôÅªŒùº®´ŸxöĞñ}›{ì¥ÜŞ4ĞÚ“b“\uC‚â°Í-iÌ6‹•lBLÆŸï©Œd=^¹î-Ä;›çñ­©/âîc}Áa|«…‡¿àf1–ºaÉ<[±=qĞöâˆ×ïßò×¯£†[DØÃäuĞU¿rqÉšÀ±şÜ%«ÈÅı%ÅŒ´¸íVı5%'D–¤±pH‰÷©+÷9UL$1€2†]3L?YÜpPÏÒŒæƒ>Æ™Õu™‡ì?|Ö——¡Ñ%ĞÓ…s=ğW7¦Ùtoazûâ¢âN=ÌWÛÂOBŠ‘ç Yªb’šaYA-*˜;VˆÇ‡Ië¬º/ÔVÕÔ¤&ñ´[3Š!Ñı&Ïõ49qq"‰Û™å~¼ÙÔ‰3„å˜@700–d•°$›K²HX’-„%Y",Æ–œ'[Ã²¶åØÑ(³_mVæaZ ƒ„omƒQ£ˆ]9p‡İ>Şæë2°$²ät‰å^Æå³Üã–=Ø×‡ìÁVá×=!> :­¿Rj4%BÃ6£®\8¡ñÚ–²eFej¬æVHŠ†z²£ìfww¡k!úyş©ÆA-úÿ`$Ô™Ío3B	{P’ßÏ%ùû¡üŸk
òÍ&F	ñïdä±­íÿ[Í>*³Ù‡–í×Øˆ“†åÛm&ÂÇÚLdÿCäìş±!™nÒš¨Û9:[CêÛïş-^áÅ9@	„õİ°~GæÂˆ~um£*÷ñÊ¾ÙPb«úÛ¤ùş½,#~Í kMßCƒxØ<¢®‹¿ƒ½Ä6lªYPÈ³²Ô,(SˆßÅÖf›)Â–íè7 øû Ïï6ÌÇ‚KŸÑ„ÙRâöïaûĞBBİ•ıV£öe^ôê}Œj