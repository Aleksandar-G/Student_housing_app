using System;

class Appoitment
{
    public string Description { get; set; }
    public Guid AppoitmentID { get; set; }
    public Guid UserID { get; set; } //Get the User ID from somewhere
    public DateTime dateTimeOfAppoitment { get; set; }

    public Appoitment(string givenDescription,DateTime givenDateTimeForAppoitment)
	{
        this.Description = givenDescription;
        this.dateTimeOfAppoitment = givenDateTimeForAppoitment;
        this.AppoitmentID = Guid.NewGuid();
	}

    public string ShowAppoiment()
    {
        return $"Description{this.Description} - {this.dateTimeOfAppoitment}";
    }
}
