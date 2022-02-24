using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Lotad Specie to store common natural stats of every {'abilities': ['swift-swim', 'rain-dish', 'own-tempo'], 'base_experience': 44, 'height': 5, 'id': 270, 'moves': ['swords-dance', 'headbutt', 'body-slam', 'double-edge', 'growl', 'mist', 'water-gun', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'counter', 'absorb', 'mega-drain', 'leech-seed', 'razor-leaf', 'solar-beam', 'toxic', 'mimic', 'double-team', 'bubble', 'flash', 'rest', 'substitute', 'thief', 'snore', 'flail', 'protect', 'icy-wind', 'giga-drain', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'sweet-scent', 'synthesis', 'hidden-power', 'rain-dance', 'sunny-day', 'whirlpool', 'uproar', 'hail', 'facade', 'nature-power', 'secret-power', 'teeter-dance', 'astonish', 'tickle', 'bullet-seed', 'water-pulse', 'natural-gift', 'seed-bomb', 'energy-ball', 'zen-headbutt', 'captivate', 'grass-knot', 'round', 'echoed-voice', 'scald', 'confide'], 'name': 'lotad', 'stats': {'hp': 40, 'attack': 30, 'defense': 30, 'special-attack': 40, 'special-defense': 50, 'speed': 30}, 'types': ['water', 'grass'], 'weight': 26, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 255, 'color': 'green', 'shape': 'armor', 'habitat': 'waters-edge', 'generation': 'generation-iii', 'growth_rate': 'medium-slow', 'egg_groups': ['water1', 'plant'], 'names': {'ja-Hrkt': 'ハスボー', 'roomaji': 'Hassboh', 'ko': '연꽃몬', 'zh-Hant': '蓮葉童子', 'fr': 'Nénupiot', 'de': 'Loturzel', 'es': 'Lotad', 'it': 'Lotad', 'en': 'Lotad', 'ja': 'ハスボー', 'zh-Hans': '莲叶童子'}, 'genera': {'ja-Hrkt': 'うきくさポケモン', 'ko': '개구리밥포켓몬', 'zh-Hant': '浮萍寶可夢', 'fr': 'Pokémon Aquaplante', 'de': 'Wasserlinse', 'es': 'Pokémon Alga', 'it': 'Pokémon Alga', 'en': 'Water Weed Pokémon', 'ja': 'うきくさポケモン', 'zh-Hans': '浮萍宝可梦'}}
	public class SpecieLotad : PokemonSpecie
	{
#nullable enable
		private static SpecieLotad? _instance = null;
#nullable restore
        public static SpecieLotad Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLotad();
                }
                return _instance;
            }
        }

		public SpecieLotad() : base(
			"Lotad",
			40, // HPs
			30, 30, // Attack & Defense
			40, 50, // Special Attack & Defense
			30			
		) {}
	}


	//Lotad Pokemon Class
	public class Lotad : Pokemon
	{

		public Lotad(string nickname, int level)
		: base(
				270,
				SpecieLotad.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Lotad() : base(
			270,
			SpecieLotad.Instance, // Pokemon Specie
			Water.Instance, Grass.Instance			
		) {}
	}
}