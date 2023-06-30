#if NEFTA_INTEGRATION_METAMASK
using MetaMask.Transports.Unity;
using UnityEngine;

namespace Nefta.ToolboxDemo.Authentication.MetaMask
{
    public class MetaMaskTransportWrapper : TransportBroadcaster
    {
        public void AssignListener(GameObject listener)
        {
            listeners = new[] { listener };
        }
    }
}
#endif