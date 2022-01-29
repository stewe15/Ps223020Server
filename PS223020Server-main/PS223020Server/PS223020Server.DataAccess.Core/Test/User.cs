using System;
using System.Collections.Generic;
using System.Text;

namespace PS223020Server.DataAccess.Core.Test
{
    public class User
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string SecondName { get; set; }
        List<Car>Cars { get; set; }
    }
}
