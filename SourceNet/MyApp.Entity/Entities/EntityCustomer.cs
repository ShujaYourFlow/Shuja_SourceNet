using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Entity.Entities
{
  public  class EntityCustomer
    {
        public Int32 MAST_CUSTOMER_KEY { get; set; }
        public String USER_ROLE { get; set; }
        public String FIRSTNAME { get; set; }
        public String LASTNAME { get; set; }
        public String CUSTOMER_COMPANY_NAME { get; set; }
        public String CUSTOMER_POSITION { get; set; }
        public String USER_TYPE_KEY { get; set; }
        public String PASSWORD { get; set; }
        public String NEWPASSWORD { get; set; }
        public String PROFILE_PIC { get; set; }
        public String USER_TYPE { get; set; }
        public String ADDRESS { get; set; }
        public String TRIAL_CUSTOMER_COMPANY { get; set; }
        public float LAT { get; set; }
        public float LONG { get; set; }

        public String EMAIL { get; set; }
        public String PHONE_NO { get; set; }
        public String PHONE_CODE { get; set; }
        public Byte TAG_ACTIVATION { get; set; }
        public Int32 ENT_USER_KEY { get; set; }
        public DateTime ENT_DATE { get; set; }
        public DateTime ENT_TIME { get; set; }
        public Int32 EDIT_USER_KEY { get; set; }
        public DateTime EDIT_DATE { get; set; }
        public DateTime EDIT_TIME { get; set; }
        public Byte TAG_ACTIVE { get; set; }
        public Byte TAG_DELETE { get; set; }
     

        public EntityCustomer() { }
  }
}
