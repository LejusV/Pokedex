using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Articuno Specie to store common natural stats of every {'abilities': ['pressure', 'snow-cloak'], 'base_experience': 261, 'height': 17, 'id': 144, 'moves': ['razor-wind', 'gust', 'whirlwind', 'fly', 'take-down', 'double-edge', 'roar', 'mist', 'water-gun', 'ice-beam', 'blizzard', 'bubble-beam', 'hyper-beam', 'peck', 'toxic', 'agility', 'rage', 'mimic', 'double-team', 'reflect', 'bide', 'swift', 'sky-attack', 'rest', 'substitute', 'mind-reader', 'snore', 'curse', 'powder-snow', 'protect', 'mud-slap', 'icy-wind', 'detect', 'sandstorm', 'endure', 'swagger', 'steel-wing', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'twister', 'rain-dance', 'sunny-day', 'ancient-power', 'rock-smash', 'hail', 'facade', 'secret-power', 'air-cutter', 'signal-beam', 'sheer-cold', 'aerial-ace', 'water-pulse', 'roost', 'natural-gift', 'pluck', 'tailwind', 'u-turn', 'giga-impact', 'avalanche', 'ice-shard', 'defog', 'ominous-wind', 'round', 'sky-drop', 'frost-breath', 'hurricane', 'freeze-dry', 'confide', 'aurora-veil'], 'name': 'articuno', 'stats': {'hp': 90, 'attack': 85, 'defense': 100, 'special-attack': 95, 'special-defense': 125, 'speed': 85}, 'types': ['ice', 'flying'], 'weight': 554, 'is_baby': False, 'is_legendary': True, 'is_mythical': False, 'hatch_counter': 80, 'gender_rate': -1, 'capture_rate': 3, 'color': 'blue', 'shape': 'wings', 'habitat': 'rare', 'generation': 'generation-i', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'フリーザー', 'roomaji': 'Freezer', 'ko': '프리져', 'zh-Hant': '急凍鳥', 'fr': 'Artikodin', 'de': 'Arktos', 'es': 'Articuno', 'it': 'Articuno', 'en': 'Articuno', 'ja': 'フリーザー', 'zh-Hans': '急冻鸟'}, 'genera': {'ja-Hrkt': 'れいとうポケモン', 'ko': '냉동포켓몬', 'zh-Hant': '冰凍寶可夢', 'fr': 'Pokémon Glaciaire', 'de': 'Eis', 'es': 'Pokémon Congelar', 'it': 'Pokémon Gelo', 'en': 'Freeze Pokémon', 'ja': 'れいとうポケモン', 'zh-Hans': '冰冻宝可梦'}}
	public class SpecieArticuno : PokemonSpecie
	{
#nullable enable
		private static SpecieArticuno? _instance = null;
#nullable restore
        public static SpecieArticuno Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieArticuno();
                }
                return _instance;
            }
        }

		public SpecieArticuno() : base(
			"Articuno",
			90, // HPs
			85, 100, // Attack & Defense
			95, 125, // Special Attack & Defense
			85			
		) {}
	}


	//Articuno Pokemon Class
	public class Articuno : Pokemon
	{

		public Articuno(string nickname, int level)
		: base(
				144,
				SpecieArticuno.Instance, // Pokemon Specie
				nickname, level,
				Ice.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Articuno() : base(
			144,
			SpecieArticuno.Instance, // Pokemon Specie
			Ice.Instance, Flying.Instance			
		) {}
	}
}