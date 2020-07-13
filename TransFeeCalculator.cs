namespace TransSurchg
{
    public class TransFeeCalculator
    {
        public static int CalculateFee(int amount)
        {
            var chargeFee = 0;
            var feeConfig = FeeConfiguration.GetFeeConfiguration();
        
            foreach (var feeConfigSet in feeConfig.fees)
            {
                if (amount >= feeConfigSet.minAmount && amount <= feeConfigSet.maxAmount)
                    chargeFee = feeConfigSet.feeAmount;
            }

            return chargeFee;
        }
    }
}
