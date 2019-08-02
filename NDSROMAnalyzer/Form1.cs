using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NDSROMAnalyzerHeaderEditor;

namespace NDSROMAnalyzer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetTextBoxesReadOnly();
        }

        private void openROMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = @"Open file...";
            openFileDialog.Filter = @"nds files (*.nds)|*.nds|All files (*.*)|*.*";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;

                ParseROMFile(path);
            }
            
        }

        private void ParseROMFile(string path)
        {
            NDSROMInfo ndsRomInfo = new NDSROMInfo(path);

            // ORIGINAL NDS ENTRIES
            textBoxGameTitle.Text = ndsRomInfo.GetGameTitle();
            textBoxGameCode.Text = ndsRomInfo.GetGameCode();
            textBoxMakerCode.Text = ndsRomInfo.GetMakerCode();
            textBoxUnitCode.Text = ndsRomInfo.GetUnitCode();
            textBoxEncryptionSeedSelect.Text = ndsRomInfo.GetEncryptionSeedSelect();
            textBoxDeviceCapacity.Text = ndsRomInfo.GetDeviceCapacity();
            textBoxReserved.Text = ndsRomInfo.GetReserved();
            textBoxGameRevision.Text = ndsRomInfo.GetGameRevision();
            textBoxRomVersion.Text = ndsRomInfo.GetROMVersion();
            textBoxInternalFlags.Text = ndsRomInfo.GetInternalFlags();
            textBoxArm9RomOffset.Text = ndsRomInfo.GetARM9ROMOffset();
            textBoxArm9EntryAddress.Text = ndsRomInfo.GetARM9EntryAddress();
            textBoxArm9LoadAddress.Text = ndsRomInfo.GetARM9LoadAddress();
            textBoxArm9Size.Text = ndsRomInfo.GetARM9Size();
            textBoxArm7RomOffset.Text = ndsRomInfo.GetARM7RomOffset();
            textBoxArm7EntryAddress.Text = ndsRomInfo.GetARM7EntryAddress();
            textBoxArm7LoadAddress.Text = ndsRomInfo.GetARM7LoadAddress();
            textBoxArm7Size.Text = ndsRomInfo.GetARM7Size();
            textBoxFileNameTableOffset.Text = ndsRomInfo.GetFileNameTableOffset();
            textBoxFileNameTableLength.Text = ndsRomInfo.GetFileNameTableLength();
            textBoxFileAllocationTableOffset.Text = ndsRomInfo.GetFileAllocationTableOffset();
            textBoxFileAllocationTableLength.Text = ndsRomInfo.GetFileAllocationTableLength();
            textBoxArm9OverlayOffset.Text = ndsRomInfo.GetARM9OverlayOffset();
            textBoxArm9OverlayLength.Text = ndsRomInfo.GetARM9OverlayLength();
            textBoxArm7OverlayOffset.Text = ndsRomInfo.GetARM7OverlayOffset();
            textBoxArm7OverlayLength.Text = ndsRomInfo.GetARM7OverlayLength();
            textBoxNormalCardControlRegisterSettings.Text = ndsRomInfo.GetNormalCardControlRegisterSettings();
            textBoxSecureCardControlRegisterSettings.Text = ndsRomInfo.GetSecureCardControlRegisterSettings();
            textBoxIconBannerOffset.Text = ndsRomInfo.GetIconBannerOffset();
            textBoxSecureArea2KCrc.Text = ndsRomInfo.GetSecureArea2KCRC();
            textBoxSecureTramsferTimeout.Text = ndsRomInfo.GetSecureTransferTimeout();
            textBoxArm9Autoload.Text = ndsRomInfo.GetARM9Autload();
            textBoxArm7Autoload.Text = ndsRomInfo.GetARM7Autload();
            textBoxSecureDisable.Text = ndsRomInfo.GetSecureDisable();
            textBoxNtrRegionRomSize.Text = ndsRomInfo.GetNTRRegionROMSize();
            textBoxHeaderSize.Text = ndsRomInfo.GetHeaderSize();
            textBoxReserved2.Text = ndsRomInfo.GetReserved2();
            textBoxNintendoLogo.Text = ndsRomInfo.GetNintendoLogo();
            textBoxNintendoLogoCrc.Text = ndsRomInfo.GetNintendoLogoCRC();
            textBoxHeaderCrc.Text = ndsRomInfo.GetHeaderCRC();
            textBoxDebuggerReserved.Text = ndsRomInfo.GetDebuggerReserved();

            // EXTENDED DSi ENTRIES
            textBoxGlobalMbk1ToMbk5Settings.Text = ndsRomInfo.GetGlobalMBK1ToMBK5Settings();
            textBoxLocalMbk6ToMbk8SettingsForArm9.Text = ndsRomInfo.GetLocalMBK6ToMBK8SettingsForARM9();
            textBoxLocalMbk6ToMbk8SettingsForArm7.Text = ndsRomInfo.GetLocalMBK6ToMBK8SettingsForARM7();
            textBoxGlobalMbk9Setting.Text = ndsRomInfo.GetGlobalMBK9Setting();
            textBoxRegionFlags.Text = ndsRomInfo.GetRegionFlags();
            textBoxAccessControl.Text = ndsRomInfo.GetAccessControl();
            textBoxArm7ScfgExtMask.Text = ndsRomInfo.GetARM7SCFGEXTMask();
            textBoxReservedFlags.Text = ndsRomInfo.GetReservedFlags();
            textBoxArm9iRomOffset.Text = ndsRomInfo.GetARM9iROMOffset();
            textBoxReserved3.Text = ndsRomInfo.GetReserved3();
            textBoxArm9iLoadAddress.Text = ndsRomInfo.GetARM9iLoadAddress();
            textBoxArm9iSize.Text = ndsRomInfo.GetARM9iSize();
            textBoxArm7iRomOffset.Text = ndsRomInfo.GetARM7iROMOffset();
            textBoxPointerToBaseAddress.Text = ndsRomInfo.GetPointerTobaseAddress();
            textBoxArm7iLoadAddress.Text = ndsRomInfo.GetARM7iLoadAddress();
            textBoxArm7iSize.Text = ndsRomInfo.GetARM7iSize();
            textBoxDigestNtrRegionOffset.Text = ndsRomInfo.GetDigestNTRRegionOffset();
            textBoxDigestNtrRegionLength.Text = ndsRomInfo.GetDigestNTRRegionLength();
            textBoxDigestTwlRegionOffset.Text = ndsRomInfo.GetDigestTWLRegionOffset();
            textBoxDigestTwlRegionLength.Text = ndsRomInfo.GetDigestTWLRegionLength();
            textBoxDigestSectorHashtableOffset.Text = ndsRomInfo.GetDigestSectorHashtableOffset();
            textBoxDigestSectorHashtableLength.Text = ndsRomInfo.GetDigestSectorHashtableLength();
            textBoxDigestBlockHashtableOffset.Text = ndsRomInfo.GetDigestBlockHashtableOffset();
            textBoxDigestBlockHashtableLength.Text = ndsRomInfo.GetDigestBlockHashtableLength();
            textBoxDigestSectorSize.Text = ndsRomInfo.GetDigestSectorSize();
            textBoxDigestBlockSectorcount.Text = ndsRomInfo.GetDigestBlockSectorCount();
            textBoxIconBannerSize.Text = ndsRomInfo.GetIconBannerSize();
            textBoxIconBannerSize.Text = ndsRomInfo.GetIconBannerSize();
            textBoxUnknown.Text = ndsRomInfo.GetUnknown();
            textBoxNtrTwlRegionRomSize.Text = ndsRomInfo.GetNTRTWLRegionROMSize();
            textBoxUnknown2.Text = ndsRomInfo.GetUnknown2();
            textBoxModcryptArea1Offset.Text = ndsRomInfo.GetModcryptArea1Offset();
            textBoxModcryptArea1Size.Text = ndsRomInfo.GetModcryptArea1Size();
            textBoxModcryptArea2Offset.Text = ndsRomInfo.GetModcryptArea2Offset();
            textBoxModcryptArea2Size.Text = ndsRomInfo.GetModcryptArea2Size();
            textBoxTitleId.Text = ndsRomInfo.GetTitleID();
            textBoxDsiWarePublicSavSize.Text = ndsRomInfo.GetDSIWarePublicSavSize();
            textBoxDsiWarePrivateSavSize.Text = ndsRomInfo.GetDSIWarePrivateSavSize();
            textBoxReservedZero.Text = ndsRomInfo.GetReservedZero();
            textBoxUnknown3.Text = ndsRomInfo.GetUnknown3();
            textBoxArm9ESASha1HmacHash.Text = ndsRomInfo.GetARM9WithEncryptedSecureAreaSHA1HMACHash();
            textBoxArm7Sha1HmacHash.Text = ndsRomInfo.GetARM7SHA1HMACHash();
            textBoxDigestMasterSha1HmacHash.Text = ndsRomInfo.GetDigestMasterSHA1HMACHash();
            textBoxBannerSha1HmacHash.Text = ndsRomInfo.GetBannerSHA1HMACHash();
            textBoxArm9iDecrypedSha1HmacHash.Text = ndsRomInfo.GetARM9iSHA1HMACHash();
            textBoxArm7iDecryptedSha1HmacHash.Text = ndsRomInfo.GetARM7iSHA1HMACHash();
            textBoxReserved4.Text = ndsRomInfo.GetReserved4();
            textBoxArm9WSASha1HmacHash.Text = ndsRomInfo.GetARM9WithoutSecureAreaSHA1HMACHash();
            textBoxReserved5.Text = ndsRomInfo.GetReserved5();
            textBoxReservedUncheckedRegion.Text = ndsRomInfo.GetReservedDebug();
            textBoxRsaSignature.Text = ndsRomInfo.GetRSASignature();
        }

        private void SetTextBoxesReadOnly()
        {
            foreach (Control control in Controls)
            {
                if (control is GroupBox)
                {
                    foreach (Control gbControl in control.Controls)
                    {
                        if (gbControl is TextBox)
                        {
                            TextBox textBox = (TextBox)gbControl;
                            textBox.ReadOnly = true;
                        }
                    }
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }
    }
}
