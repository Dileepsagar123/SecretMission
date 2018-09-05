using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
namespace JSONAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> lstemployee = new List<Employee>();
            lstemployee.Add(new Employee()
            {
                EmployeeID = 100,
                EmployeeName = "Pradeep",
                DeptWorking = "OnLineBanking",
                Salary = 10000
            });
            lstemployee.Add(new Employee()
            {
                EmployeeID = 101,
                EmployeeName = "Mark",
                DeptWorking = "OnLineBanking",
                Salary = 20000
            });
            lstemployee.Add(new Employee()
            {
                EmployeeID = 102,
                EmployeeName = "Smith",
                DeptWorking = "Mobile banking",
                Salary = 10000
            });
            lstemployee.Add(new Employee()
            {
                EmployeeID = 103,
                EmployeeName = "John",
                DeptWorking = "Testing",
                Salary = 7000
            });
            lstemployee.Add(new Employee()
            {
                EmployeeID = 104,
                EmployeeName = "Johny sins",
                DeptWorking = "R & D",
                Salary = 70000
            });
            lstemployee.Add(new Employee()
            {
                EmployeeID = 105,
                EmployeeName = "Johny sins",
                DeptWorking = "R & D",
                Salary = 70000
            });
            string output = JsonConvert.SerializeObject(lstemployee.ToArray());
            string path = @"EmployeeData.json";
            //string deserPath = @"EmployeeDataDeser.json";
            if (File.Exists(path))
            {
                File.CreateText(path);
                File.WriteAllText(@"D:\EmployeeData.json", output);
            }
            else
            {
                File.WriteAllText(@"D:\EmployeeData.json", output);
                
            }
            try
            {
                string json = string.Empty;

                using (StreamReader r = new StreamReader("D://EmployeeData.json"))

                {

                    json = r.ReadToEnd();




                    dynamic array = JsonConvert.DeserializeObject("{\"Emp\":[{\"Emp1\":{\"NAME\":\"DILEEP\",\"ADD\":\"ALIGARH\"}},{\"Emp1\":{\"NAME\":\"DILEEP1\",\"ADD\":\"ALIGARH1\"}}]}");
                    //StreamWriter streamWriter = new StreamWriter(array);
                    foreach(var keysd in array)
                    {
                        Console.WriteLine(keysd.Emp.Name[0].ToString());
                    }
                    Console.WriteLine(array);

                    //... read text from json file

                }

                var employeeDeser = JsonConvert.DeserializeObject<Employee[]>(output);
                    
                    foreach (var frmt in employeeDeser)
                    {
                       Console.WriteLine("Employee ID :  {0}",frmt.EmployeeID.ToString());
                        Console.WriteLine("Employee Salary : {0}", frmt.Salary.ToString());
                        Console.WriteLine("Employee Dept : {0}", frmt.DeptWorking.ToString());
                        Console.WriteLine("Employee Name : {0}", frmt.EmployeeName.ToString());
                     
                       
                    }
                     
                     
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();

        }
    }
}