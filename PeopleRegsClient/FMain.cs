using Microsoft.Reporting.WinForms;
using PeopleRegsClient.Import;
using PeopleRegsClient.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeopleRegsClient
{
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
        }

        private List<PersonRegistration> data;
        private List<PersonRegistration> filteredData;

        private void loadFilterOptions()
        {
            using (var context = new MainContext())
            {
                string editValue = filterCountryEdit.Text;
                filterCountryEdit.DataSource = context.Countries.ToList();
                filterCountryEdit.Text = editValue;

                editValue = filterCityEdit.Text;
                filterCityEdit.DataSource = context.PersonRegistrations.Select(r => r.City).Distinct().ToList();
                filterCityEdit.Text = editValue;

                editValue = filterOriginCityEdit.Text;
                filterOriginCityEdit.DataSource = context.OriginCities.ToList();
                filterOriginCityEdit.Text = editValue;

                editValue = filterOccupationEdit.Text;
                filterOccupationEdit.DataSource = context.Occupations.ToList();
                filterOccupationEdit.Text = editValue;

                editValue = filterQualificationEdit.Text;
                filterQualificationEdit.DataSource = context.Qualifications.ToList();
                filterQualificationEdit.Text = editValue;

                editValue = filterVotingRegistrationStatusEdit.Text;
                filterVotingRegistrationStatusEdit.DataSource = context.VotingRegistrationStatuses.ToList();
                filterVotingRegistrationStatusEdit.Text = editValue;

                editValue = filterVotingRegistrationCityEdit.Text;
                filterVotingRegistrationCityEdit.DataSource = context.OriginCities.ToList();
                filterVotingRegistrationCityEdit.Text = editValue;
            }
        }

        private void loadData()
        {
            using (var context = new MainContext())
            {
                data = context.PersonRegistrations
                    .Include(p => p.Country)
                    .Include(p => p.OriginCity)
                    .Include(p => p.Occupation)
                    .Include(p => p.Qualification)
                    .Include(p => p.VotingRegistrationStatus)
                    .Include(p => p.VotingRegistrationCity)
                    .Include(p => p.CreatedBy).ToList();
            }
        }

        private void filterData()
        {
            Func<PersonRegistration, bool> countryFilter = pr => true;
            if (filterCountryEdit.Text.Trim() != "")
            {
                countryFilter = pr => pr.Country.Name.ToLower() == filterCountryEdit.Text.ToLower();
            }

            Func<PersonRegistration, bool> cityFilter = pr => true;
            if (filterCityEdit.Text.Trim() != "")
            {
                cityFilter = pr => pr.City.ToLower() == filterCityEdit.Text.ToLower();
            }

            Func<PersonRegistration, bool> originCityFilter = pr => true;
            if (filterOriginCityEdit.Text.Trim() != "")
            {
                originCityFilter = pr => pr.OriginCity.Name.ToLower() == filterOriginCityEdit.Text.ToLower();
            }

            Func<PersonRegistration, bool> occupationFilter = pr => true;
            if (filterOccupationEdit.Text.Trim() != "")
            {
                occupationFilter = pr => pr.Occupation.Name.ToLower() == filterOccupationEdit.Text.ToLower();
            }

            Func<PersonRegistration, bool> qualificationFilter = pr => true;
            if (filterQualificationEdit.Text.Trim() != "")
            {
                qualificationFilter = pr => pr.Qualification.Name.ToLower() == filterQualificationEdit.Text.ToLower();
            }

            Func<PersonRegistration, bool> votedOnPreviousElectionsFilter = pr => true;
            if (filterVotedOnPreviousElectionsEdit.CheckState == CheckState.Checked)
            {
                votedOnPreviousElectionsFilter = pr => pr.VotedOnPreviousElections == true;
            }
            else if (filterVotedOnPreviousElectionsEdit.CheckState == CheckState.Unchecked)
            {
                votedOnPreviousElectionsFilter = pr => pr.VotedOnPreviousElections == false;
            }

            Func<PersonRegistration, bool> votingRegistrationStatusFilter = pr => true;
            if (filterVotingRegistrationStatusEdit.Text.Trim() != "")
            {
                votingRegistrationStatusFilter = pr => pr.VotingRegistrationStatus.Name.ToLower() == filterVotingRegistrationStatusEdit.Text.ToLower();
            }

            Func<PersonRegistration, bool> votingRegistrationCityFilter = pr => true;
            if (filterVotingRegistrationCityEdit.Text.Trim() != "")
            {
                votingRegistrationCityFilter = pr => pr.VotingRegistrationCity.Name.ToLower() == filterVotingRegistrationCityEdit.Text.ToLower();
            }

            Func<PersonRegistration, bool> isCitizenOfBihFilter = pr => true;
            if (filterIsCitizenOfBihEdit.CheckState == CheckState.Checked)
            {
                isCitizenOfBihFilter = pr => pr.IsCitizenOfBih == true;
            }
            else if (filterIsCitizenOfBihEdit.CheckState == CheckState.Unchecked)
            {
                isCitizenOfBihFilter = pr => pr.IsCitizenOfBih == false;
            }

            filteredData = data
                .Where(countryFilter)
                .Where(cityFilter)
                .Where(originCityFilter)
                .Where(occupationFilter)
                .Where(qualificationFilter)
                .Where(votedOnPreviousElectionsFilter)
                .Where(votingRegistrationStatusFilter)
                .Where(votingRegistrationCityFilter)
                .Where(isCitizenOfBihFilter).ToList();
        }

        private void clearFilter()
        {
            filterCountryEdit.Text = "";
            filterCityEdit.Text = "";
            filterOriginCityEdit.Text = "";
            filterOccupationEdit.Text = "";
            filterQualificationEdit.Text = "";
            filterVotedOnPreviousElectionsEdit.CheckState = CheckState.Indeterminate;
            filterVotingRegistrationStatusEdit.Text = "";
            filterVotingRegistrationCityEdit.Text = "";
            filterIsCitizenOfBihEdit.CheckState = CheckState.Indeterminate;
        }

        private void showData()
        {
            dataGridView.SuspendLayout();
            dataGridView.DataSource = filteredData;

            dataGridView.Columns["CountryName"].Visible = false;
            dataGridView.Columns["OriginCityName"].Visible = false;
            dataGridView.Columns["OccupationName"].Visible = false;
            dataGridView.Columns["QualificationName"].Visible = false;
            dataGridView.Columns["VotingRegistrationStatusName"].Visible = false;
            dataGridView.Columns["VotingRegistrationCityName"].Visible = false;
            dataGridView.ResumeLayout();

            showCounts();
        }

        private void showCounts()
        {
            if (filteredData.Count() == 1)
            {
                infoToolStripStatusLabel.Text = "Prikazan 1 upis";
            }
            else
            {
                infoToolStripStatusLabel.Text = "Prikazano " + filteredData.Count().ToString() + " upisa";
            }

            if (dataGridView.SelectedRows.Count == 1)
            {
                infoToolStripStatusLabel.Text += ", selektovan 1 upis";
            }
            else
            {
                infoToolStripStatusLabel.Text += ", selektovano " + dataGridView.SelectedRows.Count.ToString() + " upisa";
            }
        }

        private void checkForNewData()
        {
            using (var context = new MainContext())
            {
                var lastRecordsShown = data.OrderByDescending(e => e.Id).Take(1);
                var lastRecordsLoaded = context.PersonRegistrations.OrderByDescending(e => e.Id).Take(1);
                if (lastRecordsShown.Count() == 0 && lastRecordsLoaded.Count() > 0)
                {
                    refreshListToolStripButton.Enabled = true;
                    toolsRefreshListToolStripMenuItem.Enabled = true;                    
                }
                else if (lastRecordsShown.Count() > 0 && lastRecordsLoaded.Count() > 0 && lastRecordsShown.First().Id < lastRecordsLoaded.First().Id)
                {
                    refreshListToolStripButton.Enabled = true;
                    toolsRefreshListToolStripMenuItem.Enabled = true;
                }
            }
        }

        private void exportToCsv(string fileName)
        {
            var stringBuilder = new StringBuilder();

            foreach (var record in filteredData)
            {
                if (record.Email.Trim() != "")
                {
                    stringBuilder.AppendLine(record.Email.Trim() + System.Globalization.CultureInfo.CurrentCulture.TextInfo.ListSeparator);
                }                
            }

            if (stringBuilder.Length > 0)
            {
                File.WriteAllText(fileName, stringBuilder.ToString());
            }
        }

        private void exportSelectedToCsv(string fileName)
        {
            var stringBuilder = new StringBuilder();
            var selectedRows = dataGridView.SelectedRows;
            foreach (DataGridViewRow row in selectedRows)
            {
                var record = row.DataBoundItem as PersonRegistration;         
                if (record.Email.Trim() != "")
                {
                    stringBuilder.AppendLine(record.Email.Trim() + System.Globalization.CultureInfo.CurrentCulture.TextInfo.ListSeparator);
                }
            }

            if (stringBuilder.Length > 0)
            {
                File.WriteAllText(fileName, stringBuilder.ToString());
            }
        }

        private void backupDatabase(string fileName)
        {
            try
            {
                using (var context = new MainContext())
                {
                    var databaseName = context.Database.Connection.Database;
                    var sqlCommand = @"BACKUP DATABASE [{0}] TO DISK = N'{1}' WITH INIT";

                    context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction,
                        string.Format(sqlCommand, databaseName, fileName));
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void restoreDatabase(string fileName)
        {
            if (MessageBox.Show("Da li ste sigurni da želite da prepišete podatke sa rezervne kopije (podaci u bazi će biti prepisani)?", "", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            try
            {
                using (var context = new MainContext())
                {
                    var databaseName = context.Database.Connection.Database;
                    var sqlCommand = @"
                    USE master; 
                    ALTER DATABASE [{0}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
                    RESTORE DATABASE [{0}] FROM DISK = N'{1}' WITH REPLACE";

                    context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction,
                        string.Format(sqlCommand, databaseName, fileName));
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void printList()
        {
            FPrint printForm = new FPrint();
            printForm.ReportViewer.LocalReport.DataSources.Clear();
            printForm.ReportViewer.LocalReport.ReportEmbeddedResource = "PeopleRegsClient.PersonListReport.rdlc";

            var dataSet = new ReportDataSource("PersonListDataSet", filteredData);
            printForm.ReportViewer.LocalReport.DataSources.Add(dataSet);
            dataSet.Value = filteredData;
            printForm.ReportViewer.LocalReport.Refresh();
            printForm.ReportViewer.RefreshReport();

            printForm.ShowDialog();
        }

        private void printSelected()
        {
            FPrint printForm = new FPrint();
            printForm.ReportViewer.LocalReport.DataSources.Clear();
            printForm.ReportViewer.LocalReport.ReportEmbeddedResource = "PeopleRegsClient.PersonListReport.rdlc";

            List<PersonRegistration> selectedRecords = new List<PersonRegistration>();
            foreach (DataGridViewRow row in dataGridView.SelectedRows)
            {
                selectedRecords.Add(row.DataBoundItem as PersonRegistration);
            }

            var dataSet = new ReportDataSource("PersonListDataSet", selectedRecords);
            printForm.ReportViewer.LocalReport.DataSources.Add(dataSet);
            dataSet.Value = selectedRecords;
            printForm.ReportViewer.LocalReport.Refresh();
            printForm.ReportViewer.RefreshReport();

            printForm.ShowDialog();
        }

        private PersonRegistration selected = null;

        private void rememberSelected()
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                selected = dataGridView.SelectedRows[0].DataBoundItem as PersonRegistration;
            }
            else
            {
                selected = null;
            }
        }

        private void restoreSelected()
        {
            if (selected != null)
            {
                dataGridView.ClearSelection();
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if ((row.DataBoundItem as PersonRegistration).Id == selected.Id)
                    {
                        row.Selected = true;
                        dataGridView.FirstDisplayedScrollingRowIndex = row.Index;
                    }
                }
            }
        }

        private void FMain_Shown(object sender, EventArgs e)
        {
            loadingPanel.Visible = true;
            Refresh();

            refreshListToolStripButton.Enabled = false;
            toolsRefreshListToolStripMenuItem.Enabled = false;

            loadFilterOptions();
            loadData();
            filterData();
            showData();

            loadingPanel.Visible = false;
            Refresh();

            dataSyncTimer.Interval = Convert.ToInt32(ConfigurationManager.AppSettings["dataSyncIntervalInSeconds"]) * 1000;
            dataSyncTimer.Start();
        }

        private void DataSyncTimer_Tick(object sender, EventArgs e)
        {
            syncToolStripButton.Enabled = false;
            toolsSyncToolStripMenuItem.Enabled = false;

            dataSyncWorker.RunWorkerAsync();
            dataSyncTimer.Stop();
        }

        private void DataSyncWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var importService = new ImportService();
            importService.ImportData();
        }

        private void DataSyncWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            syncToolStripButton.Enabled = true;
            toolsSyncToolStripMenuItem.Enabled = true;

            checkForNewData();
            dataSyncTimer.Start();
        }

        private void dataSyncWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            showCounts();
        }

        private void filterEdit_FilterChanged(object sender, EventArgs e)
        {
            if (data != null)
            {
                filterData();
                showData();
            }
        }

        private void filterClearButton_Click(object sender, EventArgs e)
        {
            clearFilter();
            filterData();
            showData();
        }

        private void fileOpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                var record = dataGridView.SelectedRows[0].DataBoundItem as PersonRegistration;
                FEntry entryForm = new FEntry(record);
                entryForm.ShowDialog();
                dataGridView.Refresh();
            }
            else
            {
                MessageBox.Show("Morate označiti samo jedan upis.");
            }
        }

        private void filePrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printList();
        }

        private void filePrintSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printSelected();
        }

        private void fileExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolsSyncToolStripMenuItem_Click(object sender, EventArgs e)
        {
            syncToolStripButton.Enabled = false;
            toolsSyncToolStripMenuItem.Enabled = false;

            dataSyncWorker.RunWorkerAsync();
            dataSyncTimer.Stop();
        }

        private void toolsExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exportSaveFileDialog.ShowDialog();
            if (exportSaveFileDialog.FileName != "")
            {
                exportToCsv(exportSaveFileDialog.FileName);
            }
        }

        private void toolsExportSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                return;
            }

            exportSaveFileDialog.ShowDialog();
            if (exportSaveFileDialog.FileName != "")
            {
                exportSelectedToCsv(exportSaveFileDialog.FileName);
            }
        }

        private void toolsBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            backupSaveFileDialog.ShowDialog();
            if (backupSaveFileDialog.FileName != "")
            {
                backupDatabase(backupSaveFileDialog.FileName);
            }
        }

        private void toolsRestoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            backupOpenFileDialog.ShowDialog();
            if (backupOpenFileDialog.FileName != "")
            {
                restoreDatabase(backupOpenFileDialog.FileName);
                toolsRefreshListToolStripMenuItem_Click(toolsRefreshListToolStripMenuItem, new EventArgs());                
            }
        }

        private void toolsRefreshListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refreshListToolStripButton.Enabled = false;
            toolsRefreshListToolStripMenuItem.Enabled = false;

            loadingPanel.Visible = true;
            Refresh();

            rememberSelected();

            loadFilterOptions();
            loadData();
            filterData();
            showData();

            restoreSelected();

            loadingPanel.Visible = false;
            Refresh();
        }

        private void viewShowFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filterPanel.Visible = viewShowFilterToolStripMenuItem.Checked;
        }

        private void viewReloadFromDbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolsRefreshListToolStripMenuItem_Click(sender, e);
        }

        private void helpAboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Projekat Online, 2017.");
        }
    }
}
