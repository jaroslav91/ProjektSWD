using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrologService;
using SbsSW.SwiPlCs;
using SbsSW.SwiPlCs.Exceptions;
using SWD.Common;

namespace SWD
{
    public partial class ProjectSWD : Form
    {
        #region Properties
        public List<ListItem> SympthonsList { get; set; }
        public List<ListItem> TreatmentGoalsList { get; set; }
        public List<ListItem> RecognitionsList { get; set; }
        public List<ListItem> TreatmentGoalsToShow { get; set; }
        public Dictionary<string, string> ResultDictionary { get; set; }

        private IPrologService _prologService;
        public IPrologService PrologService
        {
            get { return _prologService ?? (_prologService = new PrologService.PrologService()); }
        }
        #endregion

        #region Constructors
        public ProjectSWD()
        {
            InitializeComponent();
            LoadDataStaticDb();
            LoadBindingSources();
        }
        #endregion

        #region Events
        private void _btnSuggestTreatment_Click(object sender, EventArgs e)
        {
            PrologService.AddPrologQuery("clear_stored_goals");
            var selectedTreatmentGoals = _chblTreatmentGoals.CheckedItems;
            foreach (ListItem items in selectedTreatmentGoals)
            {
                var query = "assert(cel_leczenia(" + items.InternalName + "))";
                PrologService.AddPrologQuery(query);
            }

            GetAndShowDecision();
        }

        private void _btnAnalyze_Click(object sender, EventArgs e)
        {
            ClearBeforeAnalze();
            var selectedSymptoms = _chblSymptoms.CheckedItems;
            foreach (ListItem items in selectedSymptoms)
            {
                var query = "assert(ma(" + items.InternalName + "))";
                PrologService.AddPrologQuery(query);
            }

            var selectedRecognitions = _chblRecognitions.CheckedItems;
            foreach (ListItem items in selectedRecognitions)
            {
                var query = "assert(ma(" + items.InternalName + "))";
                PrologService.AddPrologQuery(query);
            }

            GetTreatmentGoals();

        }

        private void _btnClear_Click(object sender, EventArgs e)
        {
            PrologService.CleanPrologEngine();
            _prologService = null;
            _tbResult.Text = String.Empty;

            foreach (int i in _chblSymptoms.CheckedIndices)
            {
                _chblSymptoms.SetItemCheckState(i, CheckState.Unchecked);
            }
            _chblSymptoms.ClearSelected();

            foreach (int i in _chblRecognitions.CheckedIndices)
            {
                _chblRecognitions.SetItemCheckState(i, CheckState.Unchecked);
            }
            _chblRecognitions.ClearSelected();

            TreatmentGoalsToShow = new List<ListItem>();
            _bsTreatmentGoals.DataSource = TreatmentGoalsToShow;
        }
        #endregion

        #region Private Methods

        private void LoadBindingSources()
        {
            if (SympthonsList != null)
            {
                _bsSympthons.DataSource = SympthonsList;
                _chblSymptoms.DataSource = _bsSympthons;
                _chblSymptoms.DisplayMember = "Text";
                _chblSymptoms.ValueMember = "IsSelected";

            }

            if (RecognitionsList != null)
            {
                _bsRecognitions.DataSource = RecognitionsList;
                _chblRecognitions.DataSource = _bsRecognitions;
                _chblRecognitions.DisplayMember = "Text";
                _chblRecognitions.ValueMember = "IsSelected";

            }

            if (TreatmentGoalsToShow != null)
            {
                _bsTreatmentGoals.DataSource = TreatmentGoalsToShow;
                _chblTreatmentGoals.DataSource = _bsTreatmentGoals;
                _chblTreatmentGoals.DisplayMember = "Text";
                _chblTreatmentGoals.ValueMember = "IsSelected";

            }

        }

        private void GetAndShowDecision()
        {
            var finalQuery = "co_przepisac(L)";
            var solution = PrologService.GetPologSolutionVariableses(finalQuery);
            try
            {
                var resultText = new StringBuilder();

                var result = solution.Select(v => v["L"].ToListString()).ToList().FirstOrDefault();
                if (result != null)
                {
                    var set = new SortedSet<string>() { };
                    result.ToList().ForEach(c => set.Add(MapPrologDecisionToUserFriendly(c)));


                    foreach (var line in set)
                    {
                        resultText.AppendLine(line);
                    }
                }
                _tbResult.Text = resultText.ToString();
            }
            catch (PlException)
            {
                _tbResult.Text = String.Empty;
            }
        }

        private void GetTreatmentGoals()
        {
            var finalQuery = "co_leczyc(G)";
            var solution = PrologService.GetPologSolutionVariableses(finalQuery);
            try
            {
                var result = solution.Select(v => v["G"].ToListString()).ToList().FirstOrDefault();
                if (result != null)
                    foreach (var goal in result)
                    {
                        var goalItem = TreatmentGoalsList.FirstOrDefault(g => g.InternalName.Equals(goal));
                        if (goalItem != null)
                        {
                            TreatmentGoalsToShow.Add(goalItem);
                        }

                    }
                _bsTreatmentGoals.ResetBindings(false);
            }
            catch (PlException)
            {
                _tbResult.Text = String.Empty;
            }
        }

        private void ClearBeforeAnalze()
        {
            PrologService.AddPrologQuery("clear_stored_symptons");
            PrologService.AddPrologQuery("clear_stored_goals");
            _prologService = null;
            _tbResult.Text = String.Empty;

            TreatmentGoalsToShow = new List<ListItem>();
            _bsTreatmentGoals.DataSource = TreatmentGoalsToShow;
            _bsTreatmentGoals.ResetBindings(false);

        }

        public string MapPrologDecisionToUserFriendly(string input)
        {
            if (ResultDictionary.ContainsKey(input))
            {
                var output = ResultDictionary.FirstOrDefault(item => item.Key.Equals(input));
                return output.Value;
            }
            return input;
        }
        #endregion

        #region Static Database Load in Runtime
        private void LoadDataStaticDb()
        {
            SympthonsList = new List<ListItem>()
            {
                new ListItem() {Text = "Ból głowy", InternalName = "bol_glowy"},
                new ListItem() {Text = "Ból zęba", InternalName = "bol_zeba"},
                new ListItem() {Text = "Gorączka", InternalName = "goraczka"},
                new ListItem() {Text = "Bóle mięśni", InternalName = "bole_miesni"},
                new ListItem() {Text = "Biegunka", InternalName = "biegunka"},
                new ListItem() {Text = "Kaszel", InternalName = "kaszel"},
                new ListItem() {Text = "Nerwobóle", InternalName = "nerwobole"},
                new ListItem() {Text = "Katar", InternalName = "katar"},
                

            };
            SympthonsList = SympthonsList.OrderBy(i => i.Text).ToList();

            RecognitionsList = new List<ListItem>()
            {
                new ListItem() {Text = "Uczulenie na Loperamid", InternalName = "uczulenie_na_loperamid"},
                new ListItem() {Text = "Uczulenie na Paracetamol", InternalName = "uczulenie_na_paracetamol"},
                new ListItem() {Text = "Uczulenie na Ibuprofen", InternalName = "uczulenie_na_ibuprofen"},
                new ListItem() {Text = "Niewydolność wątroby", InternalName = "niewydolnosc_watroby"},
                new ListItem() {Text = "Uczulenie na diosmektyt", InternalName = "uczulenie_na_diosmetyk"},
                new ListItem() {Text = "Cukrzyca", InternalName = "cukrzyca"},
                new ListItem() {Text = "Astma", InternalName = "astma"},
                                
            };
            RecognitionsList = RecognitionsList.OrderBy(i => i.Text).ToList();
            TreatmentGoalsList = new List<ListItem>()
            {
                new ListItem() {Text = "Zastopuj Biegunkę", InternalName = "biegunka"},
                new ListItem() {Text = "Zmniejsz gorączkę", InternalName = "goraczka"},
                new ListItem() {Text = "Wylecz ból głowy", InternalName = "bol_glowy"},
                new ListItem() {Text = "Wylecz bóle mięśni", InternalName = "bole_miesni"},
                new ListItem() {Text = "Wylecz ból zęba", InternalName = "bol_zeba"},
                new ListItem() {Text = "Wylecz katar", InternalName = "katar"},
                new ListItem() {Text = "Wylecz kaszel", InternalName = "kaszel"},
                new ListItem() {Text = "Wylecz nerwobóle", InternalName = "nerwobole"},
                new ListItem() {Text = "Wylecz bóle", InternalName = "bole"}
            
            };
            

            ResultDictionary = new Dictionary<string, string>(){
                {
                    "duzo_plynow","Pij dużo Płynów"
                },
                {
                    "lek_z_loperamidem","Podaj lek zawierający loperamid."
                },
                {
                    "lek_z_paracetamolem","Podaj lek zawierający pracetamol."
                }
                ,
                {
                    "lek_z_diosmatykiem","Podaj lek zawierający diosmatyk."
                }
                ,
                {
                    "lek_z_aspiryna","Podaj lek zawierający kwas acetylosalicylowy."
                }
                ,
                {
                    "lek_z_ibuprofen","Podaj lek zawierający ibuprofen."
                }
                 ,
                {
                    "lek_z_naproksenem","Podaj lek zawierający naproksen."
                }
                ,
                {
                    "lek_acatar","Przepisz lek Acatar."
                }
                  ,
                {
                    "lek_apselan","Przepisz lek Apselan."
                },
                {
                    "lek_elofen","Przepisz lek Elofen."
                }
                  ,
                {
                    "lek_gardlox","Przepisz lek Gardlox."
                }
                
            };
            
            TreatmentGoalsToShow = new List<ListItem>();
        }
        #endregion
    }
}
