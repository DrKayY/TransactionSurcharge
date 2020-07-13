namespace TransSurchg
{
    internal class TransferAdvice
    {
        public int GetAmountToTransfer(int amount)
        {
            var fee = TransFeeCalculator.CalculateFee(amount);
            return amount - fee;
        }
    }
}
