using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nurieva_kurs
{
    public class bdController
    {

        static bd data = new bd();
        static int id;
        static int type;

        public static bool save = true;

        public static bool auth(string email, string pass)
        {
         
            var result = data.User.Where(u => u.email.Equals(email) && u.pass.Equals(pass));

            if(result.Count() == 0) return false;

            id = result.First().id;
            type = result.First().favorite;
            return true;

        }

        public static bool reg(string email, string pass)
        {

            var result = data.User.Where(u => u.email.Equals(email));

            if (result.Count() != 0) return false;

            data.User.Add(new User()
            {

                email = email,
                pass = pass,
                favorite = 0

            });

            if (save) data.SaveChanges(); else return true;
            return auth(email, pass);

        }

        public static void changeFavorite(int _type)
        {

            data.User.Find(id).favorite = _type;
            type = _type;
            if (save) data.SaveChanges();

        }

        public static IEnumerable<Flower> GetFlowers() => data.Flower.Where(f => f.type == type);

        public static void AddOrder(int flowerId, int count, string address, string phone)
        {

            data.order.Add(new order()
            {

                idFlower = flowerId,
                count = count,
                address = address,
                phone = phone,
                idUser = id

            });

            if (save) data.SaveChanges();

        }

    }
}
