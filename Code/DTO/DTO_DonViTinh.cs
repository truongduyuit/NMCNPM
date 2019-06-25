using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DTO
{
  public  class DTO_DonViTinh
    {
        private long id;
        private string ten;

        [DisplayName("Mã Đơn Vị Tính")]
        public long Id { get => id; set => id = value; }

        [DisplayName("Tên Đơn Vị Tính")]
        public string Ten { get => ten; set => ten = value; }
    }
}
