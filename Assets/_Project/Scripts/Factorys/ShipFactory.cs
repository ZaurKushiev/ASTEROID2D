using Cysharp.Threading.Tasks;
using UnityEngine;
using Zenject;

namespace _Project.Scripts
{
    public class ShipFactory
    {
        private readonly DiContainer _container;
        private readonly ShipSpawnPoint _spawnPoint;
        private readonly IAddressablesLoader _addressablesLoader;

        public ShipFactory(
            DiContainer container,
            ShipSpawnPoint spawnPoint,
            IAddressablesLoader addressablesLoader)
        {
            _container = container;
            _spawnPoint = spawnPoint;
            _addressablesLoader = addressablesLoader;
        }

        public async UniTask<ShipMovement> CreateShip()
        {
            var shipPrefab = await _addressablesLoader.LoadShipPrefab();
            var shipInstance = _container.InstantiatePrefabForComponent<ShipMovement>(shipPrefab, _spawnPoint.transform.position, Quaternion.identity, null);
            return shipInstance;
        }
    }
}
