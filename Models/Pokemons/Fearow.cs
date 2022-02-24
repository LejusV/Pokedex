using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Fearow Specie to store common natural stats of every {'abilities': ['keen-eye', 'sniper'], 'base_experience': 155, 'height': 12, 'id': 22, 'moves': ['razor-wind', 'whirlwind', 'fly', 'fury-attack', 'take-down', 'double-edge', 'leer', 'growl', 'hyper-beam', 'peck', 'drill-peck', 'toxic', 'agility', 'rage', 'mimic', 'double-team', 'focus-energy', 'bide', 'mirror-move', 'swift', 'sky-attack', 'rest', 'substitute', 'thief', 'snore', 'curse', 'protect', 'mud-slap', 'detect', 'endure', 'false-swipe', 'swagger', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'pursuit', 'hidden-power', 'twister', 'rain-dance', 'sunny-day', 'uproar', 'heat-wave', 'facade', 'secret-power', 'air-cutter', 'aerial-ace', 'roost', 'natural-gift', 'pluck', 'tailwind', 'u-turn', 'assurance', 'giga-impact', 'defog', 'captivate', 'ominous-wind', 'round', 'echoed-voice', 'work-up', 'drill-run', 'confide'], 'name': 'fearow', 'stats': {'hp': 65, 'attack': 90, 'defense': 65, 'special-attack': 61, 'special-defense': 61, 'speed': 100}, 'types': ['normal', 'flying'], 'weight': 380, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 90, 'color': 'brown', 'shape': 'wings', 'habitat': 'rough-terrain', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['flying'], 'names': {'ja-Hrkt': 'オニドリル', 'roomaji': 'Onidrill', 'ko': '깨비드릴조', 'zh-Hant': '大嘴雀', 'fr': 'Rapasdepic', 'de': 'Ibitak', 'es': 'Fearow', 'it': 'Fearow', 'en': 'Fearow', 'ja': 'オニドリル', 'zh-Hans': '大嘴雀'}, 'genera': {'ja-Hrkt': 'くちばしポケモン', 'ko': '부리포켓몬', 'zh-Hant': '鳥嘴寶可夢', 'fr': 'Pokémon Bec-Oiseau', 'de': 'Pickvogel', 'es': 'Pokémon Pico', 'it': 'Pokémon Becco', 'en': 'Beak Pokémon', 'ja': 'くちばしポケモン', 'zh-Hans': '鸟嘴宝可梦'}}
	public class SpecieFearow : PokemonSpecie
	{
#nullable enable
		private static SpecieFearow? _instance = null;
#nullable restore
        public static SpecieFearow Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieFearow();
                }
                return _instance;
            }
        }

		public SpecieFearow() : base(
			"Fearow",
			65, // HPs
			90, 65, // Attack & Defense
			61, 61, // Special Attack & Defense
			100			
		) {}
	}


	//Fearow Pokemon Class
	public class Fearow : Pokemon
	{

		public Fearow(string nickname, int level)
		: base(
				22,
				SpecieFearow.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Fearow() : base(
			22,
			SpecieFearow.Instance, // Pokemon Specie
			Normal.Instance, Flying.Instance			
		) {}
	}
}