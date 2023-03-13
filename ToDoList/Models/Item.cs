using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Item
  {
    public int ItemId { get; set; }
    public string Description { get; set; }
    public int CategoryId { get; set; }
    public bool IsComplete { get; set; } = false;
    public Category Category { get; set; }
    public List<ItemTag> JoinEntities { get; }
  }
}

//CheckBox check_box = new CheckBox();
// using System;
// using System.Collections.Generic;
// using System.ComponentModel;
// using System.Data;
// using System.Drawing;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
// using System.Windows.Forms;
// namespace WindowsFormsApp1
// {
//   public partial class CheckBoxDemo : Form
//   {
//     public CheckBoxDemo()
//     {
//       InitializeComponent();
//     }
    // private void CheckBoxDemo_Load(object sender, EventArgs e)
    // {
    //   //Creating and setting properties of Label
    //   Label label = new Label();
    //   label.Text = "Select your technical skills";
    //   label.AutoSize = true;
    //   label.Location = new Point(192, 77);
    //   label.Font = new Font("Microsoft Sans Serif", 11);
    //   //Adding label to form
    //   this.Controls.Add(label);
    //   //Creating and setting properties of CheckBox
    //   CheckBox checkbox1 = new CheckBox();
    //   checkbox1.Location = new Point(195, 111);
    //   checkbox1.Text = "C";
    //   //Adding checkbox to form
    //   this.Controls.Add(checkbox1);
    //   CheckBox checkbox2 = new CheckBox();
    //   checkbox2.Location = new Point(195, 156);
    //   checkbox2.Text = "C++";
    //   this.Controls.Add(checkbox2);
    //   CheckBox checkbox3 = new CheckBox();
    //   checkbox3.Location = new Point(195, 195);
    //   checkbox3.Text = "C#";
    //   this.Controls.Add(checkbox3);
    //   CheckBox checkbox4 = new CheckBox();
    //   checkbox4.Location = new Point(195, 235);
    //   checkbox4.Text = "JAVA";
    //   this.Controls.Add(checkbox4);
    //   CheckBox checkbox5 = new CheckBox();
    //   checkbox5.Location = new Point(195, 275);
    //   checkbox5.Text = "HTML";
    //   this.Controls.Add(checkbox5);
    // }
//   }
// }