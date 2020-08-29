using NBitcoin;
using System;
using System.Collections.Generic;
using System.Text;

namespace NBXplorer
{
	public partial class NBXplorerNetworkProvider
	{
		private void InitLBRYCredits(NetworkType networkType)
		{
			Add(new NBXplorerNetwork(NBitcoin.Altcoins.LBRYCredits.Instance, networkType)
			{
				MinRPCVersion = 70702
			});
		}

		public NBXplorerNetwork GetLBC()
		{
			return GetFromCryptoCode(NBitcoin.Altcoins.LBRYCredits.Instance.CryptoCode);
		}
	}
}
