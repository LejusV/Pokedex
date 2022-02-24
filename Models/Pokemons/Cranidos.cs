using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Cranidos Specie to store common natural stats of every {'abilities': ['mold-breaker', 'sheer-force'], 'base_experience': 70, 'height': 9, 'id': 408, 'moves': ['fire-punch', 'thunder-punch', 'swords-dance', 'whirlwind', 'slam', 'stomp', 'headbutt', 'take-down', 'thrash', 'double-edge', 'leer', 'roar', 'flamethrower', 'ice-beam', 'blizzard', 'strength', 'thunderbolt', 'thunder', 'earthquake', 'dig', 'toxic', 'screech', 'double-team', 'focus-energy', 'fire-blast', 'rest', 'rock-slide', 'substitute', 'thief', 'snore', 'curse', 'spite', 'protect', 'scary-face', 'mud-slap', 'sandstorm', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'pursuit', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'crunch', 'ancient-power', 'rock-smash', 'uproar', 'facade', 'superpower', 'endeavor', 'secret-power', 'rock-tomb', 'shock-wave', 'hammer-arm', 'natural-gift', 'payback', 'assurance', 'fling', 'rock-polish', 'dragon-pulse', 'earth-power', 'zen-headbutt', 'rock-climb', 'iron-head', 'stone-edge', 'captivate', 'stealth-rock', 'head-smash', 'smack-down', 'round', 'chip-away', 'incinerate', 'bulldoze', 'confide', 'power-up-punch'], 'name': 'cranidos', 'stats': {'hp': 67, 'attack': 125, 'defense': 40, 'special-attack': 30, 'special-defense': 30, 'speed': 58}, 'types': ['rock'], 'weight': 315, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 30, 'gender_rate': 1, 'capture_rate': 45, 'color': 'blue', 'shape': 'upright', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'slow-then-very-fast', 'egg_groups': ['monster'], 'names': {'ja-Hrkt': 'ズガイドス', 'roomaji': 'Zugaidos', 'ko': '두개도스', 'zh-Hant': '頭蓋龍', 'fr': 'Kranidos', 'de': 'Koknodon', 'es': 'Cranidos', 'it': 'Cranidos', 'en': 'Cranidos', 'ja': 'ズガイドス', 'zh-Hans': '头盖龙'}, 'genera': {'ja-Hrkt': 'ずつきポケモン', 'ko': '박치기포켓몬', 'zh-Hant': '頭錘寶可夢', 'fr': 'Pokémon Coud’Boule', 'de': 'Kopfstoß', 'es': 'Pokémon Cabezazo', 'it': 'Pokémon Cranioso', 'en': 'Head Butt Pokémon', 'ja': 'ずつきポケモン', 'zh-Hans': '头锤宝可梦'}}
	public class SpecieCranidos : PokemonSpecie
	{
#nullable enable
		private static SpecieCranidos? _instance = null;
#nullable restore
        public static SpecieCranidos Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCranidos();
                }
                return _instance;
            }
        }

		public SpecieCranidos() : base(
			"Cranidos",
			67, // HPs
			125, 40, // Attack & Defense
			30, 30, // Special Attack & Defense
			58			
		) {}
	}


	//Cranidos Pokemon Class
	public class Cranidos : Pokemon
	{

		public Cranidos(string nickname, int level)
		: base(
				408,
				SpecieCranidos.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Cranidos() : base(
			408,
			SpecieCranidos.Instance, // Pokemon Specie
			Rock.Instance			
		) {}
	}
}