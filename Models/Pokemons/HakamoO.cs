using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Hakamo-O Specie to store common natural stats of every {'abilities': ['bulletproof', 'soundproof', 'overcoat'], 'base_experience': 147, 'height': 12, 'id': 783, 'moves': ['swords-dance', 'headbutt', 'tackle', 'leer', 'roar', 'earthquake', 'toxic', 'screech', 'double-team', 'bide', 'rest', 'rock-slide', 'substitute', 'protect', 'scary-face', 'outrage', 'sandstorm', 'false-swipe', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'hidden-power', 'facade', 'taunt', 'brick-break', 'rock-tomb', 'sky-uppercut', 'aerial-ace', 'iron-defense', 'dragon-claw', 'bulk-up', 'dragon-dance', 'close-combat', 'payback', 'fling', 'x-scissor', 'focus-blast', 'shadow-claw', 'draco-meteor', 'autotomize', 'round', 'echoed-voice', 'bulldoze', 'dragon-tail', 'work-up', 'noble-roar', 'confide', 'brutal-swing'], 'name': 'hakamo-o', 'stats': {'hp': 55, 'attack': 75, 'defense': 90, 'special-attack': 65, 'special-defense': 70, 'speed': 65}, 'types': ['dragon', 'fighting'], 'weight': 470, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 40, 'gender_rate': 4, 'capture_rate': 45, 'color': 'gray', 'shape': 'upright', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'slow', 'egg_groups': ['dragon'], 'names': {'ja-Hrkt': 'ジャランゴ', 'ko': '짜랑고우', 'zh-Hant': '鱗甲龍', 'fr': 'Écaïd', 'de': 'Mediras', 'es': 'Hakamo-o', 'it': 'Hakamo-o', 'en': 'Hakamo-o', 'ja': 'ジャランゴ', 'zh-Hans': '鳞甲龙'}, 'genera': {'ja-Hrkt': 'うろこポケモン', 'ko': '비늘포켓몬', 'zh-Hant': '鱗片寶可夢', 'fr': 'Pokémon Écailles', 'de': 'Schuppentier', 'es': 'Pokémon Escamas', 'it': 'Pokémon Squama', 'en': 'Scaly Pokémon', 'ja': 'うろこポケモン', 'zh-Hans': '鳞片宝可梦'}}
	public class SpecieHakamoO : PokemonSpecie
	{
#nullable enable
		private static SpecieHakamoO? _instance = null;
#nullable restore
        public static SpecieHakamoO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHakamoO();
                }
                return _instance;
            }
        }

		public SpecieHakamoO() : base(
			"Hakamo-O",
			55, // HPs
			75, 90, // Attack & Defense
			65, 70, // Special Attack & Defense
			65			
		) {}
	}


	//Hakamo-O Pokemon Class
	public class HakamoO : Pokemon
	{

		public HakamoO(string nickname, int level)
		: base(
				783,
				SpecieHakamoO.Instance, // Pokemon Specie
				nickname, level,
				Dragon.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public HakamoO() : base(
			783,
			SpecieHakamoO.Instance, // Pokemon Specie
			Dragon.Instance, Fighting.Instance			
		) {}
	}
}