using System.Collections.Generic;

namespace CSTest
{
    public static class Constants
    {
        public static List<CategoryRule> ruleList = new List<CategoryRule>(new[]
        {
            // Here you can add, modify and remove any rule
            new CategoryRule(){riskType="LOWRISK" , operatorType= "Less Than",threshold= 1000000,sector= "Public" },
            new CategoryRule(){riskType="MEDIUMRISK" , operatorType= "Greater Than",threshold= 1000000,sector= "Public" },
            new CategoryRule(){riskType="HIGHRISK" , operatorType= "Greater Than",threshold= 1000000,sector= "Private" },
        });

    }
}