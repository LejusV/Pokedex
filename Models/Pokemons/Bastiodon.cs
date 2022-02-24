using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Bastiodon Specie to store common natural stats of every {'abilities': ['sturdy', 'soundproof'], 'base_experience': 173, 'height': 13, 'id': 411, 'moves': ['headbutt', 'tackle', 'take-down', 'roar', 'flamethrower', 'ice-beam', 'blizzard', 'hyper-beam', 'strength', 'thunderbolt', 'thunder', 'earthquake', 'dig', 'toxic', 'double-team', 'fire-blast', 'rest', 'rock-slide', 'substitute', 'snore', 'protect', 'mud-slap', 'outrage', 'sandstorm', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'ancient-power', 'rock-smash', 'torment', 'facade', 'taunt', 'magic-coat', 'secret-power', 'rock-tomb', 'metal-sound', 'iron-defense', 'block', 'shock-wave', 'natural-gift', 'metal-burst', 'magnet-rise', 'rock-polish', 'earth-power', 'giga-impact', 'avalanche', 'flash-cannon', 'iron-head', 'stone-edge', 'captivate', 'stealth-rock', 'smack-down', 'heavy-slam', 'round', 'incinerate', 'bulldoze', 'confide'], 'name': 'bastiodon', 'stats': {'hp': 60, 'attack': 52, 'defense': 168, 'special-attack': 47, 'special-defense': 138, 'speed': 30}, 'types': ['rock', 'steel'], 'weight': 1495, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 30, 'gender_rate': 1, 'capture_rate': 45, 'color': 'gray', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'slow-then-very-fast', 'egg_groups': ['monster'], 'names': {'ja-Hrkt': 'トリデプス', 'roomaji': 'Trideps', 'ko': '바리톱스', 'zh-Hant': '護城龍', 'fr': 'Bastiodon', 'de': 'Bollterus', 'es': 'Bastiodon', 'it': 'Bastiodon', 'en': 'Bastiodon', 'ja': 'トリデプス', 'zh-Hans': '护城龙'}, 'genera': {'ja-Hrkt': 'シールドポケモン', 'ko': '실드포켓몬', 'zh-Hant': '護盾寶可夢', 'fr': 'Pokémon Bouclier', 'de': 'Schutzschild', 'es': 'Pokémon Escudo', 'it': 'Pokémon Schermo', 'en': 'Shield Pokémon', 'ja': 'シールドポケモン', 'zh-Hans': '护盾宝可梦'}}
	public class SpecieBastiodon : PokemonSpecie
	{
#nullable enable
		private static SpecieBastiodon? _instance = null;
#nullable restore
        public static SpecieBastiodon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBastiodon();
                }
                return _instance;
            }
        }

		public SpecieBastiodon() : base(
			"Bastiodon",
			60, // HPs
			52, 168, // Attack & Defense
			47, 138, // Special Attack & Defense
			30			
		) {}
	}


	//Bastiodon Pokemon Class
	public class Bastiodon : Pokemon
	{

		public Bastiodon(string nickname, int level)
		: base(
				411,
				SpecieBastiodon.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Bastiodon(int level)
		: base(
				411,
				SpecieBastiodon.Instance, // Pokemon Specie
				"Bastiodon", level,
				Rock.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Bastiodon() : base(
			411,
			SpecieBastiodon.Instance, // Pokemon Specie
			Rock.Instance, Steel.Instance			
		) {}
	}
}