using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Clauncher Specie to store common natural stats of every {'abilities': ['mega-launcher'], 'base_experience': 66, 'height': 5, 'id': 692, 'moves': ['vice-grip', 'swords-dance', 'cut', 'water-gun', 'surf', 'ice-beam', 'bubble-beam', 'toxic', 'double-team', 'waterfall', 'bubble', 'splash', 'crabhammer', 'rest', 'rock-slide', 'substitute', 'snore', 'flail', 'protect', 'sludge-bomb', 'icy-wind', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rain-dance', 'facade', 'helping-hand', 'secret-power', 'dive', 'muddy-water', 'bounce', 'water-sport', 'water-pulse', 'u-turn', 'aqua-tail', 'dragon-pulse', 'flash-cannon', 'aqua-jet', 'venoshock', 'smack-down', 'sludge-wave', 'entrainment', 'round', 'scald', 'confide'], 'name': 'clauncher', 'stats': {'hp': 50, 'attack': 53, 'defense': 62, 'special-attack': 58, 'special-defense': 63, 'speed': 44}, 'types': ['water'], 'weight': 83, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 225, 'color': 'blue', 'shape': 'armor', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'slow', 'egg_groups': ['water1', 'water3'], 'names': {'ja-Hrkt': 'ウデッポウ', 'ko': '완철포', 'zh-Hant': '鐵臂槍蝦', 'fr': 'Flingouste', 'de': 'Scampisto', 'es': 'Clauncher', 'it': 'Clauncher', 'en': 'Clauncher', 'ja': 'ウデッポウ', 'zh-Hans': '铁臂枪虾'}, 'genera': {'ja-Hrkt': 'みずでっぽうポケモン', 'ko': '물대포포켓몬', 'zh-Hant': '水槍寶可夢', 'fr': 'Pokémon Lance à Eau', 'de': 'Aquapistole', 'es': 'Pokémon Proyectagua', 'it': 'Pokémon Zampillo', 'en': 'Water Gun Pokémon', 'ja': 'みずでっぽうポケモン', 'zh-Hans': '水枪宝可梦'}}
	public class SpecieClauncher : PokemonSpecie
	{
#nullable enable
		private static SpecieClauncher? _instance = null;
#nullable restore
        public static SpecieClauncher Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieClauncher();
                }
                return _instance;
            }
        }

		public SpecieClauncher() : base(
			"Clauncher",
			50, // HPs
			53, 62, // Attack & Defense
			58, 63, // Special Attack & Defense
			44			
		) {}
	}


	//Clauncher Pokemon Class
	public class Clauncher : Pokemon
	{

		public Clauncher(string nickname, int level)
		: base(
				692,
				SpecieClauncher.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Clauncher(int level)
		: base(
				692,
				SpecieClauncher.Instance, // Pokemon Specie
				"Clauncher", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Clauncher() : base(
			692,
			SpecieClauncher.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}