using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
  public  class DTO_DonViTinh
    {
        private long id;
        private string ten;

        public long Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
    }
}
