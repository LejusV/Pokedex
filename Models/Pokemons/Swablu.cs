using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Swablu Specie to store common natural stats of every {'abilities': ['natural-cure', 'cloud-nine'], 'base_experience': 62, 'height': 4, 'id': 333, 'moves': ['fly', 'fury-attack', 'body-slam', 'take-down', 'double-edge', 'growl', 'sing', 'mist', 'ice-beam', 'peck', 'solar-beam', 'toxic', 'agility', 'rage', 'mimic', 'double-team', 'haze', 'mirror-move', 'swift', 'dream-eater', 'sky-attack', 'rest', 'substitute', 'thief', 'snore', 'protect', 'mud-slap', 'perish-song', 'outrage', 'endure', 'swagger', 'steel-wing', 'attract', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'safeguard', 'pursuit', 'hidden-power', 'twister', 'rain-dance', 'sunny-day', 'psych-up', 'uproar', 'heat-wave', 'facade', 'refresh', 'secret-power', 'feather-dance', 'hyper-voice', 'astonish', 'air-cutter', 'aerial-ace', 'roost', 'natural-gift', 'pluck', 'tailwind', 'power-swap', 'dragon-pulse', 'dragon-rush', 'captivate', 'ominous-wind', 'round', 'echoed-voice', 'cotton-guard', 'disarming-voice', 'play-rough', 'moonblast', 'confide', 'dazzling-gleam'], 'name': 'swablu', 'stats': {'hp': 45, 'attack': 40, 'defense': 60, 'special-attack': 40, 'special-defense': 75, 'speed': 50}, 'types': ['normal', 'flying'], 'weight': 12, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 255, 'color': 'blue', 'shape': 'wings', 'habitat': 'forest', 'generation': 'generation-iii', 'growth_rate': 'slow-then-very-fast', 'egg_groups': ['flying', 'dragon'], 'names': {'ja-Hrkt': 'チルット', 'roomaji': 'Tyltto', 'ko': '파비코', 'zh-Hant': '青綿鳥', 'fr': 'Tylton', 'de': 'Wablu', 'es': 'Swablu', 'it': 'Swablu', 'en': 'Swablu', 'ja': 'チルット', 'zh-Hans': '青绵鸟'}, 'genera': {'ja-Hrkt': 'わたどりポケモン', 'ko': '솜새포켓몬', 'zh-Hant': '綿鳥寶可夢', 'fr': 'Pokémon Oiseaucoton', 'de': 'Wollvogel', 'es': 'Pokémon Ave Algodón', 'it': 'Pokémon Alidicotone', 'en': 'Cotton Bird Pokémon', 'ja': 'わたどりポケモン', 'zh-Hans': '绵鸟宝可梦'}}
	public class SpecieSwablu : PokemonSpecie
	{
#nullable enable
		private static SpecieSwablu? _instance = null;
#nullable restore
        public static SpecieSwablu Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSwablu();
                }
                return _instance;
            }
        }

		public SpecieSwablu() : base(
			"Swablu",
			45, // HPs
			40, 60, // Attack & Defense
			40, 75, // Special Attack & Defense
			50			
		) {}
	}


	//Swablu Pokemon Class
	public class Swablu : Pokemon
	{

		public Swablu(string nickname, int level)
		: base(
				333,
				SpecieSwablu.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Swablu() : base(
			333,
			SpecieSwablu.Instance, // Pokemon Specie
			Normal.Instance, Flying.Instance			
		) {}
	}
}