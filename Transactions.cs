using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace CsharpTraining_Jan2725
{
    public class Transaction
    {
        /*public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }

        public Transaction(int id, string name, string desc, string type)
        {
            Id = id;
            Name = name;
            Description = desc;
            Type = type;
        }
        public void CreateTransaction()
        {
            FileStream fs = new FileStream("trans.txt", FileMode.Open, FileAccess.ReadWrite);//create file
            StreamWriter streamWriter = new StreamWriter(fs);
            streamWriter.WriteLine("Id:" + Id);
            streamWriter.WriteLine("Name:" + Name);
            streamWriter.WriteLine("Desc:" + Description);
            streamWriter.WriteLine("Type:" + Type);
            streamWriter.Close();
            fs.Close();//file cl
        }
        public void ReadTransaction()
        {
            List<Transaction> list = new List<Transaction>();

            FileStream fs = new FileStream("trans.txt", FileMode.Open, FileAccess.ReadWrite);//create file
                                                                                             //read
            StreamReader sr = new StreamReader(fs);
            //Console.WriteLine(sr.ReadToEnd());
            //Console.WriteLine(sr.ReadLine());
            //Console.WriteLine(sr.ReadLine());
            //Console.WriteLine(sr.ReadLine());
            int id = 0; string name = ""; string desc = ""; string type = "";
            while (sr.Peek() > 0)
            {
                string line = sr.ReadLine();
                if (line.StartsWith("Id"))
                {
                    string[] s = line.Split(':'); //"Id:1" -> s[0]="Id"  s[1]="1"
                    id = Convert.ToInt32(s[1]);
                }
                else if (line.StartsWith("Name"))
                {
                    string[] s = line.Split(':'); //"Id:1" -> s[0]="Id"  s[1]="1"
                    name = s[1];
                }
                else if (line.StartsWith("Desc"))
                {
                    string[] s = line.Split(':'); //"Id:1" -> s[0]="Id"  s[1]="1"
                    desc = s[1];
                }
                else if (line.StartsWith("Type"))
                {
                    string[] s = line.Split(':'); //"Id:1" -> s[0]="Id"  s[1]="1"
                    type = s[1];
                }

                if (id != 0 && name != "" && desc != "" && type != "")
                {
                    Transaction t = new Transaction(id, name, desc, type);
                    list.Add(t);
                    id = 1;
                    name = "";
                    desc = "";
                    type = "";
                }
                Console.WriteLine(line);
            }
            fs.Close();
            Console.WriteLine("Id\t\tName\t\tDesc\t\tType");
            foreach (var item in list)
            {
                //if (item.Type == "Credit")
                    Console.WriteLine($"{item.Id}\t\t{item.Name}\t\t{item.Description}\t\t{item.Type}");
            }
        }
    }
    public class Trans
    {
        public static void Main(string[] args)
        {

            
            Transaction transaction = new Transaction(1, "Abhibus", "travel", "Debit");
            transaction.CreateTransaction();
            
            transaction.ReadTransaction();
            
        }*/
        public int Id { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public string  DateTime { get; set; }
        public string Status {  get; set; }
        public string Network{  get; set; }
        public Transaction(int id,string source,string destination,string datetime,string status,string network) {
            Id = id;
            Source = source;
            Destination= destination;
            DateTime =datetime;
            Status = status;
            Network = network;
        
        }
        public void CreateTransaction()
        {
            FileStream fs = new FileStream("networking.txt", FileMode.Open, FileAccess.ReadWrite);//create file
            StreamWriter streamWriter = new StreamWriter(fs);
            streamWriter.WriteLine("Id:" + Id);
            streamWriter.WriteLine("Source:" + Source);
            streamWriter.WriteLine("Destination:" + Destination);
            streamWriter.WriteLine("DateTime:" + DateTime);
            streamWriter.WriteLine("Status:" + Status);
            streamWriter.WriteLine("Network:" + Network);
            streamWriter.Close();
            fs.Close();//file cl
        }
        public void ReadTransaction()
        {
            List<Transaction> list = new List<Transaction>();

            FileStream fs = new FileStream("networking.txt", FileMode.Open, FileAccess.ReadWrite);//create file
                                                                                             //read
            StreamReader sr = new StreamReader(fs);
            //Console.WriteLine(sr.ReadToEnd());
            //Console.WriteLine(sr.ReadLine());
            //Console.WriteLine(sr.ReadLine());
            //Console.WriteLine(sr.ReadLine());
            int id = 0; string source = ""; string destination = ""; string datetime=""; string status=""; string network="";
            while (sr.Peek() > 0)
            {
                string line = sr.ReadLine();
                if (line.StartsWith("Id"))
                {
                    string[] s = line.Split(':'); //"Id:1" -> s[0]="Id"  s[1]="1"
                    id = Convert.ToInt32(s[1]);
                }
                else if (line.StartsWith("Source"))
                {
                    string[] s = line.Split(':'); //"Id:1" -> s[0]="Id"  s[1]="1"
                    source = s[1];
                }
                else if (line.StartsWith("Destination"))
                {
                    string[] s = line.Split(':'); //"Id:1" -> s[0]="Id"  s[1]="1"
                    destination = s[1];
                }
                else if (line.StartsWith("DateTime"))
                {
                    string[] s = line.Split(':'); //"Id:1" -> s[0]="Id"  s[1]="1"
                    datetime = s[1];
                }
                else if (line.StartsWith("Status"))
                {
                    string[] s = line.Split(":");
                    status = s[1];

                }
                else if (line.StartsWith(Network))
                {
                    string[] s = line.Split(":");
                    network = s[1];
                }
            
         

                if (id != 0 && source != "" && destination != "" && datetime != "" && status != "" && network != "")
                {
                    Transaction t = new Transaction(id, source, destination, datetime,status,network);
                    list.Add(t);
                    id = 1;
                    source = "";
                    destination = "";
                    datetime = "";
                    status = "";
                    network = "";
                }
                Console.WriteLine(line);
            }
            fs.Close();
            //Console.WriteLine("Id\t\tSource\t\tDestination\t\tDatetime\t\tStatus\t\tNetwork");
            //foreach (var item in list)
            //{
                //if (item.Status == "Success")
                //Console.WriteLine(item);


                 //Console.WriteLine($"{item.Id}\t\t{item.Source}\t\t{item.Destination}\t\t{item.DateTime}\t\t{item.Status}\t\t{item.Network}");
            //}
        }
    }
    public class Trans
    {
        public static void Main(string[] args)
        {


            Transaction transaction = new Transaction(1, "13455464", "123455", "1/16/2025","success","airtel");
            transaction.CreateTransaction();

            transaction.ReadTransaction();

        }
    }
     

}
    
    /*
     * File handling
     * 
     * 1. file create
     * 2. file open
     * 3. read/write open
     * 4. file close
     * 
     * namespace: System.IO
     * 
     * 1. FileStream
     * 2. StreamWriter
     * 3. StreamReader
     * 4. File
     * 5. Directory
     * 6. TextReader
     * 7. BinaryReader
     * 8. StringReader
     * 
     * string a="welcme training bangare/Chennai";
     * welcme training bangare-[0]
     * Chennai-[1]
     * a.split('/')
     * 
     * 12/12/2025 12:20:12 AM
     * 
     * split(' ')
     * 12/12/2025
     * 12:20:12
     * AM
     */



