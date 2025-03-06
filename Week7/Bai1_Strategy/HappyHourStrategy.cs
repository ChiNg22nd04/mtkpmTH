class HappyHourStrategy : IBillingStrategy
{
 	public double GetActPrice(double rawPrice) => rawPrice * 0.5;
}