using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Moltres Specie to store common natural stats of every {'abilities': ['pressure', 'flame-body'], 'base_experience': 261, 'height': 20, 'id': 146, 'moves': ['razor-wind', 'wing-attack', 'whirlwind', 'fly', 'take-down', 'double-edge', 'leer', 'roar', 'ember', 'flamethrower', 'hyper-beam', 'peck', 'solar-beam', 'fire-spin', 'toxic', 'agility', 'rage', 'mimic', 'double-team', 'reflect', 'bide', 'fire-blast', 'swift', 'sky-attack', 'rest', 'substitute', 'snore', 'curse', 'protect', 'mud-slap', 'detect', 'sandstorm', 'endure', 'swagger', 'steel-wing', 'sleep-talk', 'return', 'frustration', 'safeguard', 'hidden-power', 'twister', 'rain-dance', 'sunny-day', 'ancient-power', 'rock-smash', 'heat-wave', 'will-o-wisp', 'facade', 'secret-power', 'air-cutter', 'overheat', 'aerial-ace', 'roost', 'natural-gift', 'pluck', 'tailwind', 'u-turn', 'air-slash', 'giga-impact', 'defog', 'ominous-wind', 'flame-charge', 'round', 'sky-drop', 'incinerate', 'hurricane', 'confide', 'burn-up'], 'name': 'moltres', 'stats': {'hp': 90, 'attack': 100, 'defense': 90, 'special-attack': 125, 'special-defense': 85, 'speed': 90}, 'types': ['fire', 'flying'], 'weight': 600, 'is_baby': False, 'is_legendary': True, 'is_mythical': False, 'hatch_counter': 80, 'gender_rate': -1, 'capture_rate': 3, 'color': 'yellow', 'shape': 'wings', 'habitat': 'rare', 'generation': 'generation-i', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'ファイヤー', 'roomaji': 'Fire', 'ko': '파이어', 'zh-Hant': '火焰鳥', 'fr': 'Sulfura', 'de': 'Lavados', 'es': 'Moltres', 'it': 'Moltres', 'en': 'Moltres', 'ja': 'ファイヤー', 'zh-Hans': '火焰鸟'}, 'genera': {'ja-Hrkt': 'かえんポケモン', 'ko': '화염포켓몬', 'zh-Hant': '火焰寶可夢', 'fr': 'Pokémon Flamme', 'de': 'Flamme', 'es': 'Pokémon Llama', 'it': 'Pokémon Fiamma', 'en': 'Flame Pokémon', 'ja': 'かえんポケモン', 'zh-Hans': '火焰宝可梦'}}
	public class SpecieMoltres : PokemonSpecie
	{
#nullable enable
		private static SpecieMoltres? _instance = null;
#nullable restore
        public static SpecieMoltres Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMoltres();
                }
                return _instance;
            }
        }

		public SpecieMoltres() : base(
			"Moltres",
			90, // HPs
			100, 90, // Attack & Defense
			125, 85, // Special Attack & Defense
			90			
		) {}
	}


	//Moltres Pokemon Class
	public class Moltres : Pokemon
	{

		public Moltres(string nickname, int level) : base(
			146,
			SpecieMoltres.Instance, // Pokemon Specie
			nickname, level,
			Fire.Instance, Flying.Instance			
		) {}

		public Moltres() : base(
			146,
			SpecieMoltres.Instance, // Pokemon Specie
			Fire.Instance, Flying.Instance			
		) {}
	}
}