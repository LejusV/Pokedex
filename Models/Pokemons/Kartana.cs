using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Kartana Specie to store common natural stats of every {'abilities': ['beast-boost'], 'base_experience': 257, 'height': 3, 'id': 798, 'moves': ['guillotine', 'swords-dance', 'cut', 'razor-leaf', 'toxic', 'double-team', 'rest', 'substitute', 'protect', 'detect', 'false-swipe', 'swagger', 'fury-cutter', 'sleep-talk', 'return', 'frustration', 'synthesis', 'hidden-power', 'brick-break', 'air-cutter', 'aerial-ace', 'calm-mind', 'leaf-blade', 'night-slash', 'air-slash', 'x-scissor', 'vacuum-wave', 'giga-impact', 'psycho-cut', 'defog', 'round', 'sacred-sword', 'confide', 'laser-focus', 'smart-strike'], 'name': 'kartana', 'stats': {'hp': 59, 'attack': 181, 'defense': 131, 'special-attack': 59, 'special-defense': 31, 'speed': 109}, 'types': ['grass', 'steel'], 'weight': 1, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 45, 'color': 'white', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'カミツルギ', 'ko': '종이신도', 'zh-Hant': '紙御劍', 'fr': 'Katagami', 'de': 'Katagami', 'es': 'Kartana', 'it': 'Kartana', 'en': 'Kartana', 'ja': 'カミツルギ', 'zh-Hans': '纸御剑'}, 'genera': {'ja-Hrkt': 'ばっとうポケモン', 'ko': '발도포켓몬', 'zh-Hant': '拔刀寶可夢', 'fr': 'Pokémon Battô', 'de': 'Schwertkunst', 'es': 'Pokémon Desenvaine', 'it': 'Pokémon Spadatratta', 'en': 'Drawn Sword Pokémon', 'ja': 'ばっとうポケモン', 'zh-Hans': '拔刀宝可梦'}}
	public class SpecieKartana : PokemonSpecie
	{
#nullable enable
		private static SpecieKartana? _instance = null;
#nullable restore
        public static SpecieKartana Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieKartana();
                }
                return _instance;
            }
        }

		public SpecieKartana() : base(
			"Kartana",
			59, // HPs
			181, 131, // Attack & Defense
			59, 31, // Special Attack & Defense
			109			
		) {}
	}


	//Kartana Pokemon Class
	public class Kartana : Pokemon
	{

		public Kartana(string nickname, int level)
		: base(
				798,
				SpecieKartana.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Kartana(int level)
		: base(
				798,
				SpecieKartana.Instance, // Pokemon Specie
				"Kartana", level,
				Grass.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Kartana() : base(
			798,
			SpecieKartana.Instance, // Pokemon Specie
			Grass.Instance, Steel.Instance			
		) {}
	}
}