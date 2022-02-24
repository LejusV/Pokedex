using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Rowlet Specie to store common natural stats of every {'abilities': ['overgrow', 'long-reach'], 'base_experience': 64, 'height': 3, 'id': 722, 'moves': ['swords-dance', 'fury-attack', 'tackle', 'growl', 'peck', 'razor-leaf', 'solar-beam', 'toxic', 'double-team', 'confuse-ray', 'light-screen', 'haze', 'rest', 'substitute', 'curse', 'protect', 'foresight', 'false-swipe', 'swagger', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'baton-pass', 'synthesis', 'hidden-power', 'sunny-day', 'facade', 'nature-power', 'feather-dance', 'astonish', 'leaf-blade', 'roost', 'pluck', 'sucker-punch', 'energy-ball', 'brave-bird', 'nasty-plot', 'shadow-claw', 'defog', 'grass-knot', 'ominous-wind', 'round', 'echoed-voice', 'grass-pledge', 'work-up', 'confide', 'leafage'], 'name': 'rowlet', 'stats': {'hp': 68, 'attack': 55, 'defense': 55, 'special-attack': 50, 'special-defense': 50, 'speed': 42}, 'types': ['grass', 'flying'], 'weight': 15, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 1, 'capture_rate': 45, 'color': 'brown', 'shape': 'wings', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'medium-slow', 'egg_groups': ['flying'], 'names': {'ja-Hrkt': 'モクロー', 'ko': '나몰빼미', 'zh-Hant': '木木梟', 'fr': 'Brindibou', 'de': 'Bauz', 'es': 'Rowlet', 'it': 'Rowlet', 'en': 'Rowlet', 'ja': 'モクロー', 'zh-Hans': '木木枭'}, 'genera': {'ja-Hrkt': 'くさばねポケモン', 'ko': '풀깃포켓몬', 'zh-Hant': '草羽寶可夢', 'fr': 'Pokémon Plumefeuille', 'de': 'Laubflügel', 'es': 'Pokémon Pluma Hoja', 'it': 'Pokémon Aliderba', 'en': 'Grass Quill Pokémon', 'ja': 'くさばねポケモン', 'zh-Hans': '草羽宝可梦'}}
	public class SpecieRowlet : PokemonSpecie
	{
#nullable enable
		private static SpecieRowlet? _instance = null;
#nullable restore
        public static SpecieRowlet Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRowlet();
                }
                return _instance;
            }
        }

		public SpecieRowlet() : base(
			"Rowlet",
			68, // HPs
			55, 55, // Attack & Defense
			50, 50, // Special Attack & Defense
			42			
		) {}
	}


	//Rowlet Pokemon Class
	public class Rowlet : Pokemon
	{

		public Rowlet(string nickname, int level)
		: base(
				722,
				SpecieRowlet.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Rowlet(int level)
		: base(
				722,
				SpecieRowlet.Instance, // Pokemon Specie
				"Rowlet", level,
				Grass.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Rowlet() : base(
			722,
			SpecieRowlet.Instance, // Pokemon Specie
			Grass.Instance, Flying.Instance			
		) {}
	}
}