using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_Portal.Student
{
    public partial class CourseCard : UserControl
    {
        public CourseCard()
        {
            InitializeComponent();
        }

        public string CourseTitle
        {
            set { lblTitle.Text = value; }
        }

        public string SectionStatus
        {
            set { lblSectionStatus.Text = value; }
        }

        public string Status
        {
            set { lblStatus.Text = value; }
        }

        public string Result
        {
            set { lblResult.Text = value; }
        }

        private void LoadCourseCards()
        {
            CourseCard card1 = new CourseCard();
            card1.CourseTitle = "02063 - SOFTWARE ENGINEERING [Q]";
            card1.SectionStatus = "(open)";
            card1.Status = "Valid";
            card1.Result = "D+ (61.40)";

            CourseCard card2 = new CourseCard();
            card2.CourseTitle = "01692 - COMPUTER NETWORKS [K]";
            card2.SectionStatus = "(open)";
            card2.Status = "Valid";
            card2.Result = "C (66.00)";

            // Add to FlowLayoutPanel
            flpGrades.Controls.Add(card1);
            flpGrades.Controls.Add(card2);
            // and so on...
        }


        private CourseCard CreateCard(string title, string sectionStatus, string status, string result)
        {
            CourseCard card = new CourseCard();
            card.CourseTitle = title;
            card.SectionStatus = sectionStatus;
            card.Status = status;
            card.Result = result;
            return card;
        }
    }
}
