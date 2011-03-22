#pragma once


namespace xinrongys {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Form1 ���K�n
	///
	/// ĵ�i: �p�G�z�ܧ�o�����O���W�١A�N�����ܧ�P�o�����O�Ҩ̾ڤ��Ҧ� .resx �ɮ����p��
	///          Managed �귽�sĶ���u�㪺 'Resource File Name' �ݩʡC
	///          �_�h�A�o�ǳ]�p�u��
	///          �N�L�k�P�o�Ӫ�����p����a�y�t�Ƹ귽
	///          ���T���ʡC
	/// </summary>
	public ref class Form1 : public System::Windows::Forms::Form
	{
	public:
		Form1(void)
		{
			InitializeComponent();
			//
			//TODO: �b���[�J�غc�禡�{���X
			//
		}

	protected:
		/// <summary>
		/// �M������ϥΤ����귽�C
		/// </summary>
		~Form1()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::ToolStripContainer^  toolStripContainer1;
	protected: 
	private: System::Windows::Forms::StatusStrip^  statusStrip;
	private: System::Windows::Forms::ToolStrip^  toolStrip;
	private: System::Windows::Forms::ToolStripButton^  addButton;
	private: System::Windows::Forms::ToolStripButton^  editButton;
	private: System::Windows::Forms::ToolStripButton^  delButton;
	private: System::Windows::Forms::ToolStripButton^  refreshButton;
	private: System::Windows::Forms::TabControl^  tabControl;
	private: System::Windows::Forms::TabPage^  customerPage;
	private: System::Windows::Forms::TabPage^  supplierPage;
	private: System::Windows::Forms::TabPage^  makingPage;
	private: System::Windows::Forms::TabPage^  daomuPage;






	private:
		/// <summary>
		/// �]�p�u��һݪ��ܼơC
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// �����]�p�u��䴩�һݪ���k - �ФŨϥε{���X�s�边�ק�o�Ӥ�k�����e�C
		///
		/// </summary>
		void InitializeComponent(void)
		{
			System::ComponentModel::ComponentResourceManager^  resources = (gcnew System::ComponentModel::ComponentResourceManager(Form1::typeid));
			this->toolStripContainer1 = (gcnew System::Windows::Forms::ToolStripContainer());
			this->statusStrip = (gcnew System::Windows::Forms::StatusStrip());
			this->toolStrip = (gcnew System::Windows::Forms::ToolStrip());
			this->addButton = (gcnew System::Windows::Forms::ToolStripButton());
			this->editButton = (gcnew System::Windows::Forms::ToolStripButton());
			this->delButton = (gcnew System::Windows::Forms::ToolStripButton());
			this->refreshButton = (gcnew System::Windows::Forms::ToolStripButton());
			this->tabControl = (gcnew System::Windows::Forms::TabControl());
			this->customerPage = (gcnew System::Windows::Forms::TabPage());
			this->supplierPage = (gcnew System::Windows::Forms::TabPage());
			this->makingPage = (gcnew System::Windows::Forms::TabPage());
			this->daomuPage = (gcnew System::Windows::Forms::TabPage());
			this->toolStripContainer1->BottomToolStripPanel->SuspendLayout();
			this->toolStripContainer1->ContentPanel->SuspendLayout();
			this->toolStripContainer1->TopToolStripPanel->SuspendLayout();
			this->toolStripContainer1->SuspendLayout();
			this->toolStrip->SuspendLayout();
			this->tabControl->SuspendLayout();
			this->SuspendLayout();
			// 
			// toolStripContainer1
			// 
			// 
			// toolStripContainer1.BottomToolStripPanel
			// 
			this->toolStripContainer1->BottomToolStripPanel->Controls->Add(this->statusStrip);
			// 
			// toolStripContainer1.ContentPanel
			// 
			this->toolStripContainer1->ContentPanel->Controls->Add(this->tabControl);
			this->toolStripContainer1->ContentPanel->Size = System::Drawing::Size(792, 526);
			this->toolStripContainer1->Dock = System::Windows::Forms::DockStyle::Fill;
			this->toolStripContainer1->Location = System::Drawing::Point(0, 0);
			this->toolStripContainer1->Name = L"toolStripContainer1";
			this->toolStripContainer1->Size = System::Drawing::Size(792, 573);
			this->toolStripContainer1->TabIndex = 0;
			this->toolStripContainer1->Text = L"toolStripContainer1";
			// 
			// toolStripContainer1.TopToolStripPanel
			// 
			this->toolStripContainer1->TopToolStripPanel->Controls->Add(this->toolStrip);
			// 
			// statusStrip
			// 
			this->statusStrip->Dock = System::Windows::Forms::DockStyle::None;
			this->statusStrip->Location = System::Drawing::Point(0, 0);
			this->statusStrip->Name = L"statusStrip";
			this->statusStrip->Size = System::Drawing::Size(792, 22);
			this->statusStrip->TabIndex = 0;
			// 
			// toolStrip
			// 
			this->toolStrip->Dock = System::Windows::Forms::DockStyle::None;
			this->toolStrip->Items->AddRange(gcnew cli::array< System::Windows::Forms::ToolStripItem^  >(4) {this->addButton, this->editButton, 
				this->delButton, this->refreshButton});
			this->toolStrip->Location = System::Drawing::Point(3, 0);
			this->toolStrip->Name = L"toolStrip";
			this->toolStrip->Size = System::Drawing::Size(104, 25);
			this->toolStrip->TabIndex = 0;
			// 
			// addButton
			// 
			this->addButton->DisplayStyle = System::Windows::Forms::ToolStripItemDisplayStyle::Image;
			this->addButton->Image = (cli::safe_cast<System::Drawing::Image^  >(resources->GetObject(L"addButton.Image")));
			this->addButton->ImageTransparentColor = System::Drawing::Color::Magenta;
			this->addButton->Name = L"addButton";
			this->addButton->Size = System::Drawing::Size(23, 22);
			this->addButton->Text = L"�s�W���";
			// 
			// editButton
			// 
			this->editButton->DisplayStyle = System::Windows::Forms::ToolStripItemDisplayStyle::Image;
			this->editButton->Image = (cli::safe_cast<System::Drawing::Image^  >(resources->GetObject(L"editButton.Image")));
			this->editButton->ImageTransparentColor = System::Drawing::Color::Magenta;
			this->editButton->Name = L"editButton";
			this->editButton->Size = System::Drawing::Size(23, 22);
			this->editButton->Text = L"�ק���";
			// 
			// delButton
			// 
			this->delButton->DisplayStyle = System::Windows::Forms::ToolStripItemDisplayStyle::Image;
			this->delButton->Image = (cli::safe_cast<System::Drawing::Image^  >(resources->GetObject(L"delButton.Image")));
			this->delButton->ImageTransparentColor = System::Drawing::Color::Magenta;
			this->delButton->Name = L"delButton";
			this->delButton->Size = System::Drawing::Size(23, 22);
			this->delButton->Text = L"�R�����";
			// 
			// refreshButton
			// 
			this->refreshButton->DisplayStyle = System::Windows::Forms::ToolStripItemDisplayStyle::Image;
			this->refreshButton->Image = (cli::safe_cast<System::Drawing::Image^  >(resources->GetObject(L"refreshButton.Image")));
			this->refreshButton->ImageTransparentColor = System::Drawing::Color::Magenta;
			this->refreshButton->Name = L"refreshButton";
			this->refreshButton->Size = System::Drawing::Size(23, 22);
			this->refreshButton->Text = L"���s��z";
			// 
			// tabControl
			// 
			this->tabControl->Controls->Add(this->customerPage);
			this->tabControl->Controls->Add(this->supplierPage);
			this->tabControl->Controls->Add(this->makingPage);
			this->tabControl->Controls->Add(this->daomuPage);
			this->tabControl->Location = System::Drawing::Point(3, 3);
			this->tabControl->Name = L"tabControl";
			this->tabControl->SelectedIndex = 0;
			this->tabControl->Size = System::Drawing::Size(786, 520);
			this->tabControl->TabIndex = 0;
			// 
			// customerPage
			// 
			this->customerPage->Location = System::Drawing::Point(4, 22);
			this->customerPage->Name = L"customerPage";
			this->customerPage->Padding = System::Windows::Forms::Padding(3);
			this->customerPage->Size = System::Drawing::Size(778, 494);
			this->customerPage->TabIndex = 0;
			this->customerPage->Text = L"�Ȥ�򥻸��";
			this->customerPage->UseVisualStyleBackColor = true;
			// 
			// supplierPage
			// 
			this->supplierPage->Location = System::Drawing::Point(4, 22);
			this->supplierPage->Name = L"supplierPage";
			this->supplierPage->Padding = System::Windows::Forms::Padding(3);
			this->supplierPage->Size = System::Drawing::Size(778, 494);
			this->supplierPage->TabIndex = 1;
			this->supplierPage->Text = L"�����Ӱ򥻸��";
			this->supplierPage->UseVisualStyleBackColor = true;
			// 
			// makingPage
			// 
			this->makingPage->Location = System::Drawing::Point(4, 22);
			this->makingPage->Name = L"makingPage";
			this->makingPage->Padding = System::Windows::Forms::Padding(3);
			this->makingPage->Size = System::Drawing::Size(778, 494);
			this->makingPage->TabIndex = 2;
			this->makingPage->Text = L"���ư򥻸��";
			this->makingPage->UseVisualStyleBackColor = true;
			// 
			// daomuPage
			// 
			this->daomuPage->Location = System::Drawing::Point(4, 22);
			this->daomuPage->Name = L"daomuPage";
			this->daomuPage->Size = System::Drawing::Size(778, 494);
			this->daomuPage->TabIndex = 3;
			this->daomuPage->Text = L"�M�Ұ򥻸��";
			this->daomuPage->UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 12);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(792, 573);
			this->Controls->Add(this->toolStripContainer1);
			this->Name = L"Form1";
			this->Text = L"Form1";
			this->toolStripContainer1->BottomToolStripPanel->ResumeLayout(false);
			this->toolStripContainer1->BottomToolStripPanel->PerformLayout();
			this->toolStripContainer1->ContentPanel->ResumeLayout(false);
			this->toolStripContainer1->TopToolStripPanel->ResumeLayout(false);
			this->toolStripContainer1->TopToolStripPanel->PerformLayout();
			this->toolStripContainer1->ResumeLayout(false);
			this->toolStripContainer1->PerformLayout();
			this->toolStrip->ResumeLayout(false);
			this->toolStrip->PerformLayout();
			this->tabControl->ResumeLayout(false);
			this->ResumeLayout(false);

		}
#pragma endregion
	};
}

