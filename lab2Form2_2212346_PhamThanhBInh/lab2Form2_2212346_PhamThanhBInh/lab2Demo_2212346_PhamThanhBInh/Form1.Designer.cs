﻿namespace lab2Demo_2212346_PhamThanhBInh
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
            this.btnTinhTien.Text = "Tính Tiền";
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
            this.lblTongTien.Text = "Tổng Tiền";
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
            this.lblTienTAB.Text = "600.000 đồng";
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
            this.lblTienTAA.Text = "400.000 đồng";
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
            this.lblTienTHB.Text = "500.000 đồng";
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
            this.lblTienTHA.Text = "300.000 đồng";
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
            this.chkTiengAnhB.Text = "Tiếng Anh B";
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
            this.chkTiengAnhA.Text = "Tiếng Anh A";
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
            this.chkTinHocB.Text = "Tin Học B";
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
            this.chkTinHocA.Text = "Tin Học A";
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
            this.lblNgayD,9Nugh{&x́�۴���J���̉xv��N�#zp��)�hl~�*�ٌn�x��vF�m=�1�D�t�jr ��d���|g Cc�:��û�S��ͥ>s���I�AG�ҲKr�ͽ�EÛӰ�ؾ�	xRxM C���&,u�/ccv2�80�Y�-o#�B�Ŧ
�D^�e�
t�{m\4A	~��]���uE�	��"�즘L��n3��/�I
���9���w��K�"��8]W<:��pgz�Jh��B��bQ�␺���5��S�I�s�~ Sg���==�;�_e){ŝ�����8�oj�BO�;�oY���w�%w)A��Y:IZD�v/��]6��W;��Ø���ԕ��9��yD�f�����V����9��"��M����z{ Q���=��3��x��g[� U���[?�-1�V��[3�D�1�Ƀ����q�7Ǆn�&H��]�}ގ���R�p�,E�� p����j6Z���r	)�u�>n�A�w1Do�uKT��t�ᷡ���6<s'�#��<F/fk^�1򎥹K�	�5��.F\��FJ�=�a�}Q�������B�i
L|�[^������eE,�6�Tz�g�H���P!�	D08�@^������#Ҥ�>2Vث�@;���S��<{)��rR�B���yQX��~���͐�-���0n�Z.5�%GD��E&�Ҡ�C�MK��s�
.͇?�Z�=��	�a G��s�]Z?��y�[2�������l��c�����ݶxH
��1�ʗHq�>�˽�+4��i�3�>ڛ�%��k����YT�iW@E�=��������S<��j:N:Հ����i�R�2��V�[`
��θ�&2�1X��	��<1j�mpu C�	�5�#��m� �t=�)��Wg�ty��DO�=�_3d���`�+G�e�|x�u��;y�+;�I1��ǣ��c�n��N��^E&���Dt+3b�1@G�n�IC2�_ &����~�b���`��0��-���Z�y{����)��� �Ė���&Xd��*�S��!i�&�a��)9NU�RP� *n�hc���~|��9h)�E
�Bl��;t�O�5���4�d6T���]����%G��'~�������1�5�'��<��#�����[N=�E".���{���Z ��HiDA8+�v�[��V|m��-<5E��sઇ�ّ�|s���_�%-��~ܓ���x��XIf��͞�6�e7�r�b�1��[�D��;^G�Z6Dar���ϻ[c�"�Z�\��R�_���,�8W�CR?(sO(���k-Bta���*���8���C�A)�g]�>��]��jn�.�X�JcML�F��6rJ��G��	�����cʯqu{VUyD@���B��T�%.�9g2� �Q�X��/�G&��ѳ`���%������$\��:rd�w��.e^-l�L�-��N���`;;��Jy˸���)��(d~M�4)�k����DƦ���8��-<=�7 D�t#:I��
�C�\�GF��l<�v�'�}_ ^�B�S_�w��)a@*U�LC\࿘����F6��P�Ԙsu���)p��]��t�~�����̤ni�*1F��ux q�z�~�ظ,�[�*�1���\!��v���rEIe�z"��m+zAcL��W���m���5JU����<��ls�ɚ �EП <D��,we���q	�PN>���c�G����.�tk־�N_/x�uo�x:Z\��\>�FQ8�<�?}.�d���b4���(v�G�qyf�޶��_����4�	o�wqU�=h((�I����y��q�b�T
pC��Mگ(�3�`���(��%�P�",��d���a�����4�3G�����Qj����:�Bs�-)�a��wL��%�
~2+�SJ�:�|Dv�)d�g"2��i�ܕ��*�V�`�n��1���I�(��&���J�e.�<���
w;�����+IGP��I��A���'���;�0<�9g���=�<@���^��5ԗ��rf^������{��?ߗ�$��t5A&,$�1-1{�Z��\��o-ec'6��x*��M�(n[��n"�Y��w��:���g��	lʲ�sA��'�o���(�K�M��w�x޴@�f!]W�R���h�zC6j�q���
ER>t��!J)F^���
���k�K)\%>�,-3���V,D�%S#�)��V³���j�щ��$}���7l��)D�C�zgZ�d�l��7[��#m�/�0���#?���͔��-�+�bvBY������K4 w�n�H�c�2��(
@L��6"�e}&��n�hj2�h��O&գX��%~%Ȼ�S��H5%kß\w�_��衉el�0���2��0�/Eٖ(�5(��(��c�o㬰)E�Ȧm;İ�mX�t
�="��̽Ćb��� a|Q[ ��>����5�f�Z:H��@?zj_�$��~&�լ��e�u��JyZ͆Z�0yC6	�L��@������Zm���yL�5��uD�h�q�2`p=�R��=D�tG�t��y�I
0���4^��!�����=�>n-��~y�@���@(�*�}u�������Q]��L��&� ��~"�E.�X��bp�;��AJc
�.�;wWYĄ�V�!�0��@ha�B)R��8Ҁ���f�,���T	��e�^��!����B���J썒x��z��
:W�p����R��K�n�#mg�.!䴗�RhXD�\�Џ^P� >=���B#��y-y{jѹ�V#d�
y!�$�eق@�"2�������1qV��nsظ�����8UD�x�2)��S�	F�z��D �jnE���6䓺M%rw��dٺւS����q��EO� �O������o�v��F����G�j�kL��C�S0��̎F#`�oPO��_�m�S���Qϩ��6���L?��p�D�]w ��u� V��״�"A��uf�3~�λ|Pl����ѥ�r�FQ��	���i;��dw�UY�Z�59�P�!^ �y܏��'
6���Jue�u�X�O�ͥ7��%MA�d�p-�
�5�u�C�
��	�"���ϸ�f,R�pm���9&h���ڛ�p�&UO�����?jQ��!���5S-��أ÷g
��ON���!�^��|��&<�w<��ϊP{�<
=�뤩������
���-�1&0��5�^+��[���e��l�"��: ��+���%�r�r���t���%���NxL��cqv��5]ɼ�&6n�3����Z3�ͅ��Z5�u)�y��b��� �\��^����kt$;����g��-��-�餱�.��C��6�S�A� Gl���=DUr�i���q/l:-��\$�SCc�\�����h/n/�6|�-�����X����	��`��Ǔ3e��`2[�N�肰�Q'��޲���|��X�
�)
n�w$P ��ݫm�2�X�
�!��+���s��Ű��5�f�Ŕ�6�gN˗��ڊQ����k���xFhv�G<���M�x���iA����c��2}
�0�e ��E�.�Q�WA�D��lyn�У��P�[>H���l�����1����i�+���8�n���r�3����M�Ÿ��y�a���|�
�f~nS�:���L� ����P�� ��݂f�3�BF�,	x�˂w��c+���E���D˙�	�/7�|�H�(�}���
![y�t�f'ݪ���N�����V�ry�[��ϓn�q��+��IyU{8v�(�n��I��^��$<����B~gC��i��)T���10�z-7���8dr�1�:���>��
=��M'��}A�N7%W�,�Ѐ�b<~>y��wYͿ08a7���"�bOְx��� ����}kE��e��Z=�������;h���^���f\|���o5Yټb����
�pz���D�9��'S�Bʋ��BmI܊|^��f*�p�iBT#Nuz�����u�;StL�VL��mig���)����Դ��<>��~�b6�9rwJ�J�����8�+5ZK��o|s2Z��φ[by�K2`��d"��"Ԅ���'�\9���&�R79:���\9��+'�B;9����N�rri�[��|C:�b�UI��#��̲/1��FcI����
CM��'��\�ٔ����9������@W��Q�pwWF��^K?����}*��j ��@��D�L�UZTkf'�(�A�d��%�m��N��M��N��<�c�c�Q۶�D�J28^hUe9?�1ͶG�NDYt �tE�f�C	�9�eLh-�&�f�&�u�h��O�nE��D8"{����+_kF�b��W h���U�����h�t�p���D3+�h���h�C�6�����^3X�������]
���֤-wr�>Oi[�)^kS���S���������'���s��2���,=���H~���D<��ı9�|B��
eTٽh�ǣ�Z&����@�h����������x���}��{���4
��&F	��d䱭��[�>*�ه���������m&���Ld�C�����!�nҚ��9:[�C����-^��9@	��ݰ~G��~um�*�����Pb��ۤ���,#~͠kM�C�x�<�������6l�YPȳ��,(S����f�)��7��� ��6�ǂK�ф�R���a��BBݕ�V��e�^��}�j