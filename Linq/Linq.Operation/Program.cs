﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Operation
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Instance
            var listInt = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var listStr = new string[] { "a", "b", "c", "d", "e", "f", "g", "h" };
            var listObj = new List<Student> {
                new Student { Name = "Dung1", Age = 20 },
                new Student { Name = "Dung2", Age = 20 },
                new Student { Name = "Dung3", Age = 20 },
                new Student { Name = "Dung4", Age = 20 },
            };
            var listInformation = new List<Information>
            {
                new Information {Students=listObj,Id=1 }
            };

            #endregion

            #region Intro
            //Create array
            /*
            int[] arr = new int[] { 1, 2, 3, 4, 5 };

            //Call method AsEnumurable()
            var linq = arr.AsEnumerable();
            foreach (var item in linq)
            {
                Console.WriteLine(item);
            }

            //Simple example
            var linq1 = from s in "this is sample example".Split()
                        select s;
            foreach (var item in linq1)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
            */
            #endregion

            #region Concat
            /*Cong 2 list cung kieu du lieu*/

            /*
            int[] arr1 = { 1, 2, 3, 4, 5, 6 };
            int[] arr2 = { 11, 22, 33, 44, 55, 66 };

            var linq = arr1.Concat(arr2);
            foreach (var item in linq)
            {
                Console.WriteLine(item);
            }

            var words = "this is example".Split();
            var strArr2 = "i am developer".Split();
            var linq1 = words.Concat(strArr2);

            foreach (var item in linq1)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            */
            #endregion

            #region Contains
            /*kieu tra su ton tai cua 1 item trong IEnumurable..*/
            /*var list = new string[] { "a", "b", "c", "d" };
            if (list.Contains<string>("1"))
            {
                Console.WriteLine("List contains a");
            }
            else
            {
                Console.WriteLine("List is not contains a");
            }
            */
            #endregion

            #region DefaultOrEmpty
            /*
            List<int> list = new List<int>();
            var linq = list.DefaultIfEmpty();

            // return default value of int : 0
            foreach (var item in linq)
            {
                Console.WriteLine(item);
            }

            var linq1 = list.DefaultIfEmpty(10);

            //return value 10
            foreach (var item in linq1)
            {
                Console.WriteLine(item);
            }
            */
            #endregion

            #region ElementAt
            //tra ve gia tri cua phan tu tai 1 vi tri xac dinh
            // new index <0 se xay ra loi
            /*
            var item = listInt.ElementAt(0);
            Console.WriteLine(item);

            for (int i = 0; i < listInt.Length; i++)
            {
                Console.WriteLine(listInt.ElementAt(i));
            }
            */
            #endregion

            #region ElementAtOrDefault
            // tuong tu ElementAt nhung giai quyet dc van de index < 0
            /*
            var item2 = listInt.ElementAtOrDefault(-1);
            Console.WriteLine(item2);
            */
            #endregion

            #region First and FirstOrDefault
            // tra ve phan tu dau tien trong danh sach. neu phan tu ko co gia tri se loi
            /*
            var obj = listObj.First();

            var list = new List<int>();
            Console.Write(listObj.FirstOrDefault().Name);
            */
            #endregion

            #region Last and LastOrDetault
            //tuong tu nhu First
            #endregion

            #region Single and SingleOrDefault
            //tra ve 1 doi tuong voi 1 dieu kien nao do
            /*
            var item = listInt.Single(x => x < 2);

            Console.WriteLine(item);

            //tra ve gia tri 0 neu khong tim duoc phan tu nao thich hop trong Collection
            var itemDefault = listInt.SingleOrDefault(x => x>11);
            Console.WriteLine(itemDefault);
            */
            #endregion

            #region SelectMany
            //tra ve list cua list
            IEnumerable<Information> infor = new List<Information>();
            IEnumerable<IEnumerable<Student>> list = infor.Select(x => x.Students);
            IEnumerable<Student> stud = infor.SelectMany(x => x.Students);
            var linq = infor.SelectMany(x => x.Students, (obj1, obj2) => new { obj1.Id, obj2.Name });
            foreach (var item in linq)
            {
                Console.WriteLine(item.Name + "--" + item.Id);
            }
            #endregion

            Console.ReadKey();
        }
    }
}
