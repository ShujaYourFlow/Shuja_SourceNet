using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Entity.Entities
{
    public class EntityBusinessSustainabilityGoals
    {

    public Int32 BUSINESS_DETAILS_KEY { get; set; }
    public Int32 MAST_BUSINESS_SUSTAINBILITY_GOALS_KEY { get; set; }


	public string NO_POVERTY { get; set; }
	public string ZERO_HUNGER { get; set; }
	public string GOOD_HEALTH_AND_WELL_BEING { get; set; }
	public string QUALITY_EDUCATION { get; set; }
	public string GENDER_EQUALITY { get; set; }
	public string CLEAN_WATER_AND_SANITITATION { get; set; }
	public string AFFORDABLE_AND_CLEAN_ENERGY { get; set; }
	public string DECENT_WORK_AND_ECONOMIC_GROWTH { get; set; }
	public string INDUSTRY_INNOVATION_AND_INFRASTRUCTURE { get; set; }
	public string REDUCED_INEQUALITIES { get; set; }
	public string SUSTAINABLE_CITY_AND_COMMUNITIES { get; set; }
	public string RESPONSIBLE_CONSUMPTION_AND_PRODUCTION { get; set; }
	public string CLIMATE_ACTION { get; set; }
	public string LIFE_BELOW_WATER { get; set; }
	public string LIFE_ONLAND { get; set; }
	public string PEACE_JUSTICE_AND_STRONG_INSTITUTION { get; set; }
	public string PARTNERSHIP_FOR_THE_GOALS { get; set; }



	public Int32 ENT_USER_KEY { get; set; }
    public Int32 EDIT_USER_KEY { get; set; }
    public byte TAG_ACTIVE { get; set; }
    public byte TAG_DELETE { get; set; }

        public EntityBusinessSustainabilityGoals() { }
    }

}
