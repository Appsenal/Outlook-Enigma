
namespace Outlook_Enigma
{
    [System.ComponentModel.ToolboxItemAttribute(false)]
    partial class EnigmaForm : Microsoft.Office.Tools.Outlook.FormRegionBase
    {
        public EnigmaForm(Microsoft.Office.Interop.Outlook.FormRegion formRegion)
            : base(Globals.Factory, formRegion)
        {
            this.InitializeComponent();
        }

        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Form Region Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private static void InitializeManifest(Microsoft.Office.Tools.Outlook.FormRegionManifest manifest, Microsoft.Office.Tools.Outlook.Factory factory)
        {
            manifest.FormRegionName = "Enigma Form";
            manifest.ShowReadingPane = false;

        }

        #endregion

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.KeyTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MessageTxt = new System.Windows.Forms.RichTextBox();
            this.DecipherBtn = new System.Windows.Forms.Button();
            this.ResultTxt = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CipherBtn = new System.Windows.Forms.Button();
            this.LoadMsgBtn = new System.Windows.Forms.Button();
            this.ComposeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Key:";
            // 
            // KeyTxt
            // 
            this.KeyTxt.Location = new System.Drawing.Point(55, 16);
            this.KeyTxt.Name = "KeyTxt";
            this.KeyTxt.Size = new System.Drawing.Size(100, 22);
            this.KeyTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Message:";
            // 
            // MessageTxt
            // 
            this.MessageTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MessageTxt.Location = new System.Drawing.Point(16, 75);
            this.MessageTxt.Name = "MessageTxt";
            this.MessageTxt.Size = new System.Drawing.Size(938, 271);
            this.MessageTxt.TabIndex = 3;
            this.MessageTxt.Text = "";
            // 
            // DecipherBtn
            // 
            this.DecipherBtn.Location = new System.Drawing.Point(362, 12);
            this.DecipherBtn.Name = "DecipherBtn";
            this.DecipherBtn.Size = new System.Drawing.Size(94, 56);
            this.DecipherBtn.TabIndex = 4;
            this.DecipherBtn.Text = "Decrypt Message";
            this.DecipherBtn.UseVisualStyleBackColor = true;
            this.DecipherBtn.Click += new System.EventHandler(this.DecipherBtn_Click);
            // 
            // ResultTxt
            // 
            this.ResultTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultTxt.Location = new System.Drawing.Point(16, 369);
            this.ResultTxt.Name = "ResultTxt";
            this.ResultTxt.Size = new System.Drawing.Size(938, 321);
            this.ResultTxt.TabIndex = 5;
            this.ResultTxt.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Result:";
            // 
            // CipherBtn
            // 
            this.CipherBtn.Location = new System.Drawing.Point(261, 12);
            this.CipherBtn.Name = "CipherBtn";
            this.CipherBtn.Size = new System.Drawing.Size(95, 56);
            this.CipherBtn.TabIndex = 7;
            this.CipherBtn.Text = "Encrypt Message";
            this.CipherBtn.UseVisualStyleBackColor = true;
            this.CipherBtn.Click += new System.EventHandler(this.CipherBtn_Click);
            // 
            // LoadMsgBtn
            // 
            this.LoadMsgBtn.Location = new System.Drawing.Point(161, 12);
            this.LoadMsgBtn.Name = "LoadMsgBtn";
            this.LoadMsgBtn.Size = new System.Drawing.Size(94, 56);
            this.LoadMsgBtn.TabIndex = 8;
            this.LoadMsgBtn.Text = "Load Message";
            this.LoadMsgBtn.UseVisualStyleBackColor = true;
            this.LoadMsgBtn.Click += new System.EventHandler(this.LoadMsgBtn_Click);
            // 
            // ComposeBtn
            // 
            this.ComposeBtn.Location = new System.Drawing.Point(462, 11);
            this.ComposeBtn.Name = "ComposeBtn";
            this.ComposeBtn.Size = new System.Drawing.Size(118, 57);
            this.ComposeBtn.TabIndex = 9;
            this.ComposeBtn.Text = "Compose Email from Result";
            this.ComposeBtn.UseVisualStyleBackColor = true;
            this.ComposeBtn.Click += new System.EventHandler(this.ComposeBtn_Click);

            // 
            // Enigma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ComposeBtn);
            this.Controls.Add(this.LoadMsgBtn);
            this.Controls.Add(this.CipherBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ResultTxt);
            this.Controls.Add(this.DecipherBtn);
            this.Controls.Add(this.MessageTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.KeyTxt);
            this.Controls.Add(this.label1);
            this.Name = "Enigma";
            this.Size = new System.Drawing.Size(970, 712);
            //this.FormRegionShowing += new System.EventHandler(this.InboxAnalytics_FormRegionShowing);
            //this.FormRegionClosed += new System.EventHandler(this.InboxAnalytics_FormRegionClosed);
            
            //components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.FormRegionShowing += new System.EventHandler(this.EnigmaForm_FormRegionShowing);
            this.FormRegionClosed += new System.EventHandler(this.EnigmaForm_FormRegionClosed);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox KeyTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox MessageTxt;
        private System.Windows.Forms.Button DecipherBtn;
        private System.Windows.Forms.RichTextBox ResultTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CipherBtn;
        private System.Windows.Forms.Button LoadMsgBtn;
        private System.Windows.Forms.Button ComposeBtn;

        public partial class EnigmaFormFactory : Microsoft.Office.Tools.Outlook.IFormRegionFactory
        {
            public event Microsoft.Office.Tools.Outlook.FormRegionInitializingEventHandler FormRegionInitializing;

            private Microsoft.Office.Tools.Outlook.FormRegionManifest _Manifest;

            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public EnigmaFormFactory()
            {
                this._Manifest = Globals.Factory.CreateFormRegionManifest();
                EnigmaForm.InitializeManifest(this._Manifest, Globals.Factory);
                this.FormRegionInitializing += new Microsoft.Office.Tools.Outlook.FormRegionInitializingEventHandler(this.EnigmaFormFactory_FormRegionInitializing);
            }

            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public Microsoft.Office.Tools.Outlook.FormRegionManifest Manifest
            {
                get
                {
                    return this._Manifest;
                }
            }

            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            Microsoft.Office.Tools.Outlook.IFormRegion Microsoft.Office.Tools.Outlook.IFormRegionFactory.CreateFormRegion(Microsoft.Office.Interop.Outlook.FormRegion formRegion)
            {
                EnigmaForm form = new EnigmaForm(formRegion);
                form.Factory = this;
                return form;
            }

            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            byte[] Microsoft.Office.Tools.Outlook.IFormRegionFactory.GetFormRegionStorage(object outlookItem, Microsoft.Office.Interop.Outlook.OlFormRegionMode formRegionMode, Microsoft.Office.Interop.Outlook.OlFormRegionSize formRegionSize)
            {
                throw new System.NotSupportedException();
            }

            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            bool Microsoft.Office.Tools.Outlook.IFormRegionFactory.IsDisplayedForItem(object outlookItem, Microsoft.Office.Interop.Outlook.OlFormRegionMode formRegionMode, Microsoft.Office.Interop.Outlook.OlFormRegionSize formRegionSize)
            {
                if (this.FormRegionInitializing != null)
                {
                    Microsoft.Office.Tools.Outlook.FormRegionInitializingEventArgs cancelArgs = Globals.Factory.CreateFormRegionInitializingEventArgs(outlookItem, formRegionMode, formRegionSize, false);
                    this.FormRegionInitializing(this, cancelArgs);
                    return !cancelArgs.Cancel;
                }
                else
                {
                    return true;
                }
            }

            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            Microsoft.Office.Tools.Outlook.FormRegionKindConstants Microsoft.Office.Tools.Outlook.IFormRegionFactory.Kind
            {
                get
                {
                    return Microsoft.Office.Tools.Outlook.FormRegionKindConstants.WindowsForms;
                }
            }
        }
    }

    partial class WindowFormRegionCollection
    {
        internal EnigmaForm EnigmaForm
        {
            get
            {
                foreach (var item in this)
                {
                    if (item.GetType() == typeof(EnigmaForm))
                        return (EnigmaForm)item;
                }
                return null;
            }
        }
    }
}
