using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Magnemite Specie to store common natural stats of every {'abilities': ['magnet-pull', 'sturdy', 'analytic'], 'base_experience': 65, 'height': 3, 'id': 81, 'moves': ['tackle', 'take-down', 'double-edge', 'supersonic', 'sonic-boom', 'thunder-shock', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'rage', 'teleport', 'mimic', 'screech', 'double-team', 'light-screen', 'reflect', 'bide', 'swift', 'flash', 'explosion', 'rest', 'substitute', 'snore', 'curse', 'protect', 'zap-cannon', 'lock-on', 'endure', 'rollout', 'swagger', 'spark', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'facade', 'magic-coat', 'recycle', 'secret-power', 'metal-sound', 'signal-beam', 'iron-defense', 'shock-wave', 'gravity', 'gyro-ball', 'natural-gift', 'magnet-rise', 'mirror-shot', 'flash-cannon', 'discharge', 'magnet-bomb', 'charge-beam', 'electro-ball', 'round', 'volt-switch', 'electroweb', 'wild-charge', 'confide'], 'name': 'magnemite', 'stats': {'hp': 25, 'attack': 35, 'defense': 70, 'special-attack': 95, 'special-defense': 55, 'speed': 45}, 'types': ['electric', 'steel'], 'weight': 60, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': -1, 'capture_rate': 190, 'color': 'gray', 'shape': 'arms', 'habitat': 'rough-terrain', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['mineral'], 'names': {'ja-Hrkt': 'コイル', 'roomaji': 'Coil', 'ko': '코일', 'zh-Hant': '小磁怪', 'fr': 'Magnéti', 'de': 'Magnetilo', 'es': 'Magnemite', 'it': 'Magnemite', 'en': 'Magnemite', 'ja': 'コイル', 'zh-Hans': '小磁怪'}, 'genera': {'ja-Hrkt': 'じしゃくポケモン', 'ko': '자석포켓몬', 'zh-Hant': '磁鐵寶可夢', 'fr': 'Pokémon Magnétique', 'de': 'Magnet', 'es': 'Pokémon Imán', 'it': 'Pokémon Calamita', 'en': 'Magnet Pokémon', 'ja': 'じしゃくポケモン', 'zh-Hans': '磁铁宝可梦'}}
	public class SpecieMagnemite : PokemonSpecie
	{
#nullable enable
		private static SpecieMagnemite? _instance = null;
#nullable restore
        public static SpecieMagnemite Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMagnemite();
                }
                return _instance;
            }
        }

		public SpecieMagnemite() : base(
			"Magnemite",
			25, // HPs
			35, 70, // Attack & Defense
			95, 55, // Special Attack & Defense
			45			
		) {}
	}


	//Magnemite Pokemon Class
	public class Magnemite : Pokemon
	{

		public Magnemite(string nickname, int level) : base(
			81,
			SpecieMagnemite.Instance, // Pokemon Specie
			nickname, level,
			Electric.Instance, Steel.Instance			
		) {}

		public Magnemite() : base(
			81,
			SpecieMagnemite.Instance, // Pokemon Specie
			Electric.Instance, Steel.Instance			
		) {}
	}
}