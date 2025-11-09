namespace launcher.c6.SingletonVault;

public class Vault
{
        private static Vault vaultConnection;
        private static object syncRoot = new Object();
        private Vault()
        {
        }

        public static Vault Instance
        {
            get
            {
                lock(syncRoot)
                {
                    if(vaultConnection == null)
                    {
                        vaultConnection = new Vault();
                    }
                }

                return vaultConnection;
            }
        }

        public void GetVaultKey()
        {
            Console.WriteLine("Ding! Order up!");
        }
}