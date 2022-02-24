using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Altaria Specie to store common natural stats of every {'abilities': ['natural-cure', 'cloud-nine'], 'base_experience': 172, 'height': 11, 'id': 334, 'moves': ['fly', 'fury-attack', 'body-slam', 'take-down', 'double-edge', 'growl', 'roar', 'sing', 'flamethrower', 'mist', 'ice-beam', 'hyper-beam', 'peck', 'solar-beam', 'earthquake', 'toxic', 'mimic', 'double-team', 'fire-blast', 'swift', 'dream-eater', 'sky-attack', 'rest', 'substitute', 'thief', 'snore', 'protect', 'mud-slap', 'perish-song', 'outrage', 'endure', 'swagger', 'steel-wing', 'attract', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'safeguard', 'dragon-breath', 'iron-tail', 'hidden-power', 'twister', 'rain-dance', 'sunny-day', 'psych-up', 'rock-smash', 'uproar', 'heat-wave', 'facade', 'refresh', 'secret-power', 'hyper-voice', 'astonish', 'air-cutter', 'aerial-ace', 'dragon-claw', 'dragon-dance', 'roost', 'natural-gift', 'pluck', 'tailwind', 'dragon-pulse', 'giga-impact', 'draco-meteor', 'captivate', 'ominous-wind', 'hone-claws', 'wonder-room', 'round', 'echoed-voice', 'incinerate', 'bulldoze', 'cotton-guard', 'disarming-voice', 'moonblast', 'confide', 'dazzling-gleam'], 'name': 'altaria', 'stats': {'hp': 75, 'attack': 70, 'defense': 90, 'special-attack': 70, 'special-defense': 105, 'speed': 80}, 'types': ['dragon', 'flying'], 'weight': 206, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 45, 'color': 'blue', 'shape': 'wings', 'habitat': 'forest', 'generation': 'generation-iii', 'growth_rate': 'slow-then-very-fast', 'egg_groups': ['flying', 'dragon'], 'names': {'ja-Hrkt': 'チルタリス', 'roomaji': 'Tyltalis', 'ko': '파비코리', 'zh-Hant': '七夕青鳥', 'fr': 'Altaria', 'de': 'Altaria', 'es': 'Altaria', 'it': 'Altaria', 'en': 'Altaria', 'ja': 'チルタリス', 'zh-Hans': '七夕青鸟'}, 'genera': {'ja-Hrkt': 'ハミングポケモン', 'ko': '허밍포켓몬', 'zh-Hant': '哼唱寶可夢', 'fr': 'Pokémon Virevolteur', 'de': 'Summsel', 'es': 'Pokémon Cantor', 'it': 'Pokémon Canterino', 'en': 'Humming Pokémon', 'ja': 'ハミングポケモン', 'zh-Hans': '哼唱宝可梦'}}
	public class SpecieAltaria : PokemonSpecie
	{
#nullable enable
		private static SpecieAltaria? _instance = null;
#nullable restore
        public static SpecieAltaria Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieAltaria();
                }
                return _instance;
            }
        }

		public SpecieAltaria() : base(
			"Altaria",
			75, // HPs
			70, 90, // Attack & Defense
			70, 105, // Special Attack & Defense
			80			
		) {}
	}


	//Altaria Pokemon Class
	public class Altaria : Pokemon
	{

		public Altaria(string nickname, int level)
		: base(
				334,
				SpecieAltaria.Instance, // Pokemon Specie
				nickname, level,
				Dragon.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Altaria() : base(
			334,
			SpecieAltaria.Instance, // Pokemon Specie
			Dragon.Instance, Flying.Instance			
		) {}
	}
}