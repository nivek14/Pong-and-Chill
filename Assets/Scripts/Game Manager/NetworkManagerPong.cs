using UnityEngine;

namespace Mirror.Examples.Pong
{
    // Custom NetworkManager that simply assigns the correct racket positions when
    // spawning players. The built in RoundRobin spawn method wouldn't work after
    // someone reconnects (both players would be on the same side).
    [AddComponentMenu("")]
    public class NetworkManagerPong : NetworkManager
    {
        public Transform topRacketSpawn;
        public Transform bottomRacketSpawn;
        public Transform topRacketScoreSpawn;
        public Transform bottomRacketScoreSpawn;
        GameObject ball;

        public override void OnServerAddPlayer(NetworkConnection conn)
        {
            // add player at correct spawn position
            Transform start = numPlayers == 0 ? topRacketSpawn : bottomRacketSpawn;
            Transform start2 = numPlayers == 0 ? topRacketScoreSpawn : bottomRacketScoreSpawn;
            GameObject player = Instantiate(playerPrefab, start.position, start.rotation);
            player.transform.localScale = new Vector3(1,1,1);
            NetworkServer.AddPlayerForConnection(conn, player);

            /*if(numPlayers == 1){
                GameObject score = Instantiate(spawnPrefabs.Find(prefab => prefab.name == "Player Score Multi"), topRacketScoreSpawn);
                NetworkServer.Spawn(score);
            }*/

            // spawn ball if two players
            if (numPlayers == 1)
            {
                ball = Instantiate(spawnPrefabs.Find(prefab => prefab.name == "Ball Multi"));
                NetworkServer.Spawn(ball);
            }
        }

        public override void OnServerDisconnect(NetworkConnection conn)
        {
            // destroy ball
            if (ball != null)
                NetworkServer.Destroy(ball);

            // call base functionality (actually destroys the player)
            base.OnServerDisconnect(conn);
        }
    }
}
