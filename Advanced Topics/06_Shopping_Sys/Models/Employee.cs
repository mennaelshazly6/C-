namespace _06_Shopping_Sys
{
    internal class Employee
    {
        public int Emp_Id { get; set; }
        public string Emp_Name { get; set; }
        public void AddProduct(Product newp, Product_Manager newman)
        {
            newman.AddItem(newp);
        }
        public void RemoveProduct(int prodid, Product_Manager newman)
        {
            newman.RemoveItem(prodid);
        }
        public void EditProductName(int ProdID, string NewName, Product_Manager newman)
        {
            newman.EditIName(ProdID, NewName);
        }
        public void EditProducPrice(int ProdID, int Newid, Product_Manager newman)
        {
            newman.EditItemPrice(ProdID, Newid);
        }
        public void ViewProducts(Product_Manager newman)
        {
            newman.viewList();
        }
    }
}
