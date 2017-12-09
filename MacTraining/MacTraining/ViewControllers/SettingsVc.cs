using Foundation;
using System;
using UIKit;
using MacTraining.Cells;
using System.Diagnostics;

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
            TableView.EstimatedRowHeight = 150;
            TableView.Source = new SettingsTableViewSource();
            //TableView.AllowsSelection = false;
            TableView.AllowsMultipleSelection = true;
            //TableView.SeparatorStyle = UITableViewCellSeparatorStyle.None;
            TableView.SelectRow( NSIndexPath.FromRowSection(2,1),true, UITableViewScrollPosition.None);
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
                //cell.SeparatorInset = new UIEdgeInsets(0, 3000, 0, 0);
                //cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                cell.SelectedBackgroundView.BackgroundColor = UIColor.Red;
                return cell;
            }
            else if (indexPath.Section == 1)
            {
                var cell = (IconAndTextCell)tableView.DequeueReusableCell("IconAndTextCell", indexPath);
                cell.Setup("Siemanko huehue " + indexPath.Row, indexPath.Row % 2 == 0 ? "huehuie" : string.Empty);
                cell.ImageView.Image = UIImage.FromBundle("Icons/clear");
                return cell;
            }
            else
            {
                var cell = SettingsCell.Create(indexPath.Row %2 ==0, "Siemanko huehue " + indexPath.Row);
                return cell;
            }
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            if (section == 0)
                return 3;
            if (section == 1)
                return 6;

            return 0;
        }

        public override nint NumberOfSections(UITableView tableView)
        {
            return 2;
        }

        public override string TitleForHeader(UITableView tableView, nint section)
        {
            return "Sekcja " + section;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            Debug.WriteLine("Selected: " + indexPath);
            //akcja
            //tableView.DeselectRow(indexPath, true);
        }

        public override void RowDeselected(UITableView tableView, NSIndexPath indexPath)
        {
            Debug.WriteLine("Deselected: "+indexPath);
        }
    }
}