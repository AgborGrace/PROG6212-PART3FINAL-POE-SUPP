namespace CMCS_POE.Models {
    public class Claim {
      public int HoursWorked {get;set;}
      public double HourlyRate {get;set;}
      public string Status {get;set;}="Pending";
      public double Total => HoursWorked*HourlyRate;
    }}