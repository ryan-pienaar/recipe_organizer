using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace recipe_organizer
{
    public partial class PlannerForm : Form
    {

        private Dictionary<DateOnly, Recipe> Planner { get; set; }

        public PlannerForm(Dictionary<DateOnly, Recipe> Planner)
        {
            this.Planner = Planner;
            InitializeComponent();
            if (Planner.ContainsKey(DateOnly.FromDateTime(dtpPlannedMeal.Value)))
            {
                lblPlannedMealName.Text = Planner[DateOnly.FromDateTime(dtpPlannedMeal.Value)].Name;
            }
            else
            {
                lblPlannedMealName.Text = "None";
            }

        }

        private void btnPlannedMealView_Click(object sender, EventArgs e)
        {
            DateOnly date = DateOnly.FromDateTime(dtpPlannedMeal.Value);
            if (Planner.ContainsKey(date))
            {
                ViewForm viewForm = new ViewForm(Planner[date]);
                viewForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("No meal planned for the selected date");
            }

        }

        private void btnPlannedMealRemove_Click(object sender, EventArgs e)
        {
            if (Planner.ContainsKey(DateOnly.FromDateTime(dtpPlannedMeal.Value)))
            {
                Planner.Remove(DateOnly.FromDateTime(dtpPlannedMeal.Value));
                lblPlannedMealName.Text = "None";
            }
            else
            {
                MessageBox.Show("No meal planned for the selected date");
            }


        }

        private void dtpPlannedMeal_ValueChanged(object sender, EventArgs e)
        {
            if (Planner.ContainsKey(DateOnly.FromDateTime(dtpPlannedMeal.Value)))
            {
                lblPlannedMealName.Text = Planner[DateOnly.FromDateTime(dtpPlannedMeal.Value)].Name;
            }
            else
            {
                lblPlannedMealName.Text = "None";
            }
        }
    }
}
