using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Venusaur Specie to store common natural stats of every {'abilities': ['overgrow', 'chlorophyll'], 'base_experience': 236, 'height': 20, 'id': 3, 'moves': ['swords-dance', 'cut', 'bind', 'vine-whip', 'headbutt', 'tackle', 'body-slam', 'take-down', 'double-edge', 'growl', 'roar', 'hyper-beam', 'strength', 'mega-drain', 'leech-seed', 'growth', 'razor-leaf', 'solar-beam', 'poison-powder', 'sleep-powder', 'petal-dance', 'string-shot', 'earthquake', 'toxic', 'rage', 'mimic', 'double-team', 'defense-curl', 'light-screen', 'reflect', 'bide', 'flash', 'rest', 'substitute', 'snore', 'curse', 'protect', 'sludge-bomb', 'mud-slap', 'outrage', 'giga-drain', 'endure', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'sweet-scent', 'synthesis', 'hidden-power', 'sunny-day', 'rock-smash', 'facade', 'nature-power', 'knock-off', 'secret-power', 'bullet-seed', 'block', 'frenzy-plant', 'natural-gift', 'worry-seed', 'seed-bomb', 'energy-ball', 'giga-impact', 'rock-climb', 'captivate', 'grass-knot', 'venoshock', 'round', 'echoed-voice', 'grass-pledge', 'bulldoze', 'work-up', 'petal-blizzard', 'confide'], 'name': 'venusaur', 'stats': {'hp': 80, 'attack': 82, 'defense': 83, 'special-attack': 100, 'special-defense': 100, 'speed': 80}, 'types': ['grass', 'poison'], 'weight': 1000, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'green', 'shape': 'quadruped', 'habitat': 'grassland', 'generation': 'generation-i', 'growth_rate': 'medium-slow', 'egg_groups': ['monster', 'plant'], 'names': {'ja-Hrkt': 'フシギバナ', 'roomaji': 'Fushigibana', 'ko': '이상해꽃', 'zh-Hant': '妙蛙花', 'fr': 'Florizarre', 'de': 'Bisaflor', 'es': 'Venusaur', 'it': 'Venusaur', 'en': 'Venusaur', 'ja': 'フシギバナ', 'zh-Hans': '妙蛙花'}, 'genera': {'ja-Hrkt': 'たねポケモン', 'ko': '씨앗포켓몬', 'zh-Hant': '種子寶可夢', 'fr': 'Pokémon Graine', 'de': 'Samen', 'es': 'Pokémon Semilla', 'it': 'Pokémon Seme', 'en': 'Seed Pokémon', 'ja': 'たねポケモン', 'zh-Hans': '种子宝可梦'}}
	public class SpecieVenusaur : PokemonSpecie
	{
#nullable enable
		private static SpecieVenusaur? _instance = null;
#nullable restore
        public static SpecieVenusaur Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieVenusaur();
                }
                return _instance;
            }
        }

		public SpecieVenusaur() : base(
			"Venusaur",
			80, // HPs
			82, 83, // Attack & Defense
			100, 100, // Special Attack & Defense
			80			
		) {}
	}


	//Venusaur Pokemon Class
	public class Venusaur : Pokemon
	{

		public Venusaur(string nickname, int level)
		: base(
				3,
				SpecieVenusaur.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Venusaur(int level)
		: base(
				3,
				SpecieVenusaur.Instance, // Pokemon Specie
				"Venusaur", level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Venusaur() : base(
			3,
			SpecieVenusaur.Instance, // Pokemon Specie
			Grass.Instance, Poison.Instance			
		) {}
	}
}