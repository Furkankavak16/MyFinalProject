
using Core.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entites.Concrete
{
  public  class Category:IEntity
    {
        //çıplak klass kalmasın
        //inheritıns yada infertance yap
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }


    }
}
