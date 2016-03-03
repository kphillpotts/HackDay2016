using System;

namespace LiveCoding
{
    public class CodeSnippets
    {
        public CodeSnippets()
        {
            /* STEP 1 - Bring in some Data 
            List<Animals.Animal> data;
            ...
            data = Animals.GetAnimals();
        */

            /* STEP 2 - Create Basic UITableView Implementation

            public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
            {
                var animal = data[indexPath.Row];       

                var cell = new UITableViewCell(UITableViewCellStyle.Default, null);
                cell.TextLabel.Text = animal.ToString();        

                return cell;
            }

            public override nint RowsInSection(UITableView tableView, nint section)
            {
                return data.Count;
            }
            */

            /* STEP 3 - Style it up some 

            var cell = new UITableViewCell(UITableViewCellStyle.Subtitle, null);    

            cell.TextLabel.Text = animal.Name;
            cell.ImageView.Image = UIImage.FromBundle(animal.Image);
            cell.DetailTextLabel.Text = animal.Description;

            */

            /* STEP 4 - Even more Styling

            cell.Accessory = UITableViewCellAccessory.DisclosureIndicator;

            cell.TextLabel.Font = UIFont.FromName("Helvetica Light", 14);
            cell.TextLabel.TextColor = UIColor.Blue;
            cell.DetailTextLabel.Font = UIFont.FromName("Helvetica Light", 12);
            cell.DetailTextLabel.TextColor = UIColor.Gray;

            */

            /* STEP 5 - Add some Interactivity

            public override void RowSelected(UITableView tableView, Foundation.NSIndexPath indexPath)
            {
                var cell = tableView.CellAt(indexPath);
                cell.ImageView.FlipWithDuration(.5, UIViewExtensions.UIViewAnimationFlipDirection.Left,1,false);
            }

            */

            /* STEP 6 - Add an Overlay

            private void ShowAnimal(Animals.Animal animal)
            {
                // create an overlay view
                UIView container = new UIView(new CGRect(0, 0, this.View.Bounds.Width, this.View.Bounds.Height));
                container.BackgroundColor = Animals.GetRandomColor();

                // add an image of the animal
                UIImageView image = new UIImageView(container.Bounds);
                image.UserInteractionEnabled = true;
                image.ContentMode = UIViewContentMode.Center;
                image.ContentMode = UIViewContentMode.Center;
                image.Image = UIImage.FromBundle(animal.Image);
                image.AddGestureRecognizer(new UITapGestureRecognizer(container.RemoveFromSuperview));
                container.AddSubview(image);

                // add a title up the top
                UILabel titleLabel = new UILabel();
                titleLabel.Frame = new CGRect(0, 0, this.View.Bounds.Width, 100);
                titleLabel.Text = animal.Name;
                titleLabel.Font = UIFont.FromName("Helvetica Bold", 40);
                titleLabel.TextColor = UIColor.White;
                titleLabel.TextAlignment = UITextAlignment.Center;
                container.Add(titleLabel);

                // add the detail text to the bottom
                UILabel detailLabel = new UILabel();
                detailLabel.Frame = new CGRect(10, View.Bounds.Height - 210, this.View.Bounds.Width - 20, 200);
                detailLabel.Text = animal.Description;
                detailLabel.Font = UIFont.FromName("Helvetica Light", 30);
                detailLabel.TextColor = UIColor.White;
                detailLabel.Lines = 0;
                detailLabel.TextAlignment = UITextAlignment.Center;
                container.Add(detailLabel);

                View.AddSubview(container);
                View.BringSubviewToFront(container);
            }

            */

            /* Step 7 - Let's get funky

            // add a transparent starburst pattern to the back
            UIImageView starburst = new UIImageView(container.Bounds);
            starburst.Image = UIImage.FromBundle("Starburst3.png");
            starburst.ContentMode = UIViewContentMode.Center;
            container.AddSubview(starburst);
            container.SendSubviewToBack(starburst);

            image.Pop(1, 1, 1);
            starburst.RotateToAngle(10, 10, UIViewExtensions.UIViewAnimationRotationDirection.Left, 10, true);

            */
        }
    }
}

