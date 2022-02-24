using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Kommo-O Specie to store common natural stats of every {'abilities': ['bulletproof', 'soundproof', 'overcoat'], 'base_experience': 270, 'height': 16, 'id': 784, 'moves': ['swords-dance', 'headbutt', 'tackle', 'leer', 'roar', 'flamethrower', 'hyper-beam', 'earthquake', 'toxic', 'screech', 'double-team', 'bide', 'rest', 'rock-slide', 'substitute', 'protect', 'scary-face', 'belly-drum', 'outrage', 'sandstorm', 'false-swipe', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'hidden-power', 'facade', 'taunt', 'brick-break', 'rock-tomb', 'sky-uppercut', 'aerial-ace', 'iron-defense', 'dragon-claw', 'bulk-up', 'dragon-dance', 'close-combat', 'payback', 'fling', 'rock-polish', 'poison-jab', 'x-scissor', 'focus-blast', 'giga-impact', 'shadow-claw', 'flash-cannon', 'draco-meteor', 'autotomize', 'round', 'echoed-voice', 'bulldoze', 'dragon-tail', 'work-up', 'noble-roar', 'confide', 'clanging-scales', 'brutal-swing'], 'name': 'kommo-o', 'stats': {'hp': 75, 'attack': 110, 'defense': 125, 'special-attack': 100, 'special-defense': 105, 'speed': 85}, 'types': ['dragon', 'fighting'], 'weight': 782, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 40, 'gender_rate': 4, 'capture_rate': 45, 'color': 'gray', 'shape': 'upright', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'slow', 'egg_groups': ['dragon'], 'names': {'ja-Hrkt': 'ジャラランガ', 'ko': '짜랑고우거', 'zh-Hant': '杖尾鱗甲龍', 'fr': 'Ékaïser', 'de': 'Grandiras', 'es': 'Kommo-o', 'it': 'Kommo-o', 'en': 'Kommo-o', 'ja': 'ジャラランガ', 'zh-Hans': '杖尾鳞甲龙'}, 'genera': {'ja-Hrkt': 'うろこポケモン', 'ko': '비늘포켓몬', 'zh-Hant': '鱗片寶可夢', 'fr': 'Pokémon Écailles', 'de': 'Schuppentier', 'es': 'Pokémon Escamas', 'it': 'Pokémon Squama', 'en': 'Scaly Pokémon', 'ja': 'うろこポケモン', 'zh-Hans': '鳞片宝可梦'}}
	public class SpecieKommoO : PokemonSpecie
	{
#nullable enable
		private static SpecieKommoO? _instance = null;
#nullable restore
        public static SpecieKommoO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieKommoO();
                }
                return _instance;
            }
        }

		public SpecieKommoO() : base(
			"Kommo-O",
			75, // HPs
			110, 125, // Attack & Defense
			100, 105, // Special Attack & Defense
			85			
		) {}
	}


	//Kommo-O Pokemon Class
	public class KommoO : Pokemon
	{

		public KommoO(string nickname, int level)
		: base(
				784,
				SpecieKommoO.Instance, // Pokemon Specie
				nickname, level,
				Dragon.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public KommoO(int level)
		: base(
				784,
				SpecieKommoO.Instance, // Pokemon Specie
				"Kommo-O", level,
				Dragon.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public KommoO() : base(
			784,
			SpecieKommoO.Instance, // Pokemon Specie
			Dragon.Instance, Fighting.Instance			
		) {}
	}
}