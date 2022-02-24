using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Tsareena Specie to store common natural stats of every {'abilities': ['leaf-guard', 'queenly-majesty', 'sweet-veil'], 'base_experience': 230, 'height': 12, 'id': 763, 'moves': ['double-slap', 'stomp', 'razor-leaf', 'solar-beam', 'toxic', 'double-team', 'light-screen', 'reflect', 'high-jump-kick', 'splash', 'rest', 'substitute', 'protect', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'rapid-spin', 'sweet-scent', 'hidden-power', 'sunny-day', 'facade', 'nature-power', 'teeter-dance', 'aromatherapy', 'magical-leaf', 'u-turn', 'payback', 'fling', 'punishment', 'energy-ball', 'giga-impact', 'leaf-storm', 'power-whip', 'captivate', 'grass-knot', 'low-sweep', 'round', 'acrobatics', 'confide', 'aromatic-mist', 'dazzling-gleam', 'trop-kick'], 'name': 'tsareena', 'stats': {'hp': 72, 'attack': 120, 'defense': 98, 'special-attack': 50, 'special-defense': 98, 'speed': 72}, 'types': ['grass'], 'weight': 214, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 8, 'capture_rate': 45, 'color': 'purple', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'medium-slow', 'egg_groups': ['plant'], 'names': {'ja-Hrkt': 'アマージョ', 'ko': '달코퀸', 'zh-Hant': '甜冷美后', 'fr': 'Sucreine', 'de': 'Fruyal', 'es': 'Tsareena', 'it': 'Tsareena', 'en': 'Tsareena', 'ja': 'アマージョ', 'zh-Hans': '甜冷美后'}, 'genera': {'ja-Hrkt': 'フルーツポケモン', 'ko': '후르츠포켓몬', 'zh-Hant': '水果寶可夢', 'fr': 'Pokémon Fruit', 'de': 'Obst', 'es': 'Pokémon Fruto', 'it': 'Pokémon Frutto', 'en': 'Fruit Pokémon', 'ja': 'フルーツポケモン', 'zh-Hans': '水果宝可梦'}}
	public class SpecieTsareena : PokemonSpecie
	{
#nullable enable
		private static SpecieTsareena? _instance = null;
#nullable restore
        public static SpecieTsareena Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTsareena();
                }
                return _instance;
            }
        }

		public SpecieTsareena() : base(
			"Tsareena",
			72, // HPs
			120, 98, // Attack & Defense
			50, 98, // Special Attack & Defense
			72			
		) {}
	}


	//Tsareena Pokemon Class
	public class Tsareena : Pokemon
	{

		public Tsareena(string nickname, int level)
		: base(
				763,
				SpecieTsareena.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Tsareena(int level)
		: base(
				763,
				SpecieTsareena.Instance, // Pokemon Specie
				"Tsareena", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Tsareena() : base(
			763,
			SpecieTsareena.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
	}
}