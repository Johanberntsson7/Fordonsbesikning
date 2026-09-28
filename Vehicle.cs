namespace Fordonsbesikning;

public class Vehicle
{
    public int Year { get; set; }
    public bool HasInsurance { get; set; }

    public string CheckInspection()
    {
        const int CurrentYear = 2026;
        int age = CurrentYear - Year;

        if (age > 5 && !HasInsurance)
        {
            return "Ej godkänt";
        }
        else if (age < 5 && HasInsurance)
        {
            return "Godkänt";
        }
        else
        {
            return "Måste kompletteras";
        }
    }
}
        
    
    
    
    
    
    
    
    


    

    
