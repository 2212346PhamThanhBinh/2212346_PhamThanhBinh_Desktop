﻿namespace lab2Form2_2212346_PhamThanhBInh
{
    partial class frmGiaoVien
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
            this.linklbLienHe = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbMonHocDay = new System.Windows.Forms.ListBox();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lbDanhSachMH = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chklbNgoaiNgu = new System.Windows.Forms.CheckedListBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblDiaChiEmail = new System.Windows.Forms.Label();
            this.mtxtSoDT = new System.Windows.Forms.MaskedTextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.cboMaSo = new System.Windows.Forms.ComboBox();
            this.lblNgoaiNgu = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblMaSo = new System.Windows.Forms.Label();
            this.lblThongTin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linklbLienHe
            // 
            this.linklbLienHe.AutoSize = true;
            this.linklbLienHe.Location = new System.Drawing.Point(787, 561);
            this.linklbLienHe.Name = "linklbLienHe";
            this.linklbLienHe.Size = new System.Drawing.Size(38, 13);
            this.linklbLienHe.TabIndex = 81;
            this.linklbLienHe.TabStop = true;
            this.linklbLienHe.Text = "liên hệ";
            this.linklbLienHe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbLienHe_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(717, 561);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 80;
            this.label3.Text = "Website";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(759, 510);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 79;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.Red;
            this.btnHuy.Location = new System.Drawing.Point(634, 510);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 78;
            this.btnHuy.Text = "Cansel";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.btnLuu.Location = new System.Drawing.Point(488, 510);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 77;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(335, 510);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 76;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(175, 510);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 75;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(517, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 74;
            this.label2.Text = "Môn học giáo viên dạy";
            // 
            // lbMonHocDay
            // 
            this.lbMonHocDay.FormattingEnabled = true;
            this.lbMonHocDay.Location = new System.Drawing.Point(520, 350);
            this.lbMonHocDay.Name = "lbMonHocDay";
            this.lbMonHocDay.Size = new System.Drawing.Size(189, 121);
            this.lbMonHocDay.TabIndex = 73;
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(459, 363);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(31, 30);
            this.btnChon.TabIndex = 72;
            this.btnChon.Text = ">>";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(459, 418);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(31, 30);
            this.btnXoa.TabIndex = 71;
            this.btnXoa.Text = "<<";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lbDanhSachMH
            // 
            this.lbDanhSachMH.FormattingEnabled = true;
            this.lbDanhSachMH.Items.AddRange(new object[] {
            "Tin học cơ sở",
            "Lập trình cấu trúc C/C++",
            "Cơ sở dữ liệu",
            "Tiếng anh B1",
            "Tiếng anh B2",
            "Lập trình hướng đối tượng",
            "Mạng máy tính",
            "Công nghệ phần mềm",
            "Phân tích TKHDT"});
            this.lbDanhSachMH.Location = new System.Drawing.Point(260, 350);
            this.lbDanhSachMH.Name = "lbDanhSachMH";
            this.lbDanhSachMH.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbDanhSachMH.Size = new System.Drawing.Size(167, 121);
            this.lbDanhSachMH.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "Danh sách môn học";
            // 
            // chklbNgoaiNgu
            // 
            this.chklbNgoaiNgu.FormattingEnabled = true;
            this.chklbNgoaiNgu.Items.AddRange(new object[] {
            "Tiếng Anh",
            "Tiếng Nhật",
            "Tiếng Pháp",
            "Tiếng Hàn"});
            this.chklbNgoaiNgu.Location = new System.Drawing.Point(271, 200);
            this.chklbNgoaiNgu.Name = "chklbNgoaiNgu";
            this.chklbNgoaiNgu.Size = new System.Drawing.Size(156, 94);
            this.chklbNgoaiNgu.TabIndex = 68;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(634, 151);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(119, 20);
            this.txtMail.TabIndex = 67;
            // 
            // lblDiaChiEmail
            // 
            this.lblDiaChiEmail.AutoSize = true;
            this.lblDiaChiEmail.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChiEmail.Location = new System.Drawing.Point(540, 153);
            this.lblDiaChiEmail.Name = "lblDiaChiEmail";
            this.lblDiaChiEmail.Size = new System.Drawing.Size(83, 15);
            this.lblDiaChiEmail.TabIndex = 66;
            this.lblDiaChiEmail.Text = "Địa Chỉ Email";
            // 
            // mtxtSoDT
            // 
            this.mtxtSoDT.Location = new System.Drawing.Point(634, 103);
            this.mtxtSoDT.Mask = "(\\0633).000.0000";
            this.mtxtSoDT.Name = "mtxtSoDT";
            this.mtxtSoDT.Size = new System.Drawing.Size(119, 20);
            this.mtxtSoDT.TabIndex = 65;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.Location = new System.Drawing.Point(540, 108);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(41, 15);
            this.lblSDT.TabIndex = 64;
            this.lblSDT.Text = "Số ĐT";
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(698, 72);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(39, 17);
            this.rdNu.TabIndex = 63;
            this.rdNu.Text = "Nữ";
            this.kIz��\��y�fLGGm�ǣ��M��d���QBN�G����t��1���wD��-l��wd��G""/�轕W����ꇓ �W�B�9)�><�%1��#ˌF�3�v��-��*ֹ�eꎬ.HF;��"{���w�xL���2uoo�{� .�� ������~��hE��٫�S�D�'o�_����ݑu
�T����4�_}e� � �5�ńx�G,������j5}K��q��>���A�оa��A[A:l�%�.�A$Y����/ɞ��scV�Ȉ��5��_J�c��p=�����|N�%߈�r�����Pj��=��V��q[��t�����B�i�f4�"H�";�a�7]6Xk�����=���Y��b+��T�vE�_��=�V=Q���0r��� ��.�>?��.f6L�����I*�UE�R����)���{��W�<H��X޽0c)\V��m�5V5�`���s10�3?;m=��X��'�<�
��^m2_52��(�=H��U����>�ZŶ&&%CxB]v�uuf�3Ԇ	��ŝAG6�&�R��1%��gXU��9&$��1\� vil�?�x!�
��6D�f�	[��O'F�V����^ʽ����|v���[�;(�yɃӝv�͇�J�8�i���O��'2�����ƣr��k(Vq�	�W��j�Wk����]�-}���6���҄}i�H�ED��ت��wµU�+��B�^*��+O�C�.��^�ӱ	%þ��y���J�)cm-�`�U|��\��"�0���F�`̌D�K>��ۮz°�{)���������(ǗOa��\UA�R'��ͻ��'e���9�����s��Z>i� ���K����m���sxL��V�I+^���欮j����fY�_Ӟ|��n�w|��Af��WJ�s��������ܦEs���d$�]��d~�'�m���"Y���]ӽQp�
�a`�s�s�$/k��v��i#s���#U��ιL��mFqG��bŜw�W�UVH��J��i	�^�1�g�#� A9̄�6�ͩ�!r�d��x���q)�*�� �1�j8���!<o{�>c�&J���4pY�v�+�#s��!n�<Cm���CS߇GV��k���.�򉼆GE��N(��w\?���P#��d�̏�Y8��ޜ�L�|�Ǝ�������c���+����z��u\��4���9� W`�ŰZZ<�8f�'����I~`�z��	k�������II�����Xj�M��,6Ǩs�u5H�ۋ)��R5��[r?��.���<�5Յ�>$�ݘ�|]���+^H�[�(��iH�
�W9725��Kv;9���,{V����3�ys�(yױQ�8	\1F1�-s��D��-��-a�軈Z�a�#�O���hX�Ǯ=E6:F�@q�#���1G�e�D#sEp�[����gkǴ�}�Ul�z��>M)5y
rߊ��x�O[��^sd�r��ZF��9?�w��μe��]]��\_$qQW�LQ��U����W�����Bh났dt�sֺ���]�	��]t�'sRrV�j�4Ne��ܙx�`n���K��O����q�̓i����_���YVh�� iS��WG \)���;�8��tX]ί��O�u�uT�<�ͼx=��81E��߰+*�^E�P�S�,&��b)cnW4�
8�%#F�> +O�����&V�{�+�X0��l�Df�/�~�'�F6��ȭ])*b�u�=ՍƄH8n-5�]2��8P��i��?�.���U�⾟������X'��^��V��cg�.��ft��VuG#Q}S�dU6�1p�	�7�6�̞
� �KV�����1��۲�*9���Y��P}X�4q
^k�^Q��
61�C[�S\<J�İ1A���D�UZ���ƙU�-�q$F�1��DH� mf�9����{k#Ѥ���?ړ���mX+�`#�1��<�#�*f`F7��v���f|
pqv@�6�jL�&b>J} o�������l�d�i�ox�y�mF��ױ���OG'v�;����O�F���ѓWü��9�Ke�*Y���ΌZ��	�*��N�Seb����F�Tt��=\7ܟT�{%1�Ӗ��t20L�J­k�5�|�w�1�?�Q��7��L_	rd��em6��V1�ȠZ����Z����ڝ��Z��F�Yr=ܩ/�����B;�O�o����q��x�~��3Om�]���a���⮯�?�}�z1��2Dk����g��;ȞVȿ����ܓ0x�8䥗�y���W�v�b`Ϗ�P��3td�KU��(��?6{oke��C8ݜ�YW��~�P�Jփc|,ɩe�y���ƌ�\�Q� mU=�D��y�:!�n.%̬���wP�+9`\oz�&��Q���� ub~����ϐi�G1�IfE�����9E����S� /!�(� ���x�\>���A�c�F9w�x���DD|�����>�q'W�[��As�'N\q����{���i�a�눛IAS|�5��:
:�4�wV9�;�|��mP����J��~�]-T<=��� �5�k$��m��b��b����G+|����Bi�����b����V��H�W=��4r���&���Ǻ����?D�7ӳ��w�8��,9+���}a5_�6�sǘ�u5\c�%WT�^ʂ�+�2�����Zg���#�g=m��/ו�8��5߉�~�R�mCZ��JG���B��@���b>W?��6����N�lc�[��1�웚����E�R�+1T�4[
�R�nx�ݫ0�.>�=He���.n3�kg�7�!�!�5]@W�2��#�hi"�Ɖ�$h���gӇ豹���}@��{G�'d8�{Q������yO+��ln�����EDl�����we&��p��A��!Y�:��dD��?Q���������4c�[����h��%u'������Tq"��?ny�� �e�������H�6��D�H�ڌ�����5�F��n����z��Md%j�?�+[����@��'���Z1:g^��*n�$��:�M���tJ�&�-a�D���6�=�g dk�K�I�/Q'�p� �S3���D�~}�-��E�l��&����x⦉{���c������OWD0Һq�ސz���8ǜ���-��:�f�7TW��$0��|\��p+���K��u����/u���a�����~��ʖ֨X���2���5�;���/�Y�NQ� B�I�h0���z��RK�XMg.�*Sm�x�����U{bR�y��U�����M\����8r�+'C)S\��B��^���5����b�S~�1�ڽ��ެHHBc�2B%!�;v�������Vhdo.���Ucb��99����U$�U�	�A�E���~��:Χ�#���I�Լ�D�c�:��|��y5�V�Io����l����\��-�U�u�Y;�&�N��ۄuV�����k�Mr��� fK}"#��*,�*;�uT�u�#��%�reƛ����4�e���\]&[�k�"!v�ϯ�W�M��NY
/~y\�w�E���������/��$#e�ӂ����`{����	�<y|�=���_]��K�;�
����"׷%'i|��ȡ1��c�@��JT��1"��Lx�4\���J�����ƈ� �>o�a�MA��X��F��G&��/n芞k_]�5��;/�t������>n���6�*I�&)_�@V�*�y+Y"N��#�� 9\��� ��od�����E������ �� �����Fk�"#�1��Č�h�Q�D��Ǎ}�_�Uj�B�jW�<+�KH�Fx%j�+bel�������!2�F��ݻ��Uj�������F�"5�o]zג_�O��DO��O��]��E�m���6�	����d����l%���w� ?�g��W돩z�NY7���5�=��WYةg�H�ܚT#G���%.8Ɗ��[�ޱ �:�Ở��|ɜs�T�u(u_mi�f�5��r�.�;h�aT���ය&�P��:�Ⱦ�v��3��蹗�uҧJG�[d�ms3�1[��ֈ�+,a:��(�	�R�")�<��G���~z����<v}� \W<���\���Q�F]���ڲ�<+�!�U�����"8�%$��&��V���D�5�8�c�Qb�p�c����b���!�K��|��?R<:�rB j-� ���%��QY(fyDKRL�[��!��>�w�/T�7ka����81�!�,���`����\�Hn���h	;Z��Į�"�:
��}<yç��g�<`�=v�ⶔ̱�݀Q~]{Q�I���I����#U&$�|N��vh�" ��]�+�\�V��A���M��R�C"\�6����%��@��)��Ɉ�����*8��htxMg4W�r��/��iߪ�L6�r!m�����کRq�H��f����ڬ�9�����h,�,2ߙ+�W5n_O���$�p�˕-&�%�cO4P��睱�v.G��U̱(D�A������7�;�]��W��c{3�Ԙ�̻nC+Nӱ���C?����pg�lةf������H+^���sޞM����ȵ�7 ��j�94�g�}����oV��cF��t�EJ(��|�:��
h�J��
�y�����Ipez ������Օ����V������k,�����P �V�#��o4���m�'Z�i���~{#3il2�.?��:�*;r��[ �\��[[�t/F��BJRX�cKO]V�;���އ�YU�6���=at�]�frqY���7���x�WqJF��d�"j�%Y������J�:����;��gh��U�2C��Y�רє�Y]�)�uZ�8��l�r5��tYl���W8�3�0� æ~]�n��?K����ҷsBd�3�]��X���o5�EQ],u��u�Z��c\w ����z��]7 uϼ0�~e�L��[e���l��@��9��s�jd��?cy�SA
)���$��x��K�<��<K�{^@:��A�\?��So������*3�yh��55%�s��\�e3��Ӎ��Ú;��9� �N݈F�9��2��?DE�$��Ώ�>�|��b�҈�!���j��ZO��o"�Э�d�li� (��U���&l@��6ɐ���,��V��-�A~�'����Kϻ�nv|[��k�n	�;�핎�y��ʚ����뾺��jk����hZ\���B��e��]�[���,��+��sF;#9��+��~+��_+Xr_�Vj�^��lt,\Z]V�����-�z�ꂗq��}N]q�(�O7�9�d#�h�g[V�.�Ϛ3�����
��R��F��:�IfJ�B��g���~���i��� ��s';[r�M�jϏk���z,ZZ�v����:e���)��ڦ՜餎J�7u�6Ha�Q���E���� �� ��RyG�����'�<e,NUcE,��������SF��S��`�Y��-rK�#�_ď�:ˌ��/-���zPj�_���,�|��a�T��4�S#E�zh�����BkF�_t5�/��lMW5��  ���������+���Gʾ�=}x��i��8�٤([�]��hcH٥2�:;����AA1RM1A,��M(�PK$�e�ά*�Y{r>7Ac� Ӫ�<���g9<Uԗ�;���p����dF5��Y�,W���:�<�,�

=�{�����o�@�L�yu7��:i(�h��c���x�N�����*XS?�CI&b@	��̰��e�CR%+�)�1)	��Z���r�������i���dk@�3Gww:���.Q���3�)>şl��3Gs��{�s�Fp�	3���m��,FL<����d�l���ܑ��5�+&�<E?�Tv��~���xƹek���$���k�|�e�e�^ۅ"W�:;��Ư���sKx��4샋g]'g9��oɥ*9=��Z�/�~t�6������*g�m=U�1%;ȜOy�(�h��<K��\RI ������vS�Z�NlʦU�N��x{bw�˿A�����D�V�>,�Ez9]ݭ����x�vb�#����O'w��w�KGS��^v�h�p��d�]������w�L�b�}�NL�1"v�e(��<mt��ʯ� @�|�%�����.�o�v� ��!��J�� W��|/u�Nޞ'�<e���� `Cb$NR�Kc��"sd9�� �\�#�b���{�H�	i$RN�Ϻ��[�J�P��震Me�{-4�

8��@����`g�~����8dC�6B03$;5��Ox��X�Hx9�0a�D����[n� ���:�W�,yۗ�Z�F�%�n.����0�����d����;[�Λ���� T1tg�~#���8\�R+�Z����#(��N�� +e�YS��%�����q��<�����{9���`��Ni�Npш�]؎Z�ȷ�S��ɹ)o�������]����o�pm�k,25z"�J)�BFi5�ϑґ*�]q�;ϸ�tk��:��.D��5T� k��q��|B4KKp�����+���mZ�:�)�6���w��Ҩ�T���"e�P�u�2������%K�oz�y��B��XJеf�����&�R�&h�$�q)��Xƛ�+~�9'��l�~��N�oK%�����<��.!�sز�	q�zj�s��S��������K���ر��Any�^t����G#7�i����w�dZ�M��/=�dB��?c�����
�����G���9�g��hpoM�n��^u��,>{&G$�맖1�h�r\۩��� �TZ����_�5 �)p-F�l�����rX�}s���/�66iFm��wz<�(0���C;����� 6�*<�*�zS�e�MI (�[Ilp֟/.�ݡx�g~q���"c��M
]Ri��F��--]X�X�>n<���NG$�o�{�{1��Êf�*��2�/�^�-6
ЦB���`�,��^����sQXɺ&�Z�V�7�ȁ#S�uc���(�ED���o�|� .��� .� �����>�o�Qr�ʼ
��c��O���Z��6����j�U[�x�����T���w�=d^� ��o�O�� �M�(��&v�,v?�|ܫ��y�;w�����K<����yc��&Jז��#��e6��~�N���|�	�o�;^o��<ky�x[�2�ylm������Ҙ0l�y Q�>���J`G���"�G�4��0p>�ԏO�.��r�v�Uڝ\5m�6��I�O���A�T�u�Dqfkf��g�Va�,S<PQҞGg�� M���׏���k����a� �cZ�xڴ��"�T�*�x&}��J׬b�2�)�FF���I�=I��e�\O���t|g��N4�zr)no��V<��[B�mk��$���Sm+�;jf�t�b;�w)����ע�ŋ!����Zsp�2Hr��HU<yC�c�s��	.<ʿ[�Me���f15�_+C'�M�d�<�?39���t�9mG�j�[v�N�**�����L[1��Z��׿�����;� ����^�.s�U֭�*f����sV֣�o����	�� yΒ:���F5;�'
'��f�e���~q9X�����G�v�v%���<h����e��I��neS1R�Ħ;���,'�� 0s��>��艴�g��9K���ˎc����s���s�h��o�6�+�Q����-GX�q��?���= ��w�/�
o!rV�+ym��f��F�JW�brx��]���d5*�H&��!&ě#dm���� �ӡ���e{��G2���lpvOq� ���"/���o��TU��٩�� �����TE�O���ʿ)��T^��O��������n^⮬�g*��+\���B�<�!Ǵ�6�)�<sv#����UD��1���̏w9-�;H�Bw�����fʹ��@���欛yI�b
�{J��q�Y���b��f�li4c��!-����8[�7��\EB�U�Fۗm�m���/;OOT�6�}fwW��X�P<�a[�'����7��v{]��*�ޚ~�=Fr6Jk���������gQj��6l�6��A v�#d�[��8y~�^ߴ��aQnd��}ˡ��|�Btp9��ڛ�lP��"V{RL�RGT���Ū���_Rf����P�c�����F�YT%CԏCk����ݓ�-��?�������.�>���NM��ʖ
�4.֬����z�W�qVI�^źC�����Ñ�	�U֒Ơ���^�V�mR���}�#�gAzs0�� ����?u�=(q4��p0T��q��}��ডI8�I$&���G�E\D��m
gq2bQ�6ѱ�M���i�;�Y"�[�{[j*,OR)E���Ă�)���f1N��r����MNN���^O]��Y񭾹)��Xu����s=3�NTD[$Z���V<�ĵ�aS�9Z�]�3��WN�:�F�kt� ��h�Ւ�6	��2e(��۴Ixb`�Z��b���:�d�e��{ ��n�
����K����K�������U*�$�c=�~��VŶ�����I!��johU�kty-��A�9��5���OH!q"��$=���^����վ���R]t���]�h�El+�
�?~5Ͱ���Fp=,zĘy��#�8��Yp��o�2��N��(l�V��ṣhcXT�t@T]W�(�����]��0�rv崲d(����҆^�u����@Y�3�>�]l,