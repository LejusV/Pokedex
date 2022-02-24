using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Bulbasaur Specie to store common natural stats of every {'abilities': ['overgrow', 'chlorophyll'], 'base_experience': 64, 'height': 7, 'id': 1, 'moves': ['razor-wind', 'swords-dance', 'cut', 'bind', 'vine-whip', 'headbutt', 'tackle', 'body-slam', 'take-down', 'double-edge', 'growl', 'strength', 'mega-drain', 'leech-seed', 'growth', 'razor-leaf', 'solar-beam', 'poison-powder', 'sleep-powder', 'petal-dance', 'string-shot', 'toxic', 'rage', 'mimic', 'double-team', 'defense-curl', 'light-screen', 'reflect', 'bide', 'sludge', 'skull-bash', 'amnesia', 'flash', 'rest', 'substitute', 'snore', 'curse', 'protect', 'sludge-bomb', 'mud-slap', 'giga-drain', 'endure', 'charm', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'sweet-scent', 'synthesis', 'hidden-power', 'sunny-day', 'rock-smash', 'facade', 'nature-power', 'ingrain', 'knock-off', 'secret-power', 'grass-whistle', 'bullet-seed', 'magical-leaf', 'natural-gift', 'worry-seed', 'seed-bomb', 'energy-ball', 'leaf-storm', 'power-whip', 'captivate', 'grass-knot', 'venoshock', 'round', 'echoed-voice', 'grass-pledge', 'work-up', 'grassy-terrain', 'confide'], 'name': 'bulbasaur', 'stats': {'hp': 45, 'attack': 49, 'defense': 49, 'special-attack': 65, 'special-defense': 65, 'speed': 45}, 'types': ['grass', 'poison'], 'weight': 69, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'green', 'shape': 'quadruped', 'habitat': 'grassland', 'generation': 'generation-i', 'growth_rate': 'medium-slow', 'egg_groups': ['monster', 'plant'], 'names': {'ja-Hrkt': 'フシギダネ', 'roomaji': 'Fushigidane', 'ko': '이상해씨', 'zh-Hant': '妙蛙種子', 'fr': 'Bulbizarre', 'de': 'Bisasam', 'es': 'Bulbasaur', 'it': 'Bulbasaur', 'en': 'Bulbasaur', 'ja': 'フシギダネ', 'zh-Hans': '妙蛙种子'}, 'genera': {'ja-Hrkt': 'たねポケモン', 'ko': '씨앗포켓몬', 'zh-Hant': '種子寶可夢', 'fr': 'Pokémon Graine', 'de': 'Samen', 'es': 'Pokémon Semilla', 'it': 'Pokémon Seme', 'en': 'Seed Pokémon', 'ja': 'たねポケモン', 'zh-Hans': '种子宝可梦'}}
	public class SpecieBulbasaur : PokemonSpecie
	{
#nullable enable
		private static SpecieBulbasaur? _instance = null;
#nullable restore
        public static SpecieBulbasaur Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBulbasaur();
                }
                return _instance;
            }
        }

		public SpecieBulbasaur() : base(
			"Bulbasaur",
			45, // HPs
			49, 49, // Attack & Defense
			65, 65, // Special Attack & Defense
			45			
		) {}
	}


	//Bulbasaur Pokemon Class
	public class Bulbasaur : Pokemon
	{

		public Bulbasaur(string nickname, int level)
		: base(
				1,
				SpecieBulbasaur.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Bulbasaur(int level)
		: base(
				1,
				SpecieBulbasaur.Instance, // Pokemon Specie
				"Bulbasaur", level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Bulbasaur() : base(
			1,
			SpecieBulbasaur.Instance, // Pokemon Specie
			Grass.Instance, Poison.Instance			
		) {}
	}
}