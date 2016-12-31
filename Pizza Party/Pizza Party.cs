using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Pizza Party App! Done by the following students:
 * Group 2 Members
 * Momo Johnson
 * Mohamed Sheikhali
 * Patrick Benjamin
 */

namespace Pizza_Party
{
    
    public partial class Form1 : Form
    {
       private String itemName;//Item name variable
       private List<OrderItems> ordertoday = new List<OrderItems>();//Order item list
       private int orderNumber;//Order number variable
        //Declaration of the order 
        OrderItems pizza8inch,pizza12Inch, pizza14Inch, pizza16Inch, susage, perpper,
            garlic, bacan, coke, sprite, chocolateChip, cheeseBread, bafaloWings;

        //An action handler that exit the form when click
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Form1()
        {
            InitializeComponent();
        }
        /*Action event that is used to add items to the list when the checkbox is check
         * for each item on the form
         */

        private void pizza8inch_CheckedChanged(object sender, EventArgs e)
        {
           
            //Casting of the sender to checkbox and coverting it to a string
            CheckBox itemReturn = (CheckBox)sender;
            itemName = itemReturn.Text;
            if (isSelected(chkpizza8inch, itemName, "8 Inches Pizza $8.00"))
            {
                
               // ischeck(true, false, false, false);
                pizza8inch= new OrderItems(8.00, "8 Inches Pizza $8.00", orderNumber, .32 );
                orderNumber = pizza8inch.getOrderNumber();
                ordertoday.Add(pizza8inch);
           }
            
          else if (isSelected(chkpizza12Inch, itemName, "12 Inches Pizza $12.00"))
            {
                //ischeck(false, true, false, false);
                 pizza12Inch = new OrderItems(12.00, "12 Inches Pizza $12.00", orderNumber, 0.55);
                orderNumber = pizza12Inch.getOrderNumber();
                ordertoday.Add(pizza12Inch);
                
            }          
                      
           else if (isSelected(chkpizza14Inch, itemName, "14 Inches Pizza $12.50"))
            {
                if (chkpizza14Inch.Checked)
                {
                 
                    pizza14Inch = new OrderItems(12.50, "14 Inches Pizza $12.50", orderNumber,0.65);
                    orderNumber = pizza14Inch.getOrderNumber();
                    ordertoday.Add(pizza14Inch);
                }
                               
            }
          else if(isSelected(chkpizza16Inch, itemName, "16 inches Pizza $13.50"))
            {
               // ischeck(false, false, false, true);
                pizza16Inch = new OrderItems(13.50, "16 inches Pizza $13.50", orderNumber, 0.75);
                orderNumber = pizza16Inch.getOrderNumber();
                ordertoday.Add(pizza16Inch);
          }else if(isSelected(chksausage, itemName, "Sausage $2.00")){
                susage = new OrderItems(2.00, "Sausage $2.00", orderNumber, 0.25);
               orderNumber = susage.getOrderNumber();
                ordertoday.Add(susage);
            } else if(isSelected(chkpepper,itemName, "Peppers $1.00"))
            {
                perpper = new OrderItems(1.00, "Peppers $1.00", orderNumber, 0.2);
                orderNumber = perpper.getOrderNumber();
                ordertoday.Add(perpper);
           }else if(isSelected(chkgarlic,itemName, "Garlic $2.50"))
            {
                garlic = new OrderItems(2.50, "Garlic $2.50", orderNumber, 0.21);
                orderNumber = garlic.getOrderNumber();
                ordertoday.Add(garlic);
            }else if(isSelected(chkbecan, itemName, "Becan $2.75"))
            {
                bacan = new OrderItems(2.75, "Becan $2.75", orderNumber, 0.20 );
                orderNumber = bacan.getOrderNumber();
                ordertoday.Add(bacan);
            }else if(isSelected(chkcoke2Liter, itemName, "2 Liter Coke $1.50"))
            {
                coke = new OrderItems(1.50, "2 Liter Coke $1.50", orderNumber,0.15);
                orderNumber = coke.getOrderNumber();
                ordertoday.Add(coke);

            }else if(isSelected(chksprite2Liter, itemName, "2 Liter Sprite $1.50"))
            {
                sprite = new OrderItems(1.50, "2 Liter Sprite $1.50", orderNumber, 0.15);
                orderNumber = sprite.getOrderNumber();
                ordertoday.Add(sprite);
            } else if(isSelected(chkchocolateChip, itemName, "Chocolate Chip Cookie $5.00"))
            {
                chocolateChip = new OrderItems(5.00, "Chocolate Chip Cookie $5.00", orderNumber,0.55);
                orderNumber = chocolateChip.getOrderNumber();
                ordertoday.Add(chocolateChip);
            }else if(isSelected(chkcheeseBread, itemName, "Cheese Bread $7.00"))
            {
                cheeseBread= new OrderItems(7.00, "Cheese Bread $7.00", orderNumber, 0.67 );
                orderNumber = cheeseBread.getOrderNumber();
                ordertoday.Add(cheeseBread);
            }else if(isSelected(chkbaffoloWings, itemName, "12 Pcs Bafalo Wings $12.75"))
            {
                bafaloWings = new OrderItems(12.75, "12 Pcs Bafalo Wings $12.75", orderNumber, 0.95 );
                orderNumber = bafaloWings.getOrderNumber();
                ordertoday.Add(bafaloWings);

            }

        }
        // The submit event handler thats calculate the total price, tax and order number when click
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!ordertoday.Any())
            {
                MessageBox.Show("You haven't selected an item", "Selection Error");
            }

            else
            {
                /*Calling the notCheck method to uncheck checkbox  after being checked
                if it is uncheck, remove the item that was added to the list*/
                notCheked(pizza12Inch, chkpizza12Inch); notCheked(perpper, chkpepper);
                notCheked(pizza14Inch, chkpizza14Inch); notCheked(garlic, chkgarlic);
                notCheked(pizza8inch, chkpizza8inch); notCheked(bacan, chkbecan);
                notCheked(pizza16Inch, chkpizza16Inch); notCheked(coke, chkcoke2Liter);
                notCheked(susage, chksausage); notCheked(sprite, chksprite2Liter);
                notCheked(chocolateChip, chkchocolateChip); notCheked(cheeseBread, chkcheeseBread);
                notCheked(bafaloWings, chkbaffoloWings);


                string itemOrderName = " ";//Item order name
                double totalPrice = 0;//total price variable
                double numberOrder = 0;//The order number variable
                double totalTax = 0;//The total tax variable
                //A for loop that loops over the list items
                for (int i = 0; i < ordertoday.Count(); i++)
                {

                    itemOrderName += ordertoday[i].getName() + "\n";//Getting of the items name
                    totalPrice = totalPrice + ordertoday[i].getPrice();//adding of the prices being added to the list
                    numberOrder = ordertoday[i].getOrderNumber();//Getting the order number for the items
                    totalTax += ordertoday[i].getTax();//Getting the tax for the items being ordered
                }

                ischeck();
                //Checking to see if the there is no order being placed
                if (!ordertoday.Any())
                {
                    MessageBox.Show("You haven't selected item, Please make a selection", "Selection Error");
                }
                else
                {
                    orderLists.Text = "Order Number: " + numberOrder +
                        "\n" + itemOrderName + "\nTotal Tax: " + totalTax.ToString("c2") +
                        "\nTotal Price: " + (totalPrice + totalTax).ToString("c2");
                }
            }
        }

        //An action event that clear the receipt label when clicked
        private void btnReceiptClear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel the order?",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                orderLists.Text = "";
                ordertoday.Clear();
            }
            
        }
        //A method that checks if a checkbox is being checked and item name equals the label name
        private bool isSelected(CheckBox box, String item, String name)
        {
            if(box.Checked && item.Equals(name))
            {
                 return true;
            }
            return false;
        }
    //A method that uncheck the checkbox for each checkbox that is being passed
        public void ischeck(bool a = false,
            bool b = false, bool c = false,
            bool d = false, bool e = false,
            bool f = false, bool g = false,
            bool h = false, bool i = false,
            bool j = false, bool k = false,
            bool l = false, bool m = false,
            bool n = false)
        {
            
            chkpizza8inch.Checked = a; chkpizza12Inch.Checked = b; chkpizza14Inch.Checked = c;
            chkpizza16Inch.Checked = d; chksausage.Checked = e; chkpepper.Checked = c;
            chkgarlic.Checked = g; chkbecan.Checked = h; chkcoke2Liter.Checked = i;
            chksprite2Liter.Checked = j; chkchocolateChip.Checked = k; chkcheeseBread.Checked = l;
            chkbaffoloWings.Checked = m;

        }
       /*A method that check if the checkbox is not checked. If is unchecked, remove the item that was
        added to the list*/

       public void notCheked(OrderItems items, CheckBox checkbox)
        {
            if(checkbox.Checked == false)
            {
                ordertoday.Remove(items);
            }
        }

        //The order items class
        public class OrderItems
        {

           private double price;//The price for the variable
           private String itemsName;//The item name variable
           private static int orderNumber = 85466;//The ordernumber variable
           private double tax;//A variable for the tax
                               //The constructor that accepts  the various items that have been ordered
            public OrderItems(double price, string name, int number, double tax)
            {
                this.price = price;//The price of the item being order
                this.itemsName = name;//The name of the item being ordered
                this.tax = tax;//The tax of the item being order
                orderNumber++;//The order number of the item being ordered

            }
            //A method that gets the name of the item being ordered
            public String getName()
            {
                return this.itemsName;
            }
            //A method that gets the price for each item being ordered
            public double getPrice()
            {
                return this.price;
            }
            //A method that returns the client order number
            public int getOrderNumber()
            {
                return orderNumber;
            }
            //A method that returns the tax
            public double getTax()
            {
                return this.tax;
            }

        }
    }
   

}


