using Stock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
    {
        RemainStock myRemainStock = new RemainStock();
        //ค่าเริ่มต้นของแต่ละเดือน เช่น start 500
        int stock_accumulate = 500;
        int stock_check = 0;
        int stock_spend;
        //มีการใส่ของเพิ่มเข้ามา เช่น in 50 รวมเป็น 550
        stock_accumulate = Add(50, stock_accumulate);
        //out 40 ลบออกเป็น 510
        myRemainStock.listOfHandlers = new RemainStock.StockHandler(CallRemainStock);
        stock_accumulate = myRemainStock.Minus(40, stock_accumulate);

        //เมื่อค่าสะสมลดลงจนเข้าใกล้ 0 ให้มี event ขึ้นมาว่า stock ใกล้จะหมดลง
        //สิ้นเดือน ให้คนเข้ามาตรวจสอบเช็ค stock เก็บในตัวแปร สมมุติว่าเหลือ 400
        stock_check = 400;
        //ลบค่า stock คงเหลือที่ตรวจกับค่าบวกลบสะสม จะได้ stock คงเหลือ ค่าที่ได้คือ stock ที่ใช้ไป เป็นการตรวจสอบ หากมากกว่า 0 แสดงว่าไม่ได้คีย์เข้าระบบจำนวนเท่านั้น
        stock_spend =  stock_accumulate - stock_check;
        stock_accumulate = stock_check;
        Console.WriteLine("ยอดคงเหลือคือ " + stock_accumulate);
        Console.WriteLine("มีของหายไปจากระบบจำนวน " + stock_spend);
        Console.ReadLine();

    }
    static int Add(int x, int y)
    {
        return x + y;
    }
    static void CallRemainStock(string msg)
    { Console.WriteLine(msg); }
}