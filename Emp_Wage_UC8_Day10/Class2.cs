using System;
using System.Collections.Generic;
using System.Text;

namespace Emp_Wage_UC8_Day9
{
    class Class2
    {
        IS_PART_TIME=1;
        IS_FULL_TIME=2;
        MAX_HRS_IN_MONTH=4;
        EMP_RATE_PER_HRS=20;
        NUM_WORKING_DAYS=20;

totalEmpHr=0;
totalworkingday=0;

function getWorkingHours()
        {
            local empCheck =$1
   case $empCheck in
      $IS_FULL_TIME)
          workHours = 12
           ; ;
       $IS_PART_TIME)
          workHours = 8
           ; ;
            *)
          workHours = 0
          ; ;
            esac
            echo $workHours
}





while [[ $totalEmpHrs -lt $MAX_HRS_IN_MONTH && $totalworkingday -lt $NUM_WORKING_DAYS]]
{
   ((totalworkingday++))
    empCheck=$((RANDOM%3))
    empHrs="$( getWorkingHours $empCheck )"
    totalEmpHrs=$(($totalEmpHrs+$empHrs))
    dailyWage[$totalworkingday]=$(($empHrs* $EMP_RATE_PER_HRS))
}

totalSalary =$(($totalEmpHrs* $EMP_RATE_PER_HRS))
echo "Total Employee wage="$totalSalary
echo ${dailyWage[@]
    }
}

}
}
