using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Steenee Specie to store common natural stats of every {'abilities': ['leaf-guard', 'oblivious', 'sweet-veil'], 'base_experience': 102, 'height': 7, 'id': 762, 'moves': ['double-slap', 'stomp', 'razor-leaf', 'solar-beam', 'toxic', 'double-team', 'light-screen', 'reflect', 'splash', 'rest', 'substitute', 'protect', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'rapid-spin', 'sweet-scent', 'hidden-power', 'sunny-day', 'facade', 'nature-power', 'teeter-dance', 'aromatherapy', 'magical-leaf', 'payback', 'fling', 'energy-ball', 'leaf-storm', 'captivate', 'grass-knot', 'low-sweep', 'round', 'play-nice', 'confide', 'aromatic-mist', 'dazzling-gleam'], 'name': 'steenee', 'stats': {'hp': 52, 'attack': 40, 'defense': 48, 'special-attack': 40, 'special-defense': 48, 'speed': 62}, 'types': ['grass'], 'weight': 82, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 8, 'capture_rate': 120, 'color': 'purple', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'medium-slow', 'egg_groups': ['plant'], 'names': {'ja-Hrkt': 'アママイコ', 'ko': '달무리나', 'zh-Hant': '甜舞妮', 'fr': 'Candine', 'de': 'Frubaila', 'es': 'Steenee', 'it': 'Steenee', 'en': 'Steenee', 'ja': 'アママイコ', 'zh-Hans': '甜舞妮'}, 'genera': {'ja-Hrkt': 'フルーツポケモン', 'ko': '후르츠포켓몬', 'zh-Hant': '水果寶可夢', 'fr': 'Pokémon Fruit', 'de': 'Obst', 'es': 'Pokémon Fruto', 'it': 'Pokémon Frutto', 'en': 'Fruit Pokémon', 'ja': 'フルーツポケモン', 'zh-Hans': '水果宝可梦'}}
	public class SpecieSteenee : PokemonSpecie
	{
#nullable enable
		private static SpecieSteenee? _instance = null;
#nullable restore
        public static SpecieSteenee Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSteenee();
                }
                return _instance;
            }
        }

		public SpecieSteenee() : base(
			"Steenee",
			52, // HPs
			40, 48, // Attack & Defense
			40, 48, // Special Attack & Defense
			62			
		) {}
	}


	//Steenee Pokemon Class
	public class Steenee : Pokemon
	{

		public Steenee(string nickname, int level) : base(
			762,
			SpecieSteenee.Instance, // Pokemon Specie
			nickname, level,
			Grass.Instance			
		) {}

		public Steenee() : base(
			762,
			SpecieSteenee.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
	}
}