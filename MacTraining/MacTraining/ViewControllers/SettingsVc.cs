using Foundation;
using System;
using UIKit;

namespace MacTraining.ViewControllers
{
    public partial class SettingsVc : UIViewController
    {
        public SettingsVc (IntPtr handle) : base (handle)
        {
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            TableView.RowHeight = UITableView.AutomaticDimension;
            TableView.EstimatedRowHeight = 44;
            TableView.Source = new SettingsTableViewSource();
        }
    }

    public class SettingsTableViewSource : UITableViewSource
    {
        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            if (indexPath.Section == 0)
            {
              var cell = new UITableViewCell();
              cell.TextLabel.Text = indexPath.Section + " " + indexPath.Row;
              return cell;
            }
            else
            {
    			var cell = tableView.DequeueReusableCell("IconAndTextCell", indexPath);
    			return cell;
            }
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return 5;
        }

        public override nint NumberOfSections(UITableView tableView)
        {
            return 4;
        }

        public override string TitleForHeader(UITableView tableView, nint section)
        {
            return "Sekcja " + section;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            //akcja
            tableView.DeselectRow(indexPath, true);
        }
    }
}