using System.Collections.Generic;
using Server.Models;

namespace DofusEvaluator.Shared {
  public static class ChestCalculator {
    public static double CalculateExpectedValue(Chest chest, IDictionary<string, double> unitPrices) {
      double sum = 0;
      foreach (var o in chest.Outcomes) {
        var price = unitPrices.TryGetValue(o.Category, out var p) ? p : 0;
        sum += o.Probability * price;
      }
      return sum;
    }
  }
}