namespace launcher.c6.SingletonVault;

public class Vault
{
        private static Vault? _vaultConnection;
        private static object _syncRoot = new Object();
        private Vault()
        {
        }

        public static Vault Instance
        {
            get
            {
                lock(_syncRoot)
                {
                    if(_vaultConnection == null)
                    {
                        _vaultConnection = new Vault();
                    }
                }

                return _vaultConnection;
            }
        }

        public void GetVaultKey()
        {
            Console.WriteLine("Ding! Order up!");
        }
}