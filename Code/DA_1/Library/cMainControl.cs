using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace DA_1.Library
{
    public class cMainControl
    {
        public static void addControl(Control control_parent, Control control_child)
        {
            //control_parent.Controls.Clear();
            control_parent.Controls.Add(control_child);
            control_child.Dock = DockStyle.Fill;
            control_child.BringToFront();

        }
        public static void showNotification(string notification, string name)
        {
            PopupNotifier popup = new PopupNotifier();
            popup.TitleColor = cColor.pink();
            popup.TitleFont = new Font("Arial",14,FontStyle.Bold);
            popup.TitleText = notification;
            popup.TitlePadding = new Padding(20, 10, 0, 0);

            popup.ContentFont = new Font("Arial", 12, FontStyle.Bold);
            popup.ContentColor = Color.Black;
            popup.ContentText = name;
            popup.ContentPadding = new Padding(70, 10, 0, 0);

            popup.AnimationInterval = 10;
            popup.Delay = 1500;
            popup.AnimationDuration = 200;
            popup.HeaderColor = cColor.pink();
            popup.BodyColor = Color.White;
            popup.BorderColor = cColor.pink();

            popup.Popup();
        }
        
    }
}
