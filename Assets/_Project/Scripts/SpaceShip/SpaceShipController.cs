namespace _Project.Scripts
{
    public class SpaceShipController
    {
        private ShipMovement _shipMovement;
        private SpaceShipShooting _spaceShipShooting;
        private InputHandler _inputHandler;

        public SpaceShipController(ShipMovement shipMovement, SpaceShipShooting spaceShipShooting, InputHandler inputHandler)
        {
            _shipMovement = shipMovement;
            _spaceShipShooting = spaceShipShooting;
            _inputHandler = inputHandler;
        }

        public void Initialize()
        {
            _inputHandler.Initialize(_shipMovement, _spaceShipShooting);
        }
    }
}
